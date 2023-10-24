namespace BookShopBD
{
    partial class UCCart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.deleteAllBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.borderDGV = new System.Windows.Forms.Panel();
            this.cartDGV = new System.Windows.Forms.DataGridView();
            this.panelOrderAll = new System.Windows.Forms.Panel();
            this.orderAllBtn = new System.Windows.Forms.Button();
            this.sumAll = new System.Windows.Forms.Label();
            this.orderAllLabel = new System.Windows.Forms.Label();
            this.sumOrderAllLabel = new System.Windows.Forms.Label();
            this.panelOrderSelected = new System.Windows.Forms.Panel();
            this.sumSelected = new System.Windows.Forms.Label();
            this.orderSelectedBtn = new System.Windows.Forms.Button();
            this.orderSelectedLabel = new System.Windows.Forms.Label();
            this.sumOrderSelectedLabel = new System.Windows.Forms.Label();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.orderBtwnOrders = new System.Windows.Forms.Panel();
            this.panelSearch.SuspendLayout();
            this.borderDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDGV)).BeginInit();
            this.panelOrderAll.SuspendLayout();
            this.panelOrderSelected.SuspendLayout();
            this.panelOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.panelSearch.Controls.Add(this.deleteAllBtn);
            this.panelSearch.Controls.Add(this.deleteBtn);
            this.panelSearch.Controls.Add(this.refreshButton);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(842, 40);
            this.panelSearch.TabIndex = 0;
            // 
            // deleteAllBtn
            // 
            this.deleteAllBtn.BackColor = System.Drawing.Color.White;
            this.deleteAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAllBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAllBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteAllBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.deleteAllBtn.Location = new System.Drawing.Point(96, 4);
            this.deleteAllBtn.Name = "deleteAllBtn";
            this.deleteAllBtn.Size = new System.Drawing.Size(120, 33);
            this.deleteAllBtn.TabIndex = 11;
            this.deleteAllBtn.Text = "Удалить всё";
            this.deleteAllBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteAllBtn.UseVisualStyleBackColor = false;
            this.deleteAllBtn.Click += new System.EventHandler(this.deleteAllBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.deleteBtn.Location = new System.Drawing.Point(0, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 33);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            // borderDGV
            // 
            this.borderDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderDGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.borderDGV.Controls.Add(this.cartDGV);
            this.borderDGV.Location = new System.Drawing.Point(0, 40);
            this.borderDGV.Name = "borderDGV";
            this.borderDGV.Size = new System.Drawing.Size(843, 351);
            this.borderDGV.TabIndex = 3;
            // 
            // cartDGV
            // 
            this.cartDGV.AllowUserToAddRows = false;
            this.cartDGV.AllowUserToDeleteRows = false;
            this.cartDGV.AllowUserToResizeColumns = false;
            this.cartDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.cartDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.cartDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.cartDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cartDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.cartDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.cartDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartDGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.cartDGV.GridColor = System.Drawing.Color.White;
            this.cartDGV.Location = new System.Drawing.Point(0, 0);
            this.cartDGV.Name = "cartDGV";
            this.cartDGV.ReadOnly = true;
            this.cartDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.cartDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartDGV.Size = new System.Drawing.Size(842, 350);
            this.cartDGV.TabIndex = 2;
            this.cartDGV.SelectionChanged += new System.EventHandler(this.cartDGV_SelectionChanged);
            // 
            // panelOrderAll
            // 
            this.panelOrderAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelOrderAll.Controls.Add(this.orderAllBtn);
            this.panelOrderAll.Controls.Add(this.sumAll);
            this.panelOrderAll.Controls.Add(this.orderAllLabel);
            this.panelOrderAll.Controls.Add(this.sumOrderAllLabel);
            this.panelOrderAll.Location = new System.Drawing.Point(422, 120);
            this.panelOrderAll.Name = "panelOrderAll";
            this.panelOrderAll.Size = new System.Drawing.Size(416, 180);
            this.panelOrderAll.TabIndex = 4;
            // 
            // orderAllBtn
            // 
            this.orderAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.orderAllBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.orderAllBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.orderAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderAllBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderAllBtn.ForeColor = System.Drawing.Color.White;
            this.orderAllBtn.Location = new System.Drawing.Point(3, 137);
            this.orderAllBtn.Name = "orderAllBtn";
            this.orderAllBtn.Size = new System.Drawing.Size(200, 40);
            this.orderAllBtn.TabIndex = 3;
            this.orderAllBtn.Text = "Заказать";
            this.orderAllBtn.UseVisualStyleBackColor = false;
            this.orderAllBtn.Click += new System.EventHandler(this.orderAllBtn_Click);
            // 
            // sumAll
            // 
            this.sumAll.AutoSize = true;
            this.sumAll.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.sumAll.Location = new System.Drawing.Point(3, 99);
            this.sumAll.Name = "sumAll";
            this.sumAll.Size = new System.Drawing.Size(62, 29);
            this.sumAll.TabIndex = 2;
            this.sumAll.Text = "0. 00";
            // 
            // orderAllLabel
            // 
            this.orderAllLabel.AutoSize = true;
            this.orderAllLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderAllLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.orderAllLabel.Location = new System.Drawing.Point(3, 4);
            this.orderAllLabel.Name = "orderAllLabel";
            this.orderAllLabel.Size = new System.Drawing.Size(137, 29);
            this.orderAllLabel.TabIndex = 1;
            this.orderAllLabel.Text = "Заказать всё";
            // 
            // sumOrderAllLabel
            // 
            this.sumOrderAllLabel.AutoSize = true;
            this.sumOrderAllLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumOrderAllLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.sumOrderAllLabel.Location = new System.Drawing.Point(3, 70);
            this.sumOrderAllLabel.Name = "sumOrderAllLabel";
            this.sumOrderAllLabel.Size = new System.Drawing.Size(145, 29);
            this.sumOrderAllLabel.TabIndex = 0;
            this.sumOrderAllLabel.Text = "Сумма заказа";
            // 
            // panelOrderSelected
            // 
            this.panelOrderSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelOrderSelected.Controls.Add(this.sumSelected);
            this.panelOrderSelected.Controls.Add(this.orderSelectedBtn);
            this.panelOrderSelected.Controls.Add(this.orderSelectedLabel);
            this.panelOrderSelected.Controls.Add(this.sumOrderSelectedLabel);
            this.panelOrderSelected.Location = new System.Drawing.Point(0, 120);
            this.panelOrderSelected.Name = "panelOrderSelected";
            this.panelOrderSelected.Size = new System.Drawing.Size(412, 180);
            this.panelOrderSelected.TabIndex = 5;
            // 
            // sumSelected
            // 
            this.sumSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sumSelected.AutoSize = true;
            this.sumSelected.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.sumSelected.Location = new System.Drawing.Point(3, 99);
            this.sumSelected.Name = "sumSelected";
            this.sumSelected.Size = new System.Drawing.Size(56, 29);
            this.sumSelected.TabIndex = 3;
            this.sumSelected.Text = "0.00";
            // 
            // orderSelectedBtn
            // 
            this.orderSelectedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.orderSelectedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.orderSelectedBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.orderSelectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderSelectedBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderSelectedBtn.ForeColor = System.Drawing.Color.White;
            this.orderSelectedBtn.Location = new System.Drawing.Point(3, 137);
            this.orderSelectedBtn.Name = "orderSelectedBtn";
            this.orderSelectedBtn.Size = new System.Drawing.Size(200, 40);
            this.orderSelectedBtn.TabIndex = 2;
            this.orderSelectedBtn.Text = "Заказать";
            this.orderSelectedBtn.UseVisualStyleBackColor = false;
            this.orderSelectedBtn.Click += new System.EventHandler(this.orderSelectedBtn_Click);
            // 
            // orderSelectedLabel
            // 
            this.orderSelectedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderSelectedLabel.AutoSize = true;
            this.orderSelectedLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderSelectedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.orderSelectedLabel.Location = new System.Drawing.Point(3, 4);
            this.orderSelectedLabel.Name = "orderSelectedLabel";
            this.orderSelectedLabel.Size = new System.Drawing.Size(217, 29);
            this.orderSelectedLabel.TabIndex = 1;
            this.orderSelectedLabel.Text = "Заказать выбранные";
            // 
            // sumOrderSelectedLabel
            // 
            this.sumOrderSelectedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sumOrderSelectedLabel.AutoSize = true;
            this.sumOrderSelectedLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumOrderSelectedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.sumOrderSelectedLabel.Location = new System.Drawing.Point(3, 70);
            this.sumOrderSelectedLabel.Name = "sumOrderSelectedLabel";
            this.sumOrderSelectedLabel.Size = new System.Drawing.Size(145, 29);
            this.sumOrderSelectedLabel.TabIndex = 0;
            this.sumOrderSelectedLabel.Text = "Сумма заказа";
            // 
            // panelOrder
            // 
            this.panelOrder.Controls.Add(this.orderBtwnOrders);
            this.panelOrder.Controls.Add(this.panelOrderAll);
            this.panelOrder.Controls.Add(this.panelOrderSelected);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOrder.Location = new System.Drawing.Point(0, 270);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(842, 300);
            this.panelOrder.TabIndex = 6;
            // 
            // orderBtwnOrders
            // 
            this.orderBtwnOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.orderBtwnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.orderBtwnOrders.Location = new System.Drawing.Point(418, 120);
            this.orderBtwnOrders.Name = "orderBtwnOrders";
            this.orderBtwnOrders.Size = new System.Drawing.Size(4, 180);
            this.orderBtwnOrders.TabIndex = 6;
            // 
            // UCCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.borderDGV);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelOrder);
            this.Name = "UCCart";
            this.Size = new System.Drawing.Size(842, 570);
            this.Load += new System.EventHandler(this.UCCart_Load);
            this.panelSearch.ResumeLayout(false);
            this.borderDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartDGV)).EndInit();
            this.panelOrderAll.ResumeLayout(false);
            this.panelOrderAll.PerformLayout();
            this.panelOrderSelected.ResumeLayout(false);
            this.panelOrderSelected.PerformLayout();
            this.panelOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Panel borderDGV;
        public System.Windows.Forms.DataGridView cartDGV;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel panelOrderAll;
        private System.Windows.Forms.Label sumOrderAllLabel;
        private System.Windows.Forms.Button deleteAllBtn;
        private System.Windows.Forms.Button orderAllBtn;
        private System.Windows.Forms.Label sumAll;
        private System.Windows.Forms.Label orderAllLabel;
        private System.Windows.Forms.Panel panelOrderSelected;
        private System.Windows.Forms.Label sumSelected;
        private System.Windows.Forms.Button orderSelectedBtn;
        private System.Windows.Forms.Label orderSelectedLabel;
        private System.Windows.Forms.Label sumOrderSelectedLabel;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Panel orderBtwnOrders;
    }
}
