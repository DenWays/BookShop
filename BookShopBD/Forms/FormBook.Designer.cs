namespace BookShopBD
{
    partial class FormBook
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBook));
            this.panelTools = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.panelDescr = new System.Windows.Forms.Panel();
            this.descriptionBook = new System.Windows.Forms.TextBox();
            this.yearBook = new System.Windows.Forms.Label();
            this.amountBook = new System.Windows.Forms.Label();
            this.priceBook = new System.Windows.Forms.Label();
            this.publisherBook = new System.Windows.Forms.Label();
            this.genreBook = new System.Windows.Forms.Label();
            this.authorBook = new System.Windows.Forms.Label();
            this.nameBook = new System.Windows.Forms.Label();
            this.panelPB = new System.Windows.Forms.Panel();
            this.imageBook = new System.Windows.Forms.PictureBox();
            this.panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelDescr.SuspendLayout();
            this.panelPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.panelTools.Controls.Add(this.closeButton);
            this.panelTools.Controls.Add(this.nameLabel);
            this.panelTools.Controls.Add(this.icon);
            this.panelTools.Location = new System.Drawing.Point(0, 0);
            this.panelTools.Margin = new System.Windows.Forms.Padding(4);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(1000, 37);
            this.panelTools.TabIndex = 1;
            this.panelTools.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTools_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(73)))), ((int)(((byte)(42)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(956, -10);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(48, 48);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "×";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(55, 9);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 24);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "BookShop";
            // 
            // icon
            // 
            this.icon.Image = global::BookShopBD.Properties.Resources.bookWhite;
            this.icon.Location = new System.Drawing.Point(4, 0);
            this.icon.Margin = new System.Windows.Forms.Padding(4);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(43, 37);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.panelMain.Controls.Add(this.addToCartButton);
            this.panelMain.Controls.Add(this.panelDescr);
            this.panelMain.Controls.Add(this.yearBook);
            this.panelMain.Controls.Add(this.amountBook);
            this.panelMain.Controls.Add(this.priceBook);
            this.panelMain.Controls.Add(this.publisherBook);
            this.panelMain.Controls.Add(this.genreBook);
            this.panelMain.Controls.Add(this.authorBook);
            this.panelMain.Controls.Add(this.nameBook);
            this.panelMain.Controls.Add(this.panelPB);
            this.panelMain.Location = new System.Drawing.Point(0, 37);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1000, 763);
            this.panelMain.TabIndex = 2;
            // 
            // addToCartButton
            // 
            this.addToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addToCartButton.BackColor = System.Drawing.Color.White;
            this.addToCartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToCartButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addToCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCartButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addToCartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.addToCartButton.Location = new System.Drawing.Point(4, 459);
            this.addToCartButton.Margin = new System.Windows.Forms.Padding(4);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(243, 41);
            this.addToCartButton.TabIndex = 12;
            this.addToCartButton.Text = "Добавить в корзину";
            this.addToCartButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addToCartButton.UseVisualStyleBackColor = false;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // panelDescr
            // 
            this.panelDescr.BackColor = System.Drawing.Color.White;
            this.panelDescr.Controls.Add(this.descriptionBook);
            this.panelDescr.Location = new System.Drawing.Point(252, 69);
            this.panelDescr.Name = "panelDescr";
            this.panelDescr.Size = new System.Drawing.Size(748, 443);
            this.panelDescr.TabIndex = 11;
            // 
            // descriptionBook
            // 
            this.descriptionBook.BackColor = System.Drawing.Color.White;
            this.descriptionBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionBook.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.descriptionBook.Location = new System.Drawing.Point(0, 0);
            this.descriptionBook.Multiline = true;
            this.descriptionBook.Name = "descriptionBook";
            this.descriptionBook.ReadOnly = true;
            this.descriptionBook.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionBook.Size = new System.Drawing.Size(748, 443);
            this.descriptionBook.TabIndex = 10;
            // 
            // yearBook
            // 
            this.yearBook.AutoSize = true;
            this.yearBook.BackColor = System.Drawing.Color.Transparent;
            this.yearBook.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearBook.ForeColor = System.Drawing.Color.White;
            this.yearBook.Location = new System.Drawing.Point(895, 36);
            this.yearBook.Name = "yearBook";
            this.yearBook.Size = new System.Drawing.Size(56, 31);
            this.yearBook.TabIndex = 9;
            this.yearBook.Text = "Год";
            // 
            // amountBook
            // 
            this.amountBook.AutoSize = true;
            this.amountBook.BackColor = System.Drawing.Color.Transparent;
            this.amountBook.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountBook.ForeColor = System.Drawing.Color.White;
            this.amountBook.Location = new System.Drawing.Point(3, 386);
            this.amountBook.Name = "amountBook";
            this.amountBook.Size = new System.Drawing.Size(147, 31);
            this.amountBook.TabIndex = 8;
            this.amountBook.Text = "Количество";
            // 
            // priceBook
            // 
            this.priceBook.AutoSize = true;
            this.priceBook.BackColor = System.Drawing.Color.Transparent;
            this.priceBook.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceBook.ForeColor = System.Drawing.Color.White;
            this.priceBook.Location = new System.Drawing.Point(3, 355);
            this.priceBook.Name = "priceBook";
            this.priceBook.Size = new System.Drawing.Size(70, 31);
            this.priceBook.TabIndex = 7;
            this.priceBook.Text = "Цена";
            // 
            // publisherBook
            // 
            this.publisherBook.AutoSize = true;
            this.publisherBook.BackColor = System.Drawing.Color.Transparent;
            this.publisherBook.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publisherBook.ForeColor = System.Drawing.Color.White;
            this.publisherBook.Location = new System.Drawing.Point(666, 35);
            this.publisherBook.Name = "publisherBook";
            this.publisherBook.Size = new System.Drawing.Size(166, 31);
            this.publisherBook.TabIndex = 5;
            this.publisherBook.Text = "Издательство";
            // 
            // genreBook
            // 
            this.genreBook.AutoSize = true;
            this.genreBook.BackColor = System.Drawing.Color.Transparent;
            this.genreBook.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreBook.ForeColor = System.Drawing.Color.White;
            this.genreBook.Location = new System.Drawing.Point(486, 35);
            this.genreBook.Name = "genreBook";
            this.genreBook.Size = new System.Drawing.Size(71, 31);
            this.genreBook.TabIndex = 4;
            this.genreBook.Text = "Жанр";
            // 
            // authorBook
            // 
            this.authorBook.AutoSize = true;
            this.authorBook.BackColor = System.Drawing.Color.Transparent;
            this.authorBook.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorBook.ForeColor = System.Drawing.Color.White;
            this.authorBook.Location = new System.Drawing.Point(256, 35);
            this.authorBook.Name = "authorBook";
            this.authorBook.Size = new System.Drawing.Size(80, 31);
            this.authorBook.TabIndex = 3;
            this.authorBook.Text = "Автор";
            // 
            // nameBook
            // 
            this.nameBook.AutoSize = true;
            this.nameBook.BackColor = System.Drawing.Color.Transparent;
            this.nameBook.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBook.ForeColor = System.Drawing.Color.White;
            this.nameBook.Location = new System.Drawing.Point(256, 4);
            this.nameBook.Name = "nameBook";
            this.nameBook.Size = new System.Drawing.Size(119, 31);
            this.nameBook.TabIndex = 1;
            this.nameBook.Text = "Название";
            // 
            // panelPB
            // 
            this.panelPB.BackColor = System.Drawing.Color.White;
            this.panelPB.Controls.Add(this.imageBook);
            this.panelPB.Location = new System.Drawing.Point(0, 0);
            this.panelPB.Name = "panelPB";
            this.panelPB.Size = new System.Drawing.Size(252, 352);
            this.panelPB.TabIndex = 0;
            // 
            // imageBook
            // 
            this.imageBook.BackColor = System.Drawing.Color.White;
            this.imageBook.Location = new System.Drawing.Point(0, 0);
            this.imageBook.Name = "imageBook";
            this.imageBook.Size = new System.Drawing.Size(252, 352);
            this.imageBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBook.TabIndex = 0;
            this.imageBook.TabStop = false;
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Shop";
            this.Load += new System.EventHandler(this.FormBook_Load);
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelDescr.ResumeLayout(false);
            this.panelDescr.PerformLayout();
            this.panelPB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label authorBook;
        private System.Windows.Forms.Label nameBook;
        private System.Windows.Forms.Panel panelPB;
        private System.Windows.Forms.PictureBox imageBook;
        private System.Windows.Forms.Label yearBook;
        private System.Windows.Forms.Label amountBook;
        private System.Windows.Forms.Label priceBook;
        private System.Windows.Forms.Label publisherBook;
        private System.Windows.Forms.Label genreBook;
        private System.Windows.Forms.TextBox descriptionBook;
        private System.Windows.Forms.Panel panelDescr;
        private System.Windows.Forms.Button addToCartButton;
    }
}

