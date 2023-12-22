using BookShopBD.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        Dictionary<string, string> dict = new Dictionary<string, string>();
        public UCCatalog()
        {
            InitializeComponent();
            dict.Add("По умолчанию", "ORDER BY id_book");
            dict.Add("Название ↑", "ORDER BY Book_name");
            dict.Add("Название ↓", "ORDER BY Book_name DESC");
            dict.Add("Цена ↑", "ORDER BY Price");
            dict.Add("Цена ↓", "ORDER BY Price DESC");
            dict.Add("Количество ↑", "ORDER BY Amount");
            dict.Add("Количество ↓", "ORDER BY Amount DESC");
            sortCB.DataSource = dict.Keys.ToList();
        }

        private void UCCatalog_Load(object sender, EventArgs e)
        {
            if (searchCB.Text == "")
            {
                searchTB.Enabled = false;
            }
            else
            {
                searchTB.Enabled = true;
            }
        
            sortCB.SelectedIndex = 0;
            flowCatalogPanel.Controls.Clear();
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
                UCBook uCBook = new UCBook();
                uCBook.Namebook = catalogbooks[i].BookName;
                uCBook.PriceBook = catalogbooks[i].Price;
                uCBook.ImageBook = catalogbooks[i].Image;
                uCBook.Id = catalogbooks[i].Id;

                flowCatalogPanel.Controls.Add(uCBook);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            searchTB.Text = "";
            searchCB.Text = "";
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
            DataTable dt = new DataTable();

            DBConnection.ConnectionDB();
            DBConnection.msCommand.CommandText = command;
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
                UCBook uCBook = new UCBook();
                uCBook.Namebook = catalogbooks[i].BookName;
                uCBook.PriceBook = catalogbooks[i].Price;
                uCBook.ImageBook = catalogbooks[i].Image;
                uCBook.Id = catalogbooks[i].Id;

                flowCatalogPanel.Controls.Add(uCBook);
            }
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            if(searchCB.Text == "")
            {
                searchTB.Enabled = false;
            }
            else
            {
                searchTB.Enabled = true;
            }
            flowCatalogPanel.Controls.Clear();
            if (searchCB.Text == "Название")
            {
                searchMethod($"SELECT id_book, Book_name, Image, Descr, Author_name, Genre_name, Publisher_name, YEAR(Publication_Year), " +
                    $"Price, Amount FROM author JOIN book USING(id_author) JOIN genre USING(id_genre) JOIN publisher " +
                    $"ON book.id_publisher = publisher.id_publisher WHERE Book_name LIKE '%{searchTB.Text}%' " + dict[sortCB.Text]);
            }
            else if (searchCB.Text == "Автор")
            {
                searchMethod($"SELECT id_book, Book_name, Image, Descr, Author_name, Genre_name, Publisher_name, YEAR(Publication_Year), " +
                    $"Price, Amount FROM author JOIN book USING(id_author) JOIN genre USING(id_genre) JOIN publisher " +
                    $"ON book.id_publisher = publisher.id_publisher WHERE Author_name LIKE '%{searchTB.Text}%' " + dict[sortCB.Text]);
            }
            else if (searchCB.Text == "Жанр")
            {
                searchMethod($"SELECT id_book, Book_name, Image, Descr, Author_name, Genre_name, Publisher_name, YEAR(Publication_Year), " +
                    $"Price, Amount FROM author JOIN book USING(id_author) JOIN genre USING(id_genre) JOIN publisher " +
                    $"ON book.id_publisher = publisher.id_publisher WHERE Genre_name LIKE '%{searchTB.Text}%' " + dict[sortCB.Text]);
            }
            else if (searchCB.Text == "Издательство")
            {
                searchMethod($"SELECT id_book, Book_name, Image, Descr, Author_name, Genre_name, Publisher_name, YEAR(Publication_Year), " +
                    $"Price, Amount FROM author JOIN book USING(id_author) JOIN genre USING(id_genre) JOIN publisher " +
                    $"ON book.id_publisher = publisher.id_publisher WHERE Publisher_name LIKE '%{searchTB.Text}%' " + dict[sortCB.Text]);
            }
            else if (searchCB.Text == "Год")
            {
                searchMethod($"SELECT id_book, Book_name, Image, Descr, Author_name, Genre_name, Publisher_name, YEAR(Publication_Year), " +
                    $"Price, Amount FROM author JOIN book USING(id_author) JOIN genre USING(id_genre) JOIN publisher " +
                    $"ON book.id_publisher = publisher.id_publisher WHERE YEAR(Publication_Year) LIKE '{searchTB.Text}%' " + dict[sortCB.Text]);
            }
            else if (searchCB.Text == "Цена")
            {
                searchMethod($"SELECT id_book, Book_name, Image, Descr, Author_name, Genre_name, Publisher_name, YEAR(Publication_Year), " +
                    $"Price, Amount FROM author JOIN book USING(id_author) JOIN genre USING(id_genre) JOIN publisher " +
                    $"ON book.id_publisher = publisher.id_publisher WHERE Price LIKE '{searchTB.Text}%' " + dict[sortCB.Text]);
            }
            else if (searchCB.Text == "Количество")
            {
                searchMethod($"SELECT id_book, Book_name, Image, Descr, Author_name, Genre_name, Publisher_name, YEAR(Publication_Year), " +
                    $"Price, Amount FROM author JOIN book USING(id_author) JOIN genre USING(id_genre) JOIN publisher " +
                    $"ON book.id_publisher = publisher.id_publisher WHERE Amount LIKE '{searchTB.Text}%' " + dict[sortCB.Text]);
            }
        }

        private void searchCB_TextChanged(object sender, EventArgs e)
        {
            if (searchCB.Text == "")
            {
                searchTB.Enabled = false;
            }
            else
            {
                searchTB.Enabled = true;
            }
            searchTB.Text = "";
        }

        private void sortCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowCatalogPanel.Controls.Clear();
            searchMethod($"SELECT id_book, Book_name, Image, Descr, Author_name, Genre_name, Publisher_name, YEAR(Publication_Year), " +
                    $"Price, Amount FROM author JOIN book USING(id_author) JOIN genre USING(id_genre) JOIN publisher " +
                    $"ON book.id_publisher = publisher.id_publisher WHERE Book_name LIKE '%{searchTB.Text}%' " + dict[sortCB.Text]);
        }
    }
}