using BookShopBD.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookShopBD
{
    public partial class UCCatalog : UserControl
    {
        public static DataGridView books;
        static bool selectFlag = false;
        DataTable catalog = new DataTable();
        List<Book> catalogbooks = new List<Book>(1);
        public UCCatalog()
        {
            InitializeComponent();
        }

        private void UCCatalog_Load(object sender, EventArgs e)
        {
            if(CurrentUser.Role == "Покупатель")
            {
                addToCartButton.Visible = true;
            }
            else
            {
                addToCartButton.Visible = false;
            }

            if(flowCatalogPanel.Controls.Count != 0)
            {
                flowCatalogPanel.Controls.Clear();
            }
            DataTable dt = new DataTable();

            DBConnection.ConnectionDB();
            DBConnection.msCommand.CommandText = $"SELECT id_book, Book_name, Image, Descr, Author_name, Genre_name, " +
                $"Publisher_name, YEAR(Publication_Year), Price, Amount FROM author JOIN book USING(id_author) " +
                $"JOIN genre USING(id_genre) JOIN publisher ON book.id_publisher = publisher.id_publisher ORDER BY id_book;";
            DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
            DBConnection.msDataAddapter.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                catalogbooks.Add(new Book());
                catalogbooks[i].Id = dt.Rows[i][0].ToString();
                catalogbooks[i].BookName = dt.Rows[i][1].ToString();
                catalogbooks[i].Image = dt.Rows[i][2].ToString();
                catalogbooks[i].Description = dt.Rows[i][3].ToString();
                catalogbooks[i].AuthorName = dt.Rows[i][4].ToString();
                catalogbooks[i].GenreName = dt.Rows[i][5].ToString();
                catalogbooks[i].PublisherName = dt.Rows[i][6].ToString();
                catalogbooks[i].Year = dt.Rows[i][7].ToString();
                catalogbooks[i].Price = dt.Rows[i][8].ToString();
                catalogbooks[i].Amount = dt.Rows[i][9].ToString();
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Panel panel = new Panel();
                panel.Size = new Size(130, 270);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(130, 220);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.LoadAsync(catalogbooks[i].Image);
                pictureBox.Dock = DockStyle.Top;
                panel.Controls.Add(pictureBox);

                Label label = new Label();
                label.Text = catalogbooks[i].BookName;
                label.Dock = DockStyle.Bottom;
                label.AutoEllipsis = true;
                label.Font = new Font("Comic Sans MS", 10);
                panel.Controls.Add(label);

                Label label2 = new Label();
                label2.Text = "Цена: " + catalogbooks[i].Price;
                label2.Dock = DockStyle.Bottom;
                label2.Font = new Font("Comic Sans MS", 10);
                panel.Controls.Add(label2);

                panel.Name = catalogbooks[i].Id;

                pictureBox.Click += infoPanel_Click;
                panel.Click += infoPanel_Click;
                flowCatalogPanel.Controls.Add(panel);
            }
        }

        private void infoPanel_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)((PictureBox)sender).Parent;
            FormBook newFrom = new FormBook(int.Parse(panel.Name));
            newFrom.ShowDialog();
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

        }

        private void booksDGV_SelectionChanged(object sender, EventArgs e)
        {
             
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            UCCatalog_Load("asd", e);
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
