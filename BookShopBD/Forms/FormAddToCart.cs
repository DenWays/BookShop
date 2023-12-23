using BookShopBD.UserControls;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BookShopBD
{
    public partial class FormAddToCart : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        List<int> ids_employee = new List<int>();
        public static object id_order;
        public FormAddToCart()
        {
            InitializeComponent();
            DBConnection.ConnectionDB();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {         
            if(choiseAmountTB.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка при заполнении полей", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(int.Parse(choiseAmountTB.Text) == 0)
            {
                MessageBox.Show("Нельзя заказать 0 книг.", "Ошибка при выборе количества", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(int.Parse(choiseAmountTB.Text) > int.Parse(FormBook.book.Amount))
            {
                MessageBox.Show($"На складе сейчас {int.Parse(FormBook.book.Amount)} книг.", "Ошибка при выборе количества", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBConnection.ConnectionDB();

            DBConnection.msCommand.CommandText = $"CALL GetUserId({CurrentUser.Id_account}, 'Покупатель');";
            object id_customer = DBConnection.msCommand.ExecuteScalar();

            DBConnection.msCommand.CommandText = $"SELECT id_order FROM order_ JOIN order_book USING(id_order) " +
                $"WHERE id_customer = {(int)id_customer} AND id_employee IS NULL AND Status = 'Ожидает заказа';";
            object id_order;

            if (DBConnection.msCommand.ExecuteScalar() == null)
            {
                DBConnection.msCommand.CommandText = $"INSERT order_(id_customer, Date_order, Status) " +
                    $"VALUES({(int)id_customer}, CURDATE(), 'Ожидает заказа')";
                DBConnection.msCommand.ExecuteNonQuery();

                DBConnection.msCommand.CommandText = $"SELECT LAST_INSERT_ID();";
                id_order = DBConnection.msCommand.ExecuteScalar();
            }
            else
            {
                DBConnection.msCommand.CommandText = $"SELECT id_order FROM order_ JOIN order_book USING(id_order) " +
                $"WHERE id_customer = {(int)id_customer} AND id_employee IS NULL AND Status = 'Ожидает заказа';";
                id_order = DBConnection.msCommand.ExecuteScalar();
            }

            DBConnection.msCommand.CommandText = $"UPDATE book JOIN author USING(id_author) " +
                $"SET Amount = Amount - {int.Parse(choiseAmountTB.Text)} " +
                $"WHERE Book_name = '{FormBook.book.BookName}' " +
                $"AND Author_name = '{FormBook.book.AuthorName}';";
            DBConnection.msCommand.ExecuteNonQuery();

            DBConnection.msCommand.CommandText = $"SELECT id_order_book FROM order_ JOIN order_book USING(id_order) " +
                $"JOIN book USING(id_book) JOIN author USING(id_author) " +
                $"WHERE Book_name = '{FormBook.book.BookName}' " +
                $"AND Author_name = '{FormBook.book.AuthorName}' " +
                $"AND id_order = {int.Parse(id_order.ToString())}";
            if (DBConnection.msCommand.ExecuteScalar() == null)
            {
                DBConnection.msCommand.CommandText = $"CALL AddToCart(" +
                $"'{FormBook.book.BookName}', '{FormBook.book.AuthorName}', " +
                $"{double.Parse(FormBook.book.Price)}, {int.Parse(choiseAmountTB.Text)}, " +
                $"{int.Parse(id_order.ToString())});";
                DBConnection.msCommand.ExecuteNonQuery();
                MessageBox.Show("Книга успешно добавлена в корзину.", "Успешно");
                this.Hide();
            }
            else
            {
                DBConnection.msCommand.CommandText = $"UPDATE order_book JOIN book USING(id_book) " +
                    $"JOIN author USING(id_author) " +
                    $"SET order_book.Amount = order_book.Amount + {int.Parse(choiseAmountTB.Text)} " +
                    $"WHERE id_order = {int.Parse(id_order.ToString())} AND Book_name = '{FormBook.book.BookName}' " +
                    $"AND Author_name = '{FormBook.book.AuthorName}';";
                DBConnection.msCommand.ExecuteNonQuery();
                MessageBox.Show("Книга успешно добавлена в корзину.", "Успешно");
                this.Hide();
            }
        }

        private void panelTools_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void choiseAmountTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Symbol = e.KeyChar;

            if (!char.IsDigit(Symbol) && Symbol != 8)
            {
                e.Handled = true;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
