namespace BookShopBD
{
    partial class FormAddToCart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTools = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizedButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.choiseEmpLabel = new System.Windows.Forms.Label();
            this.choiseEmpCB = new System.Windows.Forms.ComboBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.choiseAmountTB = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.border = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.panelTools.Controls.Add(this.closeButton);
            this.panelTools.Controls.Add(this.minimizedButton);
            this.panelTools.Controls.Add(this.nameLabel);
            this.panelTools.Controls.Add(this.icon);
            this.panelTools.Location = new System.Drawing.Point(0, 0);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(400, 30);
            this.panelTools.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(73)))), ((int)(((byte)(42)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(317, -8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(36, 39);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "×";
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // minimizedButton
            // 
            this.minimizedButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.minimizedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimizedButton.ForeColor = System.Drawing.Color.White;
            this.minimizedButton.Location = new System.Drawing.Point(284, -5);
            this.minimizedButton.Name = "minimizedButton";
            this.minimizedButton.Size = new System.Drawing.Size(36, 38);
            this.minimizedButton.TabIndex = 3;
            this.minimizedButton.Text = "—";
            this.minimizedButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizedButton.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(41, 7);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(67, 18);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "BookShop";
            // 
            // icon
            // 
            this.icon.Image = global::BookShopBD.Properties.Resources.bookWhite;
            this.icon.Location = new System.Drawing.Point(3, 0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(32, 30);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            // 
            // choiseEmpLabel
            // 
            this.choiseEmpLabel.AutoSize = true;
            this.choiseEmpLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choiseEmpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.choiseEmpLabel.Location = new System.Drawing.Point(12, 42);
            this.choiseEmpLabel.Name = "choiseEmpLabel";
            this.choiseEmpLabel.Size = new System.Drawing.Size(192, 26);
            this.choiseEmpLabel.TabIndex = 3;
            this.choiseEmpLabel.Text = "Выберите продавца";
            // 
            // choiseEmpCB
            // 
            this.choiseEmpCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choiseEmpCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choiseEmpCB.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choiseEmpCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.choiseEmpCB.FormattingEnabled = true;
            this.choiseEmpCB.Location = new System.Drawing.Point(20, 72);
            this.choiseEmpCB.Name = "choiseEmpCB";
            this.choiseEmpCB.Size = new System.Drawing.Size(310, 34);
            this.choiseEmpCB.TabIndex = 4;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.amountLabel.Location = new System.Drawing.Point(12, 109);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(196, 26);
            this.amountLabel.TabIndex = 5;
            this.amountLabel.Text = "Введите количество";
            // 
            // choiseAmountTB
            // 
            this.choiseAmountTB.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choiseAmountTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.choiseAmountTB.Location = new System.Drawing.Point(17, 138);
            this.choiseAmountTB.Name = "choiseAmountTB";
            this.choiseAmountTB.Size = new System.Drawing.Size(187, 34);
            this.choiseAmountTB.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(220, 200);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 40);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.border.ForeColor = System.Drawing.SystemColors.ControlText;
            this.border.Location = new System.Drawing.Point(19, 71);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(312, 36);
            this.border.TabIndex = 9;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(20, 200);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(110, 40);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // FormAddToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.choiseAmountTB);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.choiseEmpCB);
            this.Controls.Add(this.choiseEmpLabel);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddToCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddToCart";
            this.Load += new System.EventHandler(this.FormAddToCart_Load);
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizedButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label choiseEmpLabel;
        private System.Windows.Forms.ComboBox choiseEmpCB;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox choiseAmountTB;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.Button backButton;
    }
}