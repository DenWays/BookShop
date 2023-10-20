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
    public partial class FormCustomer : Form
    {
        bool fullScreenFlag = false;
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maximazeButton_Click(object sender, EventArgs e)
        {
            if (!fullScreenFlag)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                maximazeButton.Text = "❐";
                fullScreenFlag = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maximazeButton.Text = "⛶";
                fullScreenFlag = false;
            }

        }

        private void minimizedButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
