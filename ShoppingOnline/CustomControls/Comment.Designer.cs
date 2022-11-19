namespace ShoppingOnline.CustomControls
{
    partial class Comment
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
            this.PictureBox_Avatar = new ShoppingOnline.CustomControls.CCirclePictureBox();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_Date = new System.Windows.Forms.Label();
            this.Label_Comment = new System.Windows.Forms.Label();
            this.Button_Like = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox_Avatar
            // 
            this.PictureBox_Avatar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.PictureBox_Avatar.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PictureBox_Avatar.BorderColor2 = System.Drawing.Color.HotPink;
            this.PictureBox_Avatar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.PictureBox_Avatar.BorderSize = 2;
            this.PictureBox_Avatar.GradientAngle = 50F;
            this.PictureBox_Avatar.Location = new System.Drawing.Point(15, 16);
            this.PictureBox_Avatar.Name = "PictureBox_Avatar";
            this.PictureBox_Avatar.Size = new System.Drawing.Size(48, 48);
            this.PictureBox_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Avatar.TabIndex = 0;
            this.PictureBox_Avatar.TabStop = false;
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Name.Location = new System.Drawing.Point(73, 16);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(64, 25);
            this.Label_Name.TabIndex = 1;
            this.Label_Name.Text = "label1";
            // 
            // Label_Date
            // 
            this.Label_Date.AutoSize = true;
            this.Label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Date.ForeColor = System.Drawing.Color.Gray;
            this.Label_Date.Location = new System.Drawing.Point(73, 44);
            this.Label_Date.Name = "Label_Date";
            this.Label_Date.Size = new System.Drawing.Size(53, 20);
            this.Label_Date.TabIndex = 2;
            this.Label_Date.Text = "label1";
            // 
            // Label_Comment
            // 
            this.Label_Comment.AutoSize = true;
            this.Label_Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Comment.Location = new System.Drawing.Point(73, 80);
            this.Label_Comment.MaximumSize = new System.Drawing.Size(500, 0);
            this.Label_Comment.Name = "Label_Comment";
            this.Label_Comment.Size = new System.Drawing.Size(497, 44);
            this.Label_Comment.TabIndex = 3;
            this.Label_Comment.Text = "Áo rẻ mà đẹp quá trời, vải dày dặn, mặc lên vừa vặn đẹp lắm luôn. Shop nói chuyệ" +
    "n dễ thương";
            // 
            // Button_Like
            // 
            this.Button_Like.BackColor = System.Drawing.Color.Maroon;
            this.Button_Like.FlatAppearance.BorderSize = 0;
            this.Button_Like.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Like.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Like.ForeColor = System.Drawing.Color.White;
            this.Button_Like.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp;
            this.Button_Like.IconColor = System.Drawing.Color.White;
            this.Button_Like.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Like.IconSize = 32;
            this.Button_Like.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Like.Location = new System.Drawing.Point(454, 16);
            this.Button_Like.Name = "Button_Like";
            this.Button_Like.Size = new System.Drawing.Size(69, 38);
            this.Button_Like.TabIndex = 4;
            this.Button_Like.Text = "0";
            this.Button_Like.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Like.UseVisualStyleBackColor = false;
            this.Button_Like.Click += new System.EventHandler(this.Button_Like_Click);
            // 
            // Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Button_Like);
            this.Controls.Add(this.Label_Comment);
            this.Controls.Add(this.Label_Date);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.PictureBox_Avatar);
            this.Name = "Comment";
            this.Size = new System.Drawing.Size(600, 147);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCirclePictureBox PictureBox_Avatar;
        private Label Label_Name;
        private Label Label_Date;
        private Label Label_Comment;
        private FontAwesome.Sharp.IconButton Button_Like;
    }
}
