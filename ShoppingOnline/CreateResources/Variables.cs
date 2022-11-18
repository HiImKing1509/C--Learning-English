using ShoppingOnline.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Resources;
using System.Reflection;
using ShoppingOnline.DAO;
using System.Net.NetworkInformation;

namespace ShoppingOnline.CreateResources
{
    public class Variables
    {
        #region Colors
        
        public static Color MaastrichtBlue = ColorTranslator.FromHtml("#0C1D36");
        public static Color MetallicYellow = ColorTranslator.FromHtml("#F9CC0B");
        public static Color CetaceanBlue = ColorTranslator.FromHtml("#00002E");

        #endregion

        public static ResourceManager rm_logo = new ResourceManager("ShoppingOnline.CreateResources.Image_Logo", Assembly.GetExecutingAssembly());
        public static ResourceManager rm_avatar = new ResourceManager("ShoppingOnline.CreateResources.Images_Avatar", Assembly.GetExecutingAssembly());
        public static ResourceManager rm_brand = new ResourceManager("ShoppingOnline.CreateResources.Images_Brand", Assembly.GetExecutingAssembly());
        public static ResourceManager rm_coats = new ResourceManager("ShoppingOnline.CreateResources.Images_Coats", Assembly.GetExecutingAssembly());
        public static ResourceManager rm_customer = new ResourceManager("ShoppingOnline.CreateResources.Images_Customer", Assembly.GetExecutingAssembly());
        public static ResourceManager rm_jean = new ResourceManager("ShoppingOnline.CreateResources.Images_Jean", Assembly.GetExecutingAssembly());
        public static ResourceManager rm_shirt = new ResourceManager("ShoppingOnline.CreateResources.Images_Shirt", Assembly.GetExecutingAssembly());
        public static ResourceManager rm_short = new ResourceManager("ShoppingOnline.CreateResources.Images_Short", Assembly.GetExecutingAssembly());
        public static ResourceManager rm_tshirt = new ResourceManager("ShoppingOnline.CreateResources.Images_TShirt", Assembly.GetExecutingAssembly());

        // DataTable Account
        private static DataTable dtAccount = new DataTable();
        public static DataTable DataTableAccount {get { return dtAccount; } set { dtAccount = value; }}

        // List Controls
        private static List<Control> listControls = new List<Control>();
        public static List<Control> ListControls {get { return listControls; } set { listControls = value; }}

        // The number of Receipt
        private static string numReceipt = "";
        private static string sumPrice = "0";
        private static string numberProduct = "0";
        private static string table = "All";
        public static string NumReceipt { get => numReceipt; set => numReceipt = value; }
        public static string SumPrice { get => sumPrice; set => sumPrice=value; }
        public static string NumberProduct { get => numberProduct; set => numberProduct=value; }
        public static string Table { get => table; set => table = value; }

        public static string stringProcessing(string price)
        {
            char[] charArray = price.ToCharArray();
            Array.Reverse(charArray);
            price = new string(charArray);
            string result = "";
            int i = 1;
            foreach (char p in price)
            {
                result += p;
                if (i++ % 3 == 0 && i <= price.Length)
                    result += ".";
            }
            char[] charArrayRev = result.ToCharArray();
            Array.Reverse(charArrayRev);
            return new string(charArrayRev);
        }

        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        public static string getNumberOfReceipt()
        {
            string query = $"select [RECEIPT_ID] from RECEIPT where RECEIPT_ID like 'RE{DataTableAccount.Rows[0]["CUSTOMER_ID"].ToString().Substring(2, 2)}%'";
            DataProvider provider = new DataProvider();

            DataTable get_receipt = provider.ExecuteQuery(query);

            int num_get_receipt = get_receipt.Rows.Count;
            if (num_get_receipt < 10)
                return "0" + (num_get_receipt + 1).ToString();
            else
                return (num_get_receipt + 1).ToString();
        }

        public static void Update_DataTableAccount(string id)
        {
            string query = $"select * " +
                        "from CUSTOMER " +
                        $"where CUSTOMER_ID = '{id}'";
            DataProvider provider = new DataProvider();
            DataTableAccount = provider.ExecuteQuery(query);
        }
    }
}
