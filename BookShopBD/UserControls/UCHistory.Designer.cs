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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sumPanel = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelNotSuccess = new System.Windows.Forms.Panel();
            this.sumNSuccessLabel = new System.Windows.Forms.Label();
            this.orderNSuccesLabel = new System.Windows.Forms.Label();
            this.amountNSuccessLabel = new System.Windows.Forms.Label();
            this.nSuccesLabel = new System.Windows.Forms.Label();
            this.nSuccessDGV = new System.Windows.Forms.DataGridView();
            this.panelSuccess = new System.Windows.Forms.Panel();
            this.sumSuccessLabel = new System.Windows.Forms.Label();
            this.orderSuccesLabel = new System.Windows.Forms.Label();
            this.amountSuccessLabel = new System.Windows.Forms.Label();
            this.successLabel = new System.Windows.Forms.Label();
            this.successDGV = new System.Windows.Forms.DataGridView();
            this.sumPanel.SuspendLayout();
            this.tablePanel.SuspendLayout();
            this.panelNotSuccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSuccessDGV)).BeginInit();
            this.panelSuccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.successDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // sumPanel
            // 
            this.sumPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
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
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // tablePanel
            // 
            this.tablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.tablePanel.ColumnCount = 2;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel.Controls.Add(this.panelNotSuccess, 0, 0);
            this.tablePanel.Controls.Add(this.panelSuccess, 1, 0);
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tablePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.tablePanel.Location = new System.Drawing.Point(0, 40);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 1;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 529F));
            this.tablePanel.Size = new System.Drawing.Size(842, 530);
            this.tablePanel.TabIndex = 1;
            // 
            // panelNotSuccess
            // 
            this.panelNotSuccess.BackColor = System.Drawing.Color.White;
            this.panelNotSuccess.Controls.Add(this.sumNSuccessLabel);
            this.panelNotSuccess.Controls.Add(this.orderNSuccesLabel);
            this.panelNotSuccess.Controls.Add(this.amountNSuccessLabel);
            this.panelNotSuccess.Controls.Add(this.nSuccesLabel);
            this.panelNotSuccess.Controls.Add(this.nSuccessDGV);
            this.panelNotSuccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNotSuccess.Location = new System.Drawing.Point(3, 3);
            this.panelNotSuccess.Name = "panelNotSuccess";
            this.panelNotSuccess.Size = new System.Drawing.Size(415, 524);
            this.panelNotSuccess.TabIndex = 0;
            // 
            // sumNSuccessLabel
            // 
            this.sumNSuccessLabel.AutoSize = true;
            this.sumNSuccessLabel.Location = new System.Drawing.Point(188, 26);
            this.sumNSuccessLabel.Name = "sumNSuccessLabel";
            this.sumNSuccessLabel.Size = new System.Drawing.Size(52, 26);
            this.sumNSuccessLabel.TabIndex = 7;
            this.sumNSuccessLabel.Text = "0.00";
            // 
            // orderNSuccesLabel
            // 
            this.orderNSuccesLabel.AutoSize = true;
            this.orderNSuccesLabel.Location = new System.Drawing.Point(19, 26);
            this.orderNSuccesLabel.Name = "orderNSuccesLabel";
            this.orderNSuccesLabel.Size = new System.Drawing.Size(175, 26);
            this.orderNSuccesLabel.TabIndex = 6;
            this.orderNSuccesLabel.Text = "заказов на сумму:";
            // 
            // amountNSuccessLabel
            // 
            this.amountNSuccessLabel.AutoSize = true;
            this.amountNSuccessLabel.Location = new System.Drawing.Point(0, 26);
            this.amountNSuccessLabel.Name = "amountNSuccessLabel";
            this.amountNSuccessLabel.Size = new System.Drawing.Size(24, 26);
            this.amountNSuccessLabel.TabIndex = 5;
            this.amountNSuccessLabel.Text = "0";
            // 
            // nSuccesLabel
            // 
            this.nSuccesLabel.AutoSize = true;
            this.nSuccesLabel.Location = new System.Drawing.Point(0, 0);
            this.nSuccesLabel.Name = "nSuccesLabel";
            this.nSuccesLabel.Size = new System.Drawing.Size(245, 26);
            this.nSuccesLabel.TabIndex = 4;
            this.nSuccesLabel.Text = "Ожидают подтверждения";
            // 
            // nSuccessDGV
            // 
            this.nSuccessDGV.AllowUserToAddRows = false;
            this.nSuccessDGV.AllowUserToDeleteRows = false;
            this.nSuccessDGV.AllowUserToResizeColumns = false;
            this.nSuccessDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.nSuccessDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.nSuccessDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nSuccessDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nSuccessDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.nSuccessDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nSuccessDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.nSuccessDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nSuccessDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.nSuccessDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.nSuccessDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.nSuccessDGV.GridColor = System.Drawing.Color.White;
            this.nSuccessDGV.Location = new System.Drawing.Point(0, 55);
            this.nSuccessDGV.Name = "nSuccessDGV";
            this.nSuccessDGV.ReadOnly = true;
            this.nSuccessDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nSuccessDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.nSuccessDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nSuccessDGV.Size = new System.Drawing.Size(415, 469);
            this.nSuccessDGV.TabIndex = 3;
            // 
            // panelSuccess
            // 
            this.panelSuccess.BackColor = System.Drawing.Color.White;
            this.panelSuccess.Controls.Add(this.sumSuccessLabel);
            this.panelSuccess.Controls.Add(this.orderSuccesLabel);
            this.panelSuccess.Controls.Add(this.amountSuccessLabel);
            this.panelSuccess.Controls.Add(this.successLabel);
            this.panelSuccess.Controls.Add(this.successDGV);
            this.panelSuccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSuccess.Location = new System.Drawing.Point(424, 3);
            this.panelSuccess.Name = "panelSuccess";
            this.panelSuccess.Size = new System.Drawing.Size(415, 524);
            this.panelSuccess.TabIndex = 1;
            // 
            // sumSuccessLabel
            // 
            this.sumSuccessLabel.AutoSize = true;
            this.sumSuccessLabel.Location = new System.Drawing.Point(188, 26);
            this.sumSuccessLabel.Name = "sumSuccessLabel";
            this.sumSuccessLabel.Size = new System.Drawing.Size(52, 26);
            this.sumSuccessLabel.TabIndex = 8;
            this.sumSuccessLabel.Text = "0.00";
            // 
            // orderSuccesLabel
            // 
            this.orderSuccesLabel.AutoSize = true;
            this.orderSuccesLabel.Location = new System.Drawing.Point(19, 26);
            this.orderSuccesLabel.Name = "orderSuccesLabel";
            this.orderSuccesLabel.Size = new System.Drawing.Size(175, 26);
            this.orderSuccesLabel.TabIndex = 7;
            this.orderSuccesLabel.Text = "заказов на сумму:";
            // 
            // amountSuccessLabel
            // 
            this.amountSuccessLabel.AutoSize = true;
            this.amountSuccessLabel.Location = new System.Drawing.Point(0, 26);
            this.amountSuccessLabel.Name = "amountSuccessLabel";
            this.amountSuccessLabel.Size = new System.Drawing.Size(24, 26);
            this.amountSuccessLabel.TabIndex = 6;
            this.amountSuccessLabel.Text = "0";
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Location = new System.Drawing.Point(0, 0);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(146, 26);
            this.successLabel.TabIndex = 5;
            this.successLabel.Text = "Подтверждено";
            // 
            // successDGV
            // 
            this.successDGV.AllowUserToAddRows = false;
            this.successDGV.AllowUserToDeleteRows = false;
            this.successDGV.AllowUserToResizeColumns = false;
            this.successDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.successDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.successDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.successDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.successDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.successDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.successDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.successDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.successDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.successDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.successDGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.successDGV.GridColor = System.Drawing.Color.White;
            this.successDGV.Location = new System.Drawing.Point(0, 55);
            this.successDGV.Name = "successDGV";
            this.successDGV.ReadOnly = true;
            this.successDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.successDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.successDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.successDGV.Size = new System.Drawing.Size(415, 469);
            this.successDGV.TabIndex = 4;
            // 
            // UCHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.sumPanel);
            this.Name = "UCHistory";
            this.Size = new System.Drawing.Size(842, 570);
            this.Load += new System.EventHandler(this.UCHistory_Load);
            this.sumPanel.ResumeLayout(false);
            this.tablePanel.ResumeLayout(false);
            this.panelNotSuccess.ResumeLayout(false);
            this.panelNotSuccess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSuccessDGV)).EndInit();
            this.panelSuccess.ResumeLayout(false);
            this.panelSuccess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.successDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sumPanel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TableLayoutPanel tablePanel;
        private System.Windows.Forms.Panel panelNotSuccess;
        private System.Windows.Forms.Panel panelSuccess;
        public System.Windows.Forms.DataGridView nSuccessDGV;
        public System.Windows.Forms.DataGridView successDGV;
        private System.Windows.Forms.Label sumNSuccessLabel;
        private System.Windows.Forms.Label orderNSuccesLabel;
        private System.Windows.Forms.Label amountNSuccessLabel;
        private System.Windows.Forms.Label nSuccesLabel;
        private System.Windows.Forms.Label sumSuccessLabel;
        private System.Windows.Forms.Label orderSuccesLabel;
        private System.Windows.Forms.Label amountSuccessLabel;
        private System.Windows.Forms.Label successLabel;
    }
}
