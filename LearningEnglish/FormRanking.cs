using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LearningEnglish.Properties;
using System.Resources;



namespace LearningEnglish
{
	public partial class FormRanking : Form
	{
		public FormRanking()
		{
			InitializeComponent();
			ResourceManager rm = Resources.ResourceManager;
			Bitmap myImage = (Bitmap)rm.GetObject("wood_background_19")!;
			panelRankingContent.BackgroundImage = myImage;
			panelRankingContent.BackgroundImageLayout = ImageLayout.Stretch;
		}

		private void FormRanking_Load(object sender, EventArgs e)
		{
			LoadRanking(labelRankingAnimals.Text + ".csv");
		}

		private void labelRankingFruits_MouseEnter(object sender, EventArgs e)
		{
			Label lb = (Label)sender;
			lb.ForeColor = Color.FromArgb(255, 255, 128);
		}

		private void labelRankingFruits_MouseLeave(object sender, EventArgs e)
		{
			Label lb = (Label)sender;
			lb.ForeColor = Color.FromArgb(64, 0, 0);
		}

		private void labelRankingAnimals_Click(object sender, EventArgs e)
		{
			GlobalResources.soundButton.Play();
			LoadRanking(labelRankingAnimals.Text + ".csv");
		}

		private void labelRankingSports_Click(object sender, EventArgs e)
		{
			GlobalResources.soundButton.Play();
			LoadRanking(labelRankingSports.Text + ".csv");
		}

		private void labelRankingOccupations_Click(object sender, EventArgs e)
		{
			GlobalResources.soundButton.Play();
			LoadRanking(labelRankingOccupations.Text + ".csv");
		}

		private void labelRankingFruits_Click(object sender, EventArgs e)
		{
			GlobalResources.soundButton.Play();
			LoadRanking(labelRankingFruits.Text + ".csv");
		}

		private void labelRankingCountries_Click(object sender, EventArgs e)
		{
			GlobalResources.soundButton.Play();
			LoadRanking(labelRankingCountries.Text + ".csv");
		}

		private void labelRankingSubjects_Click(object sender, EventArgs e)
		{
			GlobalResources.soundButton.Play();
			LoadRanking(labelRankingSubjects.Text + ".csv");
		}

		private void LoadRanking(string filename)
		{
			DataTable data = GlobalResources.ConvertCSVtoDataTable(filename);

			DataTable dtCloned = data.Clone();
			dtCloned.Columns["Score"]!.DataType = Type.GetType("System.Int32");
			foreach (DataRow row in data.Rows)
				dtCloned.ImportRow(row);
			dtCloned.AcceptChanges();
			dtCloned.DefaultView.Sort = "Score DESC";
			DataTable datasort = dtCloned.DefaultView.ToTable();
			DataTable datacopy = datasort.AsEnumerable().Take(5).CopyToDataTable();
			int i = 1;
			foreach (DataRow row in datacopy.Rows)
			{
				string score = row["Score"].ToString()!;
				string name = row["Name"].ToString()!;
				if (i == 1)
				{
					LabelScoreTop1.Text = score;
					LabelNameTop1.Text = name;
				}
				else if (i == 2)
				{
					LabelScoreTop2.Text = score;
					LabelNameTop2.Text = name;
				}
				else if (i == 3)
				{
					LabelScoreTop3.Text = score;
					LabelNameTop3.Text = name;
				}
				else if (i == 4)
				{
					LabelScoreTop4.Text = score;
					LabelNameTop4.Text = name;
				}
				else
				{
					LabelScoreTop5.Text = score;
					LabelNameTop5.Text = name;
				}
				i++;
			}
		}
	}
}
