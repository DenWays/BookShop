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
            if(choiseEmpCB.Text == "" && choiseAmountTB.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка при заполнении полей", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(int.Parse(choiseAmountTB.Text) > int.Parse(UCCatalog.books.SelectedRows[0].Cells[6].Value.ToString()))
            {
                MessageBox.Show($"На складе сейчас {int.Parse(UCCatalog.books.SelectedRows[0].Cells[6].Value.ToString())} книг.", "Ошибка при выборе колличества", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBConnection.ConnectionDB();

            DBConnection.msCommand.CommandText = $"CALL GetUserId({CurrentUser.Id_account}, 'Покупатель');";
            object id_customer = DBConnection.msCommand.ExecuteScalar();

            DBConnection.msCommand.CommandText = $"CALL GetUserId({ids_employee[choiseEmpCB.SelectedIndex]}, 'Продавец');";
            object id_employee = DBConnection.msCommand.ExecuteScalar();

            DBConnection.msCommand.CommandText = $"SELECT id_order FROM order_ JOIN order_book USING(id_order) " +
                $"WHERE Status = 'Ожидает заказа' AND id_customer = {(int)id_customer} " +
                $"AND id_employee = {(int)id_employee} ORDER BY id_order DESC LIMIT 1;";
            
            if (DBConnection.msCommand.ExecuteScalar() == null)
            {             
                DBConnection.msCommand.CommandText = $"INSERT order_(id_customer, id_employee, Date_order) " +
                    $"VALUES({(int)id_customer}, {(int)id_employee}, CURDATE());";
                DBConnection.msCommand.ExecuteNonQuery();

                DBConnection.msCommand.CommandText = $"SELECT id_order FROM order_ " +
                    $"WHERE id_customer = {(int)id_customer} AND id_employee = {(int)id_employee} " +
                    $"ORDER BY id_order DESC LIMIT 1;";
                id_order = DBConnection.msCommand.ExecuteScalar(); 
            }
            else
            {
                DBConnection.msCommand.CommandText = $"SELECT id_order FROM order_ JOIN order_book USING(id_order) " +
                    $"WHERE Status = 'Ожидает заказа' AND id_customer = {(int)id_customer} " +
                    $"AND id_employee = {(int)id_employee} ORDER BY id_order DESC LIMIT 1;";
                id_order = DBConnection.msCommand.ExecuteScalar();
            }

            DBConnection.msCommand.CommandText = $"SELECT id_order_book FROM order_ JOIN order_book USING(id_order) " +
                $"JOIN book USING(id_book) JOIN author USING(id_author) " +
                $"WHERE Book_name = '{UCCatalog.books.SelectedRows[0].Cells[0].Value}' " +
                $"AND Author_name = '{UCCatalog.books.SelectedRows[0].Cells[1].Value}' " +
                $"AND id_order = {(int)id_order};";
            if(DBConnection.msCommand.ExecuteScalar() == null)
            {
                DBConnection.msCommand.CommandText = $"CALL AddToCart({(int)id_customer}, {(int)id_employee}, " +
                $"'{UCCatalog.books.SelectedRows[0].Cells[0].Value}', '{UCCatalog.books.SelectedRows[0].Cells[1].Value}', " +
                $"{double.Parse(UCCatalog.books.SelectedRows[0].Cells[5].Value.ToString())}, {int.Parse(choiseAmountTB.Text)}, " +
                $"{(int)id_order});";
                DBConnection.msCommand.ExecuteNonQuery();
                MessageBox.Show("Книга успешно добавлена в корзину.", "Успешно");
            }
            else
            {
                DBConnection.msCommand.CommandText = $"UPDATE order_book JOIN book USING(id_book) " +
                    $"JOIN author USING(id_author) " +
                    $"SET order_book.Amount = order_book.Amount + {int.Parse(choiseAmountTB.Text)} " +
                    $"WHERE id_order = {(int)id_order} AND Book_name = '{UCCatalog.books.SelectedRows[0].Cells[0].Value}' " +
                    $"AND Author_name = '{UCCatalog.books.SelectedRows[0].Cells[1].Value}';";
                DBConnection.msCommand.ExecuteNonQuery();
                MessageBox.Show("Книга успешно добавлена в корзину.", "Успешно");
            }
        }

        private void FormAddToCart_Load(object sender, EventArgs e)
        {
            DBConnection.msCommand.CommandText = "SELECT LastName, FirstName, MiddleName, id_account FROM employee";
            DBConnection.dataReader = DBConnection.msCommand.ExecuteReader();

            while (DBConnection.dataReader.Read())
            {
                choiseEmpCB.Items.Add($"{DBConnection.dataReader[0]} {DBConnection.dataReader[1]} " +
                    $"{DBConnection.dataReader[2]}");
                ids_employee.Add(int.Parse(DBConnection.dataReader[3].ToString()));
            }
            DBConnection.CloseDB();
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
