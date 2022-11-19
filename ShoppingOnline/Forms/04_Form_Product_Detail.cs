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
using System.Reflection;
using System.Printing;
using ShoppingOnline.DAO;
using ShoppingOnline.CustomControls;

namespace ShoppingOnline.Forms
{
    public partial class _04_Form_Product_Detail : Form
    {
        Bitmap ImageProduct_A;
        Bitmap ImageProduct_B;
        Bitmap ImageProduct_C;
        Bitmap ImageProduct_D;

        ResourceManager get_rm;
        DataTable get_dt;
        string _product_id = "";

        private Form activeForm = null;
        public _04_Form_Product_Detail()
        {
            InitializeComponent();
        }


        public _04_Form_Product_Detail(ResourceManager rm, DataTable dt) : this()
        {
            get_rm = rm;
            get_dt = dt;

            // Initialization
            ButtonAddToCart.BackColor = CreateResources.Variables.MaastrichtBlue;
            ButtonAddToCart.IconColor = CreateResources.Variables.MetallicYellow;
            ButtonAddToCart.ForeColor = CreateResources.Variables.MetallicYellow;

            ButtonPayment.BackColor = CreateResources.Variables.MetallicYellow;
            ButtonPayment.IconColor = CreateResources.Variables.MaastrichtBlue;
            ButtonPayment.ForeColor = CreateResources.Variables.MaastrichtBlue;

            ButtonReset.BackColor = Color.DarkRed;
            ButtonReset.IconColor = Color.White;
            ButtonReset.ForeColor = Color.White;

            ButtonDecreaseSizeS.BackColor = CreateResources.Variables.MaastrichtBlue;
            ButtonDecreaseSizeM.BackColor = CreateResources.Variables.MaastrichtBlue;
            ButtonDecreaseSizeL.BackColor = CreateResources.Variables.MaastrichtBlue;
            ButtonDecreaseSizeXL.BackColor = CreateResources.Variables.MaastrichtBlue;
            ButtonIncreaseSizeS.BackColor = CreateResources.Variables.MaastrichtBlue;
            ButtonIncreaseSizeM.BackColor = CreateResources.Variables.MaastrichtBlue;
            ButtonIncreaseSizeL.BackColor = CreateResources.Variables.MaastrichtBlue;
            ButtonIncreaseSizeXL.BackColor = CreateResources.Variables.MaastrichtBlue;
            ButtonDecreaseSizeS.IconColor = CreateResources.Variables.MetallicYellow;
            ButtonDecreaseSizeM.IconColor = CreateResources.Variables.MetallicYellow;
            ButtonDecreaseSizeL.IconColor = CreateResources.Variables.MetallicYellow;
            ButtonDecreaseSizeXL.IconColor = CreateResources.Variables.MetallicYellow;
            ButtonIncreaseSizeS.IconColor = CreateResources.Variables.MetallicYellow;
            ButtonIncreaseSizeM.IconColor = CreateResources.Variables.MetallicYellow;
            ButtonIncreaseSizeL.IconColor = CreateResources.Variables.MetallicYellow;
            ButtonIncreaseSizeXL.IconColor = CreateResources.Variables.MetallicYellow;

            Panel_ProductReviews.BottomColor = CreateResources.Variables.MaastrichtBlue;
            Panel_ProductReviews.Angle = 30;
            Label_ProductReview.ForeColor = CreateResources.Variables.MaastrichtBlue;

            Panel_OtherComment.BottomColor = CreateResources.Variables.MaastrichtBlue;
            Panel_OtherComment.TopColor = CreateResources.Variables.MetallicYellow;
            Panel_OtherComment.Angle = 30;

            Panel_MyComment.BottomColor = CreateResources.Variables.MaastrichtBlue;
            Panel_MyComment.TopColor = CreateResources.Variables.MaastrichtBlue;

            Panel_Main_Comment.BackColor = CreateResources.Variables.MetallicYellow;

            DataRow row = dt.Rows[0];
            LabelNameProduct.Text = row["PRODUCT_NAME"].ToString();
            LabelFormProduct.Text = row["PRODUCT_FORM"].ToString();
            LabelColorProduct.Text = row["PRODUCT_COLOR"].ToString();
            LabelMaterialProduct.Text = row["PRODUCT_MATERIAL"].ToString();
            LabelCompositionProduct.Text = row["PRODUCT_COMPOSITION"].ToString();
            LabelOriginProduct.Text = row["PRODUCT_COUNTRY"].ToString();
            LabelOldPriceProduct.Text = CreateResources.Variables.stringProcessing(row["PRODUCT_OLD_PRICE"].ToString());
            LabelPriceProduct.Text = CreateResources.Variables.stringProcessing(row["PRODUCT_PRICE"].ToString());

            LabelQuatitySizeS.Text = row["PRODUCT_SIZE_S"].ToString();
            LabelQuatitySizeM.Text = row["PRODUCT_SIZE_M"].ToString();
            LabelQuatitySizeL.Text = row["PRODUCT_SIZE_L"].ToString();
            LabelQuatitySizeXL.Text = row["PRODUCT_SIZE_XL"].ToString();

            ImageProduct_A = (Bitmap)rm.GetObject(row["PRODUCT_ID"].ToString() + "_A");
            ImageProduct_B = (Bitmap)rm.GetObject(row["PRODUCT_ID"].ToString() + "_B");
            ImageProduct_C = (Bitmap)rm.GetObject(row["PRODUCT_ID"].ToString() + "_C");
            ImageProduct_D = (Bitmap)rm.GetObject(row["PRODUCT_ID"].ToString() + "_D");

            PictureBoxShowImageProduct.Image = ImageProduct_A;
            ButtonImage_A.BackgroundImage = ImageProduct_A;
            ButtonImage_B.BackgroundImage = ImageProduct_B;
            ButtonImage_C.BackgroundImage = ImageProduct_C;
            ButtonImage_D.BackgroundImage = ImageProduct_D;

            _product_id = row["PRODUCT_ID"].ToString();

            LoadComment(row["PRODUCT_ID"].ToString());
        }

