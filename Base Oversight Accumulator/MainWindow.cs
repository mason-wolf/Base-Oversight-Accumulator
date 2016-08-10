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
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Globalization;

namespace Base_Oversight_Accumulator
{
    public partial class MainWindow : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        public string BOAUser { get; set; }

        public MainWindow(string username)
        {
            InitializeComponent();
            populate();
            BOAUser = username;
        }

        public void populate()
        {
            try
            {
              
                AssetDataView.Rows.Clear();
                AssetDataView.RowTemplate.Height = 20;

                ECDataView.Rows.Clear();
                ECDataView.RowTemplate.Height = 20;

                AccountDataView.Rows.Clear();
                AccountDataView.RowTemplate.Height = 20;

                TransferDataView.Rows.Clear();
                TransferDataView.RowTemplate.Height = 20;

                server = "localhost";
                database = "boa";
                user = "root";
                password = "root";
                string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";
                connection = new MySqlConnection(connectionstring);
                connection.Open();
                
                // populate assets

                MySqlCommand AssetQuery = connection.CreateCommand();
                AssetQuery.CommandText = "SELECT * FROM assets ORDER BY id DESC";
                AssetQuery.Connection = connection;
                MySqlDataReader AssetQueryResult = AssetQuery.ExecuteReader();

                int assetCount = 0;

                while (AssetQueryResult.Read())
                {
                    string id = Convert.ToString(AssetQueryResult["id"]);
                    string item = Convert.ToString(AssetQueryResult["item"]);
                    string serialnumber = Convert.ToString(AssetQueryResult["serialnumber"]);
                    string manufacturer = Convert.ToString(AssetQueryResult["manufacturer"]);
                    string model = Convert.ToString(AssetQueryResult["model"]);
                    string account = Convert.ToString(AssetQueryResult["accountnumber"]);
                    string organization = Convert.ToString(AssetQueryResult["organization"]);
                    string ec = Convert.ToString(AssetQueryResult["ec"]);
                    string building = Convert.ToString(AssetQueryResult["building"]);
                    string room = Convert.ToString(AssetQueryResult["room"]);
                    int ValueFromInt = Int32.Parse(Convert.ToString(AssetQueryResult["value"]));
                    string value = "$" + ValueFromInt.ToString("N0");
                    AssetDataView.Rows.Add(id, item, serialnumber, manufacturer, model, account, organization, ec, building, room, value);
                    assetCount++;
                    if(assetCount == 1000)
                    {
                        break;
                    }
                }

                StatusBar.Text = "Connected: " + server;


                connection.Close();
                /*
                DataGridViewColumn IDColumn = AssetDataView.Columns[0];
                IDColumn.Width = 25;

                DataGridViewColumn ItemColumn = AssetDataView.Columns[1];
                ItemColumn.Width = 75;
               
                */

                // populate equipment custodians
                connection.Open();
                MySqlCommand ECQuery = connection.CreateCommand();
                ECQuery.CommandText = "SELECT * FROM ec ORDER BY id DESC";
                ECQuery.Connection = connection;
                MySqlDataReader ECQueryResult = ECQuery.ExecuteReader();

                int CustodianCount = 0;

                while (ECQueryResult.Read())
                {
                    string ECID = Convert.ToString(ECQueryResult["id"]);
                    string ECLastName = Convert.ToString(ECQueryResult["lastname"]);
                    string ECFirstName = Convert.ToString(ECQueryResult["firstname"]);
                    string ECRank = Convert.ToString(ECQueryResult["rank"]);
                    string ECOrg = Convert.ToString(ECQueryResult["org"]);
                    string ECEmail = Convert.ToString(ECQueryResult["email"]);
                    string ECDSN = Convert.ToString(ECQueryResult["dsn"]);
                    string ECAccount = Convert.ToString(ECQueryResult["account"]);
                    string ECLocation = Convert.ToString(ECQueryResult["location"]);

                    ECDataView.Rows.Add(ECID ,ECLastName, ECFirstName, ECRank, ECAccount, ECEmail, ECDSN, ECOrg, ECLocation);
                    CustodianCount++;

                    if(CustodianCount == 1000)
                    {
                        break;
                    }
                }

                connection.Close();
            

             
                // populate accounts
            connection.Open();
            MySqlCommand AccountQuery= connection.CreateCommand();
            ECQuery.CommandText = "SELECT * FROM itam ORDER BY id DESC";
            ECQuery.Connection = connection;
            MySqlDataReader AccountQueryResult = ECQuery.ExecuteReader();
                int AccountCount = 0;
            while (AccountQueryResult.Read())
            {
                    string AccountID = Convert.ToString(AccountQueryResult["id"]);
                    string AccountDRA = Convert.ToString(AccountQueryResult["dra"]);
                    string AccountOrg = Convert.ToString(AccountQueryResult["org"]);
                    string AccountLastInventoryDate = Convert.ToString(AccountQueryResult["lastinventory"]);
                    string AccountInventoryDue = Convert.ToString(AccountQueryResult["inventorydue"]);
                    string AccountNotes = Convert.ToString(AccountQueryResult["notes"]);
                    string AccountEC = Convert.ToString(AccountQueryResult["ec"]);
                    string AccountNumber = Convert.ToString(AccountQueryResult["account"]);

                    AccountDataView.Rows.Add(AccountID, AccountNumber, AccountEC, AccountDRA, AccountOrg, AccountLastInventoryDate, AccountInventoryDue, AccountNotes);
                    AccountCount++;
                    if(AccountCount == 1000)
                    {
                        break;
                    }
            }

            connection.Close();

                // populate transfers
                connection.Open();
                MySqlCommand TransferQuery = connection.CreateCommand();
                TransferQuery.CommandText = "SELECT * FROM transfers ORDER BY id DESC";
                TransferQuery.Connection = connection;
                MySqlDataReader TransferQueryResult = TransferQuery.ExecuteReader();
                int TransferCount = 0;
                while (TransferQueryResult.Read())
                {
                    string TransferID = Convert.ToString(TransferQueryResult["id"]);
                    string TransferItem = Convert.ToString(TransferQueryResult["item"]);
                    string TransferTo = Convert.ToString(TransferQueryResult["transferto"]);
                    string TransferFrom = Convert.ToString(TransferQueryResult["transferfrom"]);
                    string TransferDate = Convert.ToString(TransferQueryResult["transferdate"]);
                    string TransferSN = Convert.ToString(TransferQueryResult["serialnumber"]);
                    string TransferLosing = Convert.ToString(TransferQueryResult["losingaccount"]);
                    string TransferGaining = Convert.ToString(TransferQueryResult["gainingaccount"]);
                    string TransferBy = Convert.ToString(TransferQueryResult["transferby"]);
                    string TransferNotes = Convert.ToString(TransferQueryResult["notes"]);


                    TransferDataView.Rows.Add(TransferID, TransferItem, TransferTo, TransferFrom,
                        TransferDate, TransferSN, TransferLosing, TransferGaining, TransferBy, TransferNotes);
                    TransferCount++;
                    if (TransferCount == 1000)
                    {
                        break;
                    }
                }

                connection.Close();
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Unable to contact database server.", "Connection Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                StatusBar.Text = "Not Connected";
            }
        }

