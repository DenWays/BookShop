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
        double sumSuccess = 0.00;
        double sumNSuccess = 0.00;
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

            DBConnection.msCommand.CommandText = $"SELECT Book_name AS Название, Author_name AS Автор, " +
                $"order_book.Price AS Цена, order_book.Amount AS Количество, " +
                $"Date_order AS Дата " +
                $"FROM order_ JOIN order_book USING(id_order) JOIN book USING(id_book) " +
                $"JOIN author USING(id_author) WHERE id_customer = {(int)id_customer} AND Status = 'Ожидает подтверждения';";
            DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
            DBConnection.msDataAddapter.Fill(dataTable);
            nSuccessDGV.DataSource = dataTable;
            DBConnection.CloseDB();
            sumNSuccess = 0.00;
            amountNSuccessLabel.Text = nSuccessDGV.RowCount.ToString();
            for (int i = 0; i < nSuccessDGV.RowCount; i++)
            {
                sumNSuccess += (double.Parse(nSuccessDGV.Rows[i].Cells[2].Value.ToString()) * int.Parse(nSuccessDGV.Rows[i].Cells[3].Value.ToString()));
            }
            sumNSuccessLabel.Text = sumNSuccess.ToString();

            DBConnection.ConnectionDB();

            DataTable dataTable2 = new DataTable();
            dataTable2.Clear();

            DBConnection.msCommand.CommandText = $"SELECT Book_name AS Название, Author_name AS Автор, " +
                $"order_book.Price AS Цена, order_book.Amount AS Количество, " +
                $"CONCAT(employee.LastName, ' ', employee.FirstName, ' ',employee.MiddleName) AS 'ФИО продавца', " +
                $"Date_order AS Дата " +
                $"FROM employee JOIN order_ USING(id_employee) JOIN order_book USING(id_order) JOIN book USING(id_book) " +
                $"JOIN author USING(id_author) WHERE id_customer = {(int)id_customer} AND Status = 'Подтверждён';";
            DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
            DBConnection.msDataAddapter.Fill(dataTable2);
            successDGV.DataSource = dataTable2;
            DBConnection.CloseDB();
            sumSuccess = 0.00;
            amountSuccessLabel.Text = successDGV.RowCount.ToString();
            for (int i = 0; i < successDGV.RowCount; i++)
            {
                sumSuccess += (double.Parse(successDGV.Rows[i].Cells[2].Value.ToString()) * int.Parse(successDGV.Rows[i].Cells[3].Value.ToString()));
            }
            sumSuccessLabel.Text = sumSuccess.ToString();
        }
    }
}
