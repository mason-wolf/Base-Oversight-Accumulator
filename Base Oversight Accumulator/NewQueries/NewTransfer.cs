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
    public partial class NewTransfer : Form
    {


        public string TransferedBy { get;  set; }

        public NewTransfer()
        {
            InitializeComponent();
        }

        private void TransferAssetButton_Click(object sender, EventArgs e)
        {

       
            // retrieve losing account details

            string LosingAccount = LosingAccountField.Text;

            dbconnect mysql = new dbconnect();
            mysql.SelectQuery("SELECT * FROM itam where account='" + LosingAccount + "'");


                while (mysql.Result.Read())
                {
                string account = mysql.Reader("account");
                string org = mysql.Reader("org");
                string ec = mysql.Reader("ec");

                    LosingAccountDetail.Text = account.ToUpper();
                    LosingOrgDetail.Text = org.ToUpper();
                    LosingECDetail.Text = ec.ToUpper();
            }
            mysql.CloseConnection();

            // gaining account details
            string GainingAccount = GainingAccountField.Text;

            mysql.OpenConnection();
            mysql.SelectQuery("SELECT * FROM itam where account='" + GainingAccount + "'");

            while (mysql.Result.Read())
            {
                string account = mysql.Reader("account");
                string org = mysql.Reader("org");
                string ec = mysql.Reader("ec");
                GainingAccountDetail.Text = account.ToUpper();
                GainingOrganizationDetail.Text = org.ToUpper();
                GainingECDetail.Text = ec.ToUpper();

            }
            mysql.CloseConnection();

            //asset details

            string SerialNumberTransfer = SerialNumberField.Text;

            mysql.OpenConnection();
            mysql.SelectQuery("SELECT * FROM assets where serialnumber='" + SerialNumberTransfer + "'");

            while (mysql.Result.Read())
            {
                string item = mysql.Reader("item");
                string manufacturer = mysql.Reader("manufacturer");
                string model = mysql.Reader("model");
                string serialnumber = mysql.Reader("serialnumber");

                AssetDetail.Text = item.ToUpper() + " " + manufacturer.ToUpper() + " " + model.ToUpper();
                SerialNumberDetail.Text = serialnumber.ToUpper();

            }

            mysql.CloseConnection();

            if(!String.IsNullOrEmpty(LosingAccountDetail.Text))
            {
                if(!String.IsNullOrEmpty(GainingAccountDetail.Text))
                {
                    if(!String.IsNullOrEmpty(SerialNumberDetail.Text))
                    {
                        TransferButton.Enabled = true;
                    }
                }
            }
       

        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            string notes = TransferNotesField.Text;

            if (MessageBox.Show("Are you sure you want to transfer this asset from " + LosingAccountField.Text.ToUpper() + " to " + GainingAccountField.Text.ToUpper() + "?",
"Confirm Transfer", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                   dbconnect mysql = new dbconnect();

                string TransferQuery = "UPDATE assets SET accountnumber='" + GainingAccountField.Text.ToUpper() + 
                "', ec='" + GainingECDetail.Text.ToUpper() +"', notes='" + notes + "' WHERE serialnumber='" + SerialNumberDetail.Text.ToUpper() + "'";
                mysql.InsertQuery(TransferQuery);

                string item = AssetDetail.Text;
                string transferto = GainingECDetail.Text;
                string transferfrom = LosingECDetail.Text;
                string transferdate = DateTime.Now.ToString();
                string serialnumber = SerialNumberDetail.Text;
                string losingaccount = LosingAccountField.Text;
                string gainingaccount = GainingAccountField.Text;

                string TransferHistory = "INSERT INTO transfers (item, transferto, transferfrom, transferdate, serialnumber, losingaccount, gainingaccount, transferby, notes) VALUES ('" +
                item + "','" + transferto + "','" + transferfrom + "','" + transferdate + "','" + serialnumber + "','" +
                losingaccount + "','" + gainingaccount + "','" + TransferedBy+ "','" + notes + "')";

                string TransferLog = "INSERT INTO log (date, who, action, account) VALUES('" + DateTime.Now.ToString() + "','" + this.TransferedBy + "','TRANSFERED " + item + " " + serialnumber + " FROM " + transferfrom + " TO " + transferto + "','" + gainingaccount + "')";

                mysql.InsertQuery(TransferHistory);
                mysql.InsertQuery(TransferLog);

                this.Close();
            }
        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }
    }

    }


