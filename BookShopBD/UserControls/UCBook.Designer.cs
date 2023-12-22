namespace BookShopBD.UserControls
{
    partial class UCBook
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.priceBookLbl = new System.Windows.Forms.Label();
            this.nameBookLbl = new System.Windows.Forms.Label();
            this.imageBookPB = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBookPB)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.priceBookLbl);
            this.mainPanel.Controls.Add(this.nameBookLbl);
            this.mainPanel.Controls.Add(this.imageBookPB);
            this.mainPanel.Location = new System.Drawing.Point(2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(172, 300);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseEnter += new System.EventHandler(this.mainPanel_MouseEnter);
            this.mainPanel.MouseLeave += new System.EventHandler(this.mainPanel_MouseLeave);
            // 
            // priceBookLbl
            // 
            this.priceBookLbl.AutoEllipsis = true;
            this.priceBookLbl.AutoSize = true;
            this.priceBookLbl.BackColor = System.Drawing.Color.White;
            this.priceBookLbl.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceBookLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.priceBookLbl.Location = new System.Drawing.Point(1, 276);
            this.priceBookLbl.Name = "priceBookLbl";
            this.priceBookLbl.Size = new System.Drawing.Size(52, 24);
            this.priceBookLbl.TabIndex = 2;
            this.priceBookLbl.Text = "Цена";
            this.priceBookLbl.Click += new System.EventHandler(this.imageBookPB_Click);
            this.priceBookLbl.MouseEnter += new System.EventHandler(this.mainPanel_MouseEnter);
            this.priceBookLbl.MouseLeave += new System.EventHandler(this.mainPanel_MouseLeave);
            // 
            // nameBookLbl
            // 
            this.nameBookLbl.AutoEllipsis = true;
            this.nameBookLbl.BackColor = System.Drawing.Color.White;
            this.nameBookLbl.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBookLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.nameBookLbl.Location = new System.Drawing.Point(3, 223);
            this.nameBookLbl.Name = "nameBookLbl";
            this.nameBookLbl.Size = new System.Drawing.Size(166, 53);
            this.nameBookLbl.TabIndex = 1;
            this.nameBookLbl.Text = "Название";
            this.nameBookLbl.Click += new System.EventHandler(this.imageBookPB_Click);
            this.nameBookLbl.MouseEnter += new System.EventHandler(this.mainPanel_MouseEnter);
            this.nameBookLbl.MouseLeave += new System.EventHandler(this.mainPanel_MouseLeave);
            // 
            // imageBookPB
            // 
            this.imageBookPB.BackColor = System.Drawing.Color.White;
            this.imageBookPB.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageBookPB.Location = new System.Drawing.Point(0, 0);
            this.imageBookPB.Name = "imageBookPB";
            this.imageBookPB.Size = new System.Drawing.Size(172, 220);
            this.imageBookPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBookPB.TabIndex = 0;
            this.imageBookPB.TabStop = false;
            this.imageBookPB.Click += new System.EventHandler(this.imageBookPB_Click);
            this.imageBookPB.MouseEnter += new System.EventHandler(this.mainPanel_MouseEnter);
            this.imageBookPB.MouseLeave += new System.EventHandler(this.mainPanel_MouseLeave);
            // 
            // UCBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.mainPanel);
            this.Name = "UCBook";
            this.Size = new System.Drawing.Size(177, 305);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBookPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox imageBookPB;
        private System.Windows.Forms.Label priceBookLbl;
        private System.Windows.Forms.Label nameBookLbl;
    }
}