        private void PanelInformationDetail_Paint(object sender, PaintEventArgs e)
        {

        }
        private void PanelSelectProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonImage_A_Click(object sender, EventArgs e)
        {
            PictureBoxShowImageProduct.Image = ImageProduct_A;
        }

        private void ButtonImage_B_Click(object sender, EventArgs e)
        {
            PictureBoxShowImageProduct.Image = ImageProduct_B;
        }

        private void ButtonImage_C_Click(object sender, EventArgs e)
        {
            PictureBoxShowImageProduct.Image = ImageProduct_C;
        }

        private void ButtonImage_D_Click(object sender, EventArgs e)
        {
            PictureBoxShowImageProduct.Image = ImageProduct_D;
        }

        private void ButtonDecreaseSizeS_Click(object sender, EventArgs e)
        {
            if (!TextBoxQuatitySizeS.Text.All(Char.IsDigit))
            {
                TextBoxQuatitySizeS.ForeColor = Color.Gray;
                TextBoxQuatitySizeS.Text = 0.ToString();
            }
            TextBoxQuatitySizeS.Text = (Convert.ToInt32(TextBoxQuatitySizeS.Text) - 1).ToString();
            if (Convert.ToInt32(TextBoxQuatitySizeS.Text) <= 0)
            {
                TextBoxQuatitySizeS.ForeColor = Color.Gray;
                TextBoxQuatitySizeS.Text = 0.ToString();
            }
        }
        private void ButtonIncreaseSizeS_Click(object sender, EventArgs e)
        {
            TextBoxQuatitySizeS.ForeColor = Color.Black;
            if (!TextBoxQuatitySizeS.Text.All(Char.IsDigit))
            {
                TextBoxQuatitySizeS.ForeColor = Color.Gray;
                TextBoxQuatitySizeS.Text = 0.ToString();

            }
            else if (Convert.ToInt32(TextBoxQuatitySizeS.Text) >= Convert.ToInt32(LabelQuatitySizeS.Text))
                TextBoxQuatitySizeS.Text = (Convert.ToInt32(LabelQuatitySizeS.Text)).ToString();
            else
                TextBoxQuatitySizeS.Text = (Convert.ToInt32(TextBoxQuatitySizeS.Text) + 1).ToString();
        }
        private void TextBoxQuatitySizeS_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == (char)13)
            {
                if (!TextBoxQuatitySizeS.Text.All(Char.IsDigit) || Convert.ToInt32(TextBoxQuatitySizeS.Text) <= 0)
                {
                    TextBoxQuatitySizeS.ForeColor = Color.Gray;
                    TextBoxQuatitySizeS.Text = 0.ToString();
                }
                if (Convert.ToInt32(TextBoxQuatitySizeS.Text) >= Convert.ToInt32(LabelQuatitySizeS.Text))
                {
                    TextBoxQuatitySizeS.ForeColor = Color.Black;
                    TextBoxQuatitySizeS.Text = (Convert.ToInt32(LabelQuatitySizeS.Text)).ToString();
                }
                else if (Convert.ToInt32(TextBoxQuatitySizeS.Text) > 0 && Convert.ToInt32(TextBoxQuatitySizeS.Text) < Convert.ToInt32(LabelQuatitySizeS.Text))
                { }
                else
                {
                    TextBoxQuatitySizeS.ForeColor = Color.Gray;
                    TextBoxQuatitySizeS.Text = 0.ToString();
                }
            }
            else if (!char.IsNumber(ch) && ch !=8 && ch != 46)  //8 is Backspace key; 46 is Delete key. This statement accepts dot key. 
                TextBoxQuatitySizeS.Text = "0";
        }
        private void ButtonDecreaseSizeM_Click(object sender, EventArgs e)
        {
            if (!TextBoxQuatitySizeM.Text.All(Char.IsDigit))
            {
                TextBoxQuatitySizeM.ForeColor = Color.Gray;
                TextBoxQuatitySizeM.Text = 0.ToString();
            }
            TextBoxQuatitySizeM.Text = (Convert.ToInt32(TextBoxQuatitySizeM.Text) - 1).ToString();
            if (Convert.ToInt32(TextBoxQuatitySizeM.Text) <= 0)
            {
                TextBoxQuatitySizeM.ForeColor = Color.Gray;
                TextBoxQuatitySizeM.Text = 0.ToString();
            }
        }

        private void ButtonIncreaseSizeM_Click(object sender, EventArgs e)
        {
            TextBoxQuatitySizeM.ForeColor = Color.Black;
            if (!TextBoxQuatitySizeM.Text.All(Char.IsDigit))
            {
                TextBoxQuatitySizeM.ForeColor = Color.Gray;
                TextBoxQuatitySizeM.Text = 0.ToString();

            }
            else if (Convert.ToInt32(TextBoxQuatitySizeM.Text) >= Convert.ToInt32(LabelQuatitySizeM.Text))
                TextBoxQuatitySizeM.Text = (Convert.ToInt32(LabelQuatitySizeM.Text)).ToString();
            else
                TextBoxQuatitySizeM.Text = (Convert.ToInt32(TextBoxQuatitySizeM.Text) + 1).ToString();
        }


        private void TextBoxQuatitySizeM_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == (char)13)
            {
                if (!TextBoxQuatitySizeM.Text.All(Char.IsDigit) || Convert.ToInt32(TextBoxQuatitySizeM.Text) <= 0)
                {
                    TextBoxQuatitySizeM.ForeColor = Color.Gray;
                    TextBoxQuatitySizeM.Text = 0.ToString();
                }
                if (Convert.ToInt32(TextBoxQuatitySizeM.Text) >= Convert.ToInt32(LabelQuatitySizeM.Text))
                {
                    TextBoxQuatitySizeM.ForeColor = Color.Black;
                    TextBoxQuatitySizeM.Text = (Convert.ToInt32(LabelQuatitySizeM.Text)).ToString();
                }
                else if (Convert.ToInt32(TextBoxQuatitySizeM.Text) > 0 && Convert.ToInt32(TextBoxQuatitySizeM.Text) < Convert.ToInt32(LabelQuatitySizeM.Text))
                { }
                else
                {
                    TextBoxQuatitySizeM.ForeColor = Color.Gray;
                    TextBoxQuatitySizeM.Text = 0.ToString();
                }
            }
            else if (!char.IsNumber(ch) && ch !=8 && ch != 46)  //8 is Backspace key; 46 is Delete key. This statement accepts dot key. 
                TextBoxQuatitySizeM.Text = "0";
        }
        private void ButtonDecreaseSizeL_Click(object sender, EventArgs e)
        {
            if (!TextBoxQuatitySizeL.Text.All(Char.IsDigit))
            {
                TextBoxQuatitySizeL.ForeColor = Color.Gray;
                TextBoxQuatitySizeL.Text = 0.ToString();
            }
            TextBoxQuatitySizeL.Text = (Convert.ToInt32(TextBoxQuatitySizeL.Text) - 1).ToString();
            if (Convert.ToInt32(TextBoxQuatitySizeL.Text) <= 0)
            {
                TextBoxQuatitySizeL.ForeColor = Color.Gray;
                TextBoxQuatitySizeL.Text = 0.ToString();
            }
        }
        private void ButtonIncreaseSizeL_Click(object sender, EventArgs e)
        {
            TextBoxQuatitySizeL.ForeColor = Color.Black;
            if (!TextBoxQuatitySizeL.Text.All(Char.IsDigit))
            {
                TextBoxQuatitySizeL.ForeColor = Color.Gray;
                TextBoxQuatitySizeL.Text = 0.ToString();

            }
            else if (Convert.ToInt32(TextBoxQuatitySizeL.Text) >= Convert.ToInt32(LabelQuatitySizeL.Text))
                TextBoxQuatitySizeL.Text = (Convert.ToInt32(LabelQuatitySizeL.Text)).ToString();
            else
                TextBoxQuatitySizeL.Text = (Convert.ToInt32(TextBoxQuatitySizeL.Text) + 1).ToString();
        }

        private void TextBoxQuatitySizeL_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == (char)13)
            {
                if (!TextBoxQuatitySizeL.Text.All(Char.IsDigit) || Convert.ToInt32(TextBoxQuatitySizeL.Text) <= 0)
                {
                    TextBoxQuatitySizeL.ForeColor = Color.Gray;
                    TextBoxQuatitySizeL.Text = 0.ToString();
                }
                if (Convert.ToInt32(TextBoxQuatitySizeL.Text) >= Convert.ToInt32(LabelQuatitySizeL.Text))
                {
                    TextBoxQuatitySizeL.ForeColor = Color.Black;
                    TextBoxQuatitySizeL.Text = (Convert.ToInt32(LabelQuatitySizeL.Text)).ToString();
                }
                else if (Convert.ToInt32(TextBoxQuatitySizeL.Text) > 0 && Convert.ToInt32(TextBoxQuatitySizeL.Text) < Convert.ToInt32(LabelQuatitySizeL.Text))
                { }
                else
                {
                    TextBoxQuatitySizeL.ForeColor = Color.Gray;
                    TextBoxQuatitySizeL.Text = 0.ToString();
                }
            }
            else if (!char.IsNumber(ch) && ch !=8 && ch != 46)  //8 is Backspace key; 46 is Delete key. This statement accepts dot key. 
                TextBoxQuatitySizeL.Text = "0";
        }

        private void ButtonDecreaseSizeXL_Click(object sender, EventArgs e)
        {
            if (!TextBoxQuatitySizeXL.Text.All(Char.IsDigit))
            {
                TextBoxQuatitySizeXL.ForeColor = Color.Gray;
                TextBoxQuatitySizeXL.Text = 0.ToString();
            }
            TextBoxQuatitySizeXL.Text = (Convert.ToInt32(TextBoxQuatitySizeXL.Text) - 1).ToString();
            if (Convert.ToInt32(TextBoxQuatitySizeXL.Text) <= 0)
            {
                TextBoxQuatitySizeXL.ForeColor = Color.Gray;
                TextBoxQuatitySizeXL.Text = 0.ToString();
            }
        }
        private void ButtonIncreaseSizeXL_Click(object sender, EventArgs e)
        {
            TextBoxQuatitySizeXL.ForeColor = Color.Black;
            if (!TextBoxQuatitySizeXL.Text.All(Char.IsDigit))
            {
                TextBoxQuatitySizeXL.ForeColor = Color.Gray;
                TextBoxQuatitySizeXL.Text = 0.ToString();

            }
            else if (Convert.ToInt32(TextBoxQuatitySizeXL.Text) >= Convert.ToInt32(LabelQuatitySizeXL.Text))
                TextBoxQuatitySizeXL.Text = (Convert.ToInt32(LabelQuatitySizeXL.Text)).ToString();
            else
                TextBoxQuatitySizeXL.Text = (Convert.ToInt32(TextBoxQuatitySizeXL.Text) + 1).ToString();
        }
        private void TextBoxQuatitySizeXL_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == (char)13)
            {
                if (!TextBoxQuatitySizeXL.Text.All(Char.IsDigit) || Convert.ToInt32(TextBoxQuatitySizeXL.Text) <= 0)
                {
                    TextBoxQuatitySizeXL.ForeColor = Color.Gray;
                    TextBoxQuatitySizeXL.Text = 0.ToString();
                }
                if (Convert.ToInt32(TextBoxQuatitySizeXL.Text) >= Convert.ToInt32(LabelQuatitySizeXL.Text))
                {
                    TextBoxQuatitySizeXL.ForeColor = Color.Black;
                    TextBoxQuatitySizeXL.Text = (Convert.ToInt32(LabelQuatitySizeXL.Text)).ToString();
                }
                else if (Convert.ToInt32(TextBoxQuatitySizeXL.Text) > 0 && Convert.ToInt32(TextBoxQuatitySizeXL.Text) < Convert.ToInt32(LabelQuatitySizeXL.Text))
                { }
                else
                {
                    TextBoxQuatitySizeXL.ForeColor = Color.Gray;
                    TextBoxQuatitySizeXL.Text = 0.ToString();
                }
            }
            else if (!char.IsNumber(ch) && ch !=8 && ch != 46)  //8 is Backspace key; 46 is Delete key. This statement accepts dot key. 
                TextBoxQuatitySizeXL.Text = "0";
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            TextBoxQuatitySizeS.ForeColor = Color.Gray;
            TextBoxQuatitySizeM.ForeColor = Color.Gray;
            TextBoxQuatitySizeL.ForeColor = Color.Gray;
            TextBoxQuatitySizeXL.ForeColor = Color.Gray;

            TextBoxQuatitySizeS.Text = 0.ToString();
            TextBoxQuatitySizeM.Text = 0.ToString();
            TextBoxQuatitySizeL.Text = 0.ToString();
            TextBoxQuatitySizeXL.Text = 0.ToString();
        }

        private async void WaitSuccess()
        {
            PanelAddCartSuccess.Visible = true;
            await Task.Delay(1000);
            PanelAddCartSuccess.Visible = false;
        }

        private async void WaitNotSuccess()
        {
            PanelAddCartError.Visible = true;
            await Task.Delay(1000);
            PanelAddCartError.Visible = false;
        }

        private void PanelInformationProduct_Paint(object sender, PaintEventArgs e)
        {

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

        private void ButtonPayment_Click(object sender, EventArgs e)
        {
            openChildForm(new _05_Form_MyCart());
        }

        private void ButtonAddToCart_Click(object sender, EventArgs e)
        {
            if (TextBoxQuatitySizeS.Text == "0" && TextBoxQuatitySizeM.Text == "0" && TextBoxQuatitySizeL.Text == "0" && TextBoxQuatitySizeXL.Text == "0")
                WaitNotSuccess();
            else
            {
                WaitSuccess();
                if (TextBoxQuatitySizeS.Text != "0")
                    Add_to_Cart("S", TextBoxQuatitySizeS.Text);
                if (TextBoxQuatitySizeM.Text != "0")
                    Add_to_Cart("M", TextBoxQuatitySizeM.Text);
                if (TextBoxQuatitySizeL.Text != "0")
                    Add_to_Cart("L", TextBoxQuatitySizeL.Text);
                if (TextBoxQuatitySizeXL.Text != "0")
                    Add_to_Cart("XL", TextBoxQuatitySizeXL.Text);
            }
        }

        private void Add_to_Cart(string size, string quatity)
        {
            DataProvider provider = new DataProvider();
            string query_add_conditions =
                "select * from RECEIPT_DETAILS " +
                $"where RECEIPT_DETAILS_ID = 'RE{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString().Substring(2, 2)}_{CreateResources.Variables.NumReceipt}' " +
                $"and RECEIPT_DETAILS_PRODUCT = '{get_dt.Rows[0]["PRODUCT_ID"]}' " +
                $"and RECEIPT_DETAILS_SIZE = '{size}'";
            DataTable dtAddConditions = provider.ExecuteQuery(query_add_conditions);
            int num_row_success = 0;
            string query = "";
            if (dtAddConditions.Rows.Count == 0)
            {
                query = 
                    $"insert into RECEIPT_DETAILS values(" +
                    $"'RE{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString().Substring(2, 2)}_{CreateResources.Variables.NumReceipt}', " +
                    $"'{get_dt.Rows[0]["PRODUCT_ID"]}', " +
                    $"'{size}', " +
                    $"{quatity})";
            }
            else
            {
                query =
                    $"update RECEIPT_DETAILS " +
                    $"set RECEIPT_DETAILS_QUATITY = RECEIPT_DETAILS_QUATITY + {quatity} " +
                    $"where RECEIPT_DETAILS_ID = 'RE{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString().Substring(2, 2)}_{CreateResources.Variables.NumReceipt}' " +
                    $"and RECEIPT_DETAILS_PRODUCT = '{get_dt.Rows[0]["PRODUCT_ID"]}' " +
                    $"and RECEIPT_DETAILS_SIZE = '{size}'";
            }
            num_row_success = provider.ExecuteNonQuery(query);
        }

        private void Button_CloseComment_Click(object sender, EventArgs e)
        {
            Panel_Comment.Visible = false;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Panel_Comment.Visible = true;
        }

        private void LoadComment(string product_id)
        {
            ResourceManager rm_ava = CreateResources.Variables.rm_avatar;
            Bitmap myImage = (Bitmap)rm_ava.GetObject($"{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"]}");
            PictureBox_Customer.Image = myImage;

            string query = $"select * from COMMENT inner join CUSTOMER on COMMENT.COMMENT_CUSTOMER = CUSTOMER.CUSTOMER_ID where COMMENT.COMMENT_PRODUCT = '{product_id}'";
            DataProvider provider = new DataProvider();

            DataTable dt = provider.ExecuteQuery(query);
            Panel_Main_Comment.Controls.Clear();
            foreach (DataRow row in dt.Rows)
            {
                Comment item = new Comment(row);
                Panel_Main_Comment.Controls.Add(item);
            }
        }

        private void TextBox_MyComment_Enter(object sender, EventArgs e)
        {
            if (TextBox_MyComment.Text == "Đánh giá sản phẩm" && TextBox_MyComment.ForeColor == Color.Silver)
            {
                TextBox_MyComment.Text = "";
                TextBox_MyComment.ForeColor = Color.Black;
            }
        }

        private void TextBox_MyComment_Leave(object sender, EventArgs e)
        {
            if (TextBox_MyComment.Text == "")
            {
                TextBox_MyComment.Text = "Đánh giá sản phẩm";
                TextBox_MyComment.ForeColor = Color.Silver;
            }
        }

        private void Button_Comment_Click(object sender, EventArgs e)
        {
            if (TextBox_MyComment.ForeColor == Color.Black)
            {
                string query =
                    $"insert into COMMENT values(" +
                    $"{++CreateResources.Variables.CommentID}, " +
                    $"'{DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt")}', " +
                    $"'{_product_id}', " +
                    $"'{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString()}', " +
                    $"N'{TextBox_MyComment.Text}', " +
                    $"0)";
                DataProvider provider = new DataProvider();

                int add_comment = provider.ExecuteNonQuery(query);

                LoadComment(_product_id);

                TextBox_MyComment.ForeColor = Color.Silver;
                TextBox_MyComment.Text = "Đánh giá sản phẩm";
            }
        }
    }
}