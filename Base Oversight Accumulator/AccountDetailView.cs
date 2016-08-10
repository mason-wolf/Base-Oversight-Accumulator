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
using System.Globalization;

namespace Base_Oversight_Accumulator
{
    public partial class AccountDetailView : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;

        public string gridid { get; set; }
        public string AssetAccountNumber { get; set; }
        public string AssetEquipmentCustodian { get; set; }

        public AccountDetailView()
        {
            InitializeComponent();
        }

        private void AccountDetailView_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "boa";
            user = "root";
            password = "root";
            string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionstring);

            connection.Open();
            
            // account id
            MySqlCommand AssetIDQuery = connection.CreateCommand();
            AssetIDQuery.CommandText = "SELECT * FROM itam where id=" + gridid;
            AssetIDQuery.Connection = connection;
            MySqlDataReader AssetIDResult = AssetIDQuery.ExecuteReader();
            while (AssetIDResult.Read())
            {
                AssetAccountNumber = Convert.ToString(AssetIDResult["account"]);
            }
            connection.Close();

            // total assets
            connection.Open();
            int count;
            string TotalAssetsQuery = "SELECT Count(*) FROM assets WHERE accountnumber='" + AssetAccountNumber + "'";
            MySqlCommand TotalAssetCmd= new MySqlCommand(TotalAssetsQuery, connection);
            count = int.Parse(TotalAssetCmd.ExecuteScalar().ToString());
            TotalAssetsField.Text = count.ToString();
            connection.Close();

            // total asset value
            connection.Open();

            try
            {
                string AssetValueQuery = "SELECT SUM(value) FROM assets WHERE accountnumber='" + AssetAccountNumber + "'";
                MySqlCommand AssetValueCmd = new MySqlCommand(AssetValueQuery, connection);
                TotalValueField.Text = "$" + double.Parse(AssetValueCmd.ExecuteScalar().ToString()).ToString("N0");
            }
            catch { }
            connection.Close();

            // equipment custodian
            connection.Open();
            MySqlCommand AssetECQuery = connection.CreateCommand();
            AssetECQuery.CommandText = "SELECT * FROM itam WHERE account='" + AssetAccountNumber + "'";
            AssetECQuery.Connection = connection;
            MySqlDataReader AssetECQueryResult = AssetECQuery.ExecuteReader();
            while (AssetECQueryResult.Read())
            {
                AssetEquipmentCustodian = Convert.ToString(AssetECQueryResult["ec"]);
                string InventoryDate = Convert.ToString(AssetECQueryResult["lastinventory"]);
                string InventoryDueDate = Convert.ToString(AssetECQueryResult["inventorydue"]);
                LastInventoryField.Text = InventoryDate;
                InventoryDueField.Text = InventoryDueDate;
            }
            connection.Close();
            ECField.Text = AssetEquipmentCustodian;

            // assets 
            connection.Open();
            MySqlCommand AssetListQuery = connection.CreateCommand();
            AssetListQuery.CommandText = "SELECT * from assets where accountnumber='" + AssetAccountNumber + "'";
            AssetListQuery.Connection = connection;
            MySqlDataReader AssetListQueryResult = AssetListQuery.ExecuteReader();
            while (AssetListQueryResult.Read())
            {

                string manufacturer = Convert.ToString(AssetListQueryResult["manufacturer"]);
                string model = Convert.ToString(AssetListQueryResult["model"]);
                string serial = Convert.ToString(AssetListQueryResult["serialnumber"]);
                AccountAssets.Items.Add(manufacturer + " " + model + " " +serial);
            }
            connection.Close();

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
                string query = "DELETE from itam WHERE id=" + gridid;
                mysql.insert(query);
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
