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
        static bool selectFlag = false;
        public UCCatalog()
        {
            InitializeComponent();
            bookDescr.MaximumSize = new Size(panelDescr.Width - 5, panelDescr.Height);
            bookDescr.AutoSize = true;
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

            DBConnection.msCommand.CommandText = $"SELECT id_author FROM book JOIN author USING(id_author) WHERE Book_name = '{booksDGV.SelectedRows[0].Cells[0].Value}';";
            object id_author = DBConnection.msCommand.ExecuteScalar();
            bookName.Text = booksDGV.SelectedRows[0].Cells[0].Value.ToString();
            DBConnection.msCommand.CommandText = $"SELECT Descr FROM book WHERE book_name = '{booksDGV.SelectedRows[0].Cells[0].Value}' AND id_author = {(int)id_author};";
            bookDescr.Text = DBConnection.msCommand.ExecuteScalar().ToString();
            selectFlag = true;
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            Form newForm = new FormAddToCart();
            newForm.ShowDialog();
        }

        private void UCCatalog_SizeChanged(object sender, EventArgs e)
        {
            bookDescr.MaximumSize = new Size(panelDescr.Width - 5, 0);
            bookDescr.AutoSize = true;
        }

        private void booksDGV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (selectFlag == false) { return; }
                DBConnection.msCommand.CommandText = $"SELECT id_author FROM book JOIN author USING(id_author) WHERE Book_name = '{booksDGV.SelectedRows[0].Cells[0].Value}';";
                object id_author = DBConnection.msCommand.ExecuteScalar();
                bookName.Text = booksDGV.SelectedRows[0].Cells[0].Value.ToString();
                DBConnection.msCommand.CommandText = $"SELECT Descr FROM book WHERE book_name = '{booksDGV.SelectedRows[0].Cells[0].Value}' AND id_author = {(int)id_author};";
                bookDescr.Text = DBConnection.msCommand.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
            }           
        }
    }
}
