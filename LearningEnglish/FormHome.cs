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
using LearningEnglish.Properties;

namespace LearningEnglish
{
	public partial class FormHome : Form
	{
		private Form? activeForm = null;
		public FormHome()
		{
			InitializeComponent();
			// Set default
			//PanelBorderBottom.Visible = false;
			this.WindowState = FormWindowState.Maximized;
			ResourceManager rm = Resources.ResourceManager;
			Bitmap myImage = (Bitmap)rm.GetObject("wood_background_6")!;
			Bitmap displayImage = (Bitmap)rm.GetObject("wood_background_11")!;
			Bitmap displaySound = (Bitmap)rm.GetObject("wood_background_15")!;
			panelContent.BackgroundImage = myImage;
			panelDisplayName.BackgroundImage = displayImage;
			Music.BackgroundImage = displaySound;
			panelContent.BackgroundImageLayout = ImageLayout.Stretch;
			panelDisplayName.BackgroundImageLayout = ImageLayout.Stretch;
			Music.BackgroundImageLayout = ImageLayout.Stretch;
			labelDisplayName.Text = GlobalResources.YourName;
			GlobalResources.soundMusic.PlayLooping();
			// Init
		}

		#region Global Function
		private void openChildForm(Form childForm)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;

			panelContent.Controls.Add(childForm);
			panelContent.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}
		#endregion 

		#region Button Home
		private void ButtonHome_MouseEnter(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			btn.BackColor = Color.Transparent;
		}

		private void ButtonHome_MouseLeave(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			btn.BackColor = Color.Transparent;
		}
		private void ButtonHome_Click(object sender, EventArgs e)
		{
			GlobalResources.soundButton.Play();
			labelTitle.Text = "Lists and Topics";
			if (activeForm != null)
				activeForm.Close();
		}
		#endregion
		
		#region Button Exit
		private void ButtonExit_Click(object sender, EventArgs e)
		{
			Form formMain = new FormMain();
			this.Close();
			formMain.Show();
		}
		#endregion

		#region Button Fruits
		#endregion

		#region Control Button
		private void ButtonWindowClose_MouseEnter(object sender, EventArgs e)
		{
			ButtonWindowClose.BackColor = Color.Red;
		}

		private void ButtonWindowClose_MouseLeave(object sender, EventArgs e)
		{
			ButtonWindowClose.BackColor = Color.Transparent;
		}
		private void ButtonWindowMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		private void ButtonWindowMinimize_MouseEnter(object sender, EventArgs e)
		{
			ButtonWindowMinimize.BackColor = Color.SaddleBrown;
		}

		private void ButtonWindowMinimize_MouseLeave(object sender, EventArgs e)
		{
			ButtonWindowMinimize.BackColor = Color.Transparent;
		}

		private void ButtonWindowMaximum_MouseEnter(object sender, EventArgs e)
		{
			ButtonWindowMaximum.BackColor = Color.SaddleBrown;
		}

		private void ButtonWindowMaximum_MouseLeave(object sender, EventArgs e)
		{
			ButtonWindowMaximum.BackColor = Color.Transparent;
		}

