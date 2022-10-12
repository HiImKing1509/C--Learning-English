using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using LearningEnglish.Properties;
using System.Media;

namespace LearningEnglish
{
	internal class GlobalResources
	{
		public static SoundPlayer soundButton = new SoundPlayer("button.wav");
		public static SoundPlayer soundMusic = new SoundPlayer("music.wav");
		private static string yourName = "";
		public static string YourName
		{
			get { return yourName; }
			set { yourName = value; }
		}

		#region Colors
		public static string SunSetOrange = "#FA5F55";
		public static string SafetyOrange = "#FF5F15";
		public static string OrangeRoughy = "#D85519";
		public static string MattleBlack = "#28282B";
		public static string Poppy = "#E35335";
		public static string IrishCoffee = "#633725";
		public static string Lotus = "#87413E";
		#endregion

		#region DataTable
		public static DataTable DatatableFruits = new DataTable();
		public static DataTable DatatableAnimals = new DataTable();
		public static DataTable DatatableCountries = new DataTable();
		public static DataTable DatatableOccupations = new DataTable();
		public static DataTable DatatableSports = new DataTable();
		public static DataTable DatatableSubjects = new DataTable();
		public static DataTable DatatableRes = new DataTable();

		public static string btnLearning = "Animals";

		public static string ButtonLearning
		{
			get
			{
				return btnLearning;
			}
			set
			{
				btnLearning = value;
			}
		}

		public static DataTable DatatableResult
		{
			get
			{
				return DatatableRes;
			}
			set
			{
				DatatableRes = value;
			}
		}
		#endregion

		#region DatatableTopic
		private static DataTable DtTopic = new DataTable();
		public static DataTable DatatableTopic
		{
			get
			{
				return DtTopic;
			}
			set
			{
				DtTopic = value;
			}
		}
		#endregion

		#region DatatableLoaded
		private static bool dtLoaded = false;
		public static bool DatatableLoaded
		{
			get
			{
				return dtLoaded;
			}
			set
			{
				dtLoaded = value;
			}
		}
		#endregion

		#region TopicResourceManager

		private static ResourceManager rm = Resources.ResourceManager;
		public static ResourceManager TopicResourceManager
		{
			get
			{
				return rm;
			}
			set
			{
				rm = value;
			}
		}
		#endregion

		private static string engName = "";
		private static string vietName = "";
		private static int numRows = 0;
		private static int max = 23;
		private static int[] array = new int[] { };
		public static string EnglishName
		{
			get { return engName; }
			set { engName = value; }
		}
		public static string VietnameseName
		{
			get { return vietName; }
			set { vietName = value; }
		}

		public static int NumberRowsDataTable
		{
			get { return numRows; }
			set { numRows = value; }
		}

		public static int MaxResult
		{
			get { return max; }
			set { max = value; }
		}

		public static int[] ArrayID
		{
			get { return array; }
			set { array = value; }
		}

		public static void SetTimeout(Action action, int timeout)
		{
			var timer = new System.Windows.Forms.Timer();
			timer.Interval = timeout;
			timer.Tick += (s, e) =>
			{
				action();
				timer.Stop();
			};
			timer.Start();
		}

		public static void CommonMethod(ref int theSettingItself, int theValueOfTheSetting)
		{
			theSettingItself = theValueOfTheSetting;
			Properties.Settings.Default.Save();
		}

		public static void SaveToCSV(DataTable dt, string filename)
		{
			StringBuilder sb = new StringBuilder();

			IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().
											  Select(column => column.ColumnName);
			sb.AppendLine(string.Join(",", columnNames));

			foreach (DataRow row in dt.Rows)
			{
				IEnumerable<string> fields = row.ItemArray.Select(field => field!.ToString())!;
				sb.AppendLine(string.Join(",", fields));
			}

			File.WriteAllText(filename, sb.ToString());
		}

		public static DataTable ConvertCSVtoDataTable(string strFilePath)
		{
			DataTable dt = new DataTable();
			using (StreamReader sr = new StreamReader(strFilePath))
			{
				string[] headers = sr.ReadLine()!.Split(',');
				foreach (string header in headers)
				{
					dt.Columns.Add(header);
				}
				while (!sr.EndOfStream)
				{
					string[] rows = sr.ReadLine()!.Split(',');
					DataRow dr = dt.NewRow();
					for (int i = 0; i < headers.Length; i++)
					{
						dr[i] = rows[i];
					}
					dt.Rows.Add(dr);
				}

			}
			return dt;
		}
	}
}
