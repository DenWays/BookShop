using System;
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
    public partial class UCOrderEmployee : UserControl
    {
        public static int id_order;
        public UCOrderEmployee()
        {
            InitializeComponent();
            DBConnection.ConnectionDB();
        }

        private void UCOrderEmployee_Load(object sender, EventArgs e)
        {
            DBConnection.ConnectionDB();
            DataTable dataTable = new DataTable();
            DBConnection.msCommand.CommandText = $"SELECT LastName AS Фамилия, FirstName AS Имя, MiddleName AS Отчество " +
                $"FROM customer JOIN order_ USING(id_customer) JOIN order_book USING(id_order) WHERE Status = 'Ожидает подтверждения' " +
                $"GROUP BY LastName, FirstName, MiddleName;";
            DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
            DBConnection.msDataAddapter.Fill(dataTable);
            customersDGV.DataSource = dataTable;
            DBConnection.CloseDB();

            try
            {
                DBConnection.ConnectionDB();
                DataTable dataTable2 = new DataTable();
                DBConnection.msCommand.CommandText = $"SELECT id_order AS 'Номер заказа', SUM(order_book.Amount) AS Товаров, Date_order AS Дата " +
                    $"FROM customer JOIN order_ USING(id_customer) JOIN order_book USING(id_order) " +
                    $"WHERE Status = 'Ожидает подтверждения' AND LastName = '{customersDGV.SelectedRows[0].Cells[0].Value}' " +
                    $"AND FirstName = '{customersDGV.SelectedRows[0].Cells[1].Value}' AND MiddleName = '{customersDGV.SelectedRows[0].Cells[2].Value}' " +
                    $"GROUP BY id_order;";
                DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
                DBConnection.msDataAddapter.Fill(dataTable2);
                ordersDGV.DataSource = dataTable2;
                DBConnection.CloseDB();
            }
            catch (Exception)
            {
            }
        }

        private void ordersDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_order = int.Parse(ordersDGV.SelectedRows[0].Cells[0].Value.ToString());
            Form newForm = new FormOrderEmployee();
            newForm.ShowDialog();
            refreshOButton_Click("asd", e);
            refreshCButton_Click("asd", e);
        }

        private void customersDGV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DBConnection.ConnectionDB();
                DataTable dataTable2 = new DataTable();
                DBConnection.msCommand.CommandText = $"SELECT id_order AS 'Номер заказа', SUM(order_book.Amount) AS Товаров, Date_order AS Дата " +
                    $"FROM customer JOIN order_ USING(id_customer) JOIN order_book USING(id_order) " +
                    $"WHERE Status = 'Ожидает подтверждения' AND LastName = '{customersDGV.SelectedRows[0].Cells[0].Value}' " +
                    $"AND FirstName = '{customersDGV.SelectedRows[0].Cells[1].Value}' AND MiddleName = '{customersDGV.SelectedRows[0].Cells[2].Value}' " +
                    $"GROUP BY id_order;";
                DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
                DBConnection.msDataAddapter.Fill(dataTable2);
                ordersDGV.DataSource = dataTable2;
                DBConnection.CloseDB();
            }
            catch (Exception)
            {
            }            
        }

        private void refreshCButton_Click(object sender, EventArgs e)
        {
            DBConnection.ConnectionDB();
            DataTable dataTable = new DataTable();
            DBConnection.msCommand.CommandText = $"SELECT LastName AS Фамилия, FirstName AS Имя, MiddleName AS Отчество " +
                $"FROM customer JOIN order_ USING(id_customer) JOIN order_book USING(id_order) WHERE Status = 'Ожидает подтверждения' " +
                $"GROUP BY LastName, FirstName, MiddleName;";
            DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
            DBConnection.msDataAddapter.Fill(dataTable);
            customersDGV.DataSource = dataTable;
            DBConnection.CloseDB();
        }

        private void refreshOButton_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.ConnectionDB();
                DataTable dataTable2 = new DataTable();
                DBConnection.msCommand.CommandText = $"SELECT id_order AS 'Номер заказа', SUM(order_book.Amount) AS Товаров, Date_order AS Дата " +
                    $"FROM customer JOIN order_ USING(id_customer) JOIN order_book USING(id_order) " +
                    $"WHERE Status = 'Ожидает подтверждения' AND LastName = '{customersDGV.SelectedRows[0].Cells[0].Value}' " +
                    $"AND FirstName = '{customersDGV.SelectedRows[0].Cells[1].Value}' AND MiddleName = '{customersDGV.SelectedRows[0].Cells[2].Value}' " +
                    $"GROUP BY id_order;";
                DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
                DBConnection.msDataAddapter.Fill(dataTable2);
                ordersDGV.DataSource = dataTable2;
                DBConnection.CloseDB();
            }
            catch (Exception)
            {
            }
        }
    }
}
