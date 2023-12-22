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
    public partial class UCBook : UserControl
    {
        public UCBook()
        {
            InitializeComponent();
        }

        private string nameBook;
        private string priceBook;
        private string imageBook;
        private string id;
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
            set { imageBook = value; imageBookPB.LoadAsync(value); }
        }
        public string Id
        {
            get { return id; }
            set { id = value; mainPanel.Name = value; }
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
            priceBookLbl.ForeColor = Color.White;
            priceBookLbl.BackColor = Color.FromArgb(47, 60, 69);
        }

        private void mainPanel_MouseLeave(object sender, EventArgs e)
        {
            mainPanel.BackColor = Color.White;
            nameBookLbl.ForeColor = Color.FromArgb(47, 60, 69);
            nameBookLbl.BackColor = Color.White;
            priceBookLbl.ForeColor = Color.FromArgb(47, 60, 69);
            priceBookLbl.BackColor = Color.White;
        }

    }
}
