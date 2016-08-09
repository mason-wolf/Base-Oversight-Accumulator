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
    public partial class CustodianDetailView : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        public string selectedID { get; set; }

        public CustodianDetailView()
        {
            InitializeComponent();
        }

        private void CustodianDetailView_Load(object sender, EventArgs e)
        {

            server = "localhost";
            database = "boa";
            user = "root";
            password = "root";
            string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionstring);

            connection.Open();
            MySqlCommand ECQuery = connection.CreateCommand();
            ECQuery.CommandText = "SELECT * FROM ec where id=" + selectedID;
            ECQuery.Connection = connection;
            MySqlDataReader ECQueryResult = ECQuery.ExecuteReader();
            while (ECQueryResult.Read())
            {
                string id = Convert.ToString(ECQueryResult["id"]);
                string firstname = Convert.ToString(ECQueryResult["lastname"]);
                string lastname = Convert.ToString(ECQueryResult["firstname"]);
                string rank = Convert.ToString(ECQueryResult["rank"]);
                string org = Convert.ToString(ECQueryResult["org"]);
                string email = Convert.ToString(ECQueryResult["email"]);
                string dsn = Convert.ToString(ECQueryResult["dsn"]);
                string account = Convert.ToString(ECQueryResult["account"]);
                string location = Convert.ToString(ECQueryResult["location"]);
                string lastinventory = Convert.ToString(ECQueryResult["lastinventorydate"]);
                string inventorydue = Convert.ToString(ECQueryResult["inventoryduedate"]);

                this.Text = "Equipment Custodian: " + rank.ToUpper() + " " + lastname.ToUpper() + ", " + firstname.ToUpper();
                ECID.Text = id;
                ECLastNameField.Text = lastname;
                ECFirstNameField.Text = firstname;
                ECRankField.Text = rank;
                ECOrgField.Text = org;
                ECEmailField.Text = email;
                ECDSNField.Text = dsn;
                ECAccountField.Text = account;
                ECLocationField.Text = location;
                ECLastInventoryField.Text = lastinventory;
                ECInventoryDueField.Text = inventorydue;

            }
            connection.Close();
        }

        private void ECEditButton_Click(object sender, EventArgs e)
        {
            ECLastNameField.ReadOnly = false;
            ECLastNameField.BackColor = Color.White;
            ECLastNameField.BorderStyle = BorderStyle.FixedSingle;

            ECFirstNameField.ReadOnly = false;
            ECFirstNameField.BackColor = Color.White;
            ECFirstNameField.BorderStyle = BorderStyle.FixedSingle;

            ECRankField.ReadOnly = false;
            ECRankField.BackColor = Color.White;
            ECRankField.BorderStyle = BorderStyle.FixedSingle;

            ECOrgField.ReadOnly = false;
            ECOrgField.BackColor = Color.White;
            ECOrgField.BorderStyle = BorderStyle.FixedSingle;

            ECEmailField.ReadOnly = false;
            ECEmailField.BackColor = Color.White;
            ECEmailField.BorderStyle = BorderStyle.FixedSingle;

            ECDSNField.ReadOnly = false;
            ECDSNField.BackColor = Color.White;
            ECDSNField.BorderStyle = BorderStyle.FixedSingle;

            ECAccountField.ReadOnly = false;
            ECAccountField.BackColor = Color.White;
            ECAccountField.BorderStyle = BorderStyle.FixedSingle;

            ECLocationField.ReadOnly = false;
            ECLocationField.BackColor = Color.White;
            ECLocationField.BorderStyle = BorderStyle.FixedSingle;

            ECLastInventoryField.Visible = false;
            ECInventoryDueField.Visible = false;
            LastInventoryDate.Visible = true;
            InventoryDueDate.Visible = true;

            ECEditButton.Enabled = false;
            SaveChangesButton.Visible = true;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            dbconnect mysql = new dbconnect();
            string id = ECID.Text;
            string lastname = ECLastNameField.Text;
            string firstname = ECFirstNameField.Text;
            string rank = ECRankField.Text;
            string org = ECOrgField.Text;
            string email = ECEmailField.Text;
            string dsn = ECDSNField.Text;
            string account = ECAccountField.Text;
            string location = ECLocationField.Text;
            string lastinventorydate = LastInventoryDate.Value.ToString();
            string inventoryduedate = InventoryDueDate.Value.ToString();
       
            string AccountUpdateQuery = "UPDATE ec SET lastname='" + lastname + "', firstname='" + firstname + "', rank='" +
                rank + "', org='" + org + "', email='" + email + "', dsn='" + dsn + "', account='" + account + "', location='" +
                location + "', lastinventorydate='" + lastinventorydate + "', inventoryduedate='" + inventoryduedate + "' WHERE id='" + id + "'";

            string AccountIDUpdateQuery = "UPDATE itam SET ec='" + rank.ToUpper() + " " + lastname.ToUpper() + ", " + firstname.ToUpper() +
      "' where account='" + account + "'";

            string AssetUpdateQuery = "UPDATE assets SET ec='" + rank.ToUpper() + " " + lastname.ToUpper() + ", " + firstname.ToUpper() +
"' where accountnumber='" + account + "'";


            mysql.insert(AccountUpdateQuery);
            mysql.insert(AccountIDUpdateQuery);
            mysql.insert(AssetUpdateQuery);
            this.Close();
        }

        private void ECDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this equipment custodian?",
"Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                dbconnect mysql = new dbconnect();
                string ID = ECID.Text;
                string query = "DELETE from ec WHERE id=" + ID;
                mysql.insert(query);
                this.Close();
            }
        }
    }
}
