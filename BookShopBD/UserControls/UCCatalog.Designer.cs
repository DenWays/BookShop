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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchCB = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.flowCatalogPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.panelSearch.Controls.Add(this.button1);
            this.panelSearch.Controls.Add(this.searchButton);
            this.panelSearch.Controls.Add(this.addToCartButton);
            this.panelSearch.Controls.Add(this.refreshButton);
            this.panelSearch.Controls.Add(this.searchTB);
            this.panelSearch.Controls.Add(this.searchCB);
            this.panelSearch.Controls.Add(this.searchLabel);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1123, 49);
            this.panelSearch.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.White;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.searchButton.Location = new System.Drawing.Point(519, 5);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(107, 41);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Искать";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            this.addToCartButton.Location = new System.Drawing.Point(819, 5);
            this.addToCartButton.Margin = new System.Windows.Forms.Padding(4);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(243, 41);
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
            this.refreshButton.Location = new System.Drawing.Point(1069, -18);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(53, 65);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "↻";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.searchTB.Location = new System.Drawing.Point(337, 5);
            this.searchTB.Margin = new System.Windows.Forms.Padding(4);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(172, 35);
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
            this.searchCB.Location = new System.Drawing.Point(156, 5);
            this.searchCB.Margin = new System.Windows.Forms.Padding(4);
            this.searchCB.Name = "searchCB";
            this.searchCB.Size = new System.Drawing.Size(172, 36);
            this.searchCB.TabIndex = 2;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(4, 5);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(136, 33);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Искать по:";
            // 
            // flowCatalogPanel
            // 
            this.flowCatalogPanel.AutoScroll = true;
            this.flowCatalogPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCatalogPanel.Location = new System.Drawing.Point(0, 49);
            this.flowCatalogPanel.Name = "flowCatalogPanel";
            this.flowCatalogPanel.Size = new System.Drawing.Size(1123, 653);
            this.flowCatalogPanel.TabIndex = 1;
            // 
            // UCCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowCatalogPanel);
            this.Controls.Add(this.panelSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCCatalog";
            this.Size = new System.Drawing.Size(1123, 702);
            this.Load += new System.EventHandler(this.UCCatalog_Load);
            this.SizeChanged += new System.EventHandler(this.UCCatalog_SizeChanged);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.ComboBox searchCB;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.FlowLayoutPanel flowCatalogPanel;
        private System.Windows.Forms.Button button1;
    }
}
