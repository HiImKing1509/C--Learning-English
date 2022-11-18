using ShoppingOnline.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using Microsoft.VisualBasic;

namespace ShoppingOnline.Forms
{
    public partial class _07_Form_Personal_Information : Form
    {
        private Form activeForm = null;
        public _07_Form_Personal_Information()
        {
            InitializeComponent();
            Panel_FormInformation.BottomColor = CreateResources.Variables.MetallicYellow;
            Panel_FormInformation.TopColor = CreateResources.Variables.MaastrichtBlue;
            Panel_FormInformation.Angle = 210;

            Label_Information.ForeColor = CreateResources.Variables.MaastrichtBlue;
            Label_SumReceiptText.ForeColor = CreateResources.Variables.MaastrichtBlue;
            Label_SumReceipt.ForeColor = CreateResources.Variables.MaastrichtBlue;

            Panel_Information.BackColor = CreateResources.Variables.MaastrichtBlue;

            Button_ChangeInformation.BackColor = CreateResources.Variables.MaastrichtBlue;
            Button_ChangeInformation.ForeColor = CreateResources.Variables.MetallicYellow;
        }

        private void _07_Personal_Information_Load(object sender, EventArgs e)
        {
            Load_Information();
        }

        private void Load_Information()
        {
            string query = $"select * from CUSTOMER where CUSTOMER_ID = '{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"]}'";
            DataProvider provider = new DataProvider();

            DataTable dt = provider.ExecuteQuery(query);
            ResourceManager rm = CreateResources.Variables.rm_avatar;

            TextBox_Name.Text = dt.Rows[0]["CUSTOMER_NAME"].ToString();
            TextBox_Phone.Text = dt.Rows[0]["CUSTOMER_PHONE_NUMBER"].ToString();
            TextBox_Account.Text = dt.Rows[0]["CUSTOMER_ACCOUNT"].ToString();
            TextBox_Password.Text = dt.Rows[0]["CUSTOMER_PASSWORD"].ToString();
            TextBox_Address.Text = dt.Rows[0]["CUSTOMER_ADDRESS"].ToString();

            Label_SumReceipt.Text = dt.Rows[0]["CUSTOMER_NUMBER_RECEIPT"].ToString();

            Bitmap myImage = (Bitmap)rm.GetObject($"{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"]}");
            PictureBox_Avatar.Image = myImage;

            Label_SumReceipt.Text = countNumberOfReceipt().ToString();
        }

        private void Button_ChangeInformation_MouseEnter(object sender, EventArgs e)
        {
            Button_ChangeInformation.BackColor = CreateResources.Variables.MetallicYellow;
            Button_ChangeInformation.ForeColor = CreateResources.Variables.MaastrichtBlue;
        }

        private void Button_ChangeInformation_MouseLeave(object sender, EventArgs e)
        {
            Button_ChangeInformation.BackColor = CreateResources.Variables.MaastrichtBlue;
            Button_ChangeInformation.ForeColor = CreateResources.Variables.MetallicYellow;
        }

        private void Button_ChangePassword_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms._08_Form_Change_Password());
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

        private int countNumberOfReceipt()
        {
            string query = $"select * from RECEIPT where RECEIPT_ID like 'RE{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString().Substring(2, 2)}%'";

            DataProvider provider = new DataProvider();
            DataTable dt = provider.ExecuteQuery(query);

            return dt.Rows.Count;
        }

        private void Button_ChangeInformation_Click(object sender, EventArgs e)
        {
            if (TextBox_Name.ReadOnly == false)
            {
                string query = $"update CUSTOMER " +
                    $"set CUSTOMER_NAME = N'{TextBox_Name.Text}', CUSTOMER_PHONE_NUMBER = '{TextBox_Phone.Text}', CUSTOMER_ADDRESS = N'{TextBox_Address.Text}' " +
                    $"where CUSTOMER_ID = '{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"]}'";

                DataProvider provider = new DataProvider();

                int success = provider.ExecuteNonQuery(query);

                TextBox_Name.ReadOnly = true;
                TextBox_Phone.ReadOnly = true;
                TextBox_Address.ReadOnly = true;
                openChildForm(new _07_Form_Personal_Information());
                CreateResources.Variables.Update_DataTableAccount(CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString());
            }
            else
            {
                TextBox_Name.ReadOnly = false;
                TextBox_Phone.ReadOnly = false;
                TextBox_Address.ReadOnly = false;

                TextBox_Name.ForeColor = Color.Silver;
                TextBox_Phone.ForeColor = Color.Silver;
                TextBox_Address.ForeColor = Color.Silver;
            }
        }
    }
}
