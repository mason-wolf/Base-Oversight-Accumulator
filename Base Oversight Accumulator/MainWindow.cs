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

namespace Base_Oversight_Accumulator
{
    public partial class MainWindow : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;

        public MainWindow()
        {
            InitializeComponent();
            populate();

        }

        public void populate()
        {
            try
            {
                AssetDataView.Rows.Clear();
                AssetDataView.RowTemplate.Height = 15;
                ECDataView.Rows.Clear();
                ECDataView.RowTemplate.Height = 15;


                server = "localhost";
                database = "boa";
                user = "root";
                password = "root";
                string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";
                connection = new MySqlConnection(connectionstring);
                connection.Open();
                
                MySqlCommand AssetQuery = connection.CreateCommand();
                AssetQuery.CommandText = "SELECT * FROM assets";
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
                    string value = Convert.ToString(AssetQueryResult["value"]);

                    AssetDataView.Rows.Add(id, item, serialnumber, manufacturer, model, account, organization, ec, building, room, value);
                    assetCount++;
                    {
                        break;
                    }
                }

                StatusBar.Text = "Connected: " + server;
                DataGridViewColumn IDColumn = AssetDataView.Columns[0];
                IDColumn.Width = 25;

                DataGridViewColumn ItemColumn = AssetDataView.Columns[1];
                ItemColumn.Width = 75;
                connection.Close();

                // equipment custodians
                connection.Open();
                MySqlCommand ECQuery = connection.CreateCommand();
                ECQuery.CommandText = "SELECT * FROM ec";
                ECQuery.Connection = connection;
                MySqlDataReader ECQueryResult = ECQuery.ExecuteReader();
                while (ECQueryResult.Read())
                {
                    string ECLastName = Convert.ToString(ECQueryResult["lastname"]);
                    string ECFirstName = Convert.ToString(ECQueryResult["firstname"]);
                    string ECRank = Convert.ToString(ECQueryResult["rank"]);
                    string ECOrg = Convert.ToString(ECQueryResult["org"]);
                    string ECEmail = Convert.ToString(ECQueryResult["email"]);
                    string ECDSN = Convert.ToString(ECQueryResult["dsn"]);
                    string ECAccount = Convert.ToString(ECQueryResult["account"]);
                    string ECLocation = Convert.ToString(ECQueryResult["location"]);

                    ECDataView.Rows.Add(ECLastName, ECFirstName, ECRank, ECOrg, ECEmail, ECDSN, ECAccount, ECLocation);
  
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
            string GridID = AssetDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
            AssetDetailView AssetDetailView = new AssetDetailView();
            AssetDetailView.selectedID = GridID;
            AssetDetailView.Show();
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

        private void AssetDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ECDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
