using BookShopBD.Forms;
using BookShopBD.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BookShopBD
{
    public partial class UCCart : UserControl
    {
        static double sumSelected_ = 0.00;
        static double sumAll_ = 0.00;
        public static List<int> ids_order = new List<int>();
        public static object id_order;
        public static List<string> itemsSelected = new List<string>();
        List<Book> cartbooks = new List<Book>(1);
        public UCCart()
        {
            InitializeComponent();
        }

        private void UCCart_Load(object sender, EventArgs e)
        {
            DBConnection.ConnectionDB();

            DataTable dt = new DataTable();
            dt.Clear();
            flowLayoutCart.Controls.Clear();

            DBConnection.msCommand.CommandText = $"CALL GetUserId({CurrentUser.Id_account}, 'Покупатель');";
            object id_customer = DBConnection.msCommand.ExecuteScalar();

            DBConnection.msCommand.CommandText = $"SELECT id_book, Book_name AS Название, Author_name AS Автор, " +
                $"Image AS Фото, order_book.Price AS Цена, order_book.Amount AS Количество " +
                $"FROM order_ JOIN order_book USING(id_order) JOIN book USING(id_book) " +
                $"JOIN author USING(id_author) WHERE id_customer = {(int)id_customer} AND Status = 'Ожидает заказа';";
            DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
            DBConnection.msDataAddapter.Fill(dt);

            cartbooks.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cartbooks.Add(new Book());
                cartbooks[i].Id = dt.Rows[i][0].ToString();
                cartbooks[i].BookName = dt.Rows[i][1].ToString();
                cartbooks[i].AuthorName = dt.Rows[i][2].ToString();
                cartbooks[i].Image = dt.Rows[i][3].ToString();
                cartbooks[i].Price = dt.Rows[i][4].ToString();
                cartbooks[i].Amount = dt.Rows[i][5].ToString();
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                UCCartBook uCBook = new UCCartBook();
                uCBook.Namebook = cartbooks[i].BookName;
                uCBook.PriceBook = cartbooks[i].Price;
                uCBook.ImageBook = cartbooks[i].Image;
                uCBook.Id = cartbooks[i].Id;
                uCBook.Amount = cartbooks[i].Amount;
                uCBook.Controls[0].Controls[0].TextChanged += ChecksSum;
                uCBook.Controls[0].Controls[1].Click += deleteBtn_Click;
                uCBook.Controls[0].Controls[3].Click += ChangeAmount;
                flowLayoutCart.Controls.Add(uCBook);
            }

            sumAll_ = 0.00;
            for (int i = 0; i < cartbooks.Count; i++)
            {
                sumAll_ += (double.Parse(cartbooks[i].Price) * int.Parse(cartbooks[i].Amount));
            }
            sumAll.Text = sumAll_.ToString() + ".00";
            sumSelected_ = sumAll_;
            sumSelected.Text = sumAll.Text;

            DBConnection.msCommand.CommandText = $"SELECT order_book.id_order FROM order_book " +
                $"JOIN order_ USING(id_order) WHERE id_customer = {(int)id_customer} AND Status = 'Ожидает заказа' " +
                $"GROUP BY order_book.id_order;";
            DBConnection.dataReader = DBConnection.msCommand.ExecuteReader();

            while (DBConnection.dataReader.Read())
            {
                ids_order.Add(int.Parse(DBConnection.dataReader[0].ToString()));
            }
            DBConnection.CloseDB();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            UCCart_Load("asd", e);
        }

        private void orderAllBtn_Click(object sender, EventArgs e)
        {
            if (flowLayoutCart.Controls.Count == 0)
            {
                MessageBox.Show("Корзина пуста", "Пустая корзина", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBConnection.ConnectionDB();

            DBConnection.msCommand.CommandText = $"UPDATE order_ SET Status = 'Ожидает подтверждения' WHERE id_order = {ids_order[0]}";
            DBConnection.msCommand.ExecuteNonQuery();

            DBConnection.msCommand.CommandText = $"SELECT id_order FROM order_ WHERE id_order " +
                    $"NOT IN (SELECT id_order FROM order_book);";
            id_order = DBConnection.msCommand.ExecuteScalar();

            ids_order.Clear();

            refreshButton_Click("↻", e);
            MessageBox.Show("Книги успешно заказаны. Ожидайте подтверждения продавца.", "Успешно");
        }

        private void orderSelectedBtn_Click(object sender, EventArgs e)
        {
            if (flowLayoutCart.Controls.Count == 0)
            {
                MessageBox.Show("Корзина пуста", "Пустая корзина", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBConnection.ConnectionDB();

            DBConnection.msCommand.CommandText = $"CALL GetUserId({CurrentUser.Id_account}, 'Покупатель');";
            object id_customer = DBConnection.msCommand.ExecuteScalar();

            DBConnection.msCommand.CommandText = $"INSERT order_(id_customer, Date_order, Status) " +
                $"VALUES({(int)id_customer}, CURDATE(), 'Ожидает подтверждения');";
            DBConnection.msCommand.ExecuteNonQuery();

            DBConnection.msCommand.CommandText = $"SELECT LAST_INSERT_ID()";
            id_order = DBConnection.msCommand.ExecuteScalar();

            for (int i = 0; i < flowLayoutCart.Controls.Count; i++)
            {
                if (flowLayoutCart.Controls[i].Controls[0].Controls[0].Text == "✓")
                {
                    DBConnection.msCommand.CommandText = $"UPDATE order_book JOIN book USING(id_book) JOIN author USING(id_author) " +
                        $"SET order_book.id_order = {int.Parse(id_order.ToString())} WHERE order_book.id_order = {ids_order[0]} " +
                        $"AND id_book = {flowLayoutCart.Controls[i].Controls[0].Name};";
                    DBConnection.msCommand.ExecuteNonQuery();
                }
            }

            DBConnection.msCommand.CommandText = $"SELECT id_order FROM order_ WHERE id_order " +
                    $"NOT IN (SELECT id_order FROM order_book);";
            id_order = DBConnection.msCommand.ExecuteScalar();
            if (id_order != null)
            {
                DBConnection.msCommand.CommandText = $"SET foreign_key_checks = 0; DELETE FROM order_ " +
                    $"WHERE id_order = {int.Parse(id_order.ToString())}";
                DBConnection.msCommand.ExecuteNonQuery();
                ids_order.Remove(int.Parse(id_order.ToString()));
            }

            refreshButton_Click("↻", e);
            MessageBox.Show("Книги успешно заказаны. Ожидайте подтверждения продавца.", "Успешно");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (flowLayoutCart.Controls.Count == 0)
            {
                MessageBox.Show("Корзина пуста.", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBConnection.ConnectionDB();

            DBConnection.msCommand.CommandText = $"DELETE order_book FROM order_ JOIN order_book USING(id_order) " +
                    $"WHERE order_book.id_order = {ids_order[0]} AND id_book = {((Button)sender).Parent.Name};";
            if (DBConnection.msCommand.ExecuteNonQuery() > 0)
            {
                DBConnection.msCommand.CommandText = $"UPDATE book JOIN author USING(id_author)" +
                    $"SET Amount = Amount + {((Button)sender).Parent.Controls[2].Text} " +
                    $"WHERE id_book = {((Button)sender).Parent.Name};";
                DBConnection.msCommand.ExecuteNonQuery();
            }

            DBConnection.msCommand.CommandText = $"SELECT id_order FROM order_ WHERE id_order " +
                    $"NOT IN (SELECT id_order FROM order_book);";
            id_order = DBConnection.msCommand.ExecuteScalar();
            if (id_order != null)
            {
                DBConnection.msCommand.CommandText = $"DELETE FROM order_ WHERE id_order = {(int)id_order}";
                DBConnection.msCommand.ExecuteNonQuery();
                ids_order.Clear();
            }

            refreshButton_Click("↻", e);
        }

        private void deleteAllBtn_Click(object sender, EventArgs e)
        {
            if (flowLayoutCart.Controls.Count == 0)
            {
                MessageBox.Show("Корзина пуста.", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBConnection.ConnectionDB();

            for (int i = 0; i < flowLayoutCart.Controls.Count; i++)
            {
                DBConnection.msCommand.CommandText = $"DELETE order_book FROM order_ JOIN order_book USING(id_order) " +
                    $"WHERE id_order = {ids_order[0]};";
                if(DBConnection.msCommand.ExecuteNonQuery() > 0)
                {
                    DBConnection.msCommand.CommandText = $"UPDATE book JOIN author USING(id_author)" +
                        $"SET Amount = Amount + {int.Parse(flowLayoutCart.Controls[i].Controls[0].Controls[2].Text)} " +
                        $"WHERE id_book = {flowLayoutCart.Controls[i].Controls[0].Name};";
                    DBConnection.msCommand.ExecuteNonQuery();
                }
            }

            DBConnection.msCommand.CommandText = $"DELETE FROM order_ WHERE id_order = {ids_order[0]}";
            DBConnection.msCommand.ExecuteNonQuery();

            ids_order.Clear();
            refreshButton_Click("↻", e);
            MessageBox.Show("Книги успешно удалены из корзины.", "Успех");
        }

        public void ChecksSum(object sender, EventArgs e)
        {
            if(((Button)sender).Text == "✓")
            {
                sumSelected_ += (double.Parse(((Button)sender).Parent.Controls[4].Text) *
                    int.Parse(((Button)sender).Parent.Controls[2].Text));
                sumSelected.Text = sumSelected_.ToString() + ".00";
            }
            else
            {
                sumSelected_ -= (double.Parse(((Button)sender).Parent.Controls[4].Text) * 
                    int.Parse(((Button)sender).Parent.Controls[2].Text));
                sumSelected.Text = sumSelected_.ToString() + ".00";
            }
        }

        private void checkAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < flowLayoutCart.Controls.Count; i++)
            {
                flowLayoutCart.Controls[i].Controls[0].Controls[0].Text = "✓";
            }
        }

        private void ChangeAmount(object sender, EventArgs e)
        {
            Form newForm = new FormChangeAmount(int.Parse(((Button)sender).Parent.Name));
            newForm.ShowDialog();
            refreshButton_Click("asd", e);
        }
    }
}
