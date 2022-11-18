using FontAwesome.Sharp;
using ShoppingOnline.CustomControls;
using ShoppingOnline.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Reflection;
using System.Resources;
using ShoppingOnline.Properties;
using System.Security.Cryptography;
using System.Windows.Shapes;
using System.Windows.Documents;

namespace ShoppingOnline.Forms
{
    public partial class _03_Form_Home : Form
    {
        private Form activeForm = null;
        public _03_Form_Home()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            // Load data
            LabelMyAccount.Text = CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_NAME"].ToString();
            CreateResources.Variables.NumReceipt = CreateResources.Variables.getNumberOfReceipt();


            // Initialization
            PanelSidebar.BackColor = CreateResources.Variables.MaastrichtBlue;
            PanelInformation.BackColor = CreateResources.Variables.MaastrichtBlue;
            ButtonSearchProduct.BackColor = CreateResources.Variables.CetaceanBlue;

            ButtonProduct.ForeColor = CreateResources.Variables.MetallicYellow;
            ButtonProduct.IconColor = CreateResources.Variables.MetallicYellow;
            ButtonShowAllProducts.ForeColor = CreateResources.Variables.MetallicYellow;
            ButtonShowTShirt.ForeColor = CreateResources.Variables.MetallicYellow;
            ButtonShowCoats.ForeColor = CreateResources.Variables.MetallicYellow;
            ButtonShowDressShirt.ForeColor = CreateResources.Variables.MetallicYellow;
            ButtonShowPant.ForeColor = CreateResources.Variables.MetallicYellow;
            ButtonShowShorts.ForeColor = CreateResources.Variables.MetallicYellow;
            ButtonMyAccount.ForeColor = CreateResources.Variables.MetallicYellow;
            ButtonMyAccount.IconColor = CreateResources.Variables.MetallicYellow;
            ButtonMyCart.ForeColor = CreateResources.Variables.MetallicYellow;
            ButtonMyCart.IconColor = CreateResources.Variables.MetallicYellow;
            ButtonHistory.ForeColor = CreateResources.Variables.MetallicYellow;
            ButtonHistory.IconColor = CreateResources.Variables.MetallicYellow;
            ButtonLogout.ForeColor = CreateResources.Variables.MetallicYellow;
            ButtonLogout.IconColor = CreateResources.Variables.MetallicYellow;
            ButtonCustomerRecord.ForeColor = CreateResources.Variables.MetallicYellow;
            ButtonChangePassword.ForeColor = CreateResources.Variables.MetallicYellow;

            PanelBrandLogo.BackColor = CreateResources.Variables.CetaceanBlue;
            CreateResources.Variables.ListControls.Add(PanelContent);
            CreateResources.Variables.ListControls.Add(Panel_Filter);

            ResourceManager rm_ava = CreateResources.Variables.rm_avatar;
            Bitmap myImage = (Bitmap)rm_ava.GetObject($"{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"]}");

