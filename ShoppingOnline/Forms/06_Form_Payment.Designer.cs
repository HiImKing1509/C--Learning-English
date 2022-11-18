namespace ShoppingOnline.Forms
{
    partial class _06_Form_Payment
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
            this.Panel_Payment = new System.Windows.Forms.Panel();
            this.Button_Payment = new FontAwesome.Sharp.IconButton();
            this.Panel_PaymentError = new System.Windows.Forms.Panel();
            this.Panel_PaymentSuccess = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_SumPrice = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Label_NumberOfProducts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_Product = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Combobox_ShipForms = new System.Windows.Forms.ComboBox();
            this.Button_ChangeInformation = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.TextBox_Address = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TextBox_Phone = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Panel_Payment.SuspendLayout();
            this.Panel_PaymentError.SuspendLayout();
            this.Panel_PaymentSuccess.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Payment
            // 
            this.Panel_Payment.Controls.Add(this.Button_Payment);
            this.Panel_Payment.Controls.Add(this.Panel_PaymentError);
            this.Panel_Payment.Controls.Add(this.label4);
            this.Panel_Payment.Controls.Add(this.Label_SumPrice);
            this.Panel_Payment.Controls.Add(this.panel5);
            this.Panel_Payment.Controls.Add(this.Label_NumberOfProducts);
            this.Panel_Payment.Controls.Add(this.label3);
            this.Panel_Payment.Controls.Add(this.label2);
            this.Panel_Payment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Payment.Location = new System.Drawing.Point(0, 553);
            this.Panel_Payment.Name = "Panel_Payment";
            this.Panel_Payment.Size = new System.Drawing.Size(1282, 150);
            this.Panel_Payment.TabIndex = 0;
            // 
            // Button_Payment
            // 
            this.Button_Payment.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Payment.FlatAppearance.BorderSize = 0;
            this.Button_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Payment.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.Button_Payment.IconColor = System.Drawing.Color.Black;
            this.Button_Payment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Payment.IconSize = 32;
            this.Button_Payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Payment.Location = new System.Drawing.Point(1014, 62);
            this.Button_Payment.Name = "Button_Payment";
            this.Button_Payment.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_Payment.Size = new System.Drawing.Size(206, 64);
            this.Button_Payment.TabIndex = 51;
            this.Button_Payment.Text = "Thanh toán";
            this.Button_Payment.UseVisualStyleBackColor = false;
            this.Button_Payment.Click += new System.EventHandler(this.Button_Payment_Click);
            this.Button_Payment.MouseEnter += new System.EventHandler(this.Button_Payment_MouseEnter);
            this.Button_Payment.MouseLeave += new System.EventHandler(this.Button_Payment_MouseLeave);
            // 
            // Panel_PaymentError
            // 
            this.Panel_PaymentError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Panel_PaymentError.Controls.Add(this.Panel_PaymentSuccess);
            this.Panel_PaymentError.Controls.Add(this.label13);
            this.Panel_PaymentError.Controls.Add(this.iconButton2);
            this.Panel_PaymentError.Location = new System.Drawing.Point(62, 15);
            this.Panel_PaymentError.Name = "Panel_PaymentError";
            this.Panel_PaymentError.Size = new System.Drawing.Size(720, 122);
            this.Panel_PaymentError.TabIndex = 44;
            this.Panel_PaymentError.Visible = false;
            // 
            // Panel_PaymentSuccess
            // 
            this.Panel_PaymentSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Panel_PaymentSuccess.Controls.Add(this.label9);
            this.Panel_PaymentSuccess.Controls.Add(this.iconButton1);
            this.Panel_PaymentSuccess.Location = new System.Drawing.Point(0, 0);
            this.Panel_PaymentSuccess.Name = "Panel_PaymentSuccess";
            this.Panel_PaymentSuccess.Size = new System.Drawing.Size(720, 122);
            this.Panel_PaymentSuccess.TabIndex = 36;
            this.Panel_PaymentSuccess.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(154, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(319, 38);
            this.label9.TabIndex = 1;
            this.label9.Text = "Đặt hàng thành công";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 80;
            this.iconButton1.Location = new System.Drawing.Point(3, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(138, 116);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(154, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(414, 38);
            this.label13.TabIndex = 1;
            this.label13.Text = "Bạn chưa có sản phẩm nào";
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 80;
            this.iconButton2.Location = new System.Drawing.Point(3, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(138, 116);
            this.iconButton2.TabIndex = 0;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(818, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tổng thanh toán:";
            // 
            // Label_SumPrice
            // 
            this.Label_SumPrice.AutoSize = true;
            this.Label_SumPrice.BackColor = System.Drawing.Color.Transparent;
            this.Label_SumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_SumPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_SumPrice.Location = new System.Drawing.Point(818, 88);
            this.Label_SumPrice.Name = "Label_SumPrice";
            this.Label_SumPrice.Size = new System.Drawing.Size(134, 38);
            this.Label_SumPrice.TabIndex = 49;
            this.Label_SumPrice.Text = "123.456";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(68, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1152, 2);
            this.panel5.TabIndex = 48;
            // 
            // Label_NumberOfProducts
            // 
            this.Label_NumberOfProducts.AutoSize = true;
            this.Label_NumberOfProducts.BackColor = System.Drawing.Color.Transparent;
            this.Label_NumberOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_NumberOfProducts.ForeColor = System.Drawing.Color.Gray;
            this.Label_NumberOfProducts.Location = new System.Drawing.Point(249, 62);
            this.Label_NumberOfProducts.Name = "Label_NumberOfProducts";
            this.Label_NumberOfProducts.Size = new System.Drawing.Size(34, 25);
            this.Label_NumberOfProducts.TabIndex = 47;
            this.Label_NumberOfProducts.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(62, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Tổng số sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(62, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 45;
            this.label2.Text = "Thanh toán";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel_Product);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 553);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel_Product
            // 
            this.flowLayoutPanel_Product.AutoScroll = true;
            this.flowLayoutPanel_Product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanel_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Product.Location = new System.Drawing.Point(0, 97);
            this.flowLayoutPanel_Product.Name = "flowLayoutPanel_Product";
            this.flowLayoutPanel_Product.Size = new System.Drawing.Size(726, 456);
            this.flowLayoutPanel_Product.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 97);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thanh toán hóa đơn";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(726, 2);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.Combobox_ShipForms);
            this.panel4.Controls.Add(this.Button_ChangeInformation);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(726, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(556, 553);
            this.panel4.TabIndex = 2;
            // 
            // Combobox_ShipForms
            // 
            this.Combobox_ShipForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Combobox_ShipForms.ForeColor = System.Drawing.Color.Silver;
            this.Combobox_ShipForms.FormattingEnabled = true;
            this.Combobox_ShipForms.Items.AddRange(new object[] {
            "Phương thức thanh toán",
            "Thanh toán trực tiếp",
            "Thanh toán online"});
            this.Combobox_ShipForms.Location = new System.Drawing.Point(45, 483);
            this.Combobox_ShipForms.Name = "Combobox_ShipForms";
            this.Combobox_ShipForms.Size = new System.Drawing.Size(449, 33);
            this.Combobox_ShipForms.TabIndex = 21;
            this.Combobox_ShipForms.Text = "Hình thức thanh toán";
            this.Combobox_ShipForms.SelectedIndexChanged += new System.EventHandler(this.Combobox_ShipForms_SelectedIndexChanged);
            // 
            // Button_ChangeInformation
            // 
            this.Button_ChangeInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ChangeInformation.FlatAppearance.BorderSize = 0;
            this.Button_ChangeInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ChangeInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_ChangeInformation.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_ChangeInformation.IconColor = System.Drawing.Color.Black;
            this.Button_ChangeInformation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_ChangeInformation.IconSize = 32;
            this.Button_ChangeInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_ChangeInformation.Location = new System.Drawing.Point(339, 24);
            this.Button_ChangeInformation.Name = "Button_ChangeInformation";
            this.Button_ChangeInformation.Size = new System.Drawing.Size(155, 46);
            this.Button_ChangeInformation.TabIndex = 3;
            this.Button_ChangeInformation.Text = "Thay đổi";
            this.Button_ChangeInformation.UseVisualStyleBackColor = true;
            this.Button_ChangeInformation.Click += new System.EventHandler(this.Button_ChangeInformation_Click);
            this.Button_ChangeInformation.MouseEnter += new System.EventHandler(this.Button_Payment_MouseEnter);
            this.Button_ChangeInformation.MouseLeave += new System.EventHandler(this.Button_Payment_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(39, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 32);
            this.label8.TabIndex = 20;
            this.label8.Text = "Giao tới";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.TextBox_Address);
            this.panel8.Location = new System.Drawing.Point(45, 342);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(449, 105);
            this.panel8.TabIndex = 19;
            // 
            // TextBox_Address
            // 
            this.TextBox_Address.BackColor = System.Drawing.Color.White;
            this.TextBox_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Address.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Address.Location = new System.Drawing.Point(19, 14);
            this.TextBox_Address.Multiline = true;
            this.TextBox_Address.Name = "TextBox_Address";
            this.TextBox_Address.ReadOnly = true;
            this.TextBox_Address.Size = new System.Drawing.Size(414, 93);
            this.TextBox_Address.TabIndex = 14;
            this.TextBox_Address.Text = "Tổ 2, khối Hà Trung, Phường Cẩm Nam, thành Phố Hội An, tỉnh Quảng Nam";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.TextBox_Phone);
            this.panel7.Location = new System.Drawing.Point(45, 231);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(449, 57);
            this.panel7.TabIndex = 18;
            // 
            // TextBox_Phone
            // 
            this.TextBox_Phone.BackColor = System.Drawing.Color.White;
            this.TextBox_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Phone.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Phone.Location = new System.Drawing.Point(19, 14);
            this.TextBox_Phone.Name = "TextBox_Phone";
            this.TextBox_Phone.ReadOnly = true;
            this.TextBox_Phone.Size = new System.Drawing.Size(414, 23);
            this.TextBox_Phone.TabIndex = 14;
            this.TextBox_Phone.Text = "0796616454";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.TextBox_Name);
            this.panel6.Location = new System.Drawing.Point(45, 126);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(449, 57);
            this.panel6.TabIndex = 17;
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.BackColor = System.Drawing.Color.White;
            this.TextBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Name.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Name.Location = new System.Drawing.Point(19, 14);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.ReadOnly = true;
            this.TextBox_Name.Size = new System.Drawing.Size(414, 23);
            this.TextBox_Name.TabIndex = 14;
            this.TextBox_Name.Text = "Huỳnh Viết Tuấn Kiệt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(45, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Địa chỉ giao hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(39, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(39, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên khách hàng";
            // 
            // _06_Form_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_Payment);
            this.Name = "_06_Form_Payment";
            this.Text = "_06_Form_Payment";
            this.Panel_Payment.ResumeLayout(false);
            this.Panel_Payment.PerformLayout();
            this.Panel_PaymentError.ResumeLayout(false);
            this.Panel_PaymentError.PerformLayout();
            this.Panel_PaymentSuccess.ResumeLayout(false);
            this.Panel_PaymentSuccess.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Panel_Payment;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel_Product;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Label label7;
        private Label label6;
        private Label label5;
        private FontAwesome.Sharp.IconButton Button_ChangeInformation;
        private Label label8;
        private Panel panel8;
        private TextBox TextBox_Address;
        private Panel panel7;
        private TextBox TextBox_Phone;
        private Panel panel6;
        private TextBox TextBox_Name;
        private ComboBox Combobox_ShipForms;
        private FontAwesome.Sharp.IconButton Button_Payment;
        private Panel Panel_PaymentError;
        private Panel Panel_PaymentSuccess;
        private Label label9;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label13;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label4;
        private Label Label_SumPrice;
        private Panel panel5;
        private Label Label_NumberOfProducts;
        private Label label3;
        private Label label2;
    }
}