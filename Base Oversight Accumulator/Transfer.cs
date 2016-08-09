using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Base_Oversight_Accumulator
{
    public partial class Transfer : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;

        public Transfer()
        {
            InitializeComponent();
        }

        private void TransferAssetButton_Click(object sender, EventArgs e)
        {
            server = "localhost";
            database = "boa";
            user = "root";
            password = "root";
            string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionstring);

       
            // retrieve losing account details

            string LosingAccount = LosingAccountField.Text;

                connection.Open();
                MySqlCommand LosingAccountQuery = connection.CreateCommand();
                 LosingAccountQuery.CommandText = "SELECT * FROM itam where account='" + LosingAccount +"'";
                 LosingAccountQuery.Connection = connection;
                MySqlDataReader LosingAccountQueryResults = LosingAccountQuery.ExecuteReader();
                while (LosingAccountQueryResults.Read())
                {
                    string account = Convert.ToString(LosingAccountQueryResults["account"]);
                    string org = Convert.ToString(LosingAccountQueryResults["org"]);
                    string ec = Convert.ToString(LosingAccountQueryResults["ec"]);
                    LosingAccountDetail.Text = account.ToUpper();
                    LosingOrgDetail.Text = org.ToUpper();
                    LosingECDetail.Text = ec.ToUpper();
            }
            connection.Close();

            // gaining account details
            string GainingAccount = GainingAccountField.Text;

            connection.Open();
            MySqlCommand GainingAccountQuery = connection.CreateCommand();
            GainingAccountQuery.CommandText = "SELECT * FROM itam where account='" + GainingAccount + "'";
            GainingAccountQuery.Connection = connection;
            MySqlDataReader GainingAccountQueryResults = GainingAccountQuery.ExecuteReader();
            while (GainingAccountQueryResults.Read())
            {
                string account = Convert.ToString(GainingAccountQueryResults["account"]);
                string org = Convert.ToString(GainingAccountQueryResults["org"]);
                string ec = Convert.ToString(GainingAccountQueryResults["ec"]);
                GainingAccountDetail.Text = account.ToUpper();
                GainingOrganizationDetail.Text = org.ToUpper();
                GainingECDetail.Text = ec.ToUpper();

            }
            connection.Close();

            //asset details

            string SerialNumberTransfer = SerialNumberField.Text;

            connection.Open();
            MySqlCommand AssetQuery = connection.CreateCommand();
            AssetQuery.CommandText = "SELECT * FROM assets where serialnumber='" + SerialNumberTransfer + "'";
            AssetQuery.Connection = connection;
            MySqlDataReader AssetQueryResults = AssetQuery.ExecuteReader();
            while (AssetQueryResults.Read())
            {
                string item = Convert.ToString(AssetQueryResults["item"]);
                string manufacturer = Convert.ToString(AssetQueryResults["manufacturer"]);
                string model = Convert.ToString(AssetQueryResults["model"]);
                string serialnumber = Convert.ToString(AssetQueryResults["serialnumber"]);

                AssetDetail.Text = item.ToUpper() + " " + manufacturer.ToUpper() + " " + model.ToUpper();
                SerialNumberDetail.Text = serialnumber.ToUpper();

            }
            connection.Close();

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
            string notes = TransferNotes.Text;

            if (MessageBox.Show("Are you sure you want to transfer this asset from " + LosingAccountField.Text.ToUpper() + " to " + GainingAccountField.Text.ToUpper() + "?",
"Confirm Transfer", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                   dbconnect mysql = new dbconnect();
                string TransferQuery = "UPDATE assets SET accountnumber='" + GainingAccountField.Text.ToUpper() + 
                    "', ec='" + GainingECDetail.Text.ToUpper() +"', notes='" + notes + "' WHERE serialnumber='" + SerialNumberDetail.Text.ToUpper() + "'";
                mysql.insert(TransferQuery);

                string item = AssetDetail.Text;
                string transferto = GainingECDetail.Text;
                string transferfrom = LosingECDetail.Text;
                string transferdate = DateTime.Now.ToString();
                string serialnumber = SerialNumberDetail.Text;
                string losingaccount = LosingAccountField.Text;
                string gainingaccount = GainingAccountField.Text;
                // transfered by
                string TransferHistory = "INSERT INTO transfers (item, transferto, transferfrom, transferdate, serialnumber, losingaccount, gainingaccount, transferedby, notes) VALUES ('" +
                    item + "','" + transferto + "','" + transferfrom + "','" + transferdate + "','" + serialnumber + "','" +
                    losingaccount + "','" + gainingaccount + "','" + notes + "')";

              //  mysql.insert(TransferHistory);
                MessageBox.Show("Transfer complete.");
                this.Close();
            }
        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }
    }

    }


