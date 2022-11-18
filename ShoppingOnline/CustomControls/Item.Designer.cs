namespace ShoppingOnline.CustomControls
{
    partial class Item
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
            this.PictureBox_ProductImage = new System.Windows.Forms.PictureBox();
            this.Label_ProductPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonDetail = new System.Windows.Forms.Button();
            this.Label_ProductName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_ProductCountry = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ProductImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox_ProductImage
            // 
            this.PictureBox_ProductImage.Location = new System.Drawing.Point(19, 3);
            this.PictureBox_ProductImage.Name = "PictureBox_ProductImage";
            this.PictureBox_ProductImage.Size = new System.Drawing.Size(270, 275);
            this.PictureBox_ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_ProductImage.TabIndex = 0;
            this.PictureBox_ProductImage.TabStop = false;
            // 
            // Label_ProductPrice
            // 
            this.Label_ProductPrice.AutoSize = true;
            this.Label_ProductPrice.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_ProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_ProductPrice.Location = new System.Drawing.Point(0, 2);
            this.Label_ProductPrice.Name = "Label_ProductPrice";
            this.Label_ProductPrice.Size = new System.Drawing.Size(101, 38);
            this.Label_ProductPrice.TabIndex = 2;
            this.Label_ProductPrice.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_ProductPrice);
            this.panel1.Location = new System.Drawing.Point(19, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 42);
            this.panel1.TabIndex = 2;
            // 
            // ButtonDetail
            // 
            this.ButtonDetail.BackColor = System.Drawing.Color.MidnightBlue;
            this.ButtonDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDetail.FlatAppearance.BorderSize = 0;
            this.ButtonDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDetail.ForeColor = System.Drawing.Color.White;
            this.ButtonDetail.Location = new System.Drawing.Point(19, 412);
            this.ButtonDetail.Name = "ButtonDetail";
            this.ButtonDetail.Size = new System.Drawing.Size(270, 54);
            this.ButtonDetail.TabIndex = 4;
            this.ButtonDetail.Text = "Detail";
            this.ButtonDetail.UseVisualStyleBackColor = false;
            this.ButtonDetail.Click += new System.EventHandler(this.ButtonDetail_Click);
            this.ButtonDetail.MouseEnter += new System.EventHandler(this.ButtonDetail_MouseEnter);
            this.ButtonDetail.MouseLeave += new System.EventHandler(this.ButtonDetail_MouseLeave);
            // 
            // Label_ProductName
            // 
            this.Label_ProductName.AutoSize = true;
            this.Label_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_ProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label_ProductName.Location = new System.Drawing.Point(0, 0);
            this.Label_ProductName.MaximumSize = new System.Drawing.Size(270, 0);
            this.Label_ProductName.Name = "Label_ProductName";
            this.Label_ProductName.Size = new System.Drawing.Size(64, 25);
            this.Label_ProductName.TabIndex = 1;
            this.Label_ProductName.Text = "label3";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Label_ProductName);
            this.panel2.Location = new System.Drawing.Point(19, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 52);
            this.panel2.TabIndex = 3;
            // 
            // Label_ProductCountry
            // 
            this.Label_ProductCountry.AutoSize = true;
            this.Label_ProductCountry.Dock = System.Windows.Forms.DockStyle.Right;
            this.Label_ProductCountry.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_ProductCountry.ForeColor = System.Drawing.Color.Gray;
            this.Label_ProductCountry.Location = new System.Drawing.Point(224, 0);
            this.Label_ProductCountry.Name = "Label_ProductCountry";
            this.Label_ProductCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label_ProductCountry.Size = new System.Drawing.Size(46, 17);
            this.Label_ProductCountry.TabIndex = 5;
            this.Label_ProductCountry.Text = "label3";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Label_ProductCountry);
            this.panel3.Location = new System.Drawing.Point(19, 385);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 28);
            this.panel3.TabIndex = 6;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ButtonDetail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PictureBox_ProductImage);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(310, 479);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ProductImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox PictureBox_ProductImage;
        private Label Label_ProductPrice;
        private Panel panel1;
        private Button ButtonDetail;
        private Label Label_ProductName;
        private Panel panel2;
        private TextBox textBox1;
        private Label Label_ProductCountry;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton ButtonCartPlus;
    }
}
