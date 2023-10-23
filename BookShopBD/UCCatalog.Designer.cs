namespace BookShopBD
{
    partial class UCCatalog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchCB = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.booksDGV = new System.Windows.Forms.DataGridView();
            this.borderGrid = new System.Windows.Forms.Panel();
            this.panelBookInfo = new System.Windows.Forms.Panel();
            this.panelDescr = new System.Windows.Forms.Panel();
            this.bookDescr = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.Label();
            this.bookImage = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDGV)).BeginInit();
            this.borderGrid.SuspendLayout();
            this.panelBookInfo.SuspendLayout();
            this.panelDescr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.panelSearch.Controls.Add(this.searchButton);
            this.panelSearch.Controls.Add(this.addToCartButton);
            this.panelSearch.Controls.Add(this.refreshButton);
            this.panelSearch.Controls.Add(this.searchTB);
            this.panelSearch.Controls.Add(this.searchCB);
            this.panelSearch.Controls.Add(this.searchLabel);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(842, 40);
            this.panelSearch.TabIndex = 0;
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
            this.addToCartButton.Location = new System.Drawing.Point(614, 4);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(182, 33);
            this.addToCartButton.TabIndex = 8;
            this.addToCartButton.Text = "Добавить в корзину";
            this.addToCartButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addToCartButton.UseVisualStyleBackColor = false;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(802, -15);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(40, 53);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "↻";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.searchTB.Location = new System.Drawing.Point(253, 4);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(130, 30);
            this.searchTB.TabIndex = 3;
            this.searchTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTB_KeyPress);
            // 
            // searchCB
            // 
            this.searchCB.BackColor = System.Drawing.Color.White;
            this.searchCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.searchCB.FormattingEnabled = true;
            this.searchCB.Items.AddRange(new object[] {
            "Название",
            "Автор",
            "Жанр",
            "Издательство",
            "Год",
            "Цена",
            "Количество"});
            this.searchCB.Location = new System.Drawing.Point(117, 4);
            this.searchCB.Name = "searchCB";
            this.searchCB.Size = new System.Drawing.Size(130, 31);
            this.searchCB.TabIndex = 2;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(3, 4);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(108, 26);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Искать по:";
            // 
            // booksDGV
            // 
            this.booksDGV.AllowUserToAddRows = false;
            this.booksDGV.AllowUserToDeleteRows = false;
            this.booksDGV.AllowUserToResizeColumns = false;
            this.booksDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.booksDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.booksDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.booksDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.booksDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.booksDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.booksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booksDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.booksDGV.GridColor = System.Drawing.Color.White;
            this.booksDGV.Location = new System.Drawing.Point(0, 0);
            this.booksDGV.MultiSelect = false;
            this.booksDGV.Name = "booksDGV";
            this.booksDGV.ReadOnly = true;
            this.booksDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.booksDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDGV.Size = new System.Drawing.Size(842, 230);
            this.booksDGV.TabIndex = 1;
            this.booksDGV.SelectionChanged += new System.EventHandler(this.booksDGV_SelectionChanged);
            // 
            // borderGrid
            // 
            this.borderGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.borderGrid.Controls.Add(this.booksDGV);
            this.borderGrid.Location = new System.Drawing.Point(0, 40);
            this.borderGrid.Name = "borderGrid";
            this.borderGrid.Size = new System.Drawing.Size(843, 231);
            this.borderGrid.TabIndex = 2;
            // 
            // panelBookInfo
            // 
            this.panelBookInfo.BackColor = System.Drawing.Color.White;
            this.panelBookInfo.Controls.Add(this.panelDescr);
            this.panelBookInfo.Controls.Add(this.bookName);
            this.panelBookInfo.Controls.Add(this.bookImage);
            this.panelBookInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBookInfo.Location = new System.Drawing.Point(0, 271);
            this.panelBookInfo.Name = "panelBookInfo";
            this.panelBookInfo.Size = new System.Drawing.Size(842, 299);
            this.panelBookInfo.TabIndex = 3;
            // 
            // panelDescr
            // 
            this.panelDescr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDescr.AutoScroll = true;
            this.panelDescr.Controls.Add(this.bookDescr);
            this.panelDescr.Location = new System.Drawing.Point(212, 30);
            this.panelDescr.Name = "panelDescr";
            this.panelDescr.Size = new System.Drawing.Size(625, 262);
            this.panelDescr.TabIndex = 3;
            // 
            // bookDescr
            // 
            this.bookDescr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookDescr.BackColor = System.Drawing.Color.White;
            this.bookDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookDescr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.bookDescr.Location = new System.Drawing.Point(3, 0);
            this.bookDescr.Name = "bookDescr";
            this.bookDescr.Size = new System.Drawing.Size(607, 262);
            this.bookDescr.TabIndex = 2;
            this.bookDescr.Text = "Описание";
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.bookName.Location = new System.Drawing.Point(212, 3);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(97, 24);
            this.bookName.TabIndex = 1;
            this.bookName.Text = "Название";
            // 
            // bookImage
            // 
            this.bookImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookImage.Location = new System.Drawing.Point(3, 3);
            this.bookImage.Name = "bookImage";
            this.bookImage.Size = new System.Drawing.Size(202, 290);
            this.bookImage.TabIndex = 0;
            this.bookImage.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.White;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.searchButton.Location = new System.Drawing.Point(389, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 33);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Искать";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // UCCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBookInfo);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.borderGrid);
            this.Name = "UCCatalog";
            this.Size = new System.Drawing.Size(842, 570);
            this.Load += new System.EventHandler(this.UCCatalog_Load);
            this.SizeChanged += new System.EventHandler(this.UCCatalog_SizeChanged);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDGV)).EndInit();
            this.borderGrid.ResumeLayout(false);
            this.panelBookInfo.ResumeLayout(false);
            this.panelBookInfo.PerformLayout();
            this.panelDescr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.ComboBox searchCB;
        private System.Windows.Forms.Button addToCartButton;
        public System.Windows.Forms.DataGridView booksDGV;
        private System.Windows.Forms.Panel borderGrid;
        private System.Windows.Forms.Panel panelBookInfo;
        private System.Windows.Forms.Label bookName;
        private System.Windows.Forms.PictureBox bookImage;
        private System.Windows.Forms.Panel panelDescr;
        public System.Windows.Forms.Label bookDescr;
        private System.Windows.Forms.Button searchButton;
    }
}
