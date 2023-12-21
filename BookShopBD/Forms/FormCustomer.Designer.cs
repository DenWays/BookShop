namespace BookShopBD
{
    partial class FormCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.panelTools = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.maximazeButton = new System.Windows.Forms.Button();
            this.minimizedButton = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelInfoUser = new System.Windows.Forms.Panel();
            this.lastNLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.firstNLabel = new System.Windows.Forms.Label();
            this.middleNLabel = new System.Windows.Forms.Label();
            this.border = new System.Windows.Forms.Panel();
            this.tabPanel = new System.Windows.Forms.Panel();
            this.panelChoise = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.catalog = new System.Windows.Forms.Button();
            this.cart = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelInfoUser.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.panelTools.Controls.Add(this.closeButton);
            this.panelTools.Controls.Add(this.nameLabel);
            this.panelTools.Controls.Add(this.icon);
            this.panelTools.Controls.Add(this.maximazeButton);
            this.panelTools.Controls.Add(this.minimizedButton);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTools.Location = new System.Drawing.Point(0, 0);
            this.panelTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(1333, 37);
            this.panelTools.TabIndex = 2;
            this.panelTools.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTools_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(73)))), ((int)(((byte)(42)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(1289, -10);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(48, 49);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "×";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(55, 9);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 24);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "BookShop";
            // 
            // icon
            // 
            this.icon.Image = global::BookShopBD.Properties.Resources.bookWhite;
            this.icon.Location = new System.Drawing.Point(4, 0);
            this.icon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(43, 37);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            // 
            // maximazeButton
            // 
            this.maximazeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximazeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.maximazeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximazeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maximazeButton.ForeColor = System.Drawing.Color.White;
            this.maximazeButton.Location = new System.Drawing.Point(1247, -10);
            this.maximazeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maximazeButton.Name = "maximazeButton";
            this.maximazeButton.Size = new System.Drawing.Size(48, 48);
            this.maximazeButton.TabIndex = 4;
            this.maximazeButton.Text = "⛶";
            this.maximazeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.maximazeButton.UseVisualStyleBackColor = true;
            this.maximazeButton.Click += new System.EventHandler(this.maximazeButton_Click);
            // 
            // minimizedButton
            // 
            this.minimizedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizedButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.minimizedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimizedButton.ForeColor = System.Drawing.Color.White;
            this.minimizedButton.Location = new System.Drawing.Point(1204, -5);
            this.minimizedButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minimizedButton.Name = "minimizedButton";
            this.minimizedButton.Size = new System.Drawing.Size(48, 46);
            this.minimizedButton.TabIndex = 3;
            this.minimizedButton.Text = "—";
            this.minimizedButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizedButton.UseVisualStyleBackColor = true;
            this.minimizedButton.Click += new System.EventHandler(this.minimizedButton_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.panelMenu.Controls.Add(this.panelInfoUser);
            this.panelMenu.Controls.Add(this.border);
            this.panelMenu.Controls.Add(this.tabPanel);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 37);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(211, 701);
            this.panelMenu.TabIndex = 3;
            // 
            // panelInfoUser
            // 
            this.panelInfoUser.Controls.Add(this.lastNLabel);
            this.panelInfoUser.Controls.Add(this.roleLabel);
            this.panelInfoUser.Controls.Add(this.firstNLabel);
            this.panelInfoUser.Controls.Add(this.middleNLabel);
            this.panelInfoUser.Location = new System.Drawing.Point(0, 0);
            this.panelInfoUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInfoUser.Name = "panelInfoUser";
            this.panelInfoUser.Size = new System.Drawing.Size(211, 130);
            this.panelInfoUser.TabIndex = 8;
            // 
            // lastNLabel
            // 
            this.lastNLabel.AutoSize = true;
            this.lastNLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNLabel.ForeColor = System.Drawing.Color.White;
            this.lastNLabel.Location = new System.Drawing.Point(0, 0);
            this.lastNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNLabel.Name = "lastNLabel";
            this.lastNLabel.Size = new System.Drawing.Size(118, 33);
            this.lastNLabel.TabIndex = 4;
            this.lastNLabel.Text = "Фамилия";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleLabel.ForeColor = System.Drawing.Color.White;
            this.roleLabel.Location = new System.Drawing.Point(0, 96);
            this.roleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(70, 33);
            this.roleLabel.TabIndex = 7;
            this.roleLabel.Text = "Роль";
            // 
            // firstNLabel
            // 
            this.firstNLabel.AutoSize = true;
            this.firstNLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNLabel.ForeColor = System.Drawing.Color.White;
            this.firstNLabel.Location = new System.Drawing.Point(0, 32);
            this.firstNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNLabel.Name = "firstNLabel";
            this.firstNLabel.Size = new System.Drawing.Size(63, 33);
            this.firstNLabel.TabIndex = 5;
            this.firstNLabel.Text = "Имя";
            // 
            // middleNLabel
            // 
            this.middleNLabel.AutoSize = true;
            this.middleNLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleNLabel.ForeColor = System.Drawing.Color.White;
            this.middleNLabel.Location = new System.Drawing.Point(0, 64);
            this.middleNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.middleNLabel.Name = "middleNLabel";
            this.middleNLabel.Size = new System.Drawing.Size(120, 33);
            this.middleNLabel.TabIndex = 6;
            this.middleNLabel.Text = "Отчество";
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.White;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(211, 138);
            this.border.TabIndex = 10;
            // 
            // tabPanel
            // 
            this.tabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPanel.Controls.Add(this.panelChoise);
            this.tabPanel.Controls.Add(this.exitButton);
            this.tabPanel.Controls.Add(this.history);
            this.tabPanel.Controls.Add(this.catalog);
            this.tabPanel.Controls.Add(this.cart);
            this.tabPanel.Location = new System.Drawing.Point(0, 143);
            this.tabPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(211, 558);
            this.tabPanel.TabIndex = 11;
            // 
            // panelChoise
            // 
            this.panelChoise.BackColor = System.Drawing.Color.White;
            this.panelChoise.Location = new System.Drawing.Point(0, 5);
            this.panelChoise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChoise.Name = "panelChoise";
            this.panelChoise.Size = new System.Drawing.Size(8, 62);
            this.panelChoise.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.exitButton.Location = new System.Drawing.Point(5, 491);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 62);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // history
            // 
            this.history.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.history.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.history.ForeColor = System.Drawing.Color.White;
            this.history.Image = global::BookShopBD.Properties.Resources.historyBtn;
            this.history.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.history.Location = new System.Drawing.Point(8, 128);
            this.history.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(204, 62);
            this.history.TabIndex = 9;
            this.history.Text = "Заказы";
            this.history.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.history.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // catalog
            // 
            this.catalog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.catalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catalog.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catalog.ForeColor = System.Drawing.Color.White;
            this.catalog.Image = global::BookShopBD.Properties.Resources.catalogBtn;
            this.catalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.catalog.Location = new System.Drawing.Point(8, 5);
            this.catalog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.catalog.Name = "catalog";
            this.catalog.Size = new System.Drawing.Size(204, 62);
            this.catalog.TabIndex = 0;
            this.catalog.Text = "Каталог";
            this.catalog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.catalog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.catalog.UseVisualStyleBackColor = true;
            this.catalog.Click += new System.EventHandler(this.catalog_Click);
            // 
            // cart
            // 
            this.cart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cart.ForeColor = System.Drawing.Color.White;
            this.cart.Image = global::BookShopBD.Properties.Resources.cartBtn;
            this.cart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cart.Location = new System.Drawing.Point(8, 66);
            this.cart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(204, 62);
            this.cart.TabIndex = 2;
            this.cart.Text = "Корзина";
            this.cart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cart.UseVisualStyleBackColor = true;
            this.cart.Click += new System.EventHandler(this.cart_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(211, 37);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1122, 701);
            this.panelInfo.TabIndex = 4;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 738);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1333, 738);
            this.Name = "FormCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCustomer_FormClosed);
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelInfoUser.ResumeLayout(false);
            this.panelInfoUser.PerformLayout();
            this.tabPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizedButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Button maximazeButton;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button catalog;
        private System.Windows.Forms.Panel panelChoise;
        private System.Windows.Forms.Button cart;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label middleNLabel;
        private System.Windows.Forms.Label firstNLabel;
        private System.Windows.Forms.Label lastNLabel;
        private System.Windows.Forms.Panel panelInfoUser;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.Panel tabPanel;
        private System.Windows.Forms.Button exitButton;
        public System.Windows.Forms.Panel panelInfo;
    }
}