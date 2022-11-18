namespace ShoppingOnline.Forms
{
    partial class _03_Form_Home
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
            this.PanelSidebar = new System.Windows.Forms.Panel();
            this.ButtonMyCart = new FontAwesome.Sharp.IconButton();
            this.ButtonHistory = new FontAwesome.Sharp.IconButton();
            this.PanelSubMenu2 = new System.Windows.Forms.Panel();
            this.ButtonChangePassword = new FontAwesome.Sharp.IconButton();
            this.ButtonCustomerRecord = new FontAwesome.Sharp.IconButton();
            this.ButtonLogout = new FontAwesome.Sharp.IconButton();
            this.ButtonMyAccount = new FontAwesome.Sharp.IconButton();
            this.PanelSubMenu1 = new System.Windows.Forms.Panel();
            this.ButtonShowShorts = new FontAwesome.Sharp.IconButton();
            this.ButtonShowPant = new FontAwesome.Sharp.IconButton();
            this.ButtonShowDressShirt = new FontAwesome.Sharp.IconButton();
            this.ButtonShowCoats = new FontAwesome.Sharp.IconButton();
            this.ButtonShowTShirt = new FontAwesome.Sharp.IconButton();
            this.ButtonShowAllProducts = new FontAwesome.Sharp.IconButton();
            this.ButtonProduct = new FontAwesome.Sharp.IconButton();
            this.PanelBrandLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.PictureBox_NotFoundProduct = new System.Windows.Forms.PictureBox();
            this.Label_NotFoundProduct = new System.Windows.Forms.Label();
            this.ButtonMinimizeForm = new FontAwesome.Sharp.IconButton();
            this.ButtonMaximumForm = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.ButtonSearchProduct = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelMyAccount = new System.Windows.Forms.Label();
            this.PictureBox_Image_Customer = new ShoppingOnline.CustomControls.CCirclePictureBox();
            this.ButtonCloseForm = new FontAwesome.Sharp.IconButton();
            this.PanelInformation = new System.Windows.Forms.Panel();
            this.Panel_Filter = new System.Windows.Forms.Panel();
            this.Button_ResetFilter = new FontAwesome.Sharp.IconButton();
            this.Label_Filter = new System.Windows.Forms.Label();
            this.Combobox_FilterMaterial = new System.Windows.Forms.ComboBox();
            this.Combobox_FilterPrice = new System.Windows.Forms.ComboBox();
            this.Combobox_FilterColor = new System.Windows.Forms.ComboBox();
            this.PanelSidebar.SuspendLayout();
            this.PanelSubMenu2.SuspendLayout();
            this.PanelSubMenu1.SuspendLayout();
            this.PanelBrandLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_NotFoundProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image_Customer)).BeginInit();
            this.PanelInformation.SuspendLayout();
            this.Panel_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSidebar
            // 
            this.PanelSidebar.BackColor = System.Drawing.Color.MidnightBlue;
            this.PanelSidebar.Controls.Add(this.ButtonMyCart);
            this.PanelSidebar.Controls.Add(this.ButtonHistory);
            this.PanelSidebar.Controls.Add(this.PanelSubMenu2);
            this.PanelSidebar.Controls.Add(this.ButtonLogout);
            this.PanelSidebar.Controls.Add(this.ButtonMyAccount);
            this.PanelSidebar.Controls.Add(this.PanelSubMenu1);
            this.PanelSidebar.Controls.Add(this.ButtonProduct);
            this.PanelSidebar.Controls.Add(this.PanelBrandLogo);
            this.PanelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSidebar.Location = new System.Drawing.Point(0, 0);
            this.PanelSidebar.Name = "PanelSidebar";
            this.PanelSidebar.Size = new System.Drawing.Size(297, 853);
            this.PanelSidebar.TabIndex = 0;
            // 
            // ButtonMyCart
            // 
            this.ButtonMyCart.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMyCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMyCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonMyCart.FlatAppearance.BorderSize = 0;
            this.ButtonMyCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMyCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonMyCart.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonMyCart.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.ButtonMyCart.IconColor = System.Drawing.Color.Yellow;
            this.ButtonMyCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonMyCart.IconSize = 32;
            this.ButtonMyCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonMyCart.Location = new System.Drawing.Point(0, 707);
            this.ButtonMyCart.Name = "ButtonMyCart";
            this.ButtonMyCart.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ButtonMyCart.Size = new System.Drawing.Size(297, 59);
            this.ButtonMyCart.TabIndex = 4;
            this.ButtonMyCart.Text = "Giỏ hàng của tôi";
            this.ButtonMyCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonMyCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonMyCart.UseVisualStyleBackColor = false;
            this.ButtonMyCart.Click += new System.EventHandler(this.ButtonMyCart_Click);
            this.ButtonMyCart.MouseEnter += new System.EventHandler(this.ButtonProduct_MouseEnter);
            this.ButtonMyCart.MouseLeave += new System.EventHandler(this.ButtonProduct_MouseLeave);
            // 
            // ButtonHistory
            // 
            this.ButtonHistory.BackColor = System.Drawing.Color.Transparent;
            this.ButtonHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonHistory.FlatAppearance.BorderSize = 0;
            this.ButtonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonHistory.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonHistory.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.ButtonHistory.IconColor = System.Drawing.Color.Yellow;
            this.ButtonHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonHistory.IconSize = 32;
            this.ButtonHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonHistory.Location = new System.Drawing.Point(0, 648);
            this.ButtonHistory.Name = "ButtonHistory";
            this.ButtonHistory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ButtonHistory.Size = new System.Drawing.Size(297, 59);
            this.ButtonHistory.TabIndex = 6;
            this.ButtonHistory.Text = "Đơn đã mua";
            this.ButtonHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonHistory.UseVisualStyleBackColor = false;
            this.ButtonHistory.Click += new System.EventHandler(this.ButtonHistory_Click);
            this.ButtonHistory.MouseEnter += new System.EventHandler(this.ButtonProduct_MouseEnter);
            this.ButtonHistory.MouseLeave += new System.EventHandler(this.ButtonProduct_MouseLeave);
            // 
            // PanelSubMenu2
            // 
            this.PanelSubMenu2.Controls.Add(this.ButtonChangePassword);
            this.PanelSubMenu2.Controls.Add(this.ButtonCustomerRecord);
            this.PanelSubMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenu2.Location = new System.Drawing.Point(0, 545);
            this.PanelSubMenu2.Name = "PanelSubMenu2";
            this.PanelSubMenu2.Size = new System.Drawing.Size(297, 103);
            this.PanelSubMenu2.TabIndex = 7;
            this.PanelSubMenu2.Visible = false;
            // 
            // ButtonChangePassword
            // 
            this.ButtonChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.ButtonChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonChangePassword.FlatAppearance.BorderSize = 0;
            this.ButtonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonChangePassword.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonChangePassword.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonChangePassword.IconColor = System.Drawing.Color.Yellow;
            this.ButtonChangePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonChangePassword.IconSize = 32;
            this.ButtonChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonChangePassword.Location = new System.Drawing.Point(0, 47);
            this.ButtonChangePassword.Name = "ButtonChangePassword";
            this.ButtonChangePassword.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ButtonChangePassword.Size = new System.Drawing.Size(297, 47);
            this.ButtonChangePassword.TabIndex = 3;
            this.ButtonChangePassword.Text = "Đổi mật khẩu";
            this.ButtonChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonChangePassword.UseVisualStyleBackColor = false;
            this.ButtonChangePassword.Click += new System.EventHandler(this.ButtonChangePassword_Click);
            this.ButtonChangePassword.MouseEnter += new System.EventHandler(this.ButtonProduct_MouseEnter);
            this.ButtonChangePassword.MouseLeave += new System.EventHandler(this.ButtonProduct_MouseLeave);
            // 
            // ButtonCustomerRecord
            // 
            this.ButtonCustomerRecord.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCustomerRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCustomerRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonCustomerRecord.FlatAppearance.BorderSize = 0;
            this.ButtonCustomerRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCustomerRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCustomerRecord.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonCustomerRecord.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonCustomerRecord.IconColor = System.Drawing.Color.Yellow;
            this.ButtonCustomerRecord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonCustomerRecord.IconSize = 32;
            this.ButtonCustomerRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCustomerRecord.Location = new System.Drawing.Point(0, 0);
            this.ButtonCustomerRecord.Name = "ButtonCustomerRecord";
            this.ButtonCustomerRecord.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ButtonCustomerRecord.Size = new System.Drawing.Size(297, 47);
            this.ButtonCustomerRecord.TabIndex = 2;
            this.ButtonCustomerRecord.Text = "Hồ sơ";
            this.ButtonCustomerRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCustomerRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonCustomerRecord.UseVisualStyleBackColor = false;
            this.ButtonCustomerRecord.Click += new System.EventHandler(this.ButtonCustomerRecord_Click);
            this.ButtonCustomerRecord.MouseEnter += new System.EventHandler(this.ButtonProduct_MouseEnter);
            this.ButtonCustomerRecord.MouseLeave += new System.EventHandler(this.ButtonProduct_MouseLeave);
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonLogout.FlatAppearance.BorderSize = 0;
            this.ButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonLogout.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.ButtonLogout.IconColor = System.Drawing.Color.Yellow;
            this.ButtonLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonLogout.IconSize = 32;
            this.ButtonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLogout.Location = new System.Drawing.Point(0, 794);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ButtonLogout.Size = new System.Drawing.Size(297, 59);
            this.ButtonLogout.TabIndex = 6;
            this.ButtonLogout.Text = "Đăng xuất";
            this.ButtonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonLogout.UseVisualStyleBackColor = false;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            this.ButtonLogout.MouseEnter += new System.EventHandler(this.ButtonProduct_MouseEnter);
            this.ButtonLogout.MouseLeave += new System.EventHandler(this.ButtonProduct_MouseLeave);
            // 
            // ButtonMyAccount
            // 
            this.ButtonMyAccount.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMyAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMyAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonMyAccount.FlatAppearance.BorderSize = 0;
            this.ButtonMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonMyAccount.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonMyAccount.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ButtonMyAccount.IconColor = System.Drawing.Color.Yellow;
            this.ButtonMyAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonMyAccount.IconSize = 32;
            this.ButtonMyAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonMyAccount.Location = new System.Drawing.Point(0, 486);
            this.ButtonMyAccount.Name = "ButtonMyAccount";
            this.ButtonMyAccount.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ButtonMyAccount.Size = new System.Drawing.Size(297, 59);
            this.ButtonMyAccount.TabIndex = 3;
            this.ButtonMyAccount.Text = "Tài khoản";
            this.ButtonMyAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonMyAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonMyAccount.UseVisualStyleBackColor = false;
            this.ButtonMyAccount.Click += new System.EventHandler(this.ButtonMyAccount_Click);
            this.ButtonMyAccount.MouseEnter += new System.EventHandler(this.ButtonProduct_MouseEnter);
            this.ButtonMyAccount.MouseLeave += new System.EventHandler(this.ButtonProduct_MouseLeave);
            // 
            // PanelSubMenu1
            // 
            this.PanelSubMenu1.Controls.Add(this.ButtonShowShorts);
            this.PanelSubMenu1.Controls.Add(this.ButtonShowPant);
            this.PanelSubMenu1.Controls.Add(this.ButtonShowDressShirt);
            this.PanelSubMenu1.Controls.Add(this.ButtonShowCoats);
            this.PanelSubMenu1.Controls.Add(this.ButtonShowTShirt);
            this.PanelSubMenu1.Controls.Add(this.ButtonShowAllProducts);
            this.PanelSubMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenu1.Location = new System.Drawing.Point(0, 191);
            this.PanelSubMenu1.Name = "PanelSubMenu1";
            this.PanelSubMenu1.Size = new System.Drawing.Size(297, 295);
            this.PanelSubMenu1.TabIndex = 2;
            this.PanelSubMenu1.Visible = false;
            // 
            // ButtonShowShorts
            // 
            this.ButtonShowShorts.BackColor = System.Drawing.Color.Transparent;
            this.ButtonShowShorts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShowShorts.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonShowShorts.FlatAppearance.BorderSize = 0;
            this.ButtonShowShorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowShorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonShowShorts.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonShowShorts.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonShowShorts.IconColor = System.Drawing.Color.Yellow;
            this.ButtonShowShorts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonShowShorts.IconSize = 32;
            this.ButtonShowShorts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShowShorts.Location = new System.Drawing.Point(0, 235);
            this.ButtonShowShorts.Name = "ButtonShowShorts";
            this.ButtonShowShorts.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ButtonShowShorts.Size = new System.Drawing.Size(297, 47);
            this.ButtonShowShorts.TabIndex = 7;
            this.ButtonShowShorts.Text = "Quần short";
            this.ButtonShowShorts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShowShorts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonShowShorts.UseVisualStyleBackColor = false;
            this.ButtonShowShorts.Click += new System.EventHandler(this.ButtonShowShorts_Click);
            this.ButtonShowShorts.MouseEnter += new System.EventHandler(this.ButtonProduct_MouseEnter);
            this.ButtonShowShorts.MouseLeave += new System.EventHandler(this.ButtonProduct_MouseLeave);
            // 
            // ButtonShowPant
            // 
            this.ButtonShowPant.BackColor = System.Drawing.Color.Transparent;
            this.ButtonShowPant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShowPant.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonShowPant.FlatAppearance.BorderSize = 0;
            this.ButtonShowPant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowPant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonShowPant.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonShowPant.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonShowPant.IconColor = System.Drawing.Color.Yellow;
            this.ButtonShowPant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonShowPant.IconSize = 32;
            this.ButtonShowPant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShowPant.Location = new System.Drawing.Point(0, 188);
            this.ButtonShowPant.Name = "ButtonShowPant";
            this.ButtonShowPant.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ButtonShowPant.Size = new System.Drawing.Size(297, 47);
            this.ButtonShowPant.TabIndex = 6;
            this.ButtonShowPant.Text = "Quần dài";
            this.ButtonShowPant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShowPant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonShowPant.UseVisualStyleBackColor = false;
            this.ButtonShowPant.Click += new System.EventHandler(this.ButtonShowPant_Click);
            this.ButtonShowPant.MouseEnter += new System.EventHandler(this.ButtonProduct_MouseEnter);
            this.ButtonShowPant.MouseLeave += new System.EventHandler(this.ButtonProduct_MouseLeave);
            // 
            // ButtonShowDressShirt
            // 
            this.ButtonShowDressShirt.BackColor = System.Drawing.Color.Transparent;
            this.ButtonShowDressShirt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShowDressShirt.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonShowDressShirt.FlatAppearance.BorderSize = 0;
            this.ButtonShowDressShirt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowDressShirt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonShowDressShirt.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonShowDressShirt.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonShowDressShirt.IconColor = System.Drawing.Color.Yellow;
            this.ButtonShowDressShirt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonShowDressShirt.IconSize = 32;
            this.ButtonShowDressShirt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShowDressShirt.Location = new System.Drawing.Point(0, 141);
            this.ButtonShowDressShirt.Name = "ButtonShowDressShirt";
            this.ButtonShowDressShirt.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ButtonShowDressShirt.Size = new System.Drawing.Size(297, 47);
            this.ButtonShowDressShirt.TabIndex = 5;
            this.ButtonShowDressShirt.Text = "Áo sơ mi";
            this.ButtonShowDressShirt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShowDressShirt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonShowDressShirt.UseVisualStyleBackColor = false;
            this.ButtonShowDressShirt.Click += new System.EventHandler(this.ButtonShowDressShirt_Click);
            this.ButtonShowDressShirt.MouseEnter += new System.EventHandler(this.ButtonProduct_MouseEnter);
            this.ButtonShowDressShirt.MouseLeave += new System.EventHandler(this.ButtonProduct_MouseLeave);
            // 
            // ButtonShowCoats
            // 
            this.ButtonShowCoats.BackColor = System.Drawing.Color.Transparent;
            this.ButtonShowCoats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShowCoats.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonShowCoats.FlatAppearance.BorderSize = 0;
            this.ButtonShowCoats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowCoats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonShowCoats.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonShowCoats.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonShowCoats.IconColor = System.Drawing.Color.Yellow;
            this.ButtonShowCoats.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonShowCoats.IconSize = 32;
            this.ButtonShowCoats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShowCoats.Location = new System.Drawing.Point(0, 94);
            this.ButtonShowCoats.Name = "ButtonShowCoats";
            this.ButtonShowCoats.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ButtonShowCoats.Size = new System.Drawing.Size(297, 47);
            this.ButtonShowCoats.TabIndex = 4;
            this.ButtonShowCoats.Text = "Áo khoác";
            this.ButtonShowCoats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShowCoats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonShowCoats.UseVisualStyleBackColor = false;
            this.ButtonShowCoats.Click += new System.EventHandler(this.ButtonShowCoats_Click);
            this.ButtonShowCoats.MouseEnter += new System.EventHandler(this.ButtonProduct_MouseEnter);
            this.ButtonShowCoats.MouseLeave += new System.EventHandler(this.ButtonProduct_MouseLeave);
            // 
            // ButtonShowTShirt
            // 
            this.ButtonShowTShirt.BackColor = System.Drawing.Color.Transparent;
            this.ButtonShowTShirt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShowTShirt.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonShowTShirt.FlatAppearance.BorderSize = 0;
            this.ButtonShowTShirt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowTShirt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonShowTShirt.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonShowTShirt.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonShowTShirt.IconColor = System.Drawing.Color.Yellow;
            this.ButtonShowTShirt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonShowTShirt.IconSize = 32;
            this.ButtonShowTShirt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShowTShirt.Location = new System.Drawing.Point(0, 47);
            this.ButtonShowTShirt.Name = "ButtonShowTShirt";
            this.ButtonShowTShirt.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ButtonShowTShirt.Size = new System.Drawing.Size(297, 47);
            this.ButtonShowTShirt.TabIndex = 3;
            this.ButtonShowTShirt.Text = "Áo thun";
            this.ButtonShowTShirt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShowTShirt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonShowTShirt.UseVisualStyleBackColor = false;
            this.ButtonShowTShirt.Click += new System.EventHandler(this.ButtonShowTShirt_Click);
            this.ButtonShowTShirt.MouseEnter += new System.EventHandler(this.ButtonProduct_MouseEnter);
            this.ButtonShowTShirt.MouseLeave += new System.EventHandler(this.ButtonProduct_MouseLeave);
            // 
            // ButtonShowAllProducts
            // 
            this.ButtonShowAllProducts.BackColor = System.Drawing.Color.Transparent;
            this.ButtonShowAllProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShowAllProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonShowAllProducts.FlatAppearance.BorderSize = 0;
            this.ButtonShowAllProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowAllProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonShowAllProducts.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonShowAllProducts.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonShowAllProducts.IconColor = System.Drawing.Color.Yellow;
            this.ButtonShowAllProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonShowAllProducts.IconSize = 32;
            this.ButtonShowAllProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShowAllProducts.Location = new System.Drawing.Point(0, 0);
            this.ButtonShowAllProducts.Name = "ButtonShowAllProducts";
            this.ButtonShowAllProducts.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ButtonShowAllProducts.Size = new System.Drawing.Size(297, 47);
            this.ButtonShowAllProducts.TabIndex = 2;
            this.ButtonShowAllProducts.Text = "Tất cả sản phẩm";
            this.ButtonShowAllProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShowAllProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonShowAllProducts.UseVisualStyleBackColor = false;
            this.ButtonShowAllProducts.Click += new System.EventHandler(this.ButtonShowAllProducts_Click);
            this.ButtonShowAllProducts.MouseEnter += new System.EventHandler(this.ButtonProduct_MouseEnter);
            this.ButtonShowAllProducts.MouseLeave += new System.EventHandler(this.ButtonProduct_MouseLeave);
            // 
            // ButtonProduct
            // 
            this.ButtonProduct.BackColor = System.Drawing.Color.Transparent;
            this.ButtonProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonProduct.FlatAppearance.BorderSize = 0;
            this.ButtonProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonProduct.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonProduct.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.ButtonProduct.IconColor = System.Drawing.Color.Yellow;
            this.ButtonProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonProduct.IconSize = 32;
            this.ButtonProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonProduct.Location = new System.Drawing.Point(0, 132);
            this.ButtonProduct.Name = "ButtonProduct";
            this.ButtonProduct.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ButtonProduct.Size = new System.Drawing.Size(297, 59);
            this.ButtonProduct.TabIndex = 1;
            this.ButtonProduct.Text = "Sản phẩm";
            this.ButtonProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonProduct.UseVisualStyleBackColor = false;
            this.ButtonProduct.Click += new System.EventHandler(this.ButtonProduct_Click);
            this.ButtonProduct.MouseEnter += new System.EventHandler(this.ButtonProduct_MouseEnter);
            this.ButtonProduct.MouseLeave += new System.EventHandler(this.ButtonProduct_MouseLeave);
            // 
            // PanelBrandLogo
            // 
            this.PanelBrandLogo.BackColor = System.Drawing.Color.Transparent;
            this.PanelBrandLogo.Controls.Add(this.pictureBox1);
            this.PanelBrandLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBrandLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelBrandLogo.Name = "PanelBrandLogo";
            this.PanelBrandLogo.Size = new System.Drawing.Size(297, 132);
            this.PanelBrandLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShoppingOnline.CreateResources.Image_Logo.Logo_Low_Resolution_04;
            this.pictureBox1.Location = new System.Drawing.Point(20, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.PictureBox_NotFoundProduct);
            this.PanelContent.Controls.Add(this.Label_NotFoundProduct);
            this.PanelContent.Location = new System.Drawing.Point(297, 132);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1285, 721);
            this.PanelContent.TabIndex = 2;
            // 
            // PictureBox_NotFoundProduct
            // 
            this.PictureBox_NotFoundProduct.Image = global::ShoppingOnline.CreateResources.Image_Logo.Not_found_product;
            this.PictureBox_NotFoundProduct.Location = new System.Drawing.Point(381, 106);
            this.PictureBox_NotFoundProduct.Name = "PictureBox_NotFoundProduct";
            this.PictureBox_NotFoundProduct.Size = new System.Drawing.Size(501, 332);
            this.PictureBox_NotFoundProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_NotFoundProduct.TabIndex = 0;
            this.PictureBox_NotFoundProduct.TabStop = false;
            this.PictureBox_NotFoundProduct.Visible = false;
            // 
            // Label_NotFoundProduct
            // 
            this.Label_NotFoundProduct.AutoSize = true;
            this.Label_NotFoundProduct.BackColor = System.Drawing.Color.Transparent;
            this.Label_NotFoundProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_NotFoundProduct.ForeColor = System.Drawing.Color.Gray;
            this.Label_NotFoundProduct.Location = new System.Drawing.Point(381, 450);
            this.Label_NotFoundProduct.Name = "Label_NotFoundProduct";
            this.Label_NotFoundProduct.Size = new System.Drawing.Size(501, 32);
            this.Label_NotFoundProduct.TabIndex = 1;
            this.Label_NotFoundProduct.Text = "Không tìm thấy sản phẩm tương ứng";
            this.Label_NotFoundProduct.Visible = false;
            // 
            // ButtonMinimizeForm
            // 
            this.ButtonMinimizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMinimizeForm.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMinimizeForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMinimizeForm.FlatAppearance.BorderSize = 0;
            this.ButtonMinimizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimizeForm.ForeColor = System.Drawing.Color.White;
            this.ButtonMinimizeForm.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.ButtonMinimizeForm.IconColor = System.Drawing.Color.White;
            this.ButtonMinimizeForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonMinimizeForm.IconSize = 24;
            this.ButtonMinimizeForm.Location = new System.Drawing.Point(1154, 0);
            this.ButtonMinimizeForm.Name = "ButtonMinimizeForm";
            this.ButtonMinimizeForm.Size = new System.Drawing.Size(45, 45);
            this.ButtonMinimizeForm.TabIndex = 1;
            this.ButtonMinimizeForm.UseVisualStyleBackColor = false;
            this.ButtonMinimizeForm.Click += new System.EventHandler(this.ButtonMinimizeForm_Click);
            // 
            // ButtonMaximumForm
            // 
            this.ButtonMaximumForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMaximumForm.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMaximumForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMaximumForm.FlatAppearance.BorderSize = 0;
            this.ButtonMaximumForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMaximumForm.ForeColor = System.Drawing.Color.White;
            this.ButtonMaximumForm.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.ButtonMaximumForm.IconColor = System.Drawing.Color.White;
            this.ButtonMaximumForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonMaximumForm.IconSize = 24;
            this.ButtonMaximumForm.Location = new System.Drawing.Point(1197, 0);
            this.ButtonMaximumForm.Name = "ButtonMaximumForm";
            this.ButtonMaximumForm.Size = new System.Drawing.Size(45, 45);
            this.ButtonMaximumForm.TabIndex = 2;
            this.ButtonMaximumForm.UseVisualStyleBackColor = false;
            this.ButtonMaximumForm.Click += new System.EventHandler(this.ButtonMaximumForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TextBoxSearchProduct);
            this.panel1.Location = new System.Drawing.Point(44, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 40);
            this.panel1.TabIndex = 0;
            // 
            // TextBoxSearchProduct
            // 
            this.TextBoxSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxSearchProduct.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxSearchProduct.Location = new System.Drawing.Point(11, 8);
            this.TextBoxSearchProduct.MinimumSize = new System.Drawing.Size(0, 25);
            this.TextBoxSearchProduct.Name = "TextBoxSearchProduct";
            this.TextBoxSearchProduct.Size = new System.Drawing.Size(547, 25);
            this.TextBoxSearchProduct.TabIndex = 0;
            this.TextBoxSearchProduct.Text = "Tìm kiếm sản phẩm trong shop";
            this.TextBoxSearchProduct.Enter += new System.EventHandler(this.TextBoxSearchProduct_Enter);
            this.TextBoxSearchProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearchProduct_KeyPress);
            this.TextBoxSearchProduct.Leave += new System.EventHandler(this.TextBoxSearchProduct_Leave);
            // 
            // ButtonSearchProduct
            // 
            this.ButtonSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ButtonSearchProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSearchProduct.FlatAppearance.BorderSize = 0;
            this.ButtonSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSearchProduct.ForeColor = System.Drawing.Color.White;
            this.ButtonSearchProduct.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ButtonSearchProduct.IconColor = System.Drawing.Color.White;
            this.ButtonSearchProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSearchProduct.IconSize = 24;
            this.ButtonSearchProduct.Location = new System.Drawing.Point(608, 62);
            this.ButtonSearchProduct.Name = "ButtonSearchProduct";
            this.ButtonSearchProduct.Size = new System.Drawing.Size(133, 40);
            this.ButtonSearchProduct.TabIndex = 4;
            this.ButtonSearchProduct.Text = "Tìm kiếm";
            this.ButtonSearchProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearchProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSearchProduct.UseVisualStyleBackColor = false;
            this.ButtonSearchProduct.Click += new System.EventHandler(this.ButtonSearchProduct_Click);
            this.ButtonSearchProduct.MouseEnter += new System.EventHandler(this.ButtonSearchProduct_MouseEnter);
            this.ButtonSearchProduct.MouseLeave += new System.EventHandler(this.ButtonSearchProduct_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LabelMyAccount);
            this.panel2.Controls.Add(this.PictureBox_Image_Customer);
            this.panel2.Location = new System.Drawing.Point(44, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 36);
            this.panel2.TabIndex = 5;
            // 
            // LabelMyAccount
            // 
            this.LabelMyAccount.AutoSize = true;
            this.LabelMyAccount.BackColor = System.Drawing.Color.Transparent;
            this.LabelMyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelMyAccount.ForeColor = System.Drawing.Color.White;
            this.LabelMyAccount.Location = new System.Drawing.Point(39, 7);
            this.LabelMyAccount.Name = "LabelMyAccount";
            this.LabelMyAccount.Size = new System.Drawing.Size(153, 22);
            this.LabelMyAccount.TabIndex = 6;
            this.LabelMyAccount.Text = "tuankiet15092002";
            // 
            // PictureBox_Image_Customer
            // 
            this.PictureBox_Image_Customer.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.PictureBox_Image_Customer.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PictureBox_Image_Customer.BorderColor2 = System.Drawing.Color.HotPink;
            this.PictureBox_Image_Customer.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.PictureBox_Image_Customer.BorderSize = 2;
            this.PictureBox_Image_Customer.GradientAngle = 50F;
            this.PictureBox_Image_Customer.Image = global::ShoppingOnline.CreateResources.Images_Customer.KH01;
            this.PictureBox_Image_Customer.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_Image_Customer.Name = "PictureBox_Image_Customer";
            this.PictureBox_Image_Customer.Size = new System.Drawing.Size(35, 35);
            this.PictureBox_Image_Customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Image_Customer.TabIndex = 0;
            this.PictureBox_Image_Customer.TabStop = false;
            // 
            // ButtonCloseForm
            // 
            this.ButtonCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCloseForm.FlatAppearance.BorderSize = 0;
            this.ButtonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCloseForm.ForeColor = System.Drawing.Color.White;
            this.ButtonCloseForm.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ButtonCloseForm.IconColor = System.Drawing.Color.White;
            this.ButtonCloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonCloseForm.IconSize = 24;
            this.ButtonCloseForm.Location = new System.Drawing.Point(1240, 0);
            this.ButtonCloseForm.Name = "ButtonCloseForm";
            this.ButtonCloseForm.Size = new System.Drawing.Size(45, 45);
            this.ButtonCloseForm.TabIndex = 6;
            this.ButtonCloseForm.UseVisualStyleBackColor = false;
            this.ButtonCloseForm.Click += new System.EventHandler(this.ButtonCloseForm_Click);
            this.ButtonCloseForm.MouseEnter += new System.EventHandler(this.ButtonCloseForm_MouseEnter);
            this.ButtonCloseForm.MouseLeave += new System.EventHandler(this.ButtonCloseForm_MouseLeave);
            // 
            // PanelInformation
            // 
            this.PanelInformation.BackColor = System.Drawing.Color.MidnightBlue;
            this.PanelInformation.Controls.Add(this.Panel_Filter);
            this.PanelInformation.Controls.Add(this.ButtonCloseForm);
            this.PanelInformation.Controls.Add(this.panel2);
            this.PanelInformation.Controls.Add(this.ButtonSearchProduct);
            this.PanelInformation.Controls.Add(this.panel1);
            this.PanelInformation.Controls.Add(this.ButtonMaximumForm);
            this.PanelInformation.Controls.Add(this.ButtonMinimizeForm);
            this.PanelInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelInformation.Location = new System.Drawing.Point(297, 0);
            this.PanelInformation.Name = "PanelInformation";
            this.PanelInformation.Size = new System.Drawing.Size(1285, 132);
            this.PanelInformation.TabIndex = 1;
            // 
            // Panel_Filter
            // 
            this.Panel_Filter.Controls.Add(this.Button_ResetFilter);
            this.Panel_Filter.Controls.Add(this.Label_Filter);
            this.Panel_Filter.Controls.Add(this.Combobox_FilterMaterial);
            this.Panel_Filter.Controls.Add(this.Combobox_FilterPrice);
            this.Panel_Filter.Controls.Add(this.Combobox_FilterColor);
            this.Panel_Filter.Location = new System.Drawing.Point(777, 43);
            this.Panel_Filter.Name = "Panel_Filter";
            this.Panel_Filter.Size = new System.Drawing.Size(496, 75);
            this.Panel_Filter.TabIndex = 7;
            // 
            // Button_ResetFilter
            // 
            this.Button_ResetFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ResetFilter.FlatAppearance.BorderSize = 0;
            this.Button_ResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ResetFilter.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBack;
            this.Button_ResetFilter.IconColor = System.Drawing.Color.White;
            this.Button_ResetFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_ResetFilter.IconSize = 20;
            this.Button_ResetFilter.Location = new System.Drawing.Point(57, 11);
            this.Button_ResetFilter.Name = "Button_ResetFilter";
            this.Button_ResetFilter.Size = new System.Drawing.Size(20, 20);
            this.Button_ResetFilter.TabIndex = 16;
            this.Button_ResetFilter.UseVisualStyleBackColor = true;
            this.Button_ResetFilter.Click += new System.EventHandler(this.Button_ResetFilter_Click);
            // 
            // Label_Filter
            // 
            this.Label_Filter.AutoSize = true;
            this.Label_Filter.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Label_Filter.ForeColor = System.Drawing.Color.White;
            this.Label_Filter.Location = new System.Drawing.Point(-1, 9);
            this.Label_Filter.Name = "Label_Filter";
            this.Label_Filter.Size = new System.Drawing.Size(52, 20);
            this.Label_Filter.TabIndex = 15;
            this.Label_Filter.Text = "Bộ lọc";
            // 
            // Combobox_FilterMaterial
            // 
            this.Combobox_FilterMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Combobox_FilterMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Combobox_FilterMaterial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Combobox_FilterMaterial.ForeColor = System.Drawing.Color.Gray;
            this.Combobox_FilterMaterial.FormattingEnabled = true;
            this.Combobox_FilterMaterial.Items.AddRange(new object[] {
            "Chất liệu",
            "Cotton",
            "Polyester",
            "Spandex"});
            this.Combobox_FilterMaterial.Location = new System.Drawing.Point(345, 37);
            this.Combobox_FilterMaterial.Name = "Combobox_FilterMaterial";
            this.Combobox_FilterMaterial.Size = new System.Drawing.Size(141, 28);
            this.Combobox_FilterMaterial.TabIndex = 14;
            this.Combobox_FilterMaterial.Text = "Chất liệu";
            this.Combobox_FilterMaterial.SelectedIndexChanged += new System.EventHandler(this.Combobox_FilterMaterial_SelectedIndexChanged);
            // 
            // Combobox_FilterPrice
            // 
            this.Combobox_FilterPrice.BackColor = System.Drawing.Color.White;
            this.Combobox_FilterPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Combobox_FilterPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Combobox_FilterPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Combobox_FilterPrice.ForeColor = System.Drawing.Color.Gray;
            this.Combobox_FilterPrice.FormattingEnabled = true;
            this.Combobox_FilterPrice.Items.AddRange(new object[] {
            "Giá",
            "0 - 200000",
            "200000 - 400000",
            "400000 - 600000",
            "600000 - 800000",
            "800000 - 1000000"});
            this.Combobox_FilterPrice.Location = new System.Drawing.Point(140, 37);
            this.Combobox_FilterPrice.Name = "Combobox_FilterPrice";
            this.Combobox_FilterPrice.Size = new System.Drawing.Size(179, 28);
            this.Combobox_FilterPrice.TabIndex = 13;
            this.Combobox_FilterPrice.Text = "Giá";
            this.Combobox_FilterPrice.SelectedIndexChanged += new System.EventHandler(this.Combobox_FilterPrice_SelectedIndexChanged);
            // 
            // Combobox_FilterColor
            // 
            this.Combobox_FilterColor.BackColor = System.Drawing.Color.White;
            this.Combobox_FilterColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Combobox_FilterColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Combobox_FilterColor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Combobox_FilterColor.ForeColor = System.Drawing.Color.Gray;
            this.Combobox_FilterColor.FormattingEnabled = true;
            this.Combobox_FilterColor.Items.AddRange(new object[] {
            "Màu",
            "Đen",
            "Trắng",
            "Nâu",
            "Xám",
            "Xanh",
            "Hồng",
            "Vàng"});
            this.Combobox_FilterColor.Location = new System.Drawing.Point(4, 37);
            this.Combobox_FilterColor.Name = "Combobox_FilterColor";
            this.Combobox_FilterColor.Size = new System.Drawing.Size(107, 28);
            this.Combobox_FilterColor.TabIndex = 12;
            this.Combobox_FilterColor.Text = "Màu";
            this.Combobox_FilterColor.SelectedIndexChanged += new System.EventHandler(this.Combobox_FilterColor_SelectedIndexChanged);
            // 
            // _03_Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.PanelInformation);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelSidebar);
            this.Name = "_03_Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_03_Form_Home";
            this.Load += new System.EventHandler(this._03_Form_Home_Load);
            this.PanelSidebar.ResumeLayout(false);
            this.PanelSubMenu2.ResumeLayout(false);
            this.PanelSubMenu1.ResumeLayout(false);
            this.PanelBrandLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelContent.ResumeLayout(false);
            this.PanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_NotFoundProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image_Customer)).EndInit();
            this.PanelInformation.ResumeLayout(false);
            this.Panel_Filter.ResumeLayout(false);
            this.Panel_Filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelSidebar;
        private Panel PanelBrandLogo;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton ButtonProduct;
        private Panel PanelSubMenu1;
        private FontAwesome.Sharp.IconButton ButtonShowAllProducts;
        private FontAwesome.Sharp.IconButton ButtonMyAccount;
        private FontAwesome.Sharp.IconButton ButtonShowCoats;
        private FontAwesome.Sharp.IconButton ButtonShowTShirt;
        private FontAwesome.Sharp.IconButton ButtonMyCart;
        private FontAwesome.Sharp.IconButton ButtonShowShorts;
        private FontAwesome.Sharp.IconButton ButtonShowPant;
        private FontAwesome.Sharp.IconButton ButtonShowDressShirt;
        private Panel PanelContent;
        private FontAwesome.Sharp.IconButton ButtonLogout;
        private Panel PanelSubMenu2;
        private FontAwesome.Sharp.IconButton ButtonChangePassword;
        private FontAwesome.Sharp.IconButton ButtonCustomerRecord;
        private FontAwesome.Sharp.IconButton ButtonHistory;
        private Label Label_NotFoundProduct;
        private PictureBox PictureBox_NotFoundProduct;
        private FontAwesome.Sharp.IconButton ButtonMinimizeForm;
        private FontAwesome.Sharp.IconButton ButtonMaximumForm;
        private Panel panel1;
        private TextBox TextBoxSearchProduct;
        private FontAwesome.Sharp.IconButton ButtonSearchProduct;
        private Panel panel2;
        private Label LabelMyAccount;
        private CustomControls.CCirclePictureBox PictureBox_Image_Customer;
        private FontAwesome.Sharp.IconButton ButtonCloseForm;
        private Panel PanelInformation;
        private Panel Panel_Filter;
        private FontAwesome.Sharp.IconButton Button_ResetFilter;
        private Label Label_Filter;
        private ComboBox Combobox_FilterMaterial;
        private ComboBox Combobox_FilterPrice;
        private ComboBox Combobox_FilterColor;
    }
}