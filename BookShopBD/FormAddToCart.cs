using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            int id_employee;
            int.TryParse(string.Join("", choiseEmpCB.SelectedItem.ToString().Where(c => char.IsDigit(c))), out id_employee);
            DBConnection.msCommand.CommandText = $"CALL AddToCart({FormCustomer.id_account}, {id_employee}, {UCCatalog.books.SelectedRows[0]}, " +
                $"{UCCatalog.books.SelectedRows[1]}, {UCCatalog.books.SelectedRows[5]}, {choiseAmountTB.Text})";
            MessageBox.Show("Успешно");
        }

        private void FormAddToCart_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            DBConnection.msCommand.CommandText = "SELECT LastName, FirstName, MiddleName, id_account FROM employee";
            DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
            DBConnection.msDataAddapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                choiseEmpCB.Items.Add(dataTable.Rows[i]);
            }
        }
    }
}
