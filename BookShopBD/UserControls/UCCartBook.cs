using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopBD.UserControls
{
    public partial class UCCartBook : UserControl
    {
        public UCCartBook()
        {
            InitializeComponent();
        }

        private string nameBook;
        private string priceBook;
        private string imageBook;
        private string id;
        private string amount;
        public string Namebook
        {
            get { return nameBook; }
            set { nameBook = value; nameBookLbl.Text = value; }
        }
        public string PriceBook
        {
            get { return priceBook; }
            set { priceBook = value; priceBookLbl.Text = value; }
        }
        public string ImageBook
        {
            get { return imageBook; }
            set { imageBook = value;
                try
                {
                    imageBookPB.LoadAsync(value);
                }
                catch
                {

                }
                }
        }
        public string Id
        {
            get { return id; }
            set { id = value; mainPanel.Name = value; }
        }
        public string Amount
        {
            get { return amount; }
            set { amount = value; amountBookLbl.Text = value; }
        }

        private void imageBookPB_Click(object sender, EventArgs e)
        {
            FormBook newFrom = new FormBook(int.Parse(mainPanel.Name));
            newFrom.ShowDialog();
        }

        private void mainPanel_MouseEnter(object sender, EventArgs e)
        {
            mainPanel.BackColor = Color.FromArgb(47, 60, 69);
            nameBookLbl.ForeColor = Color.White;
            nameBookLbl.BackColor = Color.FromArgb(47, 60, 69);
            amountBookLbl.ForeColor = Color.White;
            amountBookLbl.BackColor = Color.FromArgb(47, 60, 69);
            priceBookLbl.ForeColor = Color.White;
            priceBookLbl.BackColor = Color.FromArgb(47, 60, 69);
            changeBook.BackColor = Color.White;
            changeBook.ForeColor = Color.FromArgb(47,60,69);
            deleteBook.BackColor = Color.White;
            deleteBook.ForeColor = Color.FromArgb(47, 60, 69);
            checkBook.BackColor = Color.White;
            checkBook.ForeColor = Color.FromArgb(47, 60, 69);
        }

        private void mainPanel_MouseLeave(object sender, EventArgs e)
        {
            mainPanel.BackColor = Color.White;
            nameBookLbl.ForeColor = Color.FromArgb(47, 60, 69);
            nameBookLbl.BackColor = Color.White;
            amountBookLbl.ForeColor = Color.FromArgb(47, 60, 69);
            amountBookLbl.BackColor = Color.White;
            priceBookLbl.ForeColor = Color.FromArgb(47, 60, 69);
            priceBookLbl.BackColor = Color.White;
            changeBook.BackColor = Color.FromArgb(47, 60, 69); ;
            changeBook.ForeColor = Color.White;
            deleteBook.BackColor = Color.FromArgb(47, 60, 69); ;
            deleteBook.ForeColor = Color.White;
            checkBook.BackColor = Color.FromArgb(47, 60, 69); ;
            checkBook.ForeColor = Color.White;
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            DBConnection.ConnectionDB();
            Form bookForm = new FormBook(int.Parse(mainPanel.Name));
            Form newForm = new FormAddToCart();
            newForm.ShowDialog();
        }

        private void checkBook_Click(object sender, EventArgs e)
        {
            if (checkBook.Text == "✓")
            {
                checkBook.Text = "";
            }
            else
            {
                checkBook.Text = "✓";
            }
        }
    }
}
