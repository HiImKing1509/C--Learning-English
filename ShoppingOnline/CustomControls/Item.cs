using ShoppingOnline.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Resources;
using ShoppingOnline.Forms;

namespace ShoppingOnline.CustomControls
{
    public partial class Item : UserControl
    {
        private Form activeForm = null;
        public Item()
        {
            InitializeComponent();
            ButtonDetail.BackColor = CreateResources.Variables.MaastrichtBlue;
        }

        public Item(Bitmap image, string id, string price, string name, string country) : this()
        {
            PictureBox_ProductImage.Image = image;
            ButtonDetail.Name = id;
            Label_ProductPrice.Text = price;
            Label_ProductName.Text = name;
            Label_ProductCountry.Text = country;
        }

        private void ButtonDetail_MouseEnter(object sender, EventArgs e)
        {
            ButtonDetail.BackColor = CreateResources.Variables.MetallicYellow;
            ButtonDetail.ForeColor = CreateResources.Variables.MaastrichtBlue;
        }

        private void ButtonDetail_MouseLeave(object sender, EventArgs e)
        {
            ButtonDetail.BackColor = CreateResources.Variables.MaastrichtBlue;
            ButtonDetail.ForeColor = Color.White;
        }

        private void ButtonDetail_Click(object sender, EventArgs e)
        {
            CreateResources.Variables.Table = "All";
            CreateResources.Variables.ListControls[1].Visible = false;
            ResourceManager getRM;
            switch (ButtonDetail.Name.Substring(0, 2))
            {
                case "TS":
                    getRM = CreateResources.Variables.rm_tshirt;
                    break;
                case "CO":
                    getRM = CreateResources.Variables.rm_coats;
                    break;
                case "SI":
                    getRM = CreateResources.Variables.rm_shirt;
                    break;
                case "JE":
                    getRM = CreateResources.Variables.rm_jean;
                    break;
                case "SH":
                    getRM = CreateResources.Variables.rm_short;
                    break;
                default:
                    getRM = new ResourceManager("ShoppingOnline.CreateResources.Images_TShirt", Assembly.GetExecutingAssembly());
                    break;
            }
            string query = $"select * from PRODUCT where PRODUCT_ID like '{ButtonDetail.Name}%'";
            DataProvider provider = new DataProvider();
            DataTable dtShowProductDetail = provider.ExecuteQuery(query);
            openChildForm(new _04_Form_Product_Detail(getRM, dtShowProductDetail));
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
