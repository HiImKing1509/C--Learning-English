using ShoppingOnline.CustomControls;
using ShoppingOnline.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ShoppingOnline.Forms
{
    public partial class _05_Form_MyCart : Form
    {
        private Form activeForm = null;
        public _05_Form_MyCart()
        {
            InitializeComponent();
            Button_PurchaseProduct.BackColor = CreateResources.Variables.MaastrichtBlue;
            Button_PurchaseProduct.ForeColor = CreateResources.Variables.MetallicYellow;
            Button_PurchaseProduct.IconColor = CreateResources.Variables.MetallicYellow;

            Load_MyCart();
            UpdateSumPrice();
        }

        private void _05_Form_MyCart_Load(object sender, EventArgs e)
        {
            UpdateSumPrice();
        }

        private void Load_MyCart()
        {
            string query =
                "select * from RECEIPT_DETAILS INNER JOIN PRODUCT on RECEIPT_DETAILS.RECEIPT_DETAILS_PRODUCT = PRODUCT.PRODUCT_ID " +
                $"where RECEIPT_DETAILS.RECEIPT_DETAILS_ID = 'RE{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString().Substring(2, 2)}_{CreateResources.Variables.NumReceipt}'";

            DataProvider provider = new DataProvider();
            DataTable dtShowMyCart = provider.ExecuteQuery(query);

            Label_NumberOfProducts.Text = dtShowMyCart.Rows.Count.ToString();
            ResourceManager rm;
            if (dtShowMyCart.Rows.Count > 0)
            {
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
                    OrderDetails item = new OrderDetails(this, rm, row);
                    FlowLayoutPanel_OrderProduct.Controls.Add(item);
                    CreateResources.Variables.SumPrice = (
                        Convert.ToInt32(CreateResources.Variables.SumPrice) +
                        Convert.ToInt32(row["RECEIPT_DETAILS_QUATITY"].ToString()) * Convert.ToInt32(row["PRODUCT_PRICE"].ToString())
                    ).ToString();
                }
            }
            else
            {
                rm = CreateResources.Variables.rm_logo;
                FlowLayoutPanel_OrderProduct.BackgroundImage = (Bitmap)rm.GetObject("No_product");
            }
        }

        private void UpdateSumPrice()
        {
            DataProvider provider = new DataProvider();
            string query =
                "select sum(RECEIPT_DETAILS_QUATITY * PRODUCT_PRICE) " +
                "from RECEIPT_DETAILS INNER JOIN PRODUCT on RECEIPT_DETAILS.RECEIPT_DETAILS_PRODUCT = PRODUCT.PRODUCT_ID " +
                $"where RECEIPT_DETAILS.RECEIPT_DETAILS_ID = 'RE{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString().Substring(2, 2)}_{CreateResources.Variables.NumReceipt}'";

            Object obj = provider.ExecuteScalar(query);
            //CreateResources.Variables.ListControls[1].Text = CreateResources.Variables.stringProcessing(obj.ToString());
            //Label_SumPrice.Text = CreateResources.Variables.ListControls[1].Text;

            Label_SumPrice.Text = CreateResources.Variables.stringProcessing(obj.ToString());
        }

        private void Button_PurchaseProduct_MouseEnter(object sender, EventArgs e)
        {
            Button_PurchaseProduct.BackColor = CreateResources.Variables.MetallicYellow;
            Button_PurchaseProduct.ForeColor = CreateResources.Variables.MaastrichtBlue;
            Button_PurchaseProduct.IconColor = CreateResources.Variables.MaastrichtBlue;
        }

        private void Button_PurchaseProduct_MouseLeave(object sender, EventArgs e)
        {
            Button_PurchaseProduct.BackColor = CreateResources.Variables.MaastrichtBlue;
            Button_PurchaseProduct.ForeColor = CreateResources.Variables.MetallicYellow;
            Button_PurchaseProduct.IconColor = CreateResources.Variables.MetallicYellow;
        }

        private void Button_PurchaseProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new _06_Form_Payment(this));
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

        public string label_sum_price
        {
            get { return Label_SumPrice.Text; }
            set { Label_SumPrice.Text = value; }
        }
    }
}
