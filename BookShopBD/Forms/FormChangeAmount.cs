using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopBD.Forms
{
    public partial class FormChangeAmount : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        int id;
        public FormChangeAmount(int id)
        {
            InitializeComponent();
            DBConnection.ConnectionDB();
            this.id = id;
        }
        private void FormChangeAmount_Load(object sender, EventArgs e)
        {
        }

        private void newAmountTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Symbol = e.KeyChar;

            if (!char.IsDigit(Symbol) && Symbol != 8)
            {
                e.Handled = true;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (newAmountTB.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка при заполнении полей", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.Parse(newAmountTB.Text) == 0)
            {
                MessageBox.Show("Нельзя заказать 0 книг.", "Ошибка при выборе количества", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBConnection.msCommand.CommandText = $"SELECT Amount FROM book WHERE id_book = {id};";
            object amount = DBConnection.msCommand.ExecuteScalar();

            if(int.Parse(newAmountTB.Text) > (int)amount)
            {
                MessageBox.Show($"На складе сейчас {(int)amount} книг.", "Ошибка при выборе количества", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBConnection.msCommand.CommandText = $"CALL GetUserId({CurrentUser.Id_account}, 'Покупатель');";
            object id_customer = DBConnection.msCommand.ExecuteScalar();

            DBConnection.msCommand.CommandText = $"SELECT id_order FROM order_ JOIN order_book USING(id_order) JOIN book USING(id_book) " +
                    $"JOIN author USING(id_author) WHERE id_customer = {(int)id_customer} " +
                    $"AND id_book = {id} " +
                    $"AND Status = 'Ожидает заказа';";
            object cur_id_order = DBConnection.msCommand.ExecuteScalar();

            DBConnection.msCommand.CommandText = $"SELECT id_order_book FROM order_ JOIN order_book USING(id_order) JOIN book USING(id_book) JOIN author USING(id_author) " +
                $"WHERE id_order = {(int)cur_id_order} AND id_book = {id} AND Status = 'Ожидает заказа'";
            object id_order_book = DBConnection.msCommand.ExecuteScalar();

            DBConnection.msCommand.CommandText = $"SELECT order_book.Amount FROM order_ JOIN order_book USING(id_order)" +
                $"WHERE id_order = {(int)cur_id_order} AND Status = 'Ожидает заказа';";
            object cur_amount = DBConnection.msCommand.ExecuteScalar();

            DBConnection.msCommand.CommandText = $"UPDATE order_book " +
                $"SET Amount = {int.Parse(newAmountTB.Text)} " +
                $"WHERE id_order_book = {(int)id_order_book}";
            DBConnection.msCommand.ExecuteNonQuery();

            if(int.Parse(newAmountTB.Text) > (int)cur_amount)
            {
                DBConnection.msCommand.CommandText = $"UPDATE book JOIN author USING(id_author) " +
                $"SET Amount = Amount - ({int.Parse(newAmountTB.Text)} - {(int)cur_amount});";
                DBConnection.msCommand.ExecuteNonQuery();
            }
            else
            {
                DBConnection.msCommand.CommandText = $"UPDATE book JOIN author USING(id_author) " +
                $"SET Amount = Amount + ({(int)cur_amount} - {int.Parse(newAmountTB.Text)});";
                DBConnection.msCommand.ExecuteNonQuery();
            }           

            MessageBox.Show("Количество успешно обновлено.", "Успешно", MessageBoxButtons.OK);
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panelTools_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
