using System;
using System.Windows.Forms;

namespace BookShopBD
{
    internal class Authorization
    {
        static string role, firstName, lastName, middleName;

        static public void AuthorizationMethod(string login, string password)
        {
			try
			{
				DBConnection.msCommand.CommandText = $"SELECT Role_name FROM role JOIN account USING(id_role) " +
					$"WHERE Login = '{login}' AND Password = '{password}';";
				object result = DBConnection.msCommand.ExecuteScalar();
				if (result != null) 
				{
					role = result.ToString();
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
                    DBConnection.msCommand.CommandText = $"SELECT LastName FROM Customer JOIN account USING(id_account) " +
                        $"WHERE Login = '{login}';";
                    lastName = DBConnection.msCommand.ExecuteScalar().ToString();
                    return lastName;
                }
                else if (role == "Продавец")
                {
                    DBConnection.msCommand.CommandText = $"SELECT LastName FROM Employee JOIN account USING(id_account) " +
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
                    DBConnection.msCommand.CommandText = $"SELECT FirstName FROM Customer JOIN account USING(id_account) " +
                        $"WHERE Login = '{login}';";
                    firstName = DBConnection.msCommand.ExecuteScalar().ToString();
                    return firstName;
                }
                else if (role == "Продавец")
                {
                    DBConnection.msCommand.CommandText = $"SELECT FirstName FROM Employee JOIN account USING(id_account) " +
                        $"WHERE Login = '{login}';";
                    firstName = DBConnection.msCommand.ExecuteScalar().ToString();
                    return lastName;
                }
                else
                {
                    DBConnection.msCommand.CommandText = $"SELECT FirstName FROM Admin JOIN account USING(id_account) " +
                        $"WHERE Login = '{login}';";
                    firstName = DBConnection.msCommand.ExecuteScalar().ToString();
                    return lastName;
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
                    DBConnection.msCommand.CommandText = $"SELECT MiddleName FROM Customer JOIN account USING(id_account) " +
                        $"WHERE Login = '{login}';";
                    middleName = DBConnection.msCommand.ExecuteScalar().ToString();
                    return middleName;
                }
                else if (role == "Продавец")
                {
                    DBConnection.msCommand.CommandText = $"SELECT MiddleName FROM Employee JOIN account USING(id_account) " +
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
    }
}
