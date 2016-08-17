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
    public partial class CustodianDetailView : Form
    {

        public string selectedID { get; set; }
        public string UserViewingCustodian { get; set; }

        public CustodianDetailView()
        {
            InitializeComponent();
        }

        private void CustodianDetailView_Load(object sender, EventArgs e)
        {

            dbconnect mysql = new dbconnect();
            mysql.OpenConnection();
            mysql.SelectQuery("SELECT * FROM ec where id=" + selectedID);
            while (mysql.Result.Read())
            {
                string id = mysql.Reader("id");
                string lastname = mysql.Reader("lastname");
                string firstname = mysql.Reader("firstname");
                string rank = mysql.Reader("rank");
                string org = mysql.Reader("org");
                string email = mysql.Reader("email");
                string dsn = mysql.Reader("dsn");
                string account = mysql.Reader("account");
                string location = mysql.Reader("location");
                string lastinventory = mysql.Reader("lastinventorydate");
                string inventorydue = mysql.Reader("inventoryduedate");

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
            mysql.CloseConnection();
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
   
            string ECUpdate= "UPDATE ec SET lastname='" + lastname + "', firstname='" + firstname + "', rank='" +
                rank + "', org='" + org + "', email='" + email + "', dsn='" + dsn + "', account='" + account + "', location='" +
                location + "', lastinventorydate='" + lastinventorydate + "', inventoryduedate='" + inventoryduedate + "' WHERE id='" + id + "'";

            string AccountUpdate = "UPDATE itam SET ec='"+ lastname.ToUpper() + ", " + firstname.ToUpper() + " " + rank.ToUpper() +
      "', lastinventory='" + lastinventorydate + "', inventorydue='" + inventoryduedate + "' where account='" + account + "'";

            string AssetUpdate = "UPDATE assets SET ec='" + lastname.ToUpper() + ", " + firstname.ToUpper() + " " + rank.ToUpper() +
"' where accountnumber='" + account + "'";

            if (MessageBox.Show("Making changes to the user's inventory status updates their account. Continue?",
                "Confirm Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                mysql.InsertQuery(ECUpdate);
                mysql.InsertQuery(AccountUpdate);
                mysql.InsertQuery(AssetUpdate);
                this.Close();
            }
            else
            {

            }
        }

        private void ECDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this equipment custodian?",
"Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                try
                {
                    dbconnect mysql = new dbconnect();
                    string ID = ECID.Text;
                    string lastname = ECLastNameField.Text;
                    string firstname = ECFirstNameField.Text;
                    string rank = ECRankField.Text;
                    string account = ECAccountField.Text;
                    string ec = lastname.ToUpper() + ", " + firstname.ToUpper() + " " + rank;
                    string DeleteEC = "DELETE from ec WHERE id=" + ID;
                    string LogUpdate = "INSERT INTO log (date, who, action) VALUES('" + DateTime.Now.ToString() + "','" + UserViewingCustodian +
    "','DELETED CUSTODIAN " + ec + " MEMBER OF ACCOUNT " + account +"')";
                    string AccountUpdate = "UPDATE itam set ec='' WHERE account='" + ECAccountField.Text + "'";
                    mysql.InsertQuery(DeleteEC);
                    mysql.InsertQuery(LogUpdate);
                    mysql.InsertQuery(AccountUpdate);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Equipment custodian has already been removed. Refresh database view to see changes.");
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ECFirstNameField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
