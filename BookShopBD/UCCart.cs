﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopBD
{
    public partial class UCCart : UserControl
    {
        static double sumSelected_ = 0.00;
        static double sumAll_ = 0.00;
        List<int> ids_order = new List<int>();
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

            DBConnection.msCommand.CommandText = $"SELECT Book_name AS Название, Author_name AS Автор, order_book.Price AS Цена, " +
                $"order_book.Amount AS Количество, CONCAT(employee.LastName, ' ', employee.FirstName, ' ',employee.MiddleName) AS 'ФИО продавца' FROM employee JOIN order_ USING(id_employee) JOIN order_book USING(id_order) JOIN book USING(id_book) " +
                $"JOIN author USING(id_author) WHERE id_customer = {(int)id_customer} AND Status = 'Ожидает оплаты';";
            DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
            DBConnection.msDataAddapter.Fill(dataTable);
            cartDGV.DataSource = dataTable;
            sumAll_ = 0.00;
            for (int i = 0; i < cartDGV.RowCount; i++)
            {
                sumAll_ += (double.Parse(cartDGV.Rows[i].Cells[2].Value.ToString()) * int.Parse(cartDGV.Rows[i].Cells[3].Value.ToString()));
            }
            sumAll.Text = sumAll_.ToString();

            DBConnection.msCommand.CommandText = $"SELECT order_book.id_order FROM order_book JOIN order_ USING(id_order) WHERE id_customer = {(int)id_customer} AND Status = 'Ожидает оплаты' GROUP BY order_book.id_order;";
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
            DBConnection.ConnectionDB();

            DataTable dataTable = new DataTable();
            dataTable.Clear();

            DBConnection.msCommand.CommandText = $"CALL GetUserId({CurrentUser.Id_account}, 'Покупатель');";
            object id_customer = DBConnection.msCommand.ExecuteScalar();

            DBConnection.msCommand.CommandText = $"SELECT Book_name AS Название, Author_name AS Автор, order_book.Price AS Цена, " +
                $"order_book.Amount AS Количество, CONCAT(employee.LastName, ' ', employee.FirstName, ' ',employee.MiddleName) AS 'ФИО продавца' FROM employee JOIN order_ USING(id_employee) JOIN order_book USING(id_order) JOIN book USING(id_book) " +
                $"JOIN author USING(id_author) WHERE id_customer = {(int)id_customer} AND Status = 'Ожидает оплаты';";
            DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
            DBConnection.msDataAddapter.Fill(dataTable);
            cartDGV.DataSource = dataTable;
            sumAll_ = 0.00;
            for (int i = 0; i < cartDGV.RowCount; i++)
            {
                sumAll_ += (double.Parse(cartDGV.Rows[i].Cells[2].Value.ToString()) * int.Parse(cartDGV.Rows[i].Cells[3].Value.ToString()));
            }
            sumAll.Text = sumAll_.ToString();

            DBConnection.msCommand.CommandText = $"SELECT order_book.id_order FROM order_book JOIN order_ USING(id_order) WHERE id_customer = 5 AND Status = 'Ожидает оплаты' GROUP BY order_book.id_order;";
            DBConnection.dataReader = DBConnection.msCommand.ExecuteReader();

            while (DBConnection.dataReader.Read())
            {
                ids_order.Add(int.Parse(DBConnection.dataReader[0].ToString()));
            }
            DBConnection.CloseDB();
        }

        private void orderAllBtn_Click(object sender, EventArgs e)
        {
            DBConnection.ConnectionDB();
            for (int i = 0; i < ids_order.Count; i++)
            {
                DBConnection.msCommand.CommandText = $"SELECT id_employee FROM order_ WHERE id_order = {ids_order[i]};";
                object id_employee = DBConnection.msCommand.ExecuteScalar();

                DBConnection.msCommand.CommandText = $"CALL GetUserId({CurrentUser.Id_account}, 'Покупатель');";
                object id_customer = DBConnection.msCommand.ExecuteScalar();

                DBConnection.msCommand.CommandText = $"INSERT order_(id_customer, id_employee, Date_order) " +
                    $"VALUES({(int)id_customer}, {(int)id_employee}, CURDATE());";
                DBConnection.msCommand.ExecuteNonQuery();

                DBConnection.msCommand.CommandText = $"SELECT id_order FROM order_ WHERE id_order NOT IN (SELECT id_order FROM order_book);";
                object id_order = DBConnection.msCommand.ExecuteScalar();

                DBConnection.msCommand.CommandText = $"UPDATE order_book SET id_order = {(int)id_order}, Status = 'Оплачен' WHERE id_order = {ids_order[i]};";
                DBConnection.msCommand.ExecuteNonQuery();

                DBConnection.msCommand.CommandText = $"DELETE FROM order_ WHERE id_order = {ids_order[i]}";
                DBConnection.msCommand.ExecuteNonQuery();
            }
            refreshButton_Click("↻", e);
            MessageBox.Show("Книги успешно заказаны. Ожидайте подтверждения продавца.", "Успешно");
        }

        private void orderSelectedBtn_Click(object sender, EventArgs e)
        {
            DBConnection.ConnectionDB();
            for (int i = 0; i < ids_order.Count; i++)
            {
                DBConnection.msCommand.CommandText = $"SELECT id_employee FROM order_ WHERE id_order = {ids_order[i]};";
                object id_employee = DBConnection.msCommand.ExecuteScalar();

                DBConnection.msCommand.CommandText = $"CALL GetUserId({CurrentUser.Id_account}, 'Покупатель');";
                object id_customer = DBConnection.msCommand.ExecuteScalar();

                DBConnection.msCommand.CommandText = $"INSERT order_(id_customer, id_employee, Date_order) " +
                    $"VALUES({(int)id_customer}, {(int)id_employee}, CURDATE());";
                DBConnection.msCommand.ExecuteNonQuery();

                DBConnection.msCommand.CommandText = $"SELECT id_order FROM order_ WHERE id_order NOT IN (SELECT id_order FROM order_book);";
                object id_order = DBConnection.msCommand.ExecuteScalar();

                for (int j = 0; j < cartDGV.SelectedRows.Count; j++)
                {
                    DBConnection.msCommand.CommandText = $"UPDATE order_book JOIN book USING(id_book) JOIN author USING(id_author) SET order_book.id_order = {(int)id_order}, Status = 'Оплачен' WHERE order_book.id_order = {(ids_order[i])} AND Book_name = '{cartDGV.SelectedRows[j].Cells[0].Value}' AND Author_name = '{cartDGV.SelectedRows[j].Cells[1].Value}';";
                    DBConnection.msCommand.ExecuteNonQuery();
                }

                DBConnection.msCommand.CommandText = $"SELECT id_order FROM order_ WHERE id_order NOT IN (SELECT id_order FROM order_book);";
                id_order = DBConnection.msCommand.ExecuteScalar();
                if(id_order != null)
                {
                    DBConnection.msCommand.CommandText = $"DELETE FROM order_ WHERE id_order = {(int)id_order}";
                    DBConnection.msCommand.ExecuteNonQuery();
                }
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
                for (int j = 0; j < ids_order.Count; j++)
                {
                    DBConnection.msCommand.CommandText = $"SELECT id_employee FROM order_ WHERE id_order = {ids_order[j]};";
                    object id_employee = DBConnection.msCommand.ExecuteScalar();

                    DBConnection.msCommand.CommandText = $"CALL GetUserId({CurrentUser.Id_account}, 'Покупатель');";
                    object id_customer = DBConnection.msCommand.ExecuteScalar();

                    DBConnection.msCommand.CommandText = $"DELETE order_book FROM order_book JOIN book USING(id_book) JOIN author USING(id_author) WHERE Book_name = '{cartDGV.SelectedRows[i].Cells[0].Value}' AND Author_name = '{cartDGV.SelectedRows[i].Cells[1].Value}' AND order_book.id_order = {ids_order[j]} AND order_book.Amount = {int.Parse(cartDGV.SelectedRows[i].Cells[3].Value.ToString())} AND order_book.Price = {double.Parse(cartDGV.SelectedRows[i].Cells[2].Value.ToString())} AND Status = 'Ожидает оплаты';";
                    DBConnection.msCommand.ExecuteNonQuery();
                }              
            }
            List<int> deleteIds = new List<int>();
            DBConnection.msCommand.CommandText = $"SELECT id_order FROM order_ WHERE id_order NOT IN (SELECT id_order FROM order_book);";
            DBConnection.dataReader = DBConnection.msCommand.ExecuteReader();
            while(DBConnection.dataReader.Read())
            {
                deleteIds.Add((int)DBConnection.dataReader[0]);
            }
            DBConnection.CloseDB();
            DBConnection.ConnectionDB();
            for (int i = 0; i < deleteIds.Count; i++)
            {
                DBConnection.msCommand.CommandText = $"DELETE FROM order_ WHERE id_order = {deleteIds[i]}";
                DBConnection.msCommand.ExecuteNonQuery();
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
                for (int j = 0; j < ids_order.Count; j++)
                {
                    DBConnection.msCommand.CommandText = $"SELECT id_employee FROM order_ WHERE id_order = {ids_order[j]};";
                    object id_employee = DBConnection.msCommand.ExecuteScalar();

                    DBConnection.msCommand.CommandText = $"CALL GetUserId({CurrentUser.Id_account}, 'Покупатель');";
                    object id_customer = DBConnection.msCommand.ExecuteScalar();
                    DBConnection.msCommand.CommandText = $"DELETE order_book FROM order_book JOIN book USING(id_book) JOIN author USING(id_author) WHERE Book_name = '{cartDGV.Rows[i].Cells[0].Value}' AND Author_name = '{cartDGV.Rows[i].Cells[1].Value}' AND order_book.id_order = {ids_order[j]} AND order_book.Amount = {int.Parse(cartDGV.Rows[i].Cells[3].Value.ToString())} AND order_book.Price = {double.Parse(cartDGV.Rows[i].Cells[2].Value.ToString())} AND Status = 'Ожидает оплаты';";
                    DBConnection.msCommand.ExecuteNonQuery();
                }
            }
            List<int> deleteIds = new List<int>();
            DBConnection.msCommand.CommandText = $"SELECT id_order FROM order_ WHERE id_order NOT IN (SELECT id_order FROM order_book);";
            DBConnection.dataReader = DBConnection.msCommand.ExecuteReader();
            while (DBConnection.dataReader.Read())
            {
                deleteIds.Add((int)DBConnection.dataReader[0]);
            }
            DBConnection.CloseDB();
            DBConnection.ConnectionDB();
            for (int i = 0; i < deleteIds.Count; i++)
            {
                DBConnection.msCommand.CommandText = $"DELETE FROM order_ WHERE id_order = {deleteIds[i]}";
                DBConnection.msCommand.ExecuteNonQuery();
            }
            refreshButton_Click("↻", e);
            MessageBox.Show("Книги успешно удалены из корзины.", "Успех");
        }
    }
}
