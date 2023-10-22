using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookShopBD
{
    public partial class FormAddToCart : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        List<int> ids_employee = new List<int>();
        public FormAddToCart()
        {
            InitializeComponent();
            DBConnection.ConnectionDB();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DBConnection.ConnectionDB();

            DBConnection.msCommand.CommandText = $"CALL GetUserId({CurrentUser.Id_account}, 'Покупатель');";
            object id_customer = DBConnection.msCommand.ExecuteScalar();

            DBConnection.msCommand.CommandText = $"CALL GetUserId({ids_employee[choiseEmpCB.SelectedIndex]}, 'Продавец');";
            object id_employee = DBConnection.msCommand.ExecuteScalar();

            DBConnection.msCommand.CommandText = $"CALL AddToCart({(int)id_customer}, {(int)id_employee}, " +
                $"'{UCCatalog.books.SelectedRows[0].Cells[0].Value}', '{UCCatalog.books.SelectedRows[0].Cells[1].Value}', {double.Parse(UCCatalog.books.SelectedRows[0].Cells[5].Value.ToString())}, {int.Parse(choiseAmountTB.Text)});";
            DBConnection.msCommand.ExecuteNonQuery();
            MessageBox.Show("Успешно");
        }

        private void FormAddToCart_Load(object sender, EventArgs e)
        {
            DBConnection.msCommand.CommandText = "SELECT LastName, FirstName, MiddleName, id_account FROM employee";
            DBConnection.dataReader = DBConnection.msCommand.ExecuteReader();

            while (DBConnection.dataReader.Read())
            {
                choiseEmpCB.Items.Add($"{DBConnection.dataReader[0]} {DBConnection.dataReader[1]} {DBConnection.dataReader[2]}");
                ids_employee.Add(int.Parse(DBConnection.dataReader[3].ToString()));
            }
            DBConnection.CloseDB();
        }
    }
}
