namespace BookShopBD
{
    partial class FormCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateAccount));
            this.panelCA = new System.Windows.Forms.Panel();
            this.panelTools = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizedButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.retypePassTB = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.retypePassLabel = new System.Windows.Forms.Label();
            this.lastNLabel = new System.Windows.Forms.Label();
            this.lastNTB = new System.Windows.Forms.TextBox();
            this.firstNLabel = new System.Windows.Forms.Label();
            this.firstNTB = new System.Windows.Forms.TextBox();
            this.middleNLabel = new System.Windows.Forms.Label();
            this.middleNTB = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.typeAcLabel = new System.Windows.Forms.Label();
            this.mailTB = new System.Windows.Forms.TextBox();
            this.createAcButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.typeAcCB = new System.Windows.Forms.ComboBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.bookPB = new System.Windows.Forms.PictureBox();
            this.createAcLabel = new System.Windows.Forms.Label();
            this.panelCA.SuspendLayout();
            this.panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookPB)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCA
            // 
            this.panelCA.BackColor = System.Drawing.Color.White;
            this.panelCA.Controls.Add(this.bookPB);
            this.panelCA.Controls.Add(this.createAcLabel);
            this.panelCA.Controls.Add(this.mailLabel);
            this.panelCA.Controls.Add(this.typeAcCB);
            this.panelCA.Controls.Add(this.cancelButton);
            this.panelCA.Controls.Add(this.createAcButton);
            this.panelCA.Controls.Add(this.typeAcLabel);
            this.panelCA.Controls.Add(this.mailTB);
            this.panelCA.Controls.Add(this.phoneLabel);
            this.panelCA.Controls.Add(this.phoneTB);
            this.panelCA.Controls.Add(this.addressLabel);
            this.panelCA.Controls.Add(this.addressTB);
            this.panelCA.Controls.Add(this.middleNLabel);
            this.panelCA.Controls.Add(this.middleNTB);
            this.panelCA.Controls.Add(this.firstNLabel);
            this.panelCA.Controls.Add(this.firstNTB);
            this.panelCA.Controls.Add(this.lastNLabel);
            this.panelCA.Controls.Add(this.lastNTB);
            this.panelCA.Controls.Add(this.retypePassLabel);
            this.panelCA.Controls.Add(this.passwordLabel);
            this.panelCA.Controls.Add(this.loginLabel);
            this.panelCA.Controls.Add(this.retypePassTB);
            this.panelCA.Controls.Add(this.passwordTB);
            this.panelCA.Controls.Add(this.loginTB);
            this.panelCA.Location = new System.Drawing.Point(0, 30);
            this.panelCA.Name = "panelCA";
            this.panelCA.Size = new System.Drawing.Size(600, 370);
            this.panelCA.TabIndex = 0;
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
            this.panelTools.Size = new System.Drawing.Size(600, 30);
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
            this.closeButton.Location = new System.Drawing.Point(567, -8);
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
            this.minimizedButton.Location = new System.Drawing.Point(536, -5);
            this.minimizedButton.Name = "minimizedButton";
            this.minimizedButton.Size = new System.Drawing.Size(34, 38);
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
            // loginTB
            // 
            this.loginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.loginTB.Location = new System.Drawing.Point(10, 115);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(180, 26);
            this.loginTB.TabIndex = 0;
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.passwordTB.Location = new System.Drawing.Point(210, 115);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(180, 26);
            this.passwordTB.TabIndex = 1;
            // 
            // retypePassTB
            // 
            this.retypePassTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.retypePassTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.retypePassTB.Location = new System.Drawing.Point(410, 115);
            this.retypePassTB.Name = "retypePassTB";
            this.retypePassTB.Size = new System.Drawing.Size(180, 26);
            this.retypePassTB.TabIndex = 2;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.loginLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginLabel.Location = new System.Drawing.Point(10, 89);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(58, 23);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.passwordLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordLabel.Location = new System.Drawing.Point(210, 89);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 23);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Пароль";
            // 
            // retypePassLabel
            // 
            this.retypePassLabel.AutoSize = true;
            this.retypePassLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.retypePassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.retypePassLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.retypePassLabel.Location = new System.Drawing.Point(410, 89);
            this.retypePassLabel.Name = "retypePassLabel";
            this.retypePassLabel.Size = new System.Drawing.Size(153, 23);
            this.retypePassLabel.TabIndex = 5;
            this.retypePassLabel.Text = "Повторите пароль";
            // 
            // lastNLabel
            // 
            this.lastNLabel.AutoSize = true;
            this.lastNLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.lastNLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lastNLabel.Location = new System.Drawing.Point(10, 159);
            this.lastNLabel.Name = "lastNLabel";
            this.lastNLabel.Size = new System.Drawing.Size(78, 23);
            this.lastNLabel.TabIndex = 7;
            this.lastNLabel.Text = "Фамилия";
            // 
            // lastNTB
            // 
            this.lastNTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.lastNTB.Location = new System.Drawing.Point(10, 185);
            this.lastNTB.Name = "lastNTB";
            this.lastNTB.Size = new System.Drawing.Size(180, 26);
            this.lastNTB.TabIndex = 6;
            // 
            // firstNLabel
            // 
            this.firstNLabel.AutoSize = true;
            this.firstNLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.firstNLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.firstNLabel.Location = new System.Drawing.Point(210, 159);
            this.firstNLabel.Name = "firstNLabel";
            this.firstNLabel.Size = new System.Drawing.Size(42, 23);
            this.firstNLabel.TabIndex = 9;
            this.firstNLabel.Text = "Имя";
            // 
            // firstNTB
            // 
            this.firstNTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.firstNTB.Location = new System.Drawing.Point(210, 185);
            this.firstNTB.Name = "firstNTB";
            this.firstNTB.Size = new System.Drawing.Size(180, 26);
            this.firstNTB.TabIndex = 8;
            // 
            // middleNLabel
            // 
            this.middleNLabel.AutoSize = true;
            this.middleNLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleNLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.middleNLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.middleNLabel.Location = new System.Drawing.Point(410, 159);
            this.middleNLabel.Name = "middleNLabel";
            this.middleNLabel.Size = new System.Drawing.Size(81, 23);
            this.middleNLabel.TabIndex = 11;
            this.middleNLabel.Text = "Отчество";
            // 
            // middleNTB
            // 
            this.middleNTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleNTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.middleNTB.Location = new System.Drawing.Point(410, 185);
            this.middleNTB.Name = "middleNTB";
            this.middleNTB.Size = new System.Drawing.Size(180, 26);
            this.middleNTB.TabIndex = 10;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.addressLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addressLabel.Location = new System.Drawing.Point(10, 229);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(56, 23);
            this.addressLabel.TabIndex = 13;
            this.addressLabel.Text = "Адрес";
            // 
            // addressTB
            // 
            this.addressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.addressTB.Location = new System.Drawing.Point(10, 255);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(180, 26);
            this.addressTB.TabIndex = 12;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.phoneLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phoneLabel.Location = new System.Drawing.Point(210, 229);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(78, 23);
            this.phoneLabel.TabIndex = 15;
            this.phoneLabel.Text = "Телефон";
            // 
            // phoneTB
            // 
            this.phoneTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.phoneTB.Location = new System.Drawing.Point(210, 255);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(180, 26);
            this.phoneTB.TabIndex = 14;
            // 
            // typeAcLabel
            // 
            this.typeAcLabel.AutoSize = true;
            this.typeAcLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeAcLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.typeAcLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.typeAcLabel.Location = new System.Drawing.Point(210, 299);
            this.typeAcLabel.Name = "typeAcLabel";
            this.typeAcLabel.Size = new System.Drawing.Size(112, 23);
            this.typeAcLabel.TabIndex = 17;
            this.typeAcLabel.Text = "Тип аккаунта";
            // 
            // mailTB
            // 
            this.mailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.mailTB.Location = new System.Drawing.Point(410, 255);
            this.mailTB.Name = "mailTB";
            this.mailTB.Size = new System.Drawing.Size(180, 26);
            this.mailTB.TabIndex = 16;
            // 
            // createAcButton
            // 
            this.createAcButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.createAcButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.createAcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAcButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createAcButton.ForeColor = System.Drawing.Color.White;
            this.createAcButton.Location = new System.Drawing.Point(490, 318);
            this.createAcButton.Name = "createAcButton";
            this.createAcButton.Size = new System.Drawing.Size(100, 40);
            this.createAcButton.TabIndex = 18;
            this.createAcButton.Text = "Создать";
            this.createAcButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(10, 318);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 40);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // typeAcCB
            // 
            this.typeAcCB.BackColor = System.Drawing.Color.White;
            this.typeAcCB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeAcCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.typeAcCB.FormattingEnabled = true;
            this.typeAcCB.Items.AddRange(new object[] {
            "Покупатель",
            "Продавец"});
            this.typeAcCB.Location = new System.Drawing.Point(210, 325);
            this.typeAcCB.Name = "typeAcCB";
            this.typeAcCB.Size = new System.Drawing.Size(180, 31);
            this.typeAcCB.TabIndex = 20;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.mailLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mailLabel.Location = new System.Drawing.Point(410, 229);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(59, 23);
            this.mailLabel.TabIndex = 21;
            this.mailLabel.Text = "Почта";
            // 
            // bookPB
            // 
            this.bookPB.BackColor = System.Drawing.Color.Transparent;
            this.bookPB.Image = global::BookShopBD.Properties.Resources.bookGray;
            this.bookPB.Location = new System.Drawing.Point(260, 6);
            this.bookPB.Name = "bookPB";
            this.bookPB.Size = new System.Drawing.Size(80, 50);
            this.bookPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookPB.TabIndex = 23;
            this.bookPB.TabStop = false;
            // 
            // createAcLabel
            // 
            this.createAcLabel.AutoSize = true;
            this.createAcLabel.BackColor = System.Drawing.Color.Transparent;
            this.createAcLabel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createAcLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.createAcLabel.Location = new System.Drawing.Point(172, 47);
            this.createAcLabel.Name = "createAcLabel";
            this.createAcLabel.Size = new System.Drawing.Size(256, 38);
            this.createAcLabel.TabIndex = 22;
            this.createAcLabel.Text = "Создание аккаунта";
            this.createAcLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.panelCA);
            this.Controls.Add(this.panelTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Shop";
            this.panelCA.ResumeLayout(false);
            this.panelCA.PerformLayout();
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCA;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Button minimizedButton;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label middleNLabel;
        private System.Windows.Forms.TextBox middleNTB;
        private System.Windows.Forms.Label firstNLabel;
        private System.Windows.Forms.TextBox firstNTB;
        private System.Windows.Forms.Label lastNLabel;
        private System.Windows.Forms.TextBox lastNTB;
        private System.Windows.Forms.Label retypePassLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox retypePassTB;
        private System.Windows.Forms.Button createAcButton;
        private System.Windows.Forms.Label typeAcLabel;
        private System.Windows.Forms.TextBox mailTB;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.ComboBox typeAcCB;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.PictureBox bookPB;
        private System.Windows.Forms.Label createAcLabel;
    }
}

