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
    public partial class UCHistory : UserControl
    {
        public static int id_order;
        public UCHistory()
        {
            InitializeComponent();
            DBConnection.ConnectionDB();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            UCHistory_Load("asd", e);
        }

        private void UCHistory_Load(object sender, EventArgs e)
        {
            DBConnection.ConnectionDB();

            DataTable dataTable = new DataTable();
            dataTable.Clear();

            DBConnection.msCommand.CommandText = $"CALL GetUserId({CurrentUser.Id_account}, 'Покупатель');";
            object id_customer = DBConnection.msCommand.ExecuteScalar();

            DBConnection.msCommand.CommandText = $"SELECT id_order AS 'Номер заказа', COUNT(id_order_book) AS Товаров, Date_order AS Дата " +
                $"FROM order_ JOIN order_book USING(id_order) " +
                $"WHERE id_customer = {(int)id_customer} AND Status = 'Ожидает подтверждения' GROUP BY id_order;";
            DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
            DBConnection.msDataAddapter.Fill(dataTable);
            nSuccessDGV.DataSource = dataTable;
            DBConnection.CloseDB();


            DBConnection.ConnectionDB();
            DataTable dataTable2 = new DataTable();
            dataTable2.Clear();

            DBConnection.msCommand.CommandText = $"SELECT id_order AS 'Номер заказа', COUNT(id_order_book) AS Товаров, " +
                $"CONCAT(LastName, ' ' , FirstName, ' ' , MiddleName) AS 'ФИО продавца', " +
                $"Date_order AS Дата FROM order_book JOIN order_ USING(id_order) JOIN employee USING(id_employee) " +
                $"WHERE id_customer = {(int)id_customer} AND Status = 'Подтверждён' GROUP BY id_order;";
            DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
            DBConnection.msDataAddapter.Fill(dataTable2);
            successDGV.DataSource = dataTable2;
            DBConnection.CloseDB();
        }

        private void nSuccessDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_order = int.Parse(nSuccessDGV.SelectedRows[0].Cells[0].Value.ToString());
            Form newForm = new FormOrder();
            newForm.ShowDialog();
        }

        private void successDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_order = int.Parse(successDGV.SelectedRows[0].Cells[0].Value.ToString());
            Form newForm = new FormOrder();
            newForm.ShowDialog();
        }
    }
}
