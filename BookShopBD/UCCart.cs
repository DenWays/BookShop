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
    public partial class UCCart : UserControl
    {
        static double sumSelected_ = 0.00;
        static double sumAll_ = 0.00;
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
                $"order_book.Amount AS Количество FROM order_ JOIN order_book USING(id_order) JOIN book USING(id_book) " +
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
            DataTable dataTable = new DataTable();
            dataTable.Clear();

            DBConnection.msCommand.CommandText = $"CALL GetUserId({CurrentUser.Id_account}, 'Покупатель');";
            object id_customer = DBConnection.msCommand.ExecuteScalar();

            DBConnection.msCommand.CommandText = $"SELECT Book_name AS Название, Author_name AS Автор, order_book.Price AS Цена, " +
                $"order_book.Amount AS Количество FROM order_ JOIN order_book USING(id_order) JOIN book USING(id_book) " +
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
        }
    }
}
