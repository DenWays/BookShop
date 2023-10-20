using MySqlX.XDevAPI.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BookShopBD
{
    public partial class FormAuthorizathion : Form
    {
        public FormAuthorizathion()
        {
            InitializeComponent();
            passwordTB.UseSystemPasswordChar = true;
        }

        private void panelAuthorization_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.FromArgb(47, 60, 69),
                                                                       Color.FromArgb(240, 71, 44),
                                                                       90))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void createAccountLabel_MouseEnter(object sender, System.EventArgs e)
        {
            createAccountLabel.ForeColor = Color.Blue;
        }

        private void createAccountLabel_MouseLeave(object sender, System.EventArgs e)
        {
            createAccountLabel.ForeColor = Color.White;
        }
    }
}
