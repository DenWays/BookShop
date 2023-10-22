using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookShopBD
{
    internal class DBConnection
    {
        static string DBConnect = "server = 127.0.0.1; user=root; password=Danat@78;database=BookShop";
        static public MySqlDataAdapter msDataAddapter;
        static MySqlConnection myConnect;
        static public MySqlCommand msCommand;
        static public MySqlDataReader dataReader;

        static public void ConnectionDB()
        {
            try
            {
                myConnect = new MySqlConnection(DBConnect);
                myConnect.Open();
                msCommand = new MySqlCommand();
                msCommand.Connection = myConnect;
                msDataAddapter = new MySqlDataAdapter();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка подключения к БД.", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }            
        }

        static public void CloseDB()
        {
            myConnect.Close();
        }
    }
}
