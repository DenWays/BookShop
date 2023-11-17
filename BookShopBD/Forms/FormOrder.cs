using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BookShopBD
{
    public partial class FormOrder : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public FormOrder()
        {
            InitializeComponent();
            DBConnection.ConnectionDB();
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

        private void FormOrder_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Clear();

            DBConnection.ConnectionDB();
            DBConnection.msCommand.CommandText = $"CALL GetUserId({CurrentUser.Id_account}, 'Покупатель');";
            object id_customer = DBConnection.msCommand.ExecuteScalar();

            DBConnection.msCommand.CommandText = $"SELECT Book_name AS Название, Author_name AS Автор, " +
                $"order_book.Price AS Цена, order_book.Amount AS Количество, " +
                $"Date_order AS Дата " +
                $"FROM order_ JOIN order_book USING(id_order) JOIN book USING(id_book) " +
                $"JOIN author USING(id_author) WHERE id_customer = {(int)id_customer} AND id_order = {UCHistory.id_order};";
            DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
            DBConnection.msDataAddapter.Fill(dataTable);
            ordersDGV.DataSource = dataTable;
            DBConnection.CloseDB();

            int count = 0;
            for (int i = 0; i < ordersDGV.Rows.Count; i++)
            {
                count += int.Parse(ordersDGV.Rows[i].Cells[3].Value.ToString());
            }
            countLabel.Text = count.ToString();

            double sum = 0.00;       
            for (int i = 0; i < ordersDGV.Rows.Count; i++)
            {
                sum += (double.Parse(ordersDGV.Rows[i].Cells[2].Value.ToString()) * int.Parse(ordersDGV.Rows[i].Cells[3].Value.ToString()));
            }
            sumLabel.Text = sum.ToString();
        }
    }
}
