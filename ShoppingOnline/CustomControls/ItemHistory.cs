using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingOnline.CustomControls
{
    public partial class ItemHistory : UserControl
    {
        private Form activeForm = null;

        public ItemHistory()
        {
            InitializeComponent();
        }

        public ItemHistory(DataRow dt) : this()
        {
            Label_Receipt_ID.Text = dt["RECEIPT_ID"].ToString();
            Label_Receipt_Date.Text = dt["RECEIPT_DATE"].ToString();
            Label_Receipt_Price.Text = CreateResources.Variables.stringProcessing(dt["RECEIPT_PRICE"].ToString());
            Button_DetailProduct.Name = dt["RECEIPT_ID"].ToString();
        }

        private void Button_DetailProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms._10_Form_Receipt_Details(Button_DetailProduct.Name));
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            CreateResources.Variables.ListControls[0].Controls.Add(childForm);
            CreateResources.Variables.ListControls[0].Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
