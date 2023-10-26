using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
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

            searchMethod("SELECT * FROM catalog;");

            DBConnection.msCommand.CommandText = $"SELECT id_author FROM book JOIN author USING(id_author) " +
                $"WHERE Book_name = '{booksDGV.SelectedRows[0].Cells[0].Value}';";
            object id_author = DBConnection.msCommand.ExecuteScalar();
            bookName.Text = booksDGV.SelectedRows[0].Cells[0].Value.ToString();
            DBConnection.msCommand.CommandText = $"SELECT Descr FROM book " +
                $"WHERE book_name = '{booksDGV.SelectedRows[0].Cells[0].Value}' AND id_author = {(int)id_author};";
            bookDescr.Text = DBConnection.msCommand.ExecuteScalar().ToString();
            selectFlag = true;
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            DBConnection.ConnectionDB();
            Form newForm = new FormAddToCart();
            newForm.ShowDialog();
            refreshButton_Click("↻", e);
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
                DBConnection.msCommand.CommandText = $"SELECT id_author FROM book JOIN author USING(id_author) " +
                    $"WHERE Book_name = '{booksDGV.SelectedRows[0].Cells[0].Value}';";
                object id_author = DBConnection.msCommand.ExecuteScalar();
                bookName.Text = booksDGV.SelectedRows[0].Cells[0].Value.ToString();
                DBConnection.msCommand.CommandText = $"SELECT Descr FROM book " +
                    $"WHERE book_name = '{booksDGV.SelectedRows[0].Cells[0].Value}' AND id_author = {(int)id_author};";
                bookDescr.Text = DBConnection.msCommand.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
            }           
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            DBConnection.msCommand.CommandText = "SELECT * FROM catalog";
            DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
            DBConnection.msDataAddapter.Fill(dataTable);
            booksDGV.DataSource = dataTable;
            books = booksDGV;
        }

        private void searchTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (searchCB.Text == "Название" || searchCB.Text == "Жанр" || searchCB.Text == "Издательство" || searchCB.Text == "Автор")
            {
                string Symbol = e.KeyChar.ToString();

                if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && Symbol[0] != 8 && Symbol[0] != ' ')
                {
                    e.Handled = true;
                }
            }
            else if(searchCB.Text == "Год" && searchCB.Text == "Количество")
            {
                char Symbol = e.KeyChar;

                if (!char.IsDigit(Symbol) && Symbol != 8)
                {
                    e.Handled = true;
                }
            }
            else if(searchCB.Text == "Цена")
            {
                char Symbol = e.KeyChar;

                if (!char.IsDigit(Symbol) && Symbol != 8 && Symbol != '.' && Symbol != ',')
                {
                    e.Handled = true;
                }
            }
        }

        private void searchMethod(string command)
        {
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            DBConnection.msCommand.CommandText = command;
            DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
            DBConnection.msDataAddapter.Fill(dataTable);
            booksDGV.DataSource = dataTable;
            books = booksDGV;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchCB.Text == "Название")
            {
                searchMethod($"SELECT * FROM catalog WHERE Название LIKE '%{searchTB.Text}%'");
            }
            else if (searchCB.Text == "Автор")
            {
                searchMethod($"SELECT * FROM catalog WHERE Автор LIKE '%{searchTB.Text}%'");
            }
            else if(searchCB.Text == "Жанр")
            {
                searchMethod($"SELECT * FROM catalog WHERE Жанр LIKE '%{searchTB.Text}%'");
            }
            else if(searchCB.Text == "Издательство")
            {
                searchMethod($"SELECT * FROM catalog WHERE Издательство LIKE '%{searchTB.Text}%'");
            }
            else if (searchCB.Text == "Год")
            {
                searchMethod($"SELECT * FROM catalog WHERE Год = {int.Parse(searchTB.Text)}");
            }
            else if(searchCB.Text == "Цена")
            {
                searchMethod($"SELECT * FROM catalog WHERE Цена = {double.Parse(searchTB.Text)}");
            }    
            else if(searchCB.Text == "Количество")
            {
                searchMethod($"SELECT * FROM catalog WHERE Количество = {int.Parse(searchTB.Text)}");
            }
        }

        private void booksDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addToCartButton_Click("Добавить", e);
        }
    }
}
