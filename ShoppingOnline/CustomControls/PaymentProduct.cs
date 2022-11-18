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

namespace ShoppingOnline.CustomControls
{
    public partial class PaymentProduct : UserControl
    {
        public PaymentProduct()
        {
            InitializeComponent();
        }

        public PaymentProduct(ResourceManager rm, DataRow row) : this()
        {
            Bitmap myImage = (Bitmap)rm.GetObject(row["PRODUCT_ID"].ToString() + "_A");
            PictureBox_ImageProduct.Image = myImage;
            Label_NameProduct.Text = row["PRODUCT_NAME"].ToString();
            Label_SizeProduct.Text = "Size " + row["RECEIPT_DETAILS_SIZE"].ToString();
            Label_Quantity.Text = row["RECEIPT_DETAILS_QUATITY"].ToString();
            Label_PriceProduct.Text = CreateResources.Variables.stringProcessing(row["PRODUCT_PRICE"].ToString());
            Label_SumPrice.Text = CreateResources.Variables.stringProcessing((Convert.ToInt32(row["RECEIPT_DETAILS_QUATITY"].ToString()) * Convert.ToInt32(row["PRODUCT_PRICE"].ToString())).ToString());
        }
    }
}
