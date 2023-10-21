using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopBD
{
    public partial class UCCatalog : UserControl
    {
        public static DataGridView books;
        public UCCatalog()
        {
            InitializeComponent();
        }

        private void UCCatalog_Load(object sender, EventArgs e)
        {
            DBConnection.ConnectionDB();

            DataTable dataTable = new DataTable();
            dataTable.Clear();
            DBConnection.msCommand.CommandText = "SELECT * FROM catalog";
            DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
            DBConnection.msDataAddapter.Fill(dataTable);
            booksDGV.DataSource = dataTable;
            books = booksDGV;
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            Form newForm = new FormAddToCart();
            newForm.ShowDialog();
        }
    }
}
