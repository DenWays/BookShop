using MySqlX.XDevAPI.Common;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BookShopBD
{
    public partial class FormAuthorization : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public FormAuthorization()
        {
            InitializeComponent();
            passwordTB.UseSystemPasswordChar = true;
        }

        private void createAccountLabel_MouseEnter(object sender, System.EventArgs e)
        {
            createAccountLabel.ForeColor = Color.Blue;
        }

        private void createAccountLabel_MouseLeave(object sender, System.EventArgs e)
        {
            createAccountLabel.ForeColor = Color.FromArgb(47, 60, 69);
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
    }
}
