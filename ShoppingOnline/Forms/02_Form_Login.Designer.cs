namespace ShoppingOnline.Forms
{
    partial class _02_Form_Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelLogin = new ShoppingOnline.CustomControls.CPanelGradient();
            this.LabelErrorLogin = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextBoxAccount = new System.Windows.Forms.TextBox();
            this.ButtonExitApplication = new System.Windows.Forms.Button();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.LabelForgotPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelAccount = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelLogin.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 676);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ShoppingOnline.CreateResources.Images_Brand.Brand_14;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 676);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelLogin
            // 
            this.PanelLogin.Angle = 0F;
            this.PanelLogin.BottomColor = System.Drawing.Color.Empty;
            this.PanelLogin.Controls.Add(this.LabelErrorLogin);
            this.PanelLogin.Controls.Add(this.panel4);
            this.PanelLogin.Controls.Add(this.panel3);
            this.PanelLogin.Controls.Add(this.ButtonExitApplication);
            this.PanelLogin.Controls.Add(this.ButtonLogin);
            this.PanelLogin.Controls.Add(this.LabelForgotPassword);
            this.PanelLogin.Controls.Add(this.label1);
            this.PanelLogin.Controls.Add(this.LabelAccount);
            this.PanelLogin.Controls.Add(this.LabelLogin);
            this.PanelLogin.Controls.Add(this.panel2);
            this.PanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLogin.Location = new System.Drawing.Point(594, 0);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(623, 676);
            this.PanelLogin.TabIndex = 1;
            this.PanelLogin.TopColor = System.Drawing.Color.Empty;
            // 
            // LabelErrorLogin
            // 
            this.LabelErrorLogin.AutoSize = true;
            this.LabelErrorLogin.BackColor = System.Drawing.Color.Transparent;
            this.LabelErrorLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LabelErrorLogin.ForeColor = System.Drawing.Color.Maroon;
            this.LabelErrorLogin.Location = new System.Drawing.Point(238, 416);
            this.LabelErrorLogin.Name = "LabelErrorLogin";
            this.LabelErrorLogin.Size = new System.Drawing.Size(306, 23);
            this.LabelErrorLogin.TabIndex = 18;
            this.LabelErrorLogin.Text = "Vui lòng kiểm tra lại thông tin tài khoản";
            this.LabelErrorLogin.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.TextBoxPassword);
            this.panel4.Location = new System.Drawing.Point(95, 356);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(449, 57);
            this.panel4.TabIndex = 17;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.White;
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPassword.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxPassword.Location = new System.Drawing.Point(19, 15);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(414, 23);
            this.TextBoxPassword.TabIndex = 15;
            this.TextBoxPassword.Text = "Mật khẩu";
            this.TextBoxPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
            this.TextBoxPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TextBoxAccount);
            this.panel3.Location = new System.Drawing.Point(95, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 57);
            this.panel3.TabIndex = 16;
            // 
            // TextBoxAccount
            // 
            this.TextBoxAccount.BackColor = System.Drawing.Color.White;
            this.TextBoxAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxAccount.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxAccount.Location = new System.Drawing.Point(19, 14);
            this.TextBoxAccount.Name = "TextBoxAccount";
            this.TextBoxAccount.Size = new System.Drawing.Size(414, 23);
            this.TextBoxAccount.TabIndex = 14;
            this.TextBoxAccount.Text = "Tài khoản";
            this.TextBoxAccount.Enter += new System.EventHandler(this.TextBoxAccount_Enter);
            this.TextBoxAccount.Leave += new System.EventHandler(this.TextBoxAccount_Leave);
            // 
            // ButtonExitApplication
            // 
            this.ButtonExitApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonExitApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExitApplication.FlatAppearance.BorderSize = 0;
            this.ButtonExitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonExitApplication.ForeColor = System.Drawing.Color.White;
            this.ButtonExitApplication.Location = new System.Drawing.Point(310, 551);
            this.ButtonExitApplication.Name = "ButtonExitApplication";
            this.ButtonExitApplication.Size = new System.Drawing.Size(234, 55);
            this.ButtonExitApplication.TabIndex = 13;
            this.ButtonExitApplication.Text = "Exit";
            this.ButtonExitApplication.UseVisualStyleBackColor = false;
            this.ButtonExitApplication.Click += new System.EventHandler(this.ButtonExitApplication_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.MidnightBlue;
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(95, 467);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(449, 55);
            this.ButtonLogin.TabIndex = 12;
            this.ButtonLogin.Text = "Sign-in";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            this.ButtonLogin.MouseEnter += new System.EventHandler(this.ButtonLogin_MouseEnter);
            this.ButtonLogin.MouseLeave += new System.EventHandler(this.ButtonLogin_MouseLeave);
            // 
            // LabelForgotPassword
            // 
            this.LabelForgotPassword.AutoSize = true;
            this.LabelForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.LabelForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelForgotPassword.ForeColor = System.Drawing.Color.White;
            this.LabelForgotPassword.Location = new System.Drawing.Point(95, 551);
            this.LabelForgotPassword.Name = "LabelForgotPassword";
            this.LabelForgotPassword.Size = new System.Drawing.Size(159, 25);
            this.LabelForgotPassword.TabIndex = 11;
            this.LabelForgotPassword.Text = "Forgot Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password";
            // 
            // LabelAccount
            // 
            this.LabelAccount.AutoSize = true;
            this.LabelAccount.BackColor = System.Drawing.Color.Transparent;
            this.LabelAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabelAccount.ForeColor = System.Drawing.Color.White;
            this.LabelAccount.Location = new System.Drawing.Point(95, 231);
            this.LabelAccount.Name = "LabelAccount";
            this.LabelAccount.Size = new System.Drawing.Size(77, 20);
            this.LabelAccount.TabIndex = 6;
            this.LabelAccount.Text = "Account";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.BackColor = System.Drawing.Color.Transparent;
            this.LabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLogin.ForeColor = System.Drawing.Color.White;
            this.LabelLogin.Location = new System.Drawing.Point(83, 152);
            this.LabelLogin.Margin = new System.Windows.Forms.Padding(0);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(123, 46);
            this.LabelLogin.TabIndex = 3;
            this.LabelLogin.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 125);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ShoppingOnline.CreateResources.Image_Logo.Logo_Low_Resolution_04;
            this.pictureBox2.Location = new System.Drawing.Point(95, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(449, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // _02_Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 676);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_02_Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_02_Form_Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private CustomControls.CPanelGradient PanelLogin;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label LabelLogin;
        private Label LabelAccount;
        private Label label1;
        private Label LabelForgotPassword;
        private Button ButtonExitApplication;
        private Button ButtonLogin;
        private TextBox TextBoxPassword;
        private TextBox TextBoxAccount;
        private Panel panel4;
        private Panel panel3;
        private Label LabelErrorLogin;
    }
}