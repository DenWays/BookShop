using BookShopBD.Forms;
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
        public UCCart()
        {
            InitializeComponent();
        }

        private void UCCart_Load(object sender, EventArgs e)
        {
            DBConnection.ConnectionDB();

            DataTable dataTable = new DataTable();
            dataTable.Clear();

            DBConnection.msCommand.CommandText = $"CALL GetUserId({CurrentUser.Id_account}, 'Покупатель');";
            object id_customer = DBConnection.msCommand.ExecuteScalar();

            DBConnection.msCommand.CommandText = $"SELECT Book_name AS Название, Author_name AS Автор, " +
                $"order_book.Price AS Цена, order_book.Amount AS Количество " +
                $"FROM order_ JOIN order_book USING(id_order) JOIN book USING(id_book) " +
                $"JOIN author USING(id_author) WHERE id_customer = {(int)id_customer} AND Status = 'Ожидает заказа';";
            DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
            DBConnection.msDataAddapter.Fill(dataTable);
            cartDGV.DataSource = dataTable;
            sumAll_ = 0.00;
            for (int i = 0; i < cartDGV.RowCount; i++)
            {
                sumAll_ += (double.Parse(cartDGV.Rows[i].Cells[2].Value.ToString()) * int.Parse(cartDGV.Rows[i].Cells[3].Value.ToString()));
            }
            sumAll.Text = sumAll_.ToString();

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

        private void cartDGV_SelectionChanged(object sender, EventArgs e)
        {
            sumSelected_ = 0;
            for (int i = 0; i < cartDGV.SelectedRows.Count ; i++)
            {
                sumSelected_ += (double.Parse(cartDGV.SelectedRows[i].Cells[2].Value.ToString()) * int.Parse(cartDGV.SelectedRows[i].Cells[3].Value.ToString()));
            }
            sumSelected.Text = sumSelected_.ToString();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            UCCart_Load("asd", e);
        }

        private void orderAllBtn_Click(object sender, EventArgs e)
        {
            if(cartDGV.Rows.Count == 0)
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
            if (cartDGV.Rows.Count == 0)
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

            for (int i = 0; i < cartDGV.SelectedRows.Count; i++)
            {
                DBConnection.msCommand.CommandText = $"UPDATE order_book JOIN book USING(id_book) " +
                        $"JOIN author USING(id_author) SET order_book.id_order = {int.Parse(id_order.ToString())} " +
                        $"WHERE order_book.id_order = {(ids_order[0])} " +
                        $"AND Book_name = '{cartDGV.SelectedRows[i].Cells[0].Value}' " +
                        $"AND Author_name = '{cartDGV.SelectedRows[i].Cells[1].Value}';";
                DBConnection.msCommand.ExecuteNonQuery();
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
            if(cartDGV.Rows.Count == 0) 
            {
                MessageBox.Show("Корзина пуста.", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            DBConnection.ConnectionDB();
            for (int i = 0; i < cartDGV.SelectedRows.Count; i++)
            {
                DBConnection.msCommand.CommandText = $"DELETE order_book FROM order_ JOIN order_book USING(id_order) " +
                    $"JOIN book USING(id_book) " +
                    $"JOIN author USING(id_author) WHERE Book_name = '{cartDGV.SelectedRows[i].Cells[0].Value}' " +
                    $"AND Author_name = '{cartDGV.SelectedRows[i].Cells[1].Value}' AND order_book.id_order = {ids_order[0]} " +
                    $"AND order_book.Amount = {int.Parse(cartDGV.SelectedRows[i].Cells[3].Value.ToString())} " +
                    $"AND order_book.Price = {double.Parse(cartDGV.SelectedRows[i].Cells[2].Value.ToString())} " +
                    $"AND Status = 'Ожидает заказа';";

                if (DBConnection.msCommand.ExecuteNonQuery() > 0)
                {
                    DBConnection.msCommand.CommandText = $"UPDATE book JOIN author USING(id_author) " +
                        $"SET Amount = Amount + {int.Parse(cartDGV.Rows[i].Cells[3].Value.ToString())} " +
                        $"WHERE Book_name = '{cartDGV.SelectedRows[i].Cells[0].Value}' " +
                        $"AND Author_name = '{cartDGV.SelectedRows[i].Cells[1].Value}';";
                    DBConnection.msCommand.ExecuteNonQuery();
                }
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
            MessageBox.Show("Книги успешно удалены из корзины.", "Успех");
        }

        private void deleteAllBtn_Click(object sender, EventArgs e)
        {
            if (cartDGV.Rows.Count == 0) 
            {
                MessageBox.Show("Корзина пуста.", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            DBConnection.ConnectionDB();
            for (int i = 0; i < cartDGV.Rows.Count; i++)
            {
                DBConnection.msCommand.CommandText = $"DELETE order_book FROM order_ JOIN order_book USING(id_order) " +
                    $"JOIN book USING(id_book) " +
                    $"JOIN author USING(id_author) WHERE Book_name = '{cartDGV.Rows[i].Cells[0].Value}' " +
                    $"AND Author_name = '{cartDGV.Rows[i].Cells[1].Value}' AND order_book.id_order = {ids_order[0]} " +
                    $"AND order_book.Amount = {int.Parse(cartDGV.Rows[i].Cells[3].Value.ToString())} " +
                    $"AND order_book.Price = {double.Parse(cartDGV.Rows[i].Cells[2].Value.ToString())} " +
                    $"AND Status = 'Ожидает заказа';";
                if (DBConnection.msCommand.ExecuteNonQuery() > 0)
                {
                    DBConnection.msCommand.CommandText = $"UPDATE book JOIN author USING(id_author) " +
                        $"SET Amount = Amount + {int.Parse(cartDGV.Rows[i].Cells[3].Value.ToString())} " +
                        $"WHERE Book_name = '{cartDGV.Rows[i].Cells[0].Value}' " +
                        $"AND Author_name = '{cartDGV.Rows[i].Cells[1].Value}';";
                    DBConnection.msCommand.ExecuteNonQuery();
                }
            }

            DBConnection.msCommand.CommandText = $"DELETE FROM order_ WHERE id_order = {ids_order[0]}";
            DBConnection.msCommand.ExecuteNonQuery();

            ids_order.Clear();
            refreshButton_Click("↻", e);
            MessageBox.Show("Книги успешно удалены из корзины.", "Успех");
        }

        private void cartDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cartDGV.CurrentCell.ColumnIndex != 3) { return; }
            itemsSelected.Clear();
            for (int i = 0; i < cartDGV.ColumnCount; i++)
            {
                itemsSelected.Add(cartDGV.SelectedRows[0].Cells[i].Value.ToString());
            }
            Form newForm = new FormChangeAmount();
            newForm.ShowDialog();
            refreshButton_Click("↻", e);
        }
    }
}
