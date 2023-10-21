using MySqlX.XDevAPI.Common;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text;
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
        public static string loginActive;
        public static string roleActive;
        public static string lastName, firstName, middleName;

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
                    lastName = "Кульдеев";
                    firstName = "Данат";
                    middleName = "Владимирович";
                    this.Hide();
                }
                Authorization.AuthorizationMethod(loginTB.Text, passwordTB.Text);
                switch (Authorization.GetRole())
                {
                    case null:
                        {
                            MessageBox.Show("Такого аккаунт не существует.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    default:
                        {
                            loginActive = loginTB.Text;
                            roleActive = Authorization.GetRole();
                            lastName = Authorization.GetLastName(loginTB.Text);
                            firstName = Authorization.GetFirstName(loginTB.Text);
                            middleName = Authorization.GetMiddleName(loginTB.Text);
                            MessageBox.Show($"Добро пожаловать в профиль, {lastName} {firstName} {middleName}.",
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form newForm = new FormCustomer();
            this.Hide();
            newForm.Show();
        }
    }
}
