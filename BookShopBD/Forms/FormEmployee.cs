using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BookShopBD
{
    public partial class FormEmployee : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        bool fullScreenFlag = false;
        public static int id_account;
        public FormEmployee()
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
            DBConnection.CloseDB();
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
            if(panelChoise.Location == new Point(0, catalog.Location.Y)) { return; }
            panelChoise.Location = new Point(0, catalog.Location.Y);
            UCCatalog uCCatalog = new UCCatalog();
            AddControlsToPanel(uCCatalog);
        }

        private void panelTools_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form newForm = new FormAuthorization();
            this.Hide();
            newForm.Show();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            lastNLabel.Text = CurrentUser.LastName;
            firstNLabel.Text = CurrentUser.FirstName;
            middleNLabel.Text = CurrentUser.MiddleName;
            roleLabel.Text = CurrentUser.Role;
            id_account = CurrentUser.Id_account;
        }

        private void orders_Click(object sender, EventArgs e)
        {          
            if(panelChoise.Location == new Point(0, orders.Location.Y)) { return; }
            panelChoise.Location = new Point(0, orders.Location.Y);
            UCOrderEmployee uCOrderEmployee = new UCOrderEmployee();
            AddControlsToPanel(uCOrderEmployee);
        }
    }
}
