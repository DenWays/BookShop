namespace BookShopBD
{
    partial class UCHistory
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
            this.sumPanel = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.booksDGV = new System.Windows.Forms.DataGridView();
            this.sumCart = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.sumPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // sumPanel
            // 
            this.sumPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.sumPanel.Controls.Add(this.sumCart);
            this.sumPanel.Controls.Add(this.sumLabel);
            this.sumPanel.Controls.Add(this.refreshButton);
            this.sumPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sumPanel.Location = new System.Drawing.Point(0, 0);
            this.sumPanel.Name = "sumPanel";
            this.sumPanel.Size = new System.Drawing.Size(842, 40);
            this.sumPanel.TabIndex = 0;
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
            // 
            // booksDGV
            // 
            this.booksDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDGV.Location = new System.Drawing.Point(6, 46);
            this.booksDGV.Name = "booksDGV";
            this.booksDGV.Size = new System.Drawing.Size(830, 518);
            this.booksDGV.TabIndex = 1;
            // 
            // sumCart
            // 
            this.sumCart.AutoSize = true;
            this.sumCart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumCart.ForeColor = System.Drawing.Color.White;
            this.sumCart.Location = new System.Drawing.Point(141, 8);
            this.sumCart.Name = "sumCart";
            this.sumCart.Size = new System.Drawing.Size(24, 26);
            this.sumCart.TabIndex = 8;
            this.sumCart.Text = "0";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumLabel.ForeColor = System.Drawing.Color.White;
            this.sumLabel.Location = new System.Drawing.Point(3, 8);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(142, 26);
            this.sumLabel.TabIndex = 7;
            this.sumLabel.Text = "Общая сумма:";
            // 
            // UCHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.booksDGV);
            this.Controls.Add(this.sumPanel);
            this.Name = "UCHistory";
            this.Size = new System.Drawing.Size(842, 570);
            this.sumPanel.ResumeLayout(false);
            this.sumPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sumPanel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridView booksDGV;
        private System.Windows.Forms.Label sumCart;
        private System.Windows.Forms.Label sumLabel;
    }
}
