﻿using System.Windows.Forms;

namespace BookShopBD
{
    internal class CreateAccount
    {
        public static void CreateAccountMethod(string login, string password, string typeAc, string firstN, string lastN,
            string middleN, string address, string phone, string mail)
        {
            try
            {
                DBConnection.msCommand.CommandText = $"SELECT Login FROM account WHERE Login = '{login}'";
                if (DBConnection.msCommand.ExecuteScalar() == null)
                {
                    DBConnection.msCommand.CommandText = $"CALL CreateAccount('{login}', '{password}'," +
                        $"'{typeAc}', '{firstN}', '{lastN}', '{middleN}', '{address}'," +
                        $"'{phone}', '{mail}')";
                    DBConnection.msCommand.ExecuteNonQuery();
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Ошибка при создании аккаунта.", "Ошибка создания аккаунта", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }
    }
}
