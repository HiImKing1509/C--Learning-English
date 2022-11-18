namespace ShoppingOnline.Forms
{
    partial class _05_Form_MyCart
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
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.FlowLayoutPanel_OrderProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Button_PurchaseProduct = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_SumPrice = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Label_NumberOfProducts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 39);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhấn vào mục Mã giảm giá ở cuối trang để hưởng miễn phí vận chuyển bạn nhé!";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Location = new System.Drawing.Point(35, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(48, 39);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // FlowLayoutPanel_OrderProduct
            // 
            this.FlowLayoutPanel_OrderProduct.AutoScroll = true;
            this.FlowLayoutPanel_OrderProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FlowLayoutPanel_OrderProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlowLayoutPanel_OrderProduct.Location = new System.Drawing.Point(0, 39);
            this.FlowLayoutPanel_OrderProduct.Name = "FlowLayoutPanel_OrderProduct";
            this.FlowLayoutPanel_OrderProduct.Size = new System.Drawing.Size(1282, 531);
            this.FlowLayoutPanel_OrderProduct.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.Button_PurchaseProduct);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Label_SumPrice);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.Label_NumberOfProducts);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 570);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 153);
            this.panel2.TabIndex = 4;
            // 
            // Button_PurchaseProduct
            // 
            this.Button_PurchaseProduct.BackColor = System.Drawing.SystemColors.Control;
            this.Button_PurchaseProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_PurchaseProduct.FlatAppearance.BorderSize = 0;
            this.Button_PurchaseProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_PurchaseProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_PurchaseProduct.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.Button_PurchaseProduct.IconColor = System.Drawing.Color.Black;
            this.Button_PurchaseProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_PurchaseProduct.IconSize = 32;
            this.Button_PurchaseProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_PurchaseProduct.Location = new System.Drawing.Point(1016, 64);
            this.Button_PurchaseProduct.Name = "Button_PurchaseProduct";
            this.Button_PurchaseProduct.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_PurchaseProduct.Size = new System.Drawing.Size(206, 64);
            this.Button_PurchaseProduct.TabIndex = 27;
            this.Button_PurchaseProduct.Text = "Mua hàng";
            this.Button_PurchaseProduct.UseVisualStyleBackColor = false;
            this.Button_PurchaseProduct.Click += new System.EventHandler(this.Button_PurchaseProduct_Click);
            this.Button_PurchaseProduct.MouseEnter += new System.EventHandler(this.Button_PurchaseProduct_MouseEnter);
            this.Button_PurchaseProduct.MouseLeave += new System.EventHandler(this.Button_PurchaseProduct_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(820, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng thanh toán:";
            // 
            // Label_SumPrice
            // 
            this.Label_SumPrice.AutoSize = true;
            this.Label_SumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_SumPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_SumPrice.Location = new System.Drawing.Point(820, 90);
            this.Label_SumPrice.Name = "Label_SumPrice";
            this.Label_SumPrice.Size = new System.Drawing.Size(134, 38);
            this.Label_SumPrice.TabIndex = 8;
            this.Label_SumPrice.Text = "123.456";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(70, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1152, 2);
            this.panel5.TabIndex = 7;
            // 
            // Label_NumberOfProducts
            // 
            this.Label_NumberOfProducts.AutoSize = true;
            this.Label_NumberOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_NumberOfProducts.ForeColor = System.Drawing.Color.Gray;
            this.Label_NumberOfProducts.Location = new System.Drawing.Point(251, 64);
            this.Label_NumberOfProducts.Name = "Label_NumberOfProducts";
            this.Label_NumberOfProducts.Size = new System.Drawing.Size(34, 25);
            this.Label_NumberOfProducts.TabIndex = 6;
            this.Label_NumberOfProducts.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(64, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng số sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thanh toán";
            // 
            // _05_Form_MyCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1282, 723);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FlowLayoutPanel_OrderProduct);
            this.Controls.Add(this.panel1);
            this.Name = "_05_Form_MyCart";
            this.Text = "_05_Form_MyCart";
            this.Load += new System.EventHandler(this._05_Form_MyCart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FlowLayoutPanel FlowLayoutPanel_OrderProduct;
        private Panel panel2;
        private Label Label_NumberOfProducts;
        private Label label3;
        private Label label2;
        private Panel panel5;
        private Label label4;
        private Label Label_SumPrice;
        private FontAwesome.Sharp.IconButton Button_PurchaseProduct;
    }
}