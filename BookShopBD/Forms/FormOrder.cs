using Microsoft.Office.Interop.Word;
using System;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if(UCHistory.flag != true)
            {
                getCheckButton.Visible = false;
            }

            System.Data.DataTable dataTable = new System.Data.DataTable();
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

        private void getCheckButton_Click(object sender, EventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";

            _Application oWord;
            _Document oDoc;
            oWord = new Microsoft.Office.Interop.Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
                ref oMissing, ref oMissing);
         
            Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Text = "Чек";
            oPara1.Range.Font.Size = 14;
            oPara1.Range.Font.Bold = 1;
            oPara1.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            oPara1.Format.SpaceAfter = 14;
            oPara1.Range.InsertParagraphAfter();

            Paragraph oPara2;
            oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);          
            oPara2.Range.Text = "Имя покупателя: " + CurrentUser.LastName + " " + CurrentUser.FirstName + " " + CurrentUser.MiddleName;
            oPara2.Range.Font.Size = 14;
            oPara2.Range.Font.Bold = 0;
            oPara2.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            oPara2.Format.SpaceAfter = 14;
            oPara2.Range.InsertParagraphAfter();

            Paragraph oPara3;
            oPara3 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara3.Range.Text = "Имя продавца: " + UCHistory.FIOEmp;
            oPara3.Range.Font.Size = 14;
            oPara3.Range.Font.Bold = 0;
            oPara3.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            oPara3.Format.SpaceAfter = 14;
            oPara3.Range.InsertParagraphAfter();

            Paragraph oPara4;
            oPara4 = oDoc.Content.Paragraphs.Add(ref oMissing);
            string date = UCHistory.Date;
            string[] dates = date.Split(' ');
            oPara4.Range.Text = $"Заказ номер {UCHistory.id_order}: {countLabel.Text} товаров на сумму {sumLabel.Text},00. Дата: {dates[0]}";
            oPara4.Range.Font.Size = 14;
            oPara4.Range.Font.Bold = 0;
            oPara4.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            oPara4.Format.SpaceAfter = 14;
            oPara4.Range.InsertParagraphAfter();

            System.Data.DataTable dataTable = new System.Data.DataTable();
            DBConnection.ConnectionDB();
            DBConnection.msCommand.CommandText = $"CALL GetUserId({CurrentUser.Id_account}, 'Покупатель');";
            object id_customer = DBConnection.msCommand.ExecuteScalar();

            DBConnection.msCommand.CommandText = $"SELECT Book_name AS Название, Author_name AS Автор, " +
                $"order_book.Price AS Цена, order_book.Amount AS Количество " +
                $"FROM order_ JOIN order_book USING(id_order) JOIN book USING(id_book) " +
                $"JOIN author USING(id_author) WHERE id_customer = {(int)id_customer} AND id_order = {UCHistory.id_order};";
            DBConnection.msDataAddapter.SelectCommand = DBConnection.msCommand;
            DBConnection.msDataAddapter.Fill(dataTable);
            DBConnection.CloseDB();

            Paragraph oPara5;
            oPara5 = oDoc.Content.Paragraphs.Add(ref oMissing);

            Table table = oWord.Application.ActiveDocument.Tables.Add(oPara5.Range, dataTable.Rows.Count + 1, dataTable.Columns.Count, 
                Type.Missing, Type.Missing);
            table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
            table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                table.Cell(1, i + 1).Range.Text = dataTable.Columns[i].ColumnName;
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    table.Cell(i + 2, j + 1).Range.Text = dataTable.Rows[i][j].ToString();
                }
            }

            this.Close();
        }
    }
}
