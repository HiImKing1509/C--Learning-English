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
using System.Windows.Documents;
using ShoppingOnline.DAO;
using ShoppingOnline.Forms;

namespace ShoppingOnline.CustomControls
{
    public partial class OrderDetails : UserControl
    {
        string num_size = "";
        ResourceManager get_rm;
        DataRow get_row;
        private Form activeForm = null;
        public OrderDetails()
        {
            InitializeComponent();
        }

        private _05_Form_MyCart mainForm5 = null;

        public OrderDetails(Form callingForm5, ResourceManager rm, DataRow row) : this()
        {
            mainForm5 = callingForm5 as _05_Form_MyCart;


            get_rm = rm;
            get_row = row;

            Button_DecreaseSize.BackColor = CreateResources.Variables.MaastrichtBlue;
            Button_DecreaseSize.ForeColor = CreateResources.Variables.MetallicYellow;
            Button_DecreaseSize.IconColor = CreateResources.Variables.MetallicYellow;

            Button_IncreaseSize.BackColor = CreateResources.Variables.MaastrichtBlue;
            Button_IncreaseSize.ForeColor = CreateResources.Variables.MetallicYellow;
            Button_IncreaseSize.IconColor = CreateResources.Variables.MetallicYellow;

            Button_DetailProduct.BackColor = CreateResources.Variables.MaastrichtBlue;
            Button_DetailProduct.ForeColor = CreateResources.Variables.MetallicYellow;


            Bitmap myImage = (Bitmap)rm.GetObject(row["PRODUCT_ID"].ToString() + "_A"); 
            PictureBox_ImageProduct.Image = myImage;
            Label_NameProduct.Text = row["PRODUCT_NAME"].ToString();
            Label_OriginProduct.Text = row["PRODUCT_COUNTRY"].ToString();
            Label_SizeProduct.Text = "Size " + row["RECEIPT_DETAILS_SIZE"].ToString();
            TextBox_QuatitySize.Text = row["RECEIPT_DETAILS_QUATITY"].ToString();
            Label_OldPriceProduct.Text = CreateResources.Variables.stringProcessing(row["PRODUCT_OLD_PRICE"].ToString());
            Label_PriceProduct.Text = CreateResources.Variables.stringProcessing(row["PRODUCT_PRICE"].ToString());
            Label_SumPrice.Text = CreateResources.Variables.stringProcessing((Convert.ToInt32(row["RECEIPT_DETAILS_QUATITY"].ToString()) * Convert.ToInt32(row["PRODUCT_PRICE"].ToString())).ToString());
            num_size = row["PRODUCT_SIZE_" + row["RECEIPT_DETAILS_SIZE"].ToString()].ToString();
        }

        private void Button_DecreaseSize_Click(object sender, EventArgs e)
        {
            if (!TextBox_QuatitySize.Text.All(Char.IsDigit))
            {
                TextBox_QuatitySize.ForeColor = Color.Gray;
                TextBox_QuatitySize.Text = 0.ToString();
            }
            TextBox_QuatitySize.Text = (Convert.ToInt32(TextBox_QuatitySize.Text) - 1).ToString();
            if (Convert.ToInt32(TextBox_QuatitySize.Text) <= 0)
            {
                TextBox_QuatitySize.ForeColor = Color.Gray;
                TextBox_QuatitySize.Text = 0.ToString();
            }

            string rex = "RECEIPT_DETAILS_QUATITY - 1";
            if (TextBox_QuatitySize.Text == "0")
                rex = "0";

            DataProvider provider = new DataProvider();
            string query = 
                "update RECEIPT_DETAILS " +
                $"set RECEIPT_DETAILS_QUATITY = {rex} " +
                $"where RECEIPT_DETAILS_ID = 'RE{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString().Substring(2, 2)}_{CreateResources.Variables.NumReceipt}' " +
                $"and RECEIPT_DETAILS_PRODUCT = '{get_row["RECEIPT_DETAILS_PRODUCT"]}' " +
                $"and RECEIPT_DETAILS_SIZE = '{get_row["RECEIPT_DETAILS_SIZE"]}'";

            int update = provider.ExecuteNonQuery(query);

            UpdatePrice();
            UpdateSumPrice();
        }

        private void Button_IncreaseSize_Click(object sender, EventArgs e)
        {
            TextBox_QuatitySize.ForeColor = Color.Black;
            if (!TextBox_QuatitySize.Text.All(Char.IsDigit))
            {
                TextBox_QuatitySize.ForeColor = Color.Gray;
                TextBox_QuatitySize.Text = 0.ToString();

            }
            else if (Convert.ToInt32(TextBox_QuatitySize.Text) >= Convert.ToInt32(num_size))
                TextBox_QuatitySize.Text = (Convert.ToInt32(num_size)).ToString();
            else
                TextBox_QuatitySize.Text = (Convert.ToInt32(TextBox_QuatitySize.Text) + 1).ToString();

            DataProvider provider = new DataProvider();
            string query =
                "update RECEIPT_DETAILS " +
                "set RECEIPT_DETAILS_QUATITY = RECEIPT_DETAILS_QUATITY + 1 " +
                $"where RECEIPT_DETAILS_ID = 'RE{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString().Substring(2, 2)}_{CreateResources.Variables.NumReceipt}' " +
                $"and RECEIPT_DETAILS_PRODUCT = '{get_row["RECEIPT_DETAILS_PRODUCT"]}' " +
                $"and RECEIPT_DETAILS_SIZE = '{get_row["RECEIPT_DETAILS_SIZE"]}'";

            int update = provider.ExecuteNonQuery(query);

            UpdatePrice();
            UpdateSumPrice();
        }

