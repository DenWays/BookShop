using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopBD.Forms
{
    public partial class FormChangeAmount : Form
    {
        public FormChangeAmount()
        {
            InitializeComponent();
            DBConnection.ConnectionDB();
        }

        private void newAmountTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Symbol = e.KeyChar;

            if (!char.IsDigit(Symbol) && Symbol != 8)
            {
                e.Handled = true;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (newAmountTB.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка при заполнении полей", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.Parse(newAmountTB.Text) == 0)
            {
                MessageBox.Show("Нельзя заказать 0 книг.", "Ошибка при выборе количества", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBConnection.msCommand.CommandText = $"SELECT Amount FROM book JOIN author USING(id_author) " +
                $"WHERE Book_name = '{UCCart.itemsSelected[0]}' AND Author_name = '{UCCart.itemsSelected[1]}';";
            object amount = DBConnection.msCommand.ExecuteNonQuery();

            if(int.Parse(newAmountTB.Text) > (int)amount)
            {
                MessageBox.Show($"На складе сейчас {(int)amount} книг.", "Ошибка при выборе количества", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
    }
}
