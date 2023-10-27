using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            DBConnection.ConnectionDB();
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
            DBConnection.CloseDB();
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

        private void createAccountLabel_Click(object sender, EventArgs e)
        {
            Form newForm = new FormCreateAccount();
            newForm.ShowDialog();
        }

    private void authorizationButton_Click(object sender, EventArgs e)
        {
            if(loginTB.Text != "" && passwordTB.Text != "")
            {
                if(loginTB.Text == "admin" && passwordTB.Text == "admin")
                {
                    MessageBox.Show($"Добро пожаловать в профиль, Кульдеев Данат Владимирович.",
                                "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CurrentUser.LastName = "Кульдеев";
                    CurrentUser.FirstName = "Данат";
                    CurrentUser.MiddleName = "Владимирович";
                    this.Hide();
                }
                Authorization.AuthorizationMethod(loginTB.Text, passwordTB.Text);
                CurrentUser.Role = Authorization.GetRole();
                switch (CurrentUser.Role)
                {
                    case null:
                        {
                            MessageBox.Show("Такого аккаунт не существует.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    default:
                        {
                            CurrentUser.Login = loginTB.Text;
                            CurrentUser.LastName = Authorization.GetLastName(loginTB.Text);
                            CurrentUser.FirstName = Authorization.GetFirstName(loginTB.Text);
                            CurrentUser.MiddleName = Authorization.GetMiddleName(loginTB.Text);
                            CurrentUser.Id_account = Authorization.GetAccountID();
                            MessageBox.Show($"Добро пожаловать в профиль, {CurrentUser.LastName} {CurrentUser.FirstName} {CurrentUser.MiddleName}.",
                                "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form newForm = new FormCustomer();
                            this.Hide();
                            newForm.Show();
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]").Success)
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void passwordTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]").Success)
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
