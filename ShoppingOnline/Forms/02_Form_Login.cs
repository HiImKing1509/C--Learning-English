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
    public partial class _02_Form_Login : Form
    {
        public _02_Form_Login()
        {
            InitializeComponent();
            PanelLogin.BottomColor = CreateResources.Variables.MaastrichtBlue;
            PanelLogin.TopColor = CreateResources.Variables.MetallicYellow;
            PanelLogin.Angle = 30;
            
            ButtonLogin.BackColor = CreateResources.Variables.MaastrichtBlue;
        }

        private void TextBoxAccount_Enter(object sender, EventArgs e)
        {
            LabelErrorLogin.Visible = false;
            if (TextBoxAccount.Text == "Tài khoản" && TextBoxAccount.ForeColor == Color.Silver)
            {
                TextBoxAccount.Text = "";
                TextBoxAccount.ForeColor = Color.Black;
            }
        }

        private void TextBoxAccount_Leave(object sender, EventArgs e)
        {
            if (TextBoxAccount.Text == "")
            {
                TextBoxAccount.Text = "Tài khoản";
                TextBoxAccount.ForeColor = Color.Silver;
            }
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            LabelErrorLogin.Visible = false;
            if (TextBoxPassword.Text == "Mật khẩu" && TextBoxPassword.ForeColor == Color.Silver)
            {
                TextBoxPassword.UseSystemPasswordChar = true;
                TextBoxPassword.Text = "";
                TextBoxPassword.ForeColor = Color.Black;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "")
            {
                TextBoxPassword.UseSystemPasswordChar = false;
                TextBoxPassword.Text = "Mật khẩu";
                TextBoxPassword.ForeColor = Color.Silver;
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string query = $"select * " +
                "from CUSTOMER " +
                $"where CUSTOMER.CUSTOMER_ACCOUNT = '{TextBoxAccount.Text}' COLLATE SQL_Latin1_General_CP1_CS_AS " +
                $"and CUSTOMER.CUSTOMER_PASSWORD = '{TextBoxPassword.Text}' COLLATE SQL_Latin1_General_CP1_CS_AS";
            DataProvider provider = new DataProvider();
            CreateResources.Variables.DataTableAccount = provider.ExecuteQuery(query);
            if (CreateResources.Variables.DataTableAccount.Rows.Count > 0)
            {
                Form HomeForm = new _03_Form_Home();
                Hide();
                HomeForm.Show();
            }
            else
            {
                LabelErrorLogin.Visible = true;
                TextBoxPassword.UseSystemPasswordChar = false;
                TextBoxPassword.Text = "Mật khẩu";
                TextBoxPassword.ForeColor = Color.Silver;
            }
            CreateResources.Variables.getNumberOfComment();
        }

        private void ButtonLogin_MouseEnter(object sender, EventArgs e)
        {
            ButtonLogin.BackColor = CreateResources.Variables.MetallicYellow;
        }

        private void ButtonLogin_MouseLeave(object sender, EventArgs e)
        {
            ButtonLogin.BackColor = CreateResources.Variables.MaastrichtBlue;
        }

        private void ButtonExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
