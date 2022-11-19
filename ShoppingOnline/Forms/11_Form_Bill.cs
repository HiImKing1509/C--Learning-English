using ShoppingOnline.CustomControls;
using ShoppingOnline.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingOnline.Forms
{
    public partial class _11_Form_Bill : Form
    {
        private Form activeForm = null;
        public _11_Form_Bill()
        {
            InitializeComponent();
        }

        public _11_Form_Bill(string id) : this()
        {
            Load_Bill(id);
        }

        private void Load_Bill(string id)
        {
            string query = $"select * from RECEIPT where RECEIPT_ID = '{id}'";
            DataProvider provider = new DataProvider();

            DataTable dt_receipt = provider.ExecuteQuery(query);

            Label_Date.Text = dt_receipt.Rows[0]["RECEIPT_DATE"].ToString();
            Label_ID.Text = dt_receipt.Rows[0]["RECEIPT_ID"].ToString();
            Label_CustomerName.Text = CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_NAME"].ToString();

            query = $"select * from RECEIPT_DETAILS INNER JOIN PRODUCT on RECEIPT_DETAILS.RECEIPT_DETAILS_PRODUCT = PRODUCT.PRODUCT_ID where RECEIPT_DETAILS.RECEIPT_DETAILS_ID = '{id}'";

            DataTable dt_receipt_details = provider.ExecuteQuery(query);
            foreach (DataRow row in dt_receipt_details.Rows)
            {
                BillItemDetail item = new BillItemDetail(row);
                FlowLayoutPanel_ItemBill.Controls.Add(item);
            }
        }

        private void Button_BackToHistory_Click(object sender, EventArgs e)
        {
            openChildForm(new _09_Form_History());
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
