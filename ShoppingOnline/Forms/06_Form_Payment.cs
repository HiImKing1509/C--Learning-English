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
using System.Resources;
using FontAwesome.Sharp;

namespace ShoppingOnline.Forms
{
    public partial class _06_Form_Payment : Form
    {
        private _05_Form_MyCart mainForm = null;

        public _06_Form_Payment(Form callingForm)
        {
            mainForm = callingForm as _05_Form_MyCart;
            InitializeComponent();
            Button_Payment.BackColor = CreateResources.Variables.MaastrichtBlue;
            Button_Payment.ForeColor = CreateResources.Variables.MetallicYellow;
            Button_Payment.IconColor = CreateResources.Variables.MetallicYellow;

            Button_ChangeInformation.BackColor = CreateResources.Variables.MaastrichtBlue;
            Button_ChangeInformation.ForeColor = CreateResources.Variables.MetallicYellow;
            Button_ChangeInformation.IconColor = CreateResources.Variables.MetallicYellow;

            Load_Product();
            Load_Information();

            Label_SumPrice.Text = mainForm.label_sum_price;
        }

        private void Load_Product()
        {
            string query =
                "select * from RECEIPT_DETAILS INNER JOIN PRODUCT on RECEIPT_DETAILS.RECEIPT_DETAILS_PRODUCT = PRODUCT.PRODUCT_ID " +
                $"where RECEIPT_DETAILS.RECEIPT_DETAILS_ID = 'RE{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString().Substring(2, 2)}_{CreateResources.Variables.NumReceipt}' " +
                $"and RECEIPT_DETAILS.RECEIPT_DETAILS_QUATITY <> 0";

            DataProvider provider = new DataProvider();
            DataTable dtShowMyCart = provider.ExecuteQuery(query);

            ResourceManager rm;

            flowLayoutPanel_Product.Controls.Clear();
            if (dtShowMyCart.Rows.Count > 0)
            {
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
            else
            {
                rm = CreateResources.Variables.rm_logo;
                flowLayoutPanel_Product.BackgroundImage = (Bitmap)rm.GetObject("No_product");
            }
        }

        private void Load_Information()
        {
            TextBox_Name.Text = CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_NAME"].ToString();
            TextBox_Phone.Text = CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_PHONE_NUMBER"].ToString();
            TextBox_Address.Text = CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ADDRESS"].ToString();
        }

        private void Button_Payment_Click(object sender, EventArgs e)
        {
            if (mainForm.label_sum_price == "" || Combobox_ShipForms.ForeColor == Color.Silver)
                WaitShow(Panel_PaymentError);
            else
            {
                WaitShow(Panel_PaymentSuccess);
                DataProvider provider = new DataProvider();
                string query =
                    "insert into RECEIPT values(" +
                    $"'RE{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString().Substring(2, 2)}_{CreateResources.Variables.NumReceipt}', " +
                    $"'{DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt")}', " +
                    $"'{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"]}', " +
                    $"{String.Join("", $"{mainForm.label_sum_price}".Split('.'))})";

                int payment = provider.ExecuteNonQuery(query);

                CreateResources.Variables.NumReceipt = CreateResources.Variables.getNumberOfReceipt();
                mainForm.label_sum_price = "";
                Label_NumberOfProducts.Text = "0";
                Label_SumPrice.Text = mainForm.label_sum_price;
                query =
                    "delete from RECEIPT_DETAILS " +
                    "where RECEIPT_DETAILS_QUATITY = 0 " +
                    $"and RECEIPT_DETAILS_ID = 'RE{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString().Substring(2, 2)}_{CreateResources.Variables.NumReceipt}'";
                int update_data = provider.ExecuteNonQuery(query);
                Load_Product();
            }
        }

        private void Button_Payment_MouseEnter(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            btn.BackColor = CreateResources.Variables.MetallicYellow;
            btn.ForeColor = CreateResources.Variables.MaastrichtBlue;
            btn.IconColor = CreateResources.Variables.MaastrichtBlue;
        }

        private void Button_Payment_MouseLeave(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            btn.BackColor = CreateResources.Variables.MaastrichtBlue;
            btn.ForeColor = CreateResources.Variables.MetallicYellow;
            btn.IconColor = CreateResources.Variables.MetallicYellow;
        }

        private void Button_ChangeInformation_Click(object sender, EventArgs e)
        {
            void change_status_tb(TextBox tb)
            {
                tb.ReadOnly = !tb.ReadOnly;
                if (tb.ReadOnly) tb.ForeColor = Color.Black;
                else tb.ForeColor = Color.Silver;
            }
            change_status_tb(TextBox_Name);
            change_status_tb(TextBox_Phone);
            change_status_tb(TextBox_Address);
        }

        private async void WaitShow(Panel pn)
        {
            pn.Visible = true;
            await Task.Delay(1000);
            pn.Visible = false;
        }

        private void Combobox_ShipForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combobox_ShipForms.Text != "Hình thức thanh toán")
                Combobox_ShipForms.ForeColor = Color.Black;
            else
                Combobox_ShipForms.ForeColor = Color.Silver;
        }
    }
}
