namespace ShoppingOnline.CustomControls
{
    partial class ItemHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_Receipt_Price = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_Receipt_ID = new System.Windows.Forms.Label();
            this.Label_Receipt_Date = new System.Windows.Forms.Label();
            this.Button_DetailProduct = new FontAwesome.Sharp.IconButton();
            this.Button_BillDetails = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã đơn hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(374, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày mua hàng:";
            // 
            // Label_Receipt_Price
            // 
            this.Label_Receipt_Price.AutoSize = true;
            this.Label_Receipt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Receipt_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Receipt_Price.Location = new System.Drawing.Point(164, 77);
            this.Label_Receipt_Price.Name = "Label_Receipt_Price";
            this.Label_Receipt_Price.Size = new System.Drawing.Size(125, 32);
            this.Label_Receipt_Price.TabIndex = 26;
            this.Label_Receipt_Price.Text = "123.456";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(57, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Giá tiền:";
            // 
            // Label_Receipt_ID
            // 
            this.Label_Receipt_ID.AutoSize = true;
            this.Label_Receipt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Receipt_ID.ForeColor = System.Drawing.Color.Gray;
            this.Label_Receipt_ID.Location = new System.Drawing.Point(196, 28);
            this.Label_Receipt_ID.Name = "Label_Receipt_ID";
            this.Label_Receipt_ID.Size = new System.Drawing.Size(93, 25);
            this.Label_Receipt_ID.TabIndex = 27;
            this.Label_Receipt_ID.Text = "RE00_00";
            // 
            // Label_Receipt_Date
            // 
            this.Label_Receipt_Date.AutoSize = true;
            this.Label_Receipt_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Receipt_Date.ForeColor = System.Drawing.Color.Gray;
            this.Label_Receipt_Date.Location = new System.Drawing.Point(536, 28);
            this.Label_Receipt_Date.Name = "Label_Receipt_Date";
            this.Label_Receipt_Date.Size = new System.Drawing.Size(232, 25);
            this.Label_Receipt_Date.TabIndex = 28;
            this.Label_Receipt_Date.Text = "12-11-2022 12:24:35 PM";
            // 
            // Button_DetailProduct
            // 
            this.Button_DetailProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_DetailProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_DetailProduct.FlatAppearance.BorderSize = 0;
            this.Button_DetailProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_DetailProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_DetailProduct.ForeColor = System.Drawing.Color.White;
            this.Button_DetailProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_DetailProduct.IconColor = System.Drawing.Color.Black;
            this.Button_DetailProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_DetailProduct.IconSize = 32;
            this.Button_DetailProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_DetailProduct.Location = new System.Drawing.Point(812, 42);
            this.Button_DetailProduct.Name = "Button_DetailProduct";
            this.Button_DetailProduct.Size = new System.Drawing.Size(200, 50);
            this.Button_DetailProduct.TabIndex = 29;
            this.Button_DetailProduct.Text = "Chi tiết đơn hàng";
            this.Button_DetailProduct.UseVisualStyleBackColor = false;
            this.Button_DetailProduct.Click += new System.EventHandler(this.Button_DetailProduct_Click);
            // 
            // Button_BillDetails
            // 
            this.Button_BillDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button_BillDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_BillDetails.FlatAppearance.BorderSize = 0;
            this.Button_BillDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_BillDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_BillDetails.ForeColor = System.Drawing.Color.White;
            this.Button_BillDetails.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_BillDetails.IconColor = System.Drawing.Color.Black;
            this.Button_BillDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_BillDetails.IconSize = 32;
            this.Button_BillDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_BillDetails.Location = new System.Drawing.Point(1030, 42);
            this.Button_BillDetails.Name = "Button_BillDetails";
            this.Button_BillDetails.Size = new System.Drawing.Size(200, 50);
            this.Button_BillDetails.TabIndex = 30;
            this.Button_BillDetails.Text = "Chi tiết hóa đơn";
            this.Button_BillDetails.UseVisualStyleBackColor = false;
            this.Button_BillDetails.Click += new System.EventHandler(this.Button_BillDetails_Click);
            // 
            // ItemHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Button_BillDetails);
            this.Controls.Add(this.Button_DetailProduct);
            this.Controls.Add(this.Label_Receipt_Date);
            this.Controls.Add(this.Label_Receipt_ID);
            this.Controls.Add(this.Label_Receipt_Price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ItemHistory";
            this.Size = new System.Drawing.Size(1258, 140);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label Label_Receipt_Price;
        private Label label4;
        private Label Label_Receipt_ID;
        private Label Label_Receipt_Date;
        private FontAwesome.Sharp.IconButton Button_DetailProduct;
        private FontAwesome.Sharp.IconButton Button_BillDetails;
    }
}
