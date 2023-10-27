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

namespace BookShopBD.Forms
{
    public partial class FormAddPublisher : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public FormAddPublisher()
        {
            InitializeComponent();
            DBConnection.ConnectionDB();
        }

        private void newAmountTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Symbol = e.KeyChar;

            if (!char.IsDigit(Symbol) && Symbol != 8)
            {
                e.Handled = true;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (authorTB.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка при заполнении полей", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panelTools_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
