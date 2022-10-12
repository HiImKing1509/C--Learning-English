using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LearningEnglish.GlobalResources;

namespace LearningEnglish
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();

			// Init Properties
		}
		private void FormMain_Load(object sender, EventArgs e)
		{
			if (!GlobalResources.DatatableLoaded)
			{
				#region Datatable Fruits
				GlobalResources.DatatableFruits.Columns.Add("ID", typeof(string));
				GlobalResources.DatatableFruits.Columns.Add("English", typeof(string));
				GlobalResources.DatatableFruits.Columns.Add("Vietnamese", typeof(string));

				GlobalResources.DatatableFruits.Rows.Add("1", "Apple", "Quả táo");
				GlobalResources.DatatableFruits.Rows.Add("2", "Avocado", "Quả bơ");
				GlobalResources.DatatableFruits.Rows.Add("3", "Banana", "Quả chuối");
				GlobalResources.DatatableFruits.Rows.Add("4", "Coconut", "Quả dừa");
				GlobalResources.DatatableFruits.Rows.Add("5", "Durian", "Quả sầu riêng");
				GlobalResources.DatatableFruits.Rows.Add("6", "Guava", "Quả ổi");
				GlobalResources.DatatableFruits.Rows.Add("7", "Jackfruit", "Quả mít");
				GlobalResources.DatatableFruits.Rows.Add("8", "Kiwi", "Quả kiwi");
				GlobalResources.DatatableFruits.Rows.Add("9", "Lychee", "Quả vải");
				GlobalResources.DatatableFruits.Rows.Add("10", "Mango", "Quả xoài");
				GlobalResources.DatatableFruits.Rows.Add("11", "Orange", "Quả cam");
				GlobalResources.DatatableFruits.Rows.Add("12", "Pineapple", "Quả dứa");
				GlobalResources.DatatableFruits.Rows.Add("13", "Rambutan", "Quả chôm chôm");
				GlobalResources.DatatableFruits.Rows.Add("14", "Starfruit", "Quả khế");
				GlobalResources.DatatableFruits.Rows.Add("15", "Strawberry", "Quả dâu tây");
				#endregion

				#region Datatable Animals
				GlobalResources.DatatableAnimals.Columns.Add("ID", typeof(string));
				GlobalResources.DatatableAnimals.Columns.Add("English", typeof(string));
				GlobalResources.DatatableAnimals.Columns.Add("Vietnamese", typeof(string));

				GlobalResources.DatatableAnimals.Rows.Add("1", "Bear", "Con gấu");
				GlobalResources.DatatableAnimals.Rows.Add("2", "Elephent", "Con voi");
				GlobalResources.DatatableAnimals.Rows.Add("3", "Fox", "Con cáo");
				GlobalResources.DatatableAnimals.Rows.Add("4", "Giraffe", "Con hươu cao cổ");
				GlobalResources.DatatableAnimals.Rows.Add("5", "Hippopotamus", "Con hà mã");
				GlobalResources.DatatableAnimals.Rows.Add("6", "Lion", "Con sư tử");
				GlobalResources.DatatableAnimals.Rows.Add("7", "Rhinoceros", "Con tê giác");
				GlobalResources.DatatableAnimals.Rows.Add("8", "Squirrel", "Con sóc");
				GlobalResources.DatatableAnimals.Rows.Add("9", "Bat", "Con dơi");
				GlobalResources.DatatableAnimals.Rows.Add("10", "Wolf", "Con chó sói");
				GlobalResources.DatatableAnimals.Rows.Add("11", "Dolphin", "Con cá heo");
				GlobalResources.DatatableAnimals.Rows.Add("12", "Shark", "Con cá mập");
				GlobalResources.DatatableAnimals.Rows.Add("13", "Whale", "Con cá voi");
				GlobalResources.DatatableAnimals.Rows.Add("14", "Penguin", "Con chim cánh cụt");
				GlobalResources.DatatableAnimals.Rows.Add("15", "Turtle", "Con rùa");
				GlobalResources.DatatableAnimals.Rows.Add("16", "Bee", "Con ong");
				GlobalResources.DatatableAnimals.Rows.Add("17", "Cobra", "Con ong");
				GlobalResources.DatatableAnimals.Rows.Add("18", "Camel", "Con rắn hổ mang");
				GlobalResources.DatatableAnimals.Rows.Add("19", "Scorpion", "Con lạc đà");
				GlobalResources.DatatableAnimals.Rows.Add("20", "Hedgehog", "Con nhím");
				GlobalResources.DatatableAnimals.Rows.Add("21", "Zebra", "Con ngựa vằn");
				GlobalResources.DatatableAnimals.Rows.Add("22", "Jellyfish", "Con sứa");
				GlobalResources.DatatableAnimals.Rows.Add("23", "Squid", "Con mực");
				GlobalResources.DatatableAnimals.Rows.Add("24", "Starfish", "Con sao biển");
				GlobalResources.DatatableAnimals.Rows.Add("25", "Panda", "Con gấu trúc");
				#endregion

				#region Datatable Countries
				GlobalResources.DatatableCountries.Columns.Add("ID", typeof(string));
				GlobalResources.DatatableCountries.Columns.Add("English", typeof(string));
				GlobalResources.DatatableCountries.Columns.Add("Vietnamese", typeof(string));

				GlobalResources.DatatableCountries.Rows.Add("1", "Belgium", "Bỉ");
				GlobalResources.DatatableCountries.Rows.Add("2", "Denmark", "Đan Mạch");
				GlobalResources.DatatableCountries.Rows.Add("3", "England", "Anh");
				GlobalResources.DatatableCountries.Rows.Add("4", "Finland", "Phần Lan");
				GlobalResources.DatatableCountries.Rows.Add("5", "France", "Pháp");
				GlobalResources.DatatableCountries.Rows.Add("6", "Germany", "Đức");
				GlobalResources.DatatableCountries.Rows.Add("7", "Netherlands", "Hà Lan");
				GlobalResources.DatatableCountries.Rows.Add("8", "Russia", "Nga");
				GlobalResources.DatatableCountries.Rows.Add("9", "Spain", "Tây Ban Nha");
				GlobalResources.DatatableCountries.Rows.Add("10", "Sweden", "Thụy Điển");
				GlobalResources.DatatableCountries.Rows.Add("11", "Switzerland", "Thụy Sĩ");
				GlobalResources.DatatableCountries.Rows.Add("12", "Wales", "Xứ Wales");
				#endregion

				#region Datatable Occupations
				GlobalResources.DatatableOccupations.Columns.Add("ID", typeof(string));
				GlobalResources.DatatableOccupations.Columns.Add("English", typeof(string));
				GlobalResources.DatatableOccupations.Columns.Add("Vietnamese", typeof(string));

				GlobalResources.DatatableOccupations.Rows.Add("1", "Doctor", "Bác sĩ");
				GlobalResources.DatatableOccupations.Rows.Add("2", "Dentist", "Nha sĩ");
				GlobalResources.DatatableOccupations.Rows.Add("3", "Reporter", "Phóng viên");
				GlobalResources.DatatableOccupations.Rows.Add("4", "Tailor", "Thợ may");
				GlobalResources.DatatableOccupations.Rows.Add("5", "Teacher", "Giáo viên");
				GlobalResources.DatatableOccupations.Rows.Add("6", "Cook", "Đầu bếp");
				GlobalResources.DatatableOccupations.Rows.Add("7", "Magician", "Ảo thuật gia");
				GlobalResources.DatatableOccupations.Rows.Add("8", "Singer", "Ca sĩ");
				GlobalResources.DatatableOccupations.Rows.Add("9", "Artist", "Họa sĩ");
				GlobalResources.DatatableOccupations.Rows.Add("10", "Carpenter", "Thợ mộc");
				GlobalResources.DatatableOccupations.Rows.Add("11", "Secretary", "Thư kí");
				GlobalResources.DatatableOccupations.Rows.Add("12", "Policeman", "Cảnh sát");
				GlobalResources.DatatableOccupations.Rows.Add("13", "Hairdresser", "Thợ cắt tóc");
				GlobalResources.DatatableOccupations.Rows.Add("14", "Farmer", "Nông dân");
				GlobalResources.DatatableOccupations.Rows.Add("15", "Astronaut", "Phi hành gia");
				GlobalResources.DatatableOccupations.Rows.Add("16", "Architect", "Kiến trúc sư");
				GlobalResources.DatatableOccupations.Rows.Add("17", "Photographer", "Nhiếp ảnh gia");
				GlobalResources.DatatableOccupations.Rows.Add("18", "Lawyer", "Luật sư");
				GlobalResources.DatatableOccupations.Rows.Add("19", "Psychologist", "Nhà tâm lí học");
				GlobalResources.DatatableOccupations.Rows.Add("20", "Programmer", "Lập trình viên");
				GlobalResources.DatatableOccupations.Rows.Add("21", "Firefighter", "Lính cứu hỏa");
				GlobalResources.DatatableOccupations.Rows.Add("22", "Mailman", "Người đưa thư");
				GlobalResources.DatatableOccupations.Rows.Add("23", "Judge", "Thẩm phán");
				GlobalResources.DatatableOccupations.Rows.Add("24", "Pilot", "Phi công");
				#endregion

				#region Datatable Sports
				GlobalResources.DatatableSports.Columns.Add("ID", typeof(string));
				GlobalResources.DatatableSports.Columns.Add("English", typeof(string));
				GlobalResources.DatatableSports.Columns.Add("Vietnamese", typeof(string));

				GlobalResources.DatatableSports.Rows.Add("1", "Cycling", "Đạp xe");
				GlobalResources.DatatableSports.Rows.Add("2", "Gymnastics", "Thể dục dụng cụ");
				GlobalResources.DatatableSports.Rows.Add("3", "Athletics", "Điền kinh");
				GlobalResources.DatatableSports.Rows.Add("4", "Weighlifting", "Cử tạ");
				GlobalResources.DatatableSports.Rows.Add("5", "Boxing", "Quyền anh");
				GlobalResources.DatatableSports.Rows.Add("6", "Archery", "Bắn cung");
				GlobalResources.DatatableSports.Rows.Add("7", "Fencing", "Đấu kiếm");
				GlobalResources.DatatableSports.Rows.Add("8", "Tennis", "Quần vợt");
				GlobalResources.DatatableSports.Rows.Add("9", "Swimming", "Bơi lội");
				GlobalResources.DatatableSports.Rows.Add("10", "Volleyball", "Bóng chuyền");
				GlobalResources.DatatableSports.Rows.Add("11", "Football", "Bóng đá");
				GlobalResources.DatatableSports.Rows.Add("12", "Basketball", "Bóng rổ");
				GlobalResources.DatatableSports.Rows.Add("13", "Baseball", "Bóng chày");
				GlobalResources.DatatableSports.Rows.Add("14", "Badminton", "Cầu lông");
				GlobalResources.DatatableSports.Rows.Add("15", "Snooker", "Bi-a");
				#endregion

				#region Datatable Subjects
				GlobalResources.DatatableSubjects.Columns.Add("ID", typeof(string));
				GlobalResources.DatatableSubjects.Columns.Add("English", typeof(string));
				GlobalResources.DatatableSubjects.Columns.Add("Vietnamese", typeof(string));

				GlobalResources.DatatableSubjects.Rows.Add("1", "Math", "Toán học");
				GlobalResources.DatatableSubjects.Rows.Add("2", "Algebra", "Đại số");
				GlobalResources.DatatableSubjects.Rows.Add("3", "Geometry", "Hình học");
				GlobalResources.DatatableSubjects.Rows.Add("4", "Physics", "Vật lý");
				GlobalResources.DatatableSubjects.Rows.Add("5", "Chemistry", "Hóa học");
				GlobalResources.DatatableSubjects.Rows.Add("6", "Biology", "Sinh học");
				GlobalResources.DatatableSubjects.Rows.Add("7", "Astronomy", "Thiên văn học");
				GlobalResources.DatatableSubjects.Rows.Add("8", "Literature", "Văn học");
				GlobalResources.DatatableSubjects.Rows.Add("9", "History", "Lịch sử");
				GlobalResources.DatatableSubjects.Rows.Add("10", "Geography", "Địa lý");
				GlobalResources.DatatableSubjects.Rows.Add("11", "Ethics", "Đạo đức");
				GlobalResources.DatatableSubjects.Rows.Add("12", "Probability", "Toán xác suất");
				GlobalResources.DatatableSubjects.Rows.Add("13", "Philosophy", "Triết học");
				GlobalResources.DatatableSubjects.Rows.Add("14", "Macroeconomics", "Kinh tế vĩ mô");
				GlobalResources.DatatableSubjects.Rows.Add("15", "Microeconomics", "Kinh tế vi mô");
				#endregion
				GlobalResources.DatatableLoaded = true;
			}
		}

		private void labelStart_Click(object sender, EventArgs e)
		{
			GlobalResources.soundButton.Play();

			if (labelStart.Text == "Play")
			{
				labelEnterYourNameError.Text = "Please enter name less than 8 characters!!!";
				if (TextBoxEnterYourName.Text.Length == 0)
				{
					labelEnterYourNameError.Text = "The Name cannot be blank !!!";
					labelEnterYourNameError.Visible = true;
					var action = new Action(() =>
					{
						labelEnterYourNameError.Visible = false;
					});
					GlobalResources.SetTimeout(action, 3000);
				}
				else if (TextBoxEnterYourName.Text.Length <= 8)
				{
					YourName = TextBoxEnterYourName.Text;
					Form formHome = new FormHome();
					this.Hide();
					formHome.Show();
					labelStart.Text = "Get Started";
				}
				else
				{
					labelEnterYourNameError.Visible = true;
					var action = new Action(() =>
					{
						labelEnterYourNameError.Visible = false;
					});
					GlobalResources.SetTimeout(action, 3000);
					TextBoxEnterYourName.Text = "";
				}
			}
			else
			{
				labelStart.Text = "Play";
				labelTitle2.Visible = false;
				labelTitle1.Text = "Enter your name";
				TextBoxEnterYourName.Visible = true;
			}
		}

		private void labelExit_Click(object sender, EventArgs e)
		{
			GlobalResources.soundButton.Play();
			Application.Exit();
		}

		private void labelStart_MouseEnter(object sender, EventArgs e)
		{
			Label lb = (Label)sender;
			lb.ForeColor = Color.BurlyWood;
		}

		private void labelStart_MouseLeave(object sender, EventArgs e)
		{
			Label lb = (Label)sender;
			lb.ForeColor = Color.Gold;
		}

		private void TextBoxEnterYourName_Enter(object sender, EventArgs e)
		{
			if (TextBoxEnterYourName.Text == "Enter" && TextBoxEnterYourName.ForeColor == Color.Silver)
			{
				TextBoxEnterYourName.Text = "";
				TextBoxEnterYourName.ForeColor = Color.Black;
			}
		}

		private void TextBoxEnterYourName_Leave(object sender, EventArgs e)
		{
			if (TextBoxEnterYourName.Text == "")
			{
				TextBoxEnterYourName.Text = "Enter";
				TextBoxEnterYourName.ForeColor = Color.Silver;
			}
		}

		private void TextBoxEnterYourName_KeyDown(object sender, KeyEventArgs e)
		{
			if (TextBoxEnterYourName.Visible && e.KeyCode == Keys.Enter)
			{
				labelStart_Click(this, new EventArgs());
			}
		}
	}
}
