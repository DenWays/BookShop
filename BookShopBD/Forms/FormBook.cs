using BookShopBD.UserControls;
using Microsoft.Office.Interop.Word;
using System;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookShopBD
{
    public partial class FormBook : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        Book book = new Book();
        int id;

        public FormBook(int id)
        {
            InitializeComponent();
            DBConnection.ConnectionDB();
            this.id = id;

            System.Data.DataTable dt = new System.Data.DataTable();
            DBConnection.msCommand.CommandText = $"SELECT id_book, Book_name, Image, Descr, Author_name, Genre_name, " +
                $"Publisher_name, YEAR(Publication_Year), Price, Amount FROM author JOIN book USING(id_author) " +
                $"JOIN genre USING(id_genre) JOIN publisher ON book.id_publisher = publisher.id_publisher " +
                $"WHERE id_book = {id} ORDER BY id_book;";
            DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
            DBConnection.msDataAddapter.Fill(dt);

            book.Id = dt.Rows[0][0].ToString();
            book.BookName = dt.Rows[0][1].ToString();
            book.Image = dt.Rows[0][2].ToString();
            book.Description = dt.Rows[0][3].ToString();
            book.AuthorName = dt.Rows[0][4].ToString();
            book.GenreName = dt.Rows[0][5].ToString();
            book.PublisherName = dt.Rows[0][6].ToString();
            book.Year = dt.Rows[0][7].ToString();
            book.Price = dt.Rows[0][8].ToString();
            book.Amount = dt.Rows[0][9].ToString();
        }

        private void closeButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void panelTools_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void minimizedButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            imageBook.LoadAsync(book.Image);
            nameBook.Text = book.BookName;
            yearBook.Text = book.Year;
            authorBook.Text = book.AuthorName;
            genreBook.Text = book.GenreName;
            publisherBook.Text = book.PublisherName;
            descriptionBook.Text = book.Description;
            priceBook.Text = priceBook.Text + ": " + book.Price;
            amountBook.Text = amountBook.Text + ": " + book.Amount;
        }
    }
}
