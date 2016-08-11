using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Base_Oversight_Accumulator
{
    public partial class AccountDetailView : Form
    {
        public string gridid { get; set; }
        public string AssetAccountNumber { get; set; }
        public string AssetEquipmentCustodian { get; set; }

        public AccountDetailView()
        {
            InitializeComponent();
        }

        private void AccountDetailView_Load(object sender, EventArgs e)
        {
            // accounts
            dbconnect mysql = new dbconnect();
            mysql.OpenConnection();
            mysql.SelectQuery("SELECT * FROM itam where id=" + gridid);
            while (mysql.Result.Read())
            {
                AssetAccountNumber = mysql.Reader("account");
                AccountNumberField.Text = AssetAccountNumber;
            }
            mysql.CloseConnection();

           // total assets
            string TotalAssets = mysql.CountQuery("SELECT COUNT(*) FROM assets WHERE accountnumber='" + AssetAccountNumber + "'");
            TotalAssetsField.Text = TotalAssets;


            // total asset value
            string TotalAssetValue = mysql.SumCurrencyQuery("SELECT SUM(value) FROM assets WHERE accountnumber='" + AssetAccountNumber + "'");
            TotalValueField.Text = TotalAssetValue;

            // equipment custodian
            mysql.OpenConnection();
            mysql.SelectQuery("SELECT * FROM itam WHERE account='" + AssetAccountNumber + "'");
            while (mysql.Result.Read())
            {
                AssetEquipmentCustodian = mysql.Reader("ec");
                string InventoryDate = mysql.Reader("lastinventory");
                string InventoryDueDate = mysql.Reader("inventorydue");
                string org = mysql.Reader("org");
                ECField.Text = AssetEquipmentCustodian;
                LastInventoryField.Text = InventoryDate;
                InventoryDueField.Text = InventoryDueDate;
                OrganizationField.Text = org;
            }
            mysql.CloseConnection();

            // assets 
            mysql.OpenConnection();
            mysql.SelectQuery("SELECT * from assets where accountnumber='" + AssetAccountNumber + "'");
            while (mysql.Result.Read())
            {
                string manufacturer = mysql.Reader("manufacturer");
                string model = mysql.Reader("model");
                string serial = mysql.Reader("serialnumber");
                AccountAssets.Items.Add(manufacturer + " " + model + " " + serial);
            }
            mysql.CloseConnection();

            // drmo 
            mysql.OpenConnection();
            mysql.SelectQuery("SELECT * from drmo where account='" + AssetAccountNumber + "'");
            while (mysql.Result.Read())
            {
                string item = mysql.Reader("item");
                string date = mysql.Reader("date");
                AccountDRMO.Items.Add("# " + date + " " + item);
            }
            mysql.CloseConnection();

            // ros
            mysql.OpenConnection();
            mysql.SelectQuery("SELECT * from ros where account='" + AssetAccountNumber + "'");
            while (mysql.Result.Read())
            {
                string item = mysql.Reader("description");
                string date = mysql.Reader("date");
                AccountROS.Items.Add("#" + date + " " + item);
            }
            mysql.CloseConnection();

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this account? This action cannot be undone.",
"Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dbconnect mysql = new dbconnect();
                string DeleteAccount = "DELETE from itam WHERE id=" + gridid;
                mysql.InsertQuery(DeleteAccount);
                this.Close();
            }
        }

        private void AccountDetailsBox_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ECField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
