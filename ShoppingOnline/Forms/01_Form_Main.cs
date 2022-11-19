using LearningEnglish;
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
    public partial class _01_Form_Main : Form
    {
        public _01_Form_Main()
        {
            InitializeComponent();

            // Initialization
            this.BackColor = CreateResources.Variables.MaastrichtBlue;
            WaitLoadingForm();
        }

        public async void WaitLoadingForm()
        {
            await Task.Delay(3000);
            Form LoginForm = new Forms._02_Form_Login();
            this.Hide();
            LoginForm.Show();
        }
    }
}