        private void newEquipmentCustodianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewECWindow NewECWindow = new NewECWindow();
            NewECWindow.Show();
        }

        private void addOrganizationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AssetDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string GridID = AssetDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
                AssetDetailView AssetDetailView = new AssetDetailView();
                AssetDetailView.selectedID = GridID;
                AssetDetailView.Show();
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

  
        private void assetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAssetWindow NewAssetWindow = new NewAssetWindow();
            NewAssetWindow.Show();
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void ToolBar_Click(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NewAssetButton_Click(object sender, EventArgs e)
        {
            NewAssetWindow NewAssetWindow = new NewAssetWindow();
            NewAssetWindow.Show();
        }

        private void equipmentCustodianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewECWindow NewECWindow = new NewECWindow();
            NewECWindow.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NewECButton_Click(object sender, EventArgs e)
        {
            NewECWindow NewECWindow = new NewECWindow();
            NewECWindow.Show();
        }

        private void organizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAccount NewAccount = new NewAccount();
            NewAccount.Show();
        }

        private void NewAccountButton_Click(object sender, EventArgs e)
        {
            NewAccount NewAccount = new Base_Oversight_Accumulator.NewAccount();
            NewAccount.Show();
        }

        private void ECDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string GridID = ECDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
                CustodianDetailView CustodianDetailView = new CustodianDetailView();
                CustodianDetailView.selectedID = GridID;
                CustodianDetailView.Show();
            }
            catch { }
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addAssetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAssetWindow NewAssetWindow = new NewAssetWindow();
            NewAssetWindow.Show();
        }

        private void addEquipmentCustodianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewECWindow NewECWindow = new NewECWindow();
            NewECWindow.Show();
        }

        private void addITAMAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAccount NewAccount = new NewAccount();
            NewAccount.Show();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            Transfer Transfer = new Transfer();
            Transfer.TransferedBy = BOAUser;
            Transfer.Show();
        }

        private void AccountDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string GridID = AccountDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
                AccountDetailView AccountDetailView = new AccountDetailView();
                AccountDetailView.gridid = GridID;
                AccountDetailView.Show();
            }
            catch { }
        }

        private void transferAssetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transfer Transfer = new Transfer();
            Transfer.TransferedBy = BOAUser;
            Transfer.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AssetDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModifyAssetValueButton_Click(object sender, EventArgs e)
        {
            ModifyAssetValue ModifyAssetValue = new ModifyAssetValue();
            ModifyAssetValue.Show();
        }
    }
}
