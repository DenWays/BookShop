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
            this.refreshButton = new System.Windows.Forms.Button();
            this.cartDGV = new System.Windows.Forms.DataGridView();
            this.sumLabel = new System.Windows.Forms.Label();
            this.sumCart = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.panelSearch.Controls.Add(this.button1);
            this.panelSearch.Controls.Add(this.sumCart);
            this.panelSearch.Controls.Add(this.sumLabel);
            this.panelSearch.Controls.Add(this.refreshButton);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(842, 40);
            this.panelSearch.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
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
            // 
            // cartDGV
            // 
            this.cartDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDGV.Location = new System.Drawing.Point(6, 46);
            this.cartDGV.Name = "cartDGV";
            this.cartDGV.Size = new System.Drawing.Size(830, 518);
            this.cartDGV.TabIndex = 1;
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumLabel.ForeColor = System.Drawing.Color.White;
            this.sumLabel.Location = new System.Drawing.Point(3, 8);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(142, 26);
            this.sumLabel.TabIndex = 5;
            this.sumLabel.Text = "Общая сумма:";
            // 
            // sumCart
            // 
            this.sumCart.AutoSize = true;
            this.sumCart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumCart.ForeColor = System.Drawing.Color.White;
            this.sumCart.Location = new System.Drawing.Point(141, 8);
            this.sumCart.Name = "sumCart";
            this.sumCart.Size = new System.Drawing.Size(24, 26);
            this.sumCart.TabIndex = 6;
            this.sumCart.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.button1.Location = new System.Drawing.Point(181, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Заказать";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // UCCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cartDGV);
            this.Controls.Add(this.panelSearch);
            this.Name = "UCCart";
            this.Size = new System.Drawing.Size(842, 570);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridView cartDGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sumCart;
        private System.Windows.Forms.Label sumLabel;
    }
}
