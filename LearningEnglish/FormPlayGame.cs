using LearningEnglish.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LearningEnglish
{
	public partial class FormPlayGame : Form
	{
		int counter = 60;
		int start = 60;
		System.Windows.Forms.Timer timer1;
		Random r = new Random();
		Random random = new Random();
		SoundPlayer soundCorrect = new SoundPlayer("correct.wav");
		SoundPlayer soundIncorrect = new SoundPlayer("incorrect.wav");
		string matchImage = "";
		public FormPlayGame()
		{
			InitializeComponent();
			ResourceManager rm = Resources.ResourceManager;
			Bitmap displayBackgroundCurrentScore = (Bitmap)rm.GetObject("wood_background_10")!;
			panelShowCurentScore.BackgroundImage = displayBackgroundCurrentScore;
			panelShowCurentScore.BackgroundImageLayout = ImageLayout.Stretch;
			PictureBoxRenderImage.SizeMode = PictureBoxSizeMode.StretchImage;
			GlobalResources.NumberRowsDataTable = GlobalResources.DatatableTopic.Rows.Count;
			GlobalResources.ArrayID = Enumerable.Range(1, GlobalResources.NumberRowsDataTable).ToArray();
			GlobalResources.ArrayID = GlobalResources.ArrayID.OrderBy(x => random.Next()).ToArray();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			counter--;
			if (counter == 0)
				timer1.Stop();
			labelTime.Text = counter.ToString();
		}

		private void FormPlayGame_Load(object sender, EventArgs e)
		{
			InitImage();
			// Run time
			timer1 = new System.Windows.Forms.Timer();
			timer1.Tick += new EventHandler(timer1_Tick!);
			timer1.Interval = 1000; // 1 second
			timer1.Start();
			labelTime.Text = counter.ToString();
		}

		private void InitImage()
		{
			DataRow[] dr = GlobalResources.DatatableTopic.Select("ID='" + GlobalResources.ArrayID.Last().ToString() + "'");
			GlobalResources.ArrayID = GlobalResources.ArrayID.SkipLast(1).ToArray();
			foreach (DataRow row in dr)
			{
				GlobalResources.EnglishName = row["English"].ToString()!;
				GlobalResources.VietnameseName = row["Vietnamese"].ToString()!;
				matchImage = GlobalResources.EnglishName;
				labelShowHint.Text = GlobalResources.VietnameseName;
			}
			PictureBoxRenderImage.Image = (Bitmap)GlobalResources.TopicResourceManager.GetObject(matchImage)!;
		}

		private void TextBoxEnterResult_Enter(object sender, EventArgs e)
		{
			if (TextBoxEnterResult.Text == "Enter" && TextBoxEnterResult.ForeColor == Color.Silver)
			{
				TextBoxEnterResult.Text = "";
				TextBoxEnterResult.ForeColor = Color.Black;
			}
		}

		private void TextBoxEnterResult_Leave(object sender, EventArgs e)
		{
			if (TextBoxEnterResult.Text == "")
			{
				TextBoxEnterResult.Text = "Enter";
				TextBoxEnterResult.ForeColor = Color.Silver;
			}
		}

		private void TextBoxEnterResult_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && !panelShowScoreEndGame.Visible)
			{
				labelButtonCheckResult_Click(this, new EventArgs());
			}
		}

		private void labelButtonCheckResult_Click(object sender, EventArgs e)
		{
			if (TextBoxEnterResult.Text.ToLower() == matchImage.ToLower())
			{
				soundCorrect.Play();
				int end = counter;
				LabelCorrectScore.Text = (Convert.ToInt32(LabelCorrectScore.Text) + 1).ToString();
				labelCurrentScore.Text = (Convert.ToDouble(labelCurrentScore.Text) + Convert.ToDouble(60 / (start - end))).ToString();
				TextBoxEnterResult.BackColor = Color.LimeGreen;
				start = counter;
			}
			else if (TextBoxEnterResult.Text.ToLower() == "")
			{
				TextBoxEnterResult.BackColor = Color.Khaki;
				GlobalResources.SetTimeout(() => TextBoxEnterResult.BackColor = Color.White, 500);
			}
			else
			{
				LabelIncorrectScore.Text = (Convert.ToInt32(LabelIncorrectScore.Text) + 1).ToString();
				TextBoxEnterResult.BackColor = Color.Tomato;
				soundIncorrect.Play();
			}

			if (TextBoxEnterResult.Text != "")
			{
				var action = new Action(() =>
				{
					if (GlobalResources.ArrayID.Length > 0 && counter > 0) 
					{
						int rInt = GlobalResources.ArrayID.Last();
						GlobalResources.ArrayID = GlobalResources.ArrayID.SkipLast(1).ToArray();
						DataRow[] dr = GlobalResources.DatatableTopic.Select("ID='" + rInt.ToString() + "'");

						foreach (DataRow row in dr)
						{
							GlobalResources.EnglishName = row["English"].ToString()!;
							GlobalResources.VietnameseName = row["Vietnamese"].ToString()!;
							labelShowHint.Text = GlobalResources.VietnameseName;
						}
						panelShowHint.Visible = false;
						Bitmap myImage = (Bitmap)GlobalResources.TopicResourceManager.GetObject(GlobalResources.EnglishName)!;
						matchImage = GlobalResources.EnglishName;
						TextBoxEnterResult.BackColor = Color.White;
						PictureBoxRenderImage.Image = myImage;
						TextBoxEnterResult.Text = "";
					}
					else
					{
						timer1.Stop();
						panelShowHint.Visible = false;
						labelButtonCheckResult.Visible = false;
						labelButtonHintResult.Visible = false;
						TextBoxEnterResult.Visible = false;
						PictureBoxRenderImage.Visible = false;
						labelFinalScore.Text = labelCurrentScore.Text;
						panelShowScoreEndGame.Visible = true;
						DataTable dt = GlobalResources.ConvertCSVtoDataTable(GlobalResources.ButtonLearning + ".csv");
						dt.Rows.Add(GlobalResources.YourName, LabelCorrectScore.Text, LabelIncorrectScore.Text, labelFinalScore.Text, DateTime.Now);
						GlobalResources.SaveToCSV(dt, GlobalResources.ButtonLearning + ".csv");
					}
				});
				GlobalResources.SetTimeout(action, 500);
			}
		}

		private void labelButtonCheckResult_MouseEnter(object sender, EventArgs e)
		{
			labelButtonCheckResult.ForeColor = Color.DarkSeaGreen;
		}

		private void labelButtonCheckResult_MouseLeave(object sender, EventArgs e)
		{
			labelButtonCheckResult.ForeColor = Color.GreenYellow;
		}

		private void labelButtonHintResult_Click(object sender, EventArgs e)
		{
			panelShowHint.Visible = !panelShowHint.Visible;
			labelShowHint.Text = GlobalResources.VietnameseName;
			labelShowHint.Visible = true;
		}

		private void labelButtonHintResult_MouseEnter(object sender, EventArgs e)
		{
			labelButtonHintResult.ForeColor = Color.Khaki;
		}

		private void labelButtonHintResult_MouseLeave(object sender, EventArgs e)
		{
			labelButtonHintResult.ForeColor = Color.Gold;
		}

		private void labelShowHint_Click(object sender, EventArgs e)
		{
			if (labelShowHint.Text == GlobalResources.VietnameseName)
				labelShowHint.Text = GlobalResources.EnglishName;
			else
				labelShowHint.Text = GlobalResources.VietnameseName;
		}
	}
}
