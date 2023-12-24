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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.deleteAllBtn = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.borderDGV = new System.Windows.Forms.Panel();
            this.flowLayoutCart = new System.Windows.Forms.FlowLayoutPanel();
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
            this.checkAllButton = new System.Windows.Forms.Button();
            this.panelSearch.SuspendLayout();
            this.borderDGV.SuspendLayout();
            this.panelOrderAll.SuspendLayout();
            this.panelOrderSelected.SuspendLayout();
            this.panelOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.panelSearch.Controls.Add(this.checkAllButton);
            this.panelSearch.Controls.Add(this.deleteAllBtn);
            this.panelSearch.Controls.Add(this.refreshButton);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1123, 49);
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
            this.deleteAllBtn.Location = new System.Drawing.Point(4, 4);
            this.deleteAllBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteAllBtn.Name = "deleteAllBtn";
            this.deleteAllBtn.Size = new System.Drawing.Size(160, 41);
            this.deleteAllBtn.TabIndex = 11;
            this.deleteAllBtn.Text = "Удалить всё";
            this.deleteAllBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteAllBtn.UseVisualStyleBackColor = false;
            this.deleteAllBtn.Click += new System.EventHandler(this.deleteAllBtn_Click);
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
            // borderDGV
            // 
            this.borderDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderDGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.borderDGV.Controls.Add(this.flowLayoutCart);
            this.borderDGV.Location = new System.Drawing.Point(0, 49);
            this.borderDGV.Margin = new System.Windows.Forms.Padding(4);
            this.borderDGV.Name = "borderDGV";
            this.borderDGV.Size = new System.Drawing.Size(1124, 432);
            this.borderDGV.TabIndex = 3;
            // 
            // flowLayoutCart
            // 
            this.flowLayoutCart.AutoScroll = true;
            this.flowLayoutCart.BackColor = System.Drawing.Color.White;
            this.flowLayoutCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutCart.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutCart.Name = "flowLayoutCart";
            this.flowLayoutCart.Size = new System.Drawing.Size(1124, 432);
            this.flowLayoutCart.TabIndex = 0;
            // 
            // panelOrderAll
            // 
            this.panelOrderAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelOrderAll.BackColor = System.Drawing.Color.White;
            this.panelOrderAll.Controls.Add(this.orderAllBtn);
            this.panelOrderAll.Controls.Add(this.sumAll);
            this.panelOrderAll.Controls.Add(this.orderAllLabel);
            this.panelOrderAll.Controls.Add(this.sumOrderAllLabel);
            this.panelOrderAll.Location = new System.Drawing.Point(563, 148);
            this.panelOrderAll.Margin = new System.Windows.Forms.Padding(4);
            this.panelOrderAll.Name = "panelOrderAll";
            this.panelOrderAll.Size = new System.Drawing.Size(555, 222);
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
            this.orderAllBtn.Location = new System.Drawing.Point(4, 169);
            this.orderAllBtn.Margin = new System.Windows.Forms.Padding(4);
            this.orderAllBtn.Name = "orderAllBtn";
            this.orderAllBtn.Size = new System.Drawing.Size(267, 49);
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
            this.sumAll.Location = new System.Drawing.Point(4, 122);
            this.sumAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sumAll.Name = "sumAll";
            this.sumAll.Size = new System.Drawing.Size(80, 38);
            this.sumAll.TabIndex = 2;
            this.sumAll.Text = "0. 00";
            // 
            // orderAllLabel
            // 
            this.orderAllLabel.AutoSize = true;
            this.orderAllLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderAllLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.orderAllLabel.Location = new System.Drawing.Point(4, 5);
            this.orderAllLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderAllLabel.Name = "orderAllLabel";
            this.orderAllLabel.Size = new System.Drawing.Size(177, 38);
            this.orderAllLabel.TabIndex = 1;
            this.orderAllLabel.Text = "Заказать всё";
            // 
            // sumOrderAllLabel
            // 
            this.sumOrderAllLabel.AutoSize = true;
            this.sumOrderAllLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumOrderAllLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.sumOrderAllLabel.Location = new System.Drawing.Point(4, 86);
            this.sumOrderAllLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sumOrderAllLabel.Name = "sumOrderAllLabel";
            this.sumOrderAllLabel.Size = new System.Drawing.Size(188, 38);
            this.sumOrderAllLabel.TabIndex = 0;
            this.sumOrderAllLabel.Text = "Сумма заказа";
            // 
            // panelOrderSelected
            // 
            this.panelOrderSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelOrderSelected.BackColor = System.Drawing.Color.White;
            this.panelOrderSelected.Controls.Add(this.sumSelected);
            this.panelOrderSelected.Controls.Add(this.orderSelectedBtn);
            this.panelOrderSelected.Controls.Add(this.orderSelectedLabel);
            this.panelOrderSelected.Controls.Add(this.sumOrderSelectedLabel);
            this.panelOrderSelected.Location = new System.Drawing.Point(0, 148);
            this.panelOrderSelected.Margin = new System.Windows.Forms.Padding(4);
            this.panelOrderSelected.Name = "panelOrderSelected";
            this.panelOrderSelected.Size = new System.Drawing.Size(549, 222);
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
            this.sumSelected.Location = new System.Drawing.Point(4, 122);
            this.sumSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sumSelected.Name = "sumSelected";
            this.sumSelected.Size = new System.Drawing.Size(72, 38);
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
            this.orderSelectedBtn.Location = new System.Drawing.Point(4, 169);
            this.orderSelectedBtn.Margin = new System.Windows.Forms.Padding(4);
            this.orderSelectedBtn.Name = "orderSelectedBtn";
            this.orderSelectedBtn.Size = new System.Drawing.Size(267, 49);
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
            this.orderSelectedLabel.Location = new System.Drawing.Point(4, 5);
            this.orderSelectedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderSelectedLabel.Name = "orderSelectedLabel";
            this.orderSelectedLabel.Size = new System.Drawing.Size(277, 38);
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
            this.sumOrderSelectedLabel.Location = new System.Drawing.Point(4, 86);
            this.sumOrderSelectedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sumOrderSelectedLabel.Name = "sumOrderSelectedLabel";
            this.sumOrderSelectedLabel.Size = new System.Drawing.Size(188, 38);
            this.sumOrderSelectedLabel.TabIndex = 0;
            this.sumOrderSelectedLabel.Text = "Сумма заказа";
            // 
            // panelOrder
            // 
            this.panelOrder.BackColor = System.Drawing.Color.White;
            this.panelOrder.Controls.Add(this.orderBtwnOrders);
            this.panelOrder.Controls.Add(this.panelOrderAll);
            this.panelOrder.Controls.Add(this.panelOrderSelected);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOrder.Location = new System.Drawing.Point(0, 333);
            this.panelOrder.Margin = new System.Windows.Forms.Padding(4);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(1123, 369);
            this.panelOrder.TabIndex = 6;
            // 
            // orderBtwnOrders
            // 
            this.orderBtwnOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.orderBtwnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.orderBtwnOrders.Location = new System.Drawing.Point(557, 148);
            this.orderBtwnOrders.Margin = new System.Windows.Forms.Padding(4);
            this.orderBtwnOrders.Name = "orderBtwnOrders";
            this.orderBtwnOrders.Size = new System.Drawing.Size(5, 222);
            this.orderBtwnOrders.TabIndex = 6;
            // 
            // checkAllButton
            // 
            this.checkAllButton.BackColor = System.Drawing.Color.White;
            this.checkAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkAllButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAllButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkAllButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.checkAllButton.Location = new System.Drawing.Point(172, 4);
            this.checkAllButton.Margin = new System.Windows.Forms.Padding(4);
            this.checkAllButton.Name = "checkAllButton";
            this.checkAllButton.Size = new System.Drawing.Size(160, 41);
            this.checkAllButton.TabIndex = 12;
            this.checkAllButton.Text = "Выбрать всё";
            this.checkAllButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkAllButton.UseVisualStyleBackColor = false;
            this.checkAllButton.Click += new System.EventHandler(this.checkAllButton_Click);
            // 
            // UCCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.borderDGV);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelOrder);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCCart";
            this.Size = new System.Drawing.Size(1123, 702);
            this.Load += new System.EventHandler(this.UCCart_Load);
            this.panelSearch.ResumeLayout(false);
            this.borderDGV.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutCart;
        private System.Windows.Forms.Button checkAllButton;
    }
}
