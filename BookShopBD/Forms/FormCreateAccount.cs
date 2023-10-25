using System;
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
            DBConnection.ConnectionDB();
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
            if(loginTB.Text != "" && passwordTB.Text != "" && retypePassTB.Text != "" && firstNTB.Text != "" &&
                lastNTB.Text != "" && middleNTB.Text != "" && addressTB.Text != "" && phoneTB.Text != "" &&
                mailTB.Text != "" && typeAcCB.Text != "")
            {
                if(passwordTB.Text != retypePassTB.Text) 
                { 
                    MessageBox.Show("Пароли должны совпадать.", "Пароли не соспадают", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(!IsValidEmail(mailTB.Text)) 
                { 
                    MessageBox.Show("Почта введена неправильно.", "Ошибка ввода почты", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DBConnection.msCommand.CommandText = $"SELECT Login FROM account WHERE Login = '{loginTB.Text}'";
                if (DBConnection.msCommand.ExecuteScalar() == null)
                {
                    CreateAccount.CreateAccountMethod(loginTB.Text, passwordTB.Text, typeAcCB.Text, firstNTB.Text,
                    lastNTB.Text, middleNTB.Text, addressTB.Text, phoneTB.Text, mailTB.Text);
                    MessageBox.Show("Аккаунт успешно создан!", "Успешно", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Аккаунт с таким логином уже есть.", "Логин занят", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля.", "Ошибка создания аккаунта", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lastNTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && Symbol[0] != 8)
            {
                e.Handled = true;
            }
        }

        private void firstNTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && Symbol[0] != 8)
            {
                e.Handled = true;
            }
        }

        private void middleNTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && Symbol[0] != 8)
            {
                e.Handled = true;
            }
        }

        private void mailTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[a-zA-Z]").Success && Symbol[0] != 8 && Symbol[0] != '@' && Symbol[0] != '.')
            {
                e.Handled = true;
            }
            else
            {
                return;
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

        private void retypePassTB_KeyPress(object sender, KeyPressEventArgs e)
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
