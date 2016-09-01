using Base_Oversight_Accumulator.Properties;
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
                mysql.OpenConnection();
                mysql.SelectQuery("SELECT * from assets where serialnumber='" + batch + "'");
                if (!mysql.Result.Read())
                {
                    string BatchAssets = "INSERT INTO assets(item, manufacturer, model, serialnumber, accountnumber, organization, ec, building, room, value, notes) VALUES ('" +
                item + "','" + manufacturer + "','" +
                model + "','" + batch + "','" + owner + "','" + org + "','" +
                ec + "','" + bldg + "','" + room + "','" + value + "','" + notes + "')";

                    // update individual logs for items
                    string NewAssetLog = "INSERT INTO log (date, who, action, account) VALUES ('" + DateTime.Now.ToString() + "','" + this.UserAddingAssetBatch + "','CREATED NEW ASSET " + manufacturer.ToUpper() + " " + model.ToUpper() +
                       " WITH SERIAL NUMBER " + batch + " FOR ACCOUNT " + owner + " ASSIGNED TO " + ec + "', '" + owner + "')";

                    mysql.InsertQuery(BatchAssets);
                    mysql.InsertQuery(NewAssetLog);
                    this.Close();
                }
                else {
                    AssetBatchError.Visible = true;
                    AssetBatchError.Text = "Asset(s) already exist. Validate serial numbers before adding items.";
                }
                mysql.CloseConnection();
            }
            string LogItem = item + " " + manufacturer + " " + model;
            // update log to show that user added x amount of items
            string NewAssetsLog = "INSERT INTO log (date, who, action) VALUES ('" + DateTime.Now.ToString() + "','" + this.UserAddingAssetBatch + "','CREATED " + ItemCount + " NEW ASSETS (" + LogItem.ToUpper() + ") FOR ACCOUNT " + owner + " ASSIGNED TO " + ec + "')";


            mysql.InsertQuery(NewAssetsLog);
            mysql.CloseConnection();
            Settings.Default.WorkingCustodian = ec;
            Settings.Default.WorkingOrganization = org;
            Settings.Default.WorkingAccount = owner;
            Settings.Default.Save();

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
