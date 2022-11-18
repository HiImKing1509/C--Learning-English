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
    public partial class _08_Form_Change_Password : Form
    {
        string cur_password = "";
        private Form activeForm = null;
        public _08_Form_Change_Password()
        {
            InitializeComponent();
            Panel_ChangePassword.BottomColor = CreateResources.Variables.MetallicYellow;
            Panel_ChangePassword.TopColor = CreateResources.Variables.MaastrichtBlue;
            Panel_ChangePassword.Angle = 210;

            Panel_ChangePasswordDetail.BackColor = CreateResources.Variables.MaastrichtBlue;

            Label_ChangePassword.ForeColor = CreateResources.Variables.MaastrichtBlue;

            // Get Password
            string query = $"select [CUSTOMER_PASSWORD] from CUSTOMER where CUSTOMER_ID = '{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"]}'";
            DataProvider provider = new DataProvider();

            DataTable dt = provider.ExecuteQuery(query);
            cur_password = dt.Rows[0]["CUSTOMER_PASSWORD"].ToString();
        }

        private void TextBox_Name_Enter(object sender, EventArgs e)
        {
            if (TextBox_Name.Text == "Nhập mật khẩu cũ" && TextBox_Name.ForeColor == Color.Silver)
            {
                TextBox_Name.Text = "";
                TextBox_Name.ForeColor = Color.Black;
            }
        }

        private void TextBox_Name_Leave(object sender, EventArgs e)
        {
            if (TextBox_Name.Text == "")
            {
                TextBox_Name.Text = "Nhập mật khẩu cũ";
                TextBox_Name.ForeColor = Color.Silver;
            }
        }

        private void TextBox_Phone_Enter(object sender, EventArgs e)
        {
            if (TextBox_Phone.Text == "Nhập mật khẩu mới" && TextBox_Phone.ForeColor == Color.Silver)
            {
                TextBox_Phone.Text = "";
                TextBox_Phone.ForeColor = Color.Black;
            }
        }

        private void TextBox_Phone_Leave(object sender, EventArgs e)
        {
            if (TextBox_Phone.Text == "")
            {
                TextBox_Phone.Text = "Nhập mật khẩu mới";
                TextBox_Phone.ForeColor = Color.Silver;
            }
        }

        private void TextBox_ConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (TextBox_ConfirmPassword.Text == "Xác nhận mật khẩu mới" && TextBox_ConfirmPassword.ForeColor == Color.Silver)
            {
                TextBox_ConfirmPassword.Text = "";
                TextBox_ConfirmPassword.ForeColor = Color.Black;
            }
        }

        private void TextBox_ConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (TextBox_ConfirmPassword.Text == "")
            {
                TextBox_ConfirmPassword.Text = "Xác nhận mật khẩu mới";
                TextBox_ConfirmPassword.ForeColor = Color.Silver;
            }
        }

        private void Button_ChangePassword_Click(object sender, EventArgs e)
        {
            if (Button_ChangePassword.BackColor == Color.Green)
            {
                string query = $"update CUSTOMER " +
                    $"set CUSTOMER_PASSWORD = '{TextBox_Phone.Text}' " +
                    $"where CUSTOMER_ID = '{CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"]}'";
                DataProvider provider = new DataProvider();

                int success = provider.ExecuteNonQuery(query);
                CreateResources.Variables.Update_DataTableAccount(CreateResources.Variables.DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString());
                openChildForm(new _08_Form_Change_Password());
            }
        }

        private void Update_Button_Status()
        {
            if (TextBox_Name.Text == cur_password && TextBox_Phone.Text == TextBox_ConfirmPassword.Text)
            {
                Button_ChangePassword.BackColor = Color.Green;
            }
        }

        private void TextBox_Name_TextChanged(object sender, EventArgs e)
        {
            Update_Button_Status();
        }

        private void TextBox_Phone_TextChanged(object sender, EventArgs e)
        {
            Update_Button_Status();
        }

        private void TextBox_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            Update_Button_Status();
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
