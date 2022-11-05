using LearningEnglish.Properties;
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
using System.Reflection;

namespace LearningEnglish
{
    public partial class FormLearning : Form
    {
        public FormLearning()
        {
            InitializeComponent();
            ResourceManager rm = Resources.ResourceManager;
            Bitmap myImage = (Bitmap)rm.GetObject("wood_background_19")!;
            panelLearningContent.BackgroundImage = myImage;
            panelLearningContent.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void labelLearningAnimals_MouseEnter(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.ForeColor = Color.BurlyWood;
        }

        private void labelLearningAnimals_MouseLeave(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.ForeColor = Color.Gold;
        }

        private void FormLearning_Load(object sender, EventArgs e)
        {
            flowLayoutPanelLearning.Controls.Clear();
            LoadingFlowLayoutPanel("Animals");
        }

        private void LoadingFlowLayoutPanel(string text)
        {
            ResourceManager Animals = new ResourceManager("LearningEnglish.ImageAnimals", Assembly.GetExecutingAssembly());
            ResourceManager Occupations = new ResourceManager("LearningEnglish.ImageOccupations", Assembly.GetExecutingAssembly());
            ResourceManager Sports = new ResourceManager("LearningEnglish.ImageSports", Assembly.GetExecutingAssembly());
            ResourceManager Fruits = new ResourceManager("LearningEnglish.ImageFruits", Assembly.GetExecutingAssembly());
            ResourceManager Subjects = new ResourceManager("LearningEnglish.ImageSubjects", Assembly.GetExecutingAssembly());
            ResourceManager Countries = new ResourceManager("LearningEnglish.ImageCountries", Assembly.GetExecutingAssembly());

            DataTable data = new DataTable();
            switch (text)
            {
                case "Animals":
                    data = GlobalResources.DatatableAnimals;
                    break;
                case "Occupations":
                    data = GlobalResources.DatatableOccupations;
                    break;
                case "Sports":
                    data = GlobalResources.DatatableSports;
                    break;
                case "Fruits":
                    data = GlobalResources.DatatableFruits;
                    break;
                case "Subjects":
                    data = GlobalResources.DatatableSubjects;
                    break;
                case "Countries":
                    data = GlobalResources.DatatableCountries;
                    break;
                default:
                    data = GlobalResources.DatatableAnimals;
                    break;
            }
            foreach (DataRow row in data.Rows)
            {
                Button btns = new Button() { Width = this.Width, Height = 200 };
                btns.Text = row["English"].ToString(); /*+ Environment.NewLine + row["Vn"].ToString()*/;
                btns.TextAlign = ContentAlignment.MiddleCenter;
                btns.Font = new Font("UTM Cookies", 28, FontStyle.Bold);
                btns.ForeColor = Color.Gold;
                btns.BackColor = Color.White;
                btns.Anchor = AnchorStyles.Left;
                btns.Anchor = AnchorStyles.Right;
                btns.FlatAppearance.BorderSize = 0;

                int w = 200;
                int h = 200;
                Bitmap bm = new Bitmap(w, h);
                Graphics g = Graphics.FromImage(bm);

                switch (text)
                {
                    case "Animals":
                        g.DrawImage((Image)Animals.GetObject(btns.Text!)!, 0, 0, w, h);
                        break;
                    case "Occupations":
                        g.DrawImage((Image)Occupations.GetObject(btns.Text!)!, 0, 0, w, h);
                        break;
                    case "Sports":
                        g.DrawImage((Image)Sports.GetObject(btns.Text!)!, 0, 0, w, h);
                        break;
                    case "Fruits":
                        g.DrawImage((Image)Fruits.GetObject(btns.Text!)!, 0, 0, w, h);
                        break;
                    case "Subjects":
                        g.DrawImage((Image)Subjects.GetObject(btns.Text!)!, 0, 0, w, h);
                        break;
                    case "Countries":
                        g.DrawImage((Image)Countries.GetObject(btns.Text!)!, 0, 0, w, h);
                        break;
                    default:
                        break;
                }
                g.Dispose();
                btns.Image = bm;
                btns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                //btns.TextImageRelation = TextImageRelation.ImageBeforeText;
                flowLayoutPanelLearning.Controls.Add(btns);
            }
        }

		private void labelLearningAnimals_Click(object sender, EventArgs e)
		{
            //GlobalResources.soundButton.Play();
            flowLayoutPanelLearning.Controls.Clear();
            LoadingFlowLayoutPanel(labelLearningAnimals.Text);
        }

		private void labelLearningOccupations_Click(object sender, EventArgs e)
		{
            //GlobalResources.soundButton.Play();
            flowLayoutPanelLearning.Controls.Clear();
            LoadingFlowLayoutPanel(labelLearningOccupations.Text);
        }

        private void labelLearningSports_Click(object sender, EventArgs e)
		{
            //GlobalResources.soundButton.Play();
            flowLayoutPanelLearning.Controls.Clear();
            LoadingFlowLayoutPanel(labelLearningSports.Text);
        }

        private void labelLearningFruits_Click(object sender, EventArgs e)
		{
            //GlobalResources.soundButton.Play();
            flowLayoutPanelLearning.Controls.Clear();
            LoadingFlowLayoutPanel(labelLearningFruits.Text);
        }

        private void labelLearningSubjects_Click(object sender, EventArgs e)
		{
            //GlobalResources.soundButton.Play();
            flowLayoutPanelLearning.Controls.Clear();
            LoadingFlowLayoutPanel(labelLearningSubjects.Text);
        }

        private void labelLearningCountries_Click(object sender, EventArgs e)
		{
            //GlobalResources.soundButton.Play();
            flowLayoutPanelLearning.Controls.Clear();
            LoadingFlowLayoutPanel(labelLearningCountries.Text);
        }
    }
}
