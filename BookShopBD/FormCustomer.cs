using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopBD
{
    public partial class FormCustomer : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        bool fullScreenFlag = false;
        public FormCustomer()
        {
            InitializeComponent();
            UCCatalog uCCatalog = new UCCatalog();
            AddControlsToPanel(uCCatalog);
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelInfo.Controls.Clear();
            panelInfo.Controls.Add(c);
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

        private void catalog_Click(object sender, EventArgs e)
        {
            panelChoise.Location = new Point(0, catalog.Location.Y);
            UCCatalog uCCatalog = new UCCatalog();
            AddControlsToPanel(uCCatalog);
        }

        private void cart_Click(object sender, EventArgs e)
        {
            panelChoise.Location = new Point(0, cart.Location.Y);
            UCCart uCCart = new UCCart();
            AddControlsToPanel(uCCart);
        }

        private void panelTools_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
