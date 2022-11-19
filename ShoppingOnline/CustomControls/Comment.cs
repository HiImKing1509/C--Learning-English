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
using ShoppingOnline.DAO;

namespace ShoppingOnline.CustomControls
{
    public partial class Comment : UserControl
    {
        public Comment()
        {
            InitializeComponent();
        }
        public Comment(DataRow row) : this()
        {
            ResourceManager rm = CreateResources.Variables.rm_logo;
            Bitmap myImage = (Bitmap)rm.GetObject(row["CUSTOMER_ID"].ToString());
            PictureBox_Avatar.Image = myImage;
            Label_Name.Text = row["CUSTOMER_NAME"].ToString();
            Label_Date.Text = row["COMMENT_DATE"].ToString();
            Label_Comment.Text = row["COMMENT_CONTENT"].ToString();
            Button_Like.Text = row["COMMENT_LIKE"].ToString();
        }

        private void Button_Like_Click(object sender, EventArgs e)
        {
            int number_like = Convert.ToInt32(Button_Like.Text);
            string query = $"update COMMENT set COMMENT_LIKE = COMMENT_LIKE + 1 where COMMENT_ID = {Button_Like.Text}";
            DataProvider provider = new DataProvider();
            number_like++;
            int update = provider.ExecuteNonQuery(query);
            Button_Like.Text = number_like.ToString();
        }
    }
}
