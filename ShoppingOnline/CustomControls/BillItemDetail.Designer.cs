namespace ShoppingOnline.CustomControls
{
    partial class BillItemDetail
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
            this.Label_SumPrice = new System.Windows.Forms.Label();
            this.Label_Price = new System.Windows.Forms.Label();
            this.Label_Quantity = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_SumPrice
            // 
            this.Label_SumPrice.AutoSize = true;
            this.Label_SumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_SumPrice.Location = new System.Drawing.Point(717, 10);
            this.Label_SumPrice.Name = "Label_SumPrice";
            this.Label_SumPrice.Size = new System.Drawing.Size(80, 20);
            this.Label_SumPrice.TabIndex = 25;
            this.Label_SumPrice.Text = "5.000.000";
            // 
            // Label_Price
            // 
            this.Label_Price.AutoSize = true;
            this.Label_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Price.Location = new System.Drawing.Point(569, 10);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(67, 20);
            this.Label_Price.TabIndex = 24;
            this.Label_Price.Text = "300.000";
            // 
            // Label_Quantity
            // 
            this.Label_Quantity.AutoSize = true;
            this.Label_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Quantity.Location = new System.Drawing.Point(445, 10);
            this.Label_Quantity.Name = "Label_Quantity";
            this.Label_Quantity.Size = new System.Drawing.Size(27, 20);
            this.Label_Quantity.TabIndex = 23;
            this.Label_Quantity.Text = "00";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Name.Location = new System.Drawing.Point(20, 10);
            this.Label_Name.MaximumSize = new System.Drawing.Size(400, 0);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(387, 40);
            this.Label_Name.TabIndex = 22;
            this.Label_Name.Text = "Tên sản phẩm, Tên sản phẩm, Tên sản phẩm, Tên sản phẩm, Tên sản phẩm, Tên sản phẩ" +
    "m";
            // 
            // BillItemDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Label_SumPrice);
            this.Controls.Add(this.Label_Price);
            this.Controls.Add(this.Label_Quantity);
            this.Controls.Add(this.Label_Name);
            this.Name = "BillItemDetail";
            this.Size = new System.Drawing.Size(816, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Label_SumPrice;
        private Label Label_Price;
        private Label Label_Quantity;
        private Label Label_Name;
    }
}
