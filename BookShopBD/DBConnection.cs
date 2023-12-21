using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookShopBD
{
    internal class DBConnection
    {
        /*server=mc.flectone.net; port=3307; user=root; database=bookshop; password=7KaXphKo3z8QAJ;*/
        /*server=localhost; port=3306; user=root; database=bookshop; password=Danat@78;*/
        static string DBConnect = "server=localhost; port=3306; user=root; database=bookshop; password=Danat@78;";
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
