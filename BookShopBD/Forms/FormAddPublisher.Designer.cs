namespace BookShopBD.Forms
{
    partial class FormAddPublisher
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.PictureBox();
            this.panelChange = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.publisherTB = new System.Windows.Forms.TextBox();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.panelChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.panelTools.Controls.Add(this.nameLabel);
            this.panelTools.Controls.Add(this.closeButton);
            this.panelTools.Controls.Add(this.icon);
            this.panelTools.Location = new System.Drawing.Point(0, 0);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(250, 30);
            this.panelTools.TabIndex = 3;
            this.panelTools.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTools_MouseDown);
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
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(73)))), ((int)(((byte)(42)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(217, -8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(36, 39);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "×";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            // panelChange
            // 
            this.panelChange.BackColor = System.Drawing.Color.White;
            this.panelChange.Controls.Add(this.backButton);
            this.panelChange.Controls.Add(this.changeButton);
            this.panelChange.Controls.Add(this.publisherTB);
            this.panelChange.Controls.Add(this.publisherLabel);
            this.panelChange.Location = new System.Drawing.Point(0, 30);
            this.panelChange.Name = "panelChange";
            this.panelChange.Size = new System.Drawing.Size(250, 120);
            this.panelChange.TabIndex = 4;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(3, 77);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(110, 40);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.Location = new System.Drawing.Point(137, 77);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(110, 40);
            this.changeButton.TabIndex = 9;
            this.changeButton.Text = "Добавить";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // publisherTB
            // 
            this.publisherTB.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publisherTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.publisherTB.Location = new System.Drawing.Point(3, 32);
            this.publisherTB.Name = "publisherTB";
            this.publisherTB.Size = new System.Drawing.Size(244, 34);
            this.publisherTB.TabIndex = 1;
            this.publisherTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newAmountTB_KeyPress);
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publisherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.publisherLabel.Location = new System.Drawing.Point(-2, 3);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(213, 26);
            this.publisherLabel.TabIndex = 0;
            this.publisherLabel.Text = "Введите издательство";
            // 
            // FormAddPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.panelChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddPublisher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Shop";
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.panelChange.ResumeLayout(false);
            this.panelChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Panel panelChange;
        private System.Windows.Forms.TextBox publisherTB;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button backButton;
    }
}