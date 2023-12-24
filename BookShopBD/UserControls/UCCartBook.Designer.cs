namespace BookShopBD.UserControls
{
    partial class UCCartBook
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
            this.changeBook = new System.Windows.Forms.Button();
            this.amountBookLbl = new System.Windows.Forms.Label();
            this.deleteBook = new System.Windows.Forms.Button();
            this.imageBookPB = new System.Windows.Forms.PictureBox();
            this.checkBook = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBookPB)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.checkBook);
            this.mainPanel.Controls.Add(this.deleteBook);
            this.mainPanel.Controls.Add(this.amountBookLbl);
            this.mainPanel.Controls.Add(this.changeBook);
            this.mainPanel.Controls.Add(this.priceBookLbl);
            this.mainPanel.Controls.Add(this.nameBookLbl);
            this.mainPanel.Controls.Add(this.imageBookPB);
            this.mainPanel.Location = new System.Drawing.Point(2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(172, 372);
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
            // changeBook
            // 
            this.changeBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.changeBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeBook.FlatAppearance.BorderSize = 0;
            this.changeBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeBook.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeBook.ForeColor = System.Drawing.Color.White;
            this.changeBook.Location = new System.Drawing.Point(3, 332);
            this.changeBook.Name = "changeBook";
            this.changeBook.Size = new System.Drawing.Size(40, 37);
            this.changeBook.TabIndex = 3;
            this.changeBook.Text = "✎";
            this.changeBook.UseVisualStyleBackColor = false;
            this.changeBook.MouseEnter += new System.EventHandler(this.mainPanel_MouseEnter);
            this.changeBook.MouseLeave += new System.EventHandler(this.mainPanel_MouseLeave);
            // 
            // amountBookLbl
            // 
            this.amountBookLbl.AutoEllipsis = true;
            this.amountBookLbl.AutoSize = true;
            this.amountBookLbl.BackColor = System.Drawing.Color.White;
            this.amountBookLbl.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountBookLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.amountBookLbl.Location = new System.Drawing.Point(1, 306);
            this.amountBookLbl.Name = "amountBookLbl";
            this.amountBookLbl.Size = new System.Drawing.Size(108, 24);
            this.amountBookLbl.TabIndex = 4;
            this.amountBookLbl.Text = "Количество";
            this.amountBookLbl.MouseEnter += new System.EventHandler(this.mainPanel_MouseEnter);
            this.amountBookLbl.MouseLeave += new System.EventHandler(this.mainPanel_MouseLeave);
            // 
            // deleteBook
            // 
            this.deleteBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.deleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBook.FlatAppearance.BorderSize = 0;
            this.deleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBook.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBook.ForeColor = System.Drawing.Color.White;
            this.deleteBook.Location = new System.Drawing.Point(49, 332);
            this.deleteBook.Name = "deleteBook";
            this.deleteBook.Size = new System.Drawing.Size(40, 37);
            this.deleteBook.TabIndex = 6;
            this.deleteBook.Text = "✕";
            this.deleteBook.UseVisualStyleBackColor = false;
            this.deleteBook.MouseEnter += new System.EventHandler(this.mainPanel_MouseEnter);
            this.deleteBook.MouseLeave += new System.EventHandler(this.mainPanel_MouseLeave);
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
            // checkBook
            // 
            this.checkBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.checkBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBook.FlatAppearance.BorderSize = 0;
            this.checkBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBook.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBook.ForeColor = System.Drawing.Color.White;
            this.checkBook.Location = new System.Drawing.Point(95, 332);
            this.checkBook.Name = "checkBook";
            this.checkBook.Size = new System.Drawing.Size(40, 37);
            this.checkBook.TabIndex = 7;
            this.checkBook.Text = "✓";
            this.checkBook.UseVisualStyleBackColor = false;
            this.checkBook.Click += new System.EventHandler(this.checkBook_Click);
            this.checkBook.MouseEnter += new System.EventHandler(this.mainPanel_MouseEnter);
            this.checkBook.MouseLeave += new System.EventHandler(this.mainPanel_MouseLeave);
            // 
            // UCCartBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.mainPanel);
            this.Name = "UCCartBook";
            this.Size = new System.Drawing.Size(177, 376);
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
        private System.Windows.Forms.Label amountBookLbl;
        private System.Windows.Forms.Button changeBook;
        private System.Windows.Forms.Button deleteBook;
        private System.Windows.Forms.Button checkBook;
    }
}
