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
    public partial class BillItemDetail : UserControl
    {
        public BillItemDetail()
        {
            InitializeComponent();
        }

        public BillItemDetail(DataRow row) : this()
        {
            Label_Name.Text = row["PRODUCT_NAME"].ToString();
            Label_Quantity.Text = row["RECEIPT_DETAILS_QUATITY"].ToString();
            Label_Price.Text = CreateResources.Variables.stringProcessing(row["PRODUCT_PRICE"].ToString());
            Label_SumPrice.Text = CreateResources.Variables.stringProcessing((Convert.ToInt32(row["RECEIPT_DETAILS_QUATITY"].ToString()) * Convert.ToInt32(row["PRODUCT_PRICE"].ToString())).ToString());
        }
    }
}
