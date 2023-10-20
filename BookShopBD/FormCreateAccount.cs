using MySqlX.XDevAPI.Common;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BookShopBD
{
    public partial class FormCreateAccount : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public FormCreateAccount()
        {
            InitializeComponent();
            passwordTB.UseSystemPasswordChar = true;
            retypePassTB.UseSystemPasswordChar = true;
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

        public static bool IsValidEmail(string mail)
        {
            return Regex.IsMatch(mail,
                   @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }

        private void createAcButton_Click(object sender, EventArgs e)
        {
            if(loginTB.Text != null && passwordTB.Text != null && retypePassTB.Text != null && firstNTB.Text != null &&
                lastNTB.Text != null && middleNTB.Text != null && addressTB.Text != null && phoneTB.Text != null &&
                mailTB.Text != null)
            {
                if(passwordTB.Text != retypePassTB.Text) { MessageBox.Show("Пароли должны совпадать.", "Пароли не соспадают", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                if(!IsValidEmail(mailTB.Text)) { MessageBox.Show("Почта введена неправильно.", "Ошибка ввода почты", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            else
            {
                MessageBox.Show("Заполните все поля.", "Ошибка создания аккаунта", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lastNTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private void firstNTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private void middleNTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }
    }
}
