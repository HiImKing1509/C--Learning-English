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
    public partial class _09_Form_History : Form
    {
        public _09_Form_History()
        {
            InitializeComponent();
            Panel_History.BottomColor = CreateResources.Variables.MetallicYellow;
            Panel_History.Angle = 30;

            Label_History.ForeColor = CreateResources.Variables.MaastrichtBlue;

            Load_MyHistory();
        }


        private void Load_MyHistory()
        {
            string query = $"select * from RECEIPT where RECEIPT_ID like 'RE{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString().Substring(2, 2)}%'";

            DataProvider provider = new DataProvider();
            DataTable dtShowMyCart = provider.ExecuteQuery(query);

            foreach (DataRow row in dtShowMyCart.Rows)
            {
                ItemHistory item = new ItemHistory(row);
                FlowLayoutPanel_LoadItems.Controls.Add(item);
            }
        }
    }
}