		private void ButtonWindowMaximum_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Normal)
				this.WindowState = FormWindowState.Maximized;
			else
				this.WindowState = FormWindowState.Normal;
		}

		private void ButtonWindowClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		#endregion

		private void labelButtonHome_Click(object sender, EventArgs e)
		{
			GlobalResources.soundButton.Play();
			labelTitle.Text = "Lists and Topics";
			if (activeForm != null)
				activeForm.Close();
		}

		private void labelButtonFruits_Click(object sender, EventArgs e)
		{
			GlobalResources.soundButton.Play();
			GlobalResources.TopicResourceManager = ImageFruits.ResourceManager;
			GlobalResources.DatatableTopic = GlobalResources.DatatableFruits;
			GlobalResources.ButtonLearning = labelButtonFruits.Text;
			//GlobalResources.ConvertCSVtoDataTable(labelButtonFruits.Text + ".csv");
			openChildForm(new FormPlayGame());
			labelTitle.Text = labelButtonFruits.Text;
			panelRenderContent.AutoScroll = false;
		}
		private void labelButtonFruits_MouseEnter(object sender, EventArgs e)
		{
			Label lb = (Label)sender;
			lb.ForeColor = Color.BurlyWood;
		}

		private void labelButtonFruits_MouseLeave(object sender, EventArgs e)
		{
			Label lb = (Label)sender;
			lb.ForeColor = Color.Gold;
		}

		private void labelButtonAnimals_Click(object sender, EventArgs e)
		{
			GlobalResources.soundButton.Play();
			GlobalResources.TopicResourceManager = ImageAnimals.ResourceManager;
			GlobalResources.DatatableTopic = GlobalResources.DatatableAnimals;
			GlobalResources.ButtonLearning = labelButtonAnimals.Text;
			//GlobalResources.ConvertCSVtoDataTable(labelButtonAnimals.Text + ".csv");
			openChildForm(new FormPlayGame());
			labelTitle.Text = labelButtonAnimals.Text;
			panelRenderContent.AutoScroll = false;
		}

		private void labelButtonCountries_Click(object sender, EventArgs e)
		{
			GlobalResources.soundButton.Play();
			GlobalResources.TopicResourceManager = ImageCountries.ResourceManager;
			GlobalResources.DatatableTopic = GlobalResources.DatatableCountries;
			GlobalResources.ButtonLearning = labelButtonCountries.Text;
			//GlobalResources.ConvertCSVtoDataTable(labelButtonCountries.Text + ".csv");

			openChildForm(new FormPlayGame());
			labelTitle.Text = labelButtonCountries.Text;
			panelRenderContent.AutoScroll = false;
		}

		private void labelButtonOccupations_Click(object sender, EventArgs e)
		{
			GlobalResources.soundButton.Play();
			GlobalResources.TopicResourceManager = ImageOccupations.ResourceManager;
			GlobalResources.DatatableTopic = GlobalResources.DatatableOccupations;
			GlobalResources.ButtonLearning = labelButtonOccupations.Text;
			//GlobalResources.ConvertCSVtoDataTable(labelButtonOccupations.Text + ".csv");

			openChildForm(new FormPlayGame());
			labelTitle.Text = labelButtonOccupations.Text;
			panelRenderContent.AutoScroll = false;
		}

		private void labelButtonSports_Click(object sender, EventArgs e)
		{
			GlobalResources.soundButton.Play();
			GlobalResources.TopicResourceManager = ImageSports.ResourceManager;
			GlobalResources.DatatableTopic = GlobalResources.DatatableSports;
			GlobalResources.ButtonLearning = labelButtonSports.Text;
			//GlobalResources.ConvertCSVtoDataTable(labelButtonSports.Text + ".csv");
			openChildForm(new FormPlayGame());
			labelTitle.Text = labelButtonSports.Text;
			panelRenderContent.AutoScroll = false;
		}

		private void labelButtonSubjects_Click(object sender, EventArgs e)
		{
			GlobalResources.soundButton.Play();
			GlobalResources.TopicResourceManager = ImageSubjects.ResourceManager;
			GlobalResources.ButtonLearning = labelButtonSubjects.Text;
			GlobalResources.DatatableTopic = GlobalResources.DatatableSubjects;
			//GlobalResources.ConvertCSVtoDataTable(labelButtonSubjects.Text + ".csv");
			openChildForm(new FormPlayGame());
			labelTitle.Text = labelButtonSubjects.Text;
			panelRenderContent.AutoScroll = false;
		}

		private void labelButtonRanking_Click(object sender, EventArgs e)
		{
			/*GlobalResources.soundButton.Play();*/
			openChildForm(new FormRanking());
			labelTitle.Text = labelButtonRanking.Text;
			panelRenderContent.AutoScroll = false;
		}

		private void labelButtonExit_Click(object sender, EventArgs e)
		{
			GlobalResources.soundButton.Play();
			Form fLoad = new FormMain();
			this.Hide();
			fLoad.Show();
		}

		private void labelButtonLearning_Click(object sender, EventArgs e)
		{
			GlobalResources.soundButton.Play();
			openChildForm(new FormLearning());
			labelTitle.Text = labelButtonLearning.Text;
			panelRenderContent.AutoScroll = false;
		}

		private void Music_Click(object sender, EventArgs e)
		{
			if (Music.IconChar == FontAwesome.Sharp.IconChar.VolumeUp)
			{
				Music.IconChar = FontAwesome.Sharp.IconChar.VolumeMute;
				GlobalResources.soundMusic.Stop();
			}
			else 
			{
				Music.IconChar = FontAwesome.Sharp.IconChar.VolumeUp;
				GlobalResources.soundMusic.PlayLooping();
			}
		}
	}
}