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
        }
    }
}
