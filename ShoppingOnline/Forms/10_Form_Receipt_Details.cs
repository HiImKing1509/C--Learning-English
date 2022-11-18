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
using System.Resources;
using ShoppingOnline.CustomControls;

namespace ShoppingOnline.Forms
{
    public partial class _10_Form_Receipt_Details : Form
    {
        private Form activeForm = null;

        public _10_Form_Receipt_Details()
        {
            InitializeComponent();
        }

        public _10_Form_Receipt_Details(string id) : this()
        {
            Button_BackToHistory.BackColor = CreateResources.Variables.MaastrichtBlue;
            Button_BackToHistory.ForeColor = CreateResources.Variables.MetallicYellow;

            Load_Product(id);
            LoadCustomerInformation(id);
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

        private void Load_Product(string id)
        {
            string query =
                "select * from RECEIPT_DETAILS INNER JOIN PRODUCT on RECEIPT_DETAILS.RECEIPT_DETAILS_PRODUCT = PRODUCT.PRODUCT_ID " +
                $"where RECEIPT_DETAILS.RECEIPT_DETAILS_ID = '{id}' " +
                $"and RECEIPT_DETAILS.RECEIPT_DETAILS_QUATITY <> 0";

            DataProvider provider = new DataProvider();
            DataTable dtShowMyCart = provider.ExecuteQuery(query);

            ResourceManager rm;

            flowLayoutPanel_Product.Controls.Clear();
            Label_NumberOfProducts.Text = dtShowMyCart.Rows.Count.ToString();
            foreach (DataRow row in dtShowMyCart.Rows)
            {
                string str = row["PRODUCT_ID"].ToString().Substring(0, 2);
                switch (str)
                {
                    case "TS":
                        rm = CreateResources.Variables.rm_tshirt;
                        break;
                    case "CO":
                        rm = CreateResources.Variables.rm_coats;
                        break;
                    case "SI":
                        rm = CreateResources.Variables.rm_shirt;
                        break;
                    case "JE":
                        rm = CreateResources.Variables.rm_jean;
                        break;
                    case "SH":
                        rm = CreateResources.Variables.rm_short;
                        break;
                    default:
                        rm = CreateResources.Variables.rm_tshirt;
                        break;
                }
                PaymentProduct item = new PaymentProduct(rm, row);
                flowLayoutPanel_Product.Controls.Add(item);
                CreateResources.Variables.SumPrice = (
                    Convert.ToInt32(CreateResources.Variables.SumPrice) +
                    Convert.ToInt32(row["RECEIPT_DETAILS_QUATITY"].ToString()) * Convert.ToInt32(row["PRODUCT_PRICE"].ToString())
                ).ToString();
            }
        }

        private void LoadCustomerInformation(string id)
        {
            DataProvider provider = new DataProvider();
            string query = $"select * from CUSTOMER where CUSTOMER_ID = 'CU{id.Substring(2, 2)}'";
            DataTable dtShowCustomerInformation = provider.ExecuteQuery(query);
            Label_Name.Text = dtShowCustomerInformation.Rows[0]["CUSTOMER_NAME"].ToString();
            Label_Phone.Text = dtShowCustomerInformation.Rows[0]["CUSTOMER_PHONE_NUMBER"].ToString();

            query = $"select * from RECEIPT_DETAILS where RECEIPT_DETAILS_ID = '{id}'";
            DataTable dtShowReceiptDetails = provider.ExecuteQuery(query);

            query = $"select * from RECEIPT where RECEIPT_ID = '{id}'";
            DataTable dtShowReceiptInformation = provider.ExecuteQuery(query);
            Label_ID.Text = dtShowReceiptInformation.Rows[0]["RECEIPT_ID"].ToString();
            Label_Date.Text = dtShowReceiptInformation.Rows[0]["RECEIPT_DATE"].ToString();

            Label_SumPrice.Text = CreateResources.Variables.stringProcessing(dtShowReceiptInformation.Rows[0]["RECEIPT_PRICE"].ToString());
            Label_NumberOfProducts.Text = dtShowReceiptDetails.Rows.Count.ToString();
        }
    }
}
