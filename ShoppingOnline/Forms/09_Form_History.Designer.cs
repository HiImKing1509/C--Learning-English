namespace ShoppingOnline.Forms
{
    partial class _09_Form_History
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
            this.Panel_History = new LearningEnglish.CustomComponents.CPanelGradient();
            this.Label_History = new System.Windows.Forms.Label();
            this.FlowLayoutPanel_LoadItems = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_History.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_History
            // 
            this.Panel_History.Angle = 0F;
            this.Panel_History.BottomColor = System.Drawing.Color.Empty;
            this.Panel_History.Controls.Add(this.Label_History);
            this.Panel_History.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_History.Location = new System.Drawing.Point(0, 0);
            this.Panel_History.Name = "Panel_History";
            this.Panel_History.Size = new System.Drawing.Size(1267, 95);
            this.Panel_History.TabIndex = 2;
            this.Panel_History.TopColor = System.Drawing.Color.Empty;
            // 
            // Label_History
            // 
            this.Label_History.AutoSize = true;
            this.Label_History.BackColor = System.Drawing.Color.Transparent;
            this.Label_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Label_History.ForeColor = System.Drawing.Color.Gray;
            this.Label_History.Location = new System.Drawing.Point(77, 30);
            this.Label_History.Name = "Label_History";
            this.Label_History.Size = new System.Drawing.Size(274, 38);
            this.Label_History.TabIndex = 41;
            this.Label_History.Text = "Lịch sử mua hàng";
            // 
            // FlowLayoutPanel_LoadItems
            // 
            this.FlowLayoutPanel_LoadItems.AutoScroll = true;
            this.FlowLayoutPanel_LoadItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel_LoadItems.Location = new System.Drawing.Point(0, 95);
            this.FlowLayoutPanel_LoadItems.Name = "FlowLayoutPanel_LoadItems";
            this.FlowLayoutPanel_LoadItems.Size = new System.Drawing.Size(1267, 618);
            this.FlowLayoutPanel_LoadItems.TabIndex = 3;
            // 
            // _09_Form_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 713);
            this.Controls.Add(this.FlowLayoutPanel_LoadItems);
            this.Controls.Add(this.Panel_History);
            this.Name = "_09_Form_History";
            this.Text = "_09_Form_History";
            this.Panel_History.ResumeLayout(false);
            this.Panel_History.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LearningEnglish.CustomComponents.CPanelGradient Panel_History;
        private FlowLayoutPanel FlowLayoutPanel_LoadItems;
        private Label Label_History;
    }
}