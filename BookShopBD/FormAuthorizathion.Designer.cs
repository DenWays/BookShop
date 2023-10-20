namespace BookShopBD
{
    partial class FormAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            this.authorizationLabel = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.authorizationButton = new System.Windows.Forms.Button();
            this.panelAuthorization = new System.Windows.Forms.Panel();
            this.panelTools = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizedButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bookPB = new System.Windows.Forms.PictureBox();
            this.icon = new System.Windows.Forms.PictureBox();
            this.panelAuthorization.SuspendLayout();
            this.panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // authorizationLabel
            // 
            this.authorizationLabel.AutoSize = true;
            this.authorizationLabel.BackColor = System.Drawing.Color.Transparent;
            this.authorizationLabel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.authorizationLabel.Location = new System.Drawing.Point(107, 55);
            this.authorizationLabel.Name = "authorizationLabel";
            this.authorizationLabel.Size = new System.Drawing.Size(185, 38);
            this.authorizationLabel.TabIndex = 0;
            this.authorizationLabel.Text = "Авторизация";
            this.authorizationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginTB
            // 
            this.loginTB.BackColor = System.Drawing.Color.White;
            this.loginTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTB.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.loginTB.Location = new System.Drawing.Point(100, 142);
            this.loginTB.MaxLength = 15;
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(200, 45);
            this.loginTB.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.loginLabel.Location = new System.Drawing.Point(100, 110);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(76, 29);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логин";
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.White;
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTB.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTB.Location = new System.Drawing.Point(100, 228);
            this.passwordTB.MaxLength = 15;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(200, 45);
            this.passwordTB.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.passwordLabel.Location = new System.Drawing.Point(100, 196);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(90, 29);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Пароль";
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.createAccountLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createAccountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.createAccountLabel.Location = new System.Drawing.Point(101, 280);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(141, 23);
            this.createAccountLabel.TabIndex = 5;
            this.createAccountLabel.Text = "Создать аккаунт?";
            this.createAccountLabel.Click += new System.EventHandler(this.createAccountLabel_Click);
            this.createAccountLabel.MouseEnter += new System.EventHandler(this.createAccountLabel_MouseEnter);
            this.createAccountLabel.MouseLeave += new System.EventHandler(this.createAccountLabel_MouseLeave);
            // 
            // authorizationButton
            // 
            this.authorizationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.authorizationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.authorizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorizationButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.authorizationButton.FlatAppearance.BorderSize = 0;
            this.authorizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorizationButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationButton.ForeColor = System.Drawing.Color.White;
            this.authorizationButton.Location = new System.Drawing.Point(100, 310);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.Size = new System.Drawing.Size(200, 45);
            this.authorizationButton.TabIndex = 6;
            this.authorizationButton.Text = "Авторизоваться";
            this.authorizationButton.UseVisualStyleBackColor = false;
            this.authorizationButton.Click += new System.EventHandler(this.authorizationButton_Click);
            // 
            // panelAuthorization
            // 
            this.panelAuthorization.BackColor = System.Drawing.Color.White;
            this.panelAuthorization.Controls.Add(this.button1);
            this.panelAuthorization.Controls.Add(this.bookPB);
            this.panelAuthorization.Controls.Add(this.authorizationButton);
            this.panelAuthorization.Controls.Add(this.createAccountLabel);
            this.panelAuthorization.Controls.Add(this.passwordLabel);
            this.panelAuthorization.Controls.Add(this.passwordTB);
            this.panelAuthorization.Controls.Add(this.loginLabel);
            this.panelAuthorization.Controls.Add(this.loginTB);
            this.panelAuthorization.Controls.Add(this.authorizationLabel);
            this.panelAuthorization.Location = new System.Drawing.Point(0, 30);
            this.panelAuthorization.Name = "panelAuthorization";
            this.panelAuthorization.Size = new System.Drawing.Size(400, 370);
            this.panelAuthorization.TabIndex = 0;
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
            this.closeButton.Location = new System.Drawing.Point(367, -8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(36, 39);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "×";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizedButton
            // 
            this.minimizedButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.minimizedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimizedButton.ForeColor = System.Drawing.Color.White;
            this.minimizedButton.Location = new System.Drawing.Point(334, -5);
            this.minimizedButton.Name = "minimizedButton";
            this.minimizedButton.Size = new System.Drawing.Size(36, 38);
            this.minimizedButton.TabIndex = 3;
            this.minimizedButton.Text = "—";
            this.minimizedButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizedButton.UseVisualStyleBackColor = true;
            this.minimizedButton.Click += new System.EventHandler(this.minimizedButton_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookPB
            // 
            this.bookPB.BackColor = System.Drawing.Color.Transparent;
            this.bookPB.Image = global::BookShopBD.Properties.Resources.bookGray;
            this.bookPB.Location = new System.Drawing.Point(160, 14);
            this.bookPB.Name = "bookPB";
            this.bookPB.Size = new System.Drawing.Size(80, 50);
            this.bookPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookPB.TabIndex = 7;
            this.bookPB.TabStop = false;
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
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.panelAuthorization);
            this.Controls.Add(this.panelTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Shop";
            this.panelAuthorization.ResumeLayout(false);
            this.panelAuthorization.PerformLayout();
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label authorizationLabel;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label createAccountLabel;
        private System.Windows.Forms.Button authorizationButton;
        private System.Windows.Forms.PictureBox bookPB;
        private System.Windows.Forms.Panel panelAuthorization;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Button minimizedButton;
        private System.Windows.Forms.Button button1;
    }
}

