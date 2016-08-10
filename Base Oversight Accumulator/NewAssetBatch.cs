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
        
        public NewAssetBatch()
        {
            InitializeComponent();
        }

        private void AddBatchButton_Click(object sender, EventArgs e)
        {

            String s = String.Empty;
            foreach (string str in AssetBatchInput.Lines)
            {
                s = str;
                string batch = RemoveSpecialCharacters(s).ToUpper();
                //  MessageBox.Show(result);
                dbconnect mysql = new dbconnect();

                string query = "INSERT INTO assets(item, manufacturer, model, serialnumber, accountnumber, organization, ec, building, room, value, notes) VALUES ('" +
                                item + "','" + manufacturer+ "','" +
                                model + "','" + batch + "','" + owner + "','" + org + "','" +
                                ec + "','" + bldg + "','" + room+ "','" + value + "','" + notes + "')";

                mysql.insert(query);
                this.Close();
            }
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
    }
}