            PictureBox_Image_Customer.Image = myImage;
        }

        private void _03_Form_Home_Load(object sender, EventArgs e)
        {
            CreateResources.Variables.Table = "All";
            //string query = "select [PRODUCT_ID],[PRODUCT_NAME],[PRODUCT_PRICE],[PRODUCT_COUNTRY] from PRODUCT";
            //PanelActivateAllProducts(query);
            FilterMerchandise();
        }

        #region Button controls FormWindowState
        private void ButtonCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonMinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonMaximumForm_Click(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Normal)
            //    this.WindowState = FormWindowState.Maximized;
            //else
            //    this.WindowState = FormWindowState.Normal;
        }
        
        private void ButtonCloseForm_MouseEnter(object sender, EventArgs e)
        {
            ButtonCloseForm.BackColor = Color.Red;
            ButtonCloseForm.IconColor = Color.White;
        }

        private void ButtonCloseForm_MouseLeave(object sender, EventArgs e)
        {
            ButtonCloseForm.BackColor = Color.Transparent;
            ButtonCloseForm.IconColor = Color.White;
        }
        #endregion

        private void ButtonSearchProduct_MouseEnter(object sender, EventArgs e)
        {
            ButtonSearchProduct.BackColor = CreateResources.Variables.MetallicYellow;
            ButtonSearchProduct.ForeColor = CreateResources.Variables.MaastrichtBlue;
            ButtonSearchProduct.IconColor = CreateResources.Variables.MaastrichtBlue;
        }

        private void ButtonSearchProduct_MouseLeave(object sender, EventArgs e)
        {
            ButtonSearchProduct.BackColor = CreateResources.Variables.CetaceanBlue;
            ButtonSearchProduct.ForeColor = Color.White;
            ButtonSearchProduct.IconColor = Color.White;
        }

        #region Processing
        // Hide all Submenu
        private void hideSubMenu()
        {
            // ...
            // Your code
            if (PanelSubMenu1.Visible) PanelSubMenu1.Visible = false;
            if (PanelSubMenu2.Visible) PanelSubMenu2.Visible = false;
            // Your code
            // ...
        }

        // Visible a Submenu
        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        private void ButtonProduct_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenu1);
        }

        private void ButtonProduct_MouseEnter(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            btn.BackColor = CreateResources.Variables.MetallicYellow;
            btn.ForeColor = CreateResources.Variables.MaastrichtBlue;
            btn.IconColor = CreateResources.Variables.MaastrichtBlue;
        }

        private void ButtonProduct_MouseLeave(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            btn.BackColor = CreateResources.Variables.MaastrichtBlue;
            btn.ForeColor = CreateResources.Variables.MetallicYellow;
            btn.IconColor = CreateResources.Variables.MetallicYellow;
        }

        private void TextBoxSearchProduct_Enter(object sender, EventArgs e)
        {
            if (TextBoxSearchProduct.Text == "Tìm kiếm sản phẩm trong shop" && TextBoxSearchProduct.ForeColor == Color.Silver)
            {
                TextBoxSearchProduct.Text = "";
                TextBoxSearchProduct.ForeColor = Color.Black;
            }
        }

        private void TextBoxSearchProduct_Leave(object sender, EventArgs e)
        {
            if (TextBoxSearchProduct.Text == "")
            {
                TextBoxSearchProduct.Text = "Tìm kiếm sản phẩm trong shop";
                TextBoxSearchProduct.ForeColor = Color.Silver;
            }
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
        private void PanelActivateAllProducts(string query)
        {
            foreach (Control item in PanelContent.Controls.OfType<FlowLayoutPanel>().ToList())
                PanelContent.Controls.Remove(item);
            foreach (Control item in PanelContent.Controls.OfType<Form>().ToList())
                PanelContent.Controls.Remove(item);
            FlowLayoutPanel flpShowProduct = new FlowLayoutPanel();
            PanelContent.Controls.Add(flpShowProduct);
            flpShowProduct.Dock = DockStyle.Fill;
            flpShowProduct.AutoScroll = true;

            DataProvider provider = new DataProvider();
            DataTable dtShowProduct = provider.ExecuteQuery(query);

            if (dtShowProduct.Rows.Count == 0)
            {
                PictureBox_NotFoundProduct.Visible = true;
                Label_NotFoundProduct.Visible = true;
            }
            else
            {
                PictureBox_NotFoundProduct.Visible = false;
                Label_NotFoundProduct.Visible = false;
                ResourceManager rm;
                foreach (DataRow row in dtShowProduct.Rows)
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
                    Bitmap myImage = (Bitmap)rm.GetObject(row["PRODUCT_ID"].ToString() + "_A");
                    Item item = new Item(
                        myImage,
                        row["PRODUCT_ID"].ToString(),
                        CreateResources.Variables.stringProcessing(row["PRODUCT_PRICE"].ToString()),
                        row["PRODUCT_NAME"].ToString(),
                        row["PRODUCT_COUNTRY"].ToString()
                    );
                    flpShowProduct.Controls.Add(item);
                }
            };
        }

        private void ButtonShowAllProducts_Click(object sender, EventArgs e)
        {
            CreateResources.Variables.Table = "All";
            FilterVisible_True();
            FilterMerchandise();
        }

        private void ButtonShowTShirt_Click(object sender, EventArgs e)
        {
            CreateResources.Variables.Table = "TS";
            FilterVisible_True();
            FilterMerchandise();
        }

        private void ButtonShowCoats_Click(object sender, EventArgs e)
        {
            CreateResources.Variables.Table = "CO";
            FilterVisible_True();
            FilterMerchandise();
        }

        private void ButtonShowDressShirt_Click(object sender, EventArgs e)
        {
            CreateResources.Variables.Table = "SI";
            FilterVisible_True();
            FilterMerchandise();
        }

        private void ButtonShowPant_Click(object sender, EventArgs e)
        {
            CreateResources.Variables.Table = "JE";
            FilterVisible_True();
            FilterMerchandise();
        }

        private void ButtonShowShorts_Click(object sender, EventArgs e)
        {
            CreateResources.Variables.Table = "SH";
            FilterVisible_True();
            FilterMerchandise();
        }

        private void Button_ResetFilter_Click(object sender, EventArgs e)
        {
            Combobox_FilterColor.Text = "Màu";
            Combobox_FilterPrice.Text = "Giá";
            Combobox_FilterMaterial.Text = "Chất liệu";

            FilterMerchandise();
        }

        private void ButtonSearchProduct_Click(object sender, EventArgs e)
        {
            FilterMerchandise();
        }

        private void TextBoxSearchProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == (char)13)
                FilterMerchandise();
        }

        private void ButtonCustomerRecord_Click(object sender, EventArgs e)
        {
            CreateResources.Variables.Table = "All";
            FilterVisible_False();
            openChildForm(new _07_Form_Personal_Information());
        }

        private void ButtonMyAccount_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = CreateResources.Variables.MaastrichtBlue;
            btn.ForeColor = Color.White;
        }

        private void ButtonMyAccount_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = CreateResources.Variables.MaastrichtBlue;
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            CreateResources.Variables.Table = "All";
            CreateResources.Variables.ListControls.Clear();
            Form LoginForm = new _02_Form_Login();
            Hide();
            LoginForm.Show();
        }

        private void ButtonMyAccount_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenu2);
        }

        private void ButtonMyCart_Click(object sender, EventArgs e)
        {
            CreateResources.Variables.Table = "All";
            FilterVisible_False();
            openChildForm(new _05_Form_MyCart());
        }

        private void Combobox_FilterColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterMerchandise();
        }

        private void Combobox_FilterPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterMerchandise();
        }

        private void Combobox_FilterMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterMerchandise();
        }

        private void FilterMerchandise()
        {
            string query = "select [PRODUCT_ID], [PRODUCT_NAME], [PRODUCT_COLOR], [PRODUCT_PRICE], [PRODUCT_MATERIAL], [PRODUCT_COUNTRY] from PRODUCT ";
            if (TextBoxSearchProduct.Text == "Tìm kiếm sản phẩm trong shop")
                query += "where (dbo.LanguageComprehension(PRODUCT_NAME) like N'%" + "" + "%' " +
                         "or PRODUCT_NAME like N'%" + "" + "%')";
            else
            {
                query += "where (dbo.LanguageComprehension(PRODUCT_NAME) like N'%" + TextBoxSearchProduct.Text + "%' " +
                         "or PRODUCT_NAME like N'%" + TextBoxSearchProduct.Text + "%')";
            }
            if (CreateResources.Variables.Table != "All")
                query += $" and PRODUCT_ID like '{CreateResources.Variables.Table}%'";
            if (Combobox_FilterColor.Text != "Màu")
            {
                query += $" and PRODUCT_COLOR like N'%" + Combobox_FilterColor.Text + "%'";
            }
            if (Combobox_FilterMaterial.Text != "Chất liệu")
            {
                query += $" and PRODUCT_MATERIAL like N'%" + Combobox_FilterMaterial.Text + "%'";
            }
            if (Combobox_FilterPrice.Text != "Giá")
            {
                List<string> stringPriceList = Combobox_FilterPrice.Text.Split(" - ").ToList();
                query += $" and PRODUCT_PRICE between {stringPriceList[0]} and {stringPriceList[1]}";
            }
            PanelActivateAllProducts(query);
        }

        private void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            CreateResources.Variables.Table = "All";
            FilterVisible_False();
            openChildForm(new _08_Form_Change_Password());
        }

        private void ButtonHistory_Click(object sender, EventArgs e)
        {
            CreateResources.Variables.Table = "All";
            FilterVisible_False();
            openChildForm(new _09_Form_History());
        }

        private void FilterVisible_True()
        {
            Panel_Filter.Visible = true;
        }

        private void FilterVisible_False()
        {
            Panel_Filter.Visible = false;
        }
    }
}
