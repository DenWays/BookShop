using System;
using System.Windows.Forms;

namespace BookShopBD
{
    internal class Authorization
    {
        static string role, firstName, lastName, middleName;
        static int id_account;

        static public void AuthorizationMethod(string login, string password)
        {
            try
            {
                DBConnection.msCommand.CommandText = $"SELECT Role_name FROM role JOIN account USING(id_role) " +
                    $"WHERE Login = '{login}' AND Password = MD5('{password}')";
                object result = DBConnection.msCommand.ExecuteScalar();
                DBConnection.msCommand.CommandText = $"SELECT id_account FROM account WHERE Login = '{login}' AND Password = MD5('{password}')";
                object resID = DBConnection.msCommand.ExecuteScalar();
                if (result != null) 
				{
					role = result.ToString();
                    id_account = (int)resID;
				}
				else
				{
					role = firstName = lastName = null;
				}
			}
			catch (Exception)
			{
                role = null;
                MessageBox.Show("Ошибка при авторизации!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		static public string GetLastName(string login)
		{
            try
            {
                if (role == "Покупатель")
                {
                    DBConnection.msCommand.CommandText = $"SELECT LastName FROM customer JOIN account USING(id_account) " +
                        $"WHERE Login = '{login}';";
                    lastName = DBConnection.msCommand.ExecuteScalar().ToString();
                    return lastName;
                }
                else if (role == "Продавец")
                {
                    DBConnection.msCommand.CommandText = $"SELECT LastName FROM employee JOIN account USING(id_account) " +
                        $"WHERE Login = '{login}';";
                    lastName = DBConnection.msCommand.ExecuteScalar().ToString();
                    return lastName;
                }
                else
                {
                    DBConnection.msCommand.CommandText = $"SELECT LastName FROM Admin JOIN account USING(id_account) " +
                        $"WHERE Login = '{login}';";
                    lastName = DBConnection.msCommand.ExecuteScalar().ToString();
                    return lastName;
                }
            }
            catch (Exception)
            {
                return null;
            }
		}

        static public string GetFirstName(string login)
        {
			try
			{
                if (role == "Покупатель")
                {
                    DBConnection.msCommand.CommandText = $"SELECT FirstName FROM customer JOIN account USING(id_account) " +
                        $"WHERE Login = '{login}';";
                    firstName = DBConnection.msCommand.ExecuteScalar().ToString();
                    return firstName;
                }
                else if (role == "Продавец")
                {
                    DBConnection.msCommand.CommandText = $"SELECT FirstName FROM employee JOIN account USING(id_account) " +
                        $"WHERE Login = '{login}';";
                    firstName = DBConnection.msCommand.ExecuteScalar().ToString();
                    return firstName;
                }
                else
                {
                    DBConnection.msCommand.CommandText = $"SELECT FirstName FROM Admin JOIN account USING(id_account) " +
                        $"WHERE Login = '{login}';";
                    firstName = DBConnection.msCommand.ExecuteScalar().ToString();
                    return firstName;
                }
            }
			catch (Exception)
			{
                return null;
			}
        }

        static public string GetMiddleName(string login)
        {
            try
            {
                if (role == "Покупатель")
                {
                    DBConnection.msCommand.CommandText = $"SELECT MiddleName FROM customer JOIN account USING(id_account) " +
                        $"WHERE Login = '{login}';";
                    middleName = DBConnection.msCommand.ExecuteScalar().ToString();
                    return middleName;
                }
                else if (role == "Продавец")
                {
                    DBConnection.msCommand.CommandText = $"SELECT MiddleName FROM employee JOIN account USING(id_account) " +
                        $"WHERE Login = '{login}';";
                    middleName = DBConnection.msCommand.ExecuteScalar().ToString();
                    return middleName;
                }
                else
                {
                    DBConnection.msCommand.CommandText = $"SELECT MiddleName FROM Admin JOIN account USING(id_account) " +
                        $"WHERE Login = '{login}';";
                    middleName = DBConnection.msCommand.ExecuteScalar().ToString();
                    return middleName;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string GetRole()
        {
            return role;
        }

        public static int GetAccountID()
        {
            return id_account;
        }
    }
}