        private void TextBox_QuatitySize_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == (char)13)
            {
                if (!TextBox_QuatitySize.Text.All(Char.IsDigit) || Convert.ToInt32(TextBox_QuatitySize.Text) <= 0)
                {
                    TextBox_QuatitySize.ForeColor = Color.Gray;
                    TextBox_QuatitySize.Text = 0.ToString();
                }
                if (Convert.ToInt32(TextBox_QuatitySize.Text) >= Convert.ToInt32(num_size))
                {
                    TextBox_QuatitySize.ForeColor = Color.Black;
                    TextBox_QuatitySize.Text = (Convert.ToInt32(num_size)).ToString();
                }
                else if (Convert.ToInt32(TextBox_QuatitySize.Text) > 0 && Convert.ToInt32(TextBox_QuatitySize.Text) < Convert.ToInt32(num_size))
                { }
                else
                {
                    TextBox_QuatitySize.ForeColor = Color.Gray;
                    TextBox_QuatitySize.Text = 0.ToString();
                }

                DataProvider provider = new DataProvider();
                string query =
                    "update RECEIPT_DETAILS " +
                    $"set RECEIPT_DETAILS_QUATITY = '{TextBox_QuatitySize.Text}' " +
                    $"where RECEIPT_DETAILS_ID = 'RE{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString().Substring(2, 2)}_{CreateResources.Variables.NumReceipt}' " +
                    $"and RECEIPT_DETAILS_PRODUCT = '{get_row["RECEIPT_DETAILS_PRODUCT"]}' " +
                    $"and RECEIPT_DETAILS_SIZE = '{get_row["RECEIPT_DETAILS_SIZE"]}'";

                int update = provider.ExecuteNonQuery(query);
                UpdatePrice();
                UpdateSumPrice();
            }
            else if (!char.IsNumber(ch) && ch !=8 && ch != 46)  //8 is Backspace key; 46 is Delete key. This statement accepts dot key. 
                TextBox_QuatitySize.Text = "0";
        }

        private void Button_DetailProduct_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string query =
                "select * from RECEIPT_DETAILS INNER JOIN PRODUCT on RECEIPT_DETAILS.RECEIPT_DETAILS_PRODUCT = PRODUCT.PRODUCT_ID " +
                $"where RECEIPT_DETAILS.RECEIPT_DETAILS_ID = 'RE{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString().Substring(2, 2)}_{CreateResources.Variables.NumReceipt}' " +
                $"and RECEIPT_DETAILS_ID = '{get_row["RECEIPT_DETAILS_ID"]}' " +
                $"and RECEIPT_DETAILS_PRODUCT = '{get_row["RECEIPT_DETAILS_PRODUCT"]}' " +
                $"and RECEIPT_DETAILS_SIZE = '{get_row["RECEIPT_DETAILS_SIZE"]}'";
            DataTable dt = provider.ExecuteQuery(query);
            openChildForm(new Forms._04_Form_Product_Detail(get_rm, dt));
        }

        private void Button_RemoveProduct_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();

            string query = 
                $"delete from RECEIPT_DETAILS " +
                $"where RECEIPT_DETAILS_ID = '{get_row["RECEIPT_DETAILS_ID"]}' " +
                $"and RECEIPT_DETAILS_PRODUCT = '{get_row["RECEIPT_DETAILS_PRODUCT"]}' " +
                $"and RECEIPT_DETAILS_SIZE = '{get_row["RECEIPT_DETAILS_SIZE"]}'";

            provider.ExecuteNonQuery(query);
            UpdateSumPrice();
            openChildForm(new _05_Form_MyCart());
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

        private void UpdatePrice()
        {
            DataProvider provider = new DataProvider();
            string query =
                "select * from RECEIPT_DETAILS INNER JOIN PRODUCT on RECEIPT_DETAILS.RECEIPT_DETAILS_PRODUCT = PRODUCT.PRODUCT_ID " +
                $"where RECEIPT_DETAILS.RECEIPT_DETAILS_ID = 'RE{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString().Substring(2, 2)}_{CreateResources.Variables.NumReceipt}' " +
                $"and RECEIPT_DETAILS_ID = '{get_row["RECEIPT_DETAILS_ID"]}' " +
                $"and RECEIPT_DETAILS_PRODUCT = '{get_row["RECEIPT_DETAILS_PRODUCT"]}' " +
                $"and RECEIPT_DETAILS_SIZE = '{get_row["RECEIPT_DETAILS_SIZE"]}'";
            DataTable dt = provider.ExecuteQuery(query);

            Label_SumPrice.Text = CreateResources.Variables.stringProcessing((Convert.ToInt32(dt.Rows[0]["PRODUCT_PRICE"].ToString()) * Convert.ToInt32(dt.Rows[0]["RECEIPT_DETAILS_QUATITY"].ToString())).ToString());
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
            //mainForm.label_sum_price = CreateResources.Variables.ListControls[1].Text;

            mainForm5.label_sum_price = CreateResources.Variables.stringProcessing(obj.ToString());
        }
    }
}
