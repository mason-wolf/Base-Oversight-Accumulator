using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_Oversight_Accumulator
{
    public partial class NewAssetBatch : Form
    {
        public string UserAddingAssetBatch { get; set; }
        public string item { get; set; }
        public string manufacturer { get; set; }
        public string model { get; set; }
        public string serialnumber { get; set; }
        public string owner { get; set;}
        public string org { get; set; }
        public string ec { get; set; }
        public string bldg { get; set; }
        public string room { get; set; }
        public string value { get; set; }
        public string notes { get; set; }
        dbconnect mysql = new dbconnect();
        public NewAssetBatch()
        {
            InitializeComponent();
        }

        private void AddBatchButton_Click(object sender, EventArgs e)
        {

            String s = String.Empty;
            int ItemCount = 0;
            foreach (string str in AssetBatchInput.Lines)
            {
                s = str;
                ItemCount++;
                string batch = RemoveSpecialCharacters(s).ToUpper();
                //  MessageBox.Show(result);

                string BatchAssets = "INSERT INTO assets(item, manufacturer, model, serialnumber, accountnumber, organization, ec, building, room, value, notes) VALUES ('" +
                                item + "','" + manufacturer+ "','" +
                                model + "','" + batch + "','" + owner + "','" + org + "','" +
                                ec + "','" + bldg + "','" + room+ "','" + value + "','" + notes + "')";
                mysql.InsertQuery(BatchAssets);
                this.Close();
            }
            string LogItem = item + " " + manufacturer + " " + model;
            string NewAssetLog = "INSERT INTO log (date, who, action) VALUES ('" + DateTime.Now.ToString() + "','" + this.UserAddingAssetBatch + "','CREATED " + ItemCount + " NEW ASSETS (" + LogItem.ToUpper() + ") FOR ACCOUNT " + owner + " ASSIGNED TO " + ec + "')";
            mysql.InsertQuery(NewAssetLog);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private void NewAssetBatch_Load(object sender, EventArgs e)
        {

        }
    }
}
