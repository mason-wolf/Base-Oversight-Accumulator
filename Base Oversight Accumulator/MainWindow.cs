using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Globalization;

namespace Base_Oversight_Accumulator
{
    public partial class MainWindow : Form
    {

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

                IssuedDataView.Rows.Clear();
                IssuedDataView.RowTemplate.Height = 20;

                ActionLogDataView.Rows.Clear();
                ActionLogDataView.RowTemplate.Height = 20;

                dbconnect mysql = new dbconnect();
                mysql.OpenConnection();

                // populate assets
                mysql.SelectQuery("SELECT * FROM assets ORDER BY id DESC");

                int assetCount = 0;

                while (mysql.Result.Read())
                {
                    string id = mysql.Reader("id");
                    string item = mysql.Reader("item");
                    string serialnumber = mysql.Reader("serialnumber");
                    string manufacturer = mysql.Reader("manufacturer");
                    string model = mysql.Reader("model");
                    string account = mysql.Reader("accountnumber");
                    string organization = mysql.Reader("organization");
                    string ec = mysql.Reader("ec");
                    string building = mysql.Reader("building");
                    string room = mysql.Reader("room");
                    int ValueFromInt = Int32.Parse(Convert.ToString(mysql.Reader("value")));
                    string value = "$" + ValueFromInt.ToString("N0");
                    AssetDataView.Rows.Add(id, item, serialnumber, manufacturer, model, account, organization, ec, building, room, value);
                    assetCount++;
                    if(assetCount == 1000)
                    {
                        break;
                    }
                }

                //       StatusBar.Text = "Connected: " + server; 

                
                mysql.CloseConnection();
                /*
                DataGridViewColumn Tab1ID= AssetDataView.Columns[0];
                Tab1ID.Width = 20;
                DataGridViewColumn Tab2ID = ECDataView.Columns[0];
                Tab2ID.Width = 20;
                DataGridViewColumn Tab3ID = AccountDataView.Columns[0];
                Tab3ID.Width = 20;
                DataGridViewColumn Tab4ID = TransferDataView.Columns[0];
                Tab4ID.Width = 20;
                DataGridViewColumn Tab5ID = IssuedDataView.Columns[0];
                Tab5ID.Width = 20;
                */

                // populate equipment custodians
                mysql.OpenConnection();
                mysql.SelectQuery("SELECT * FROM ec ORDER BY id DESC");

                int CustodianCount = 0;

                while (mysql.Result.Read())
                {
                    string ECID = mysql.Reader("id");
                    string ECLastName = mysql.Reader("lastname");
                    string ECFirstName = mysql.Reader("firstname");
                    string ECRank = mysql.Reader("rank");
                    string ECOrg = mysql.Reader("org");
                    string ECEmail = mysql.Reader("email");
                    string ECDSN = mysql.Reader("dsn");
                    string ECAccount = mysql.Reader("account");
                    string ECLocation = mysql.Reader("location");

                    ECDataView.Rows.Add(ECID ,ECLastName, ECFirstName, ECRank, ECAccount, ECEmail, ECDSN, ECOrg, ECLocation);
                    CustodianCount++;

                    if(CustodianCount == 1000)
                    {
                        break;
                    }
                }

                mysql.CloseConnection();



                // populate accounts
                mysql.OpenConnection();
                mysql.SelectQuery("SELECT * FROM itam ORDER BY id DESC");

                int AccountCount = 0;
            while (mysql.Result.Read())
            {
                    string AccountID = mysql.Reader("id");
                    string AccountDRA = mysql.Reader("dra");
                    string AccountOrg = mysql.Reader("org");
                    string AccountLastInventoryDate = mysql.Reader("lastinventory");
                    string AccountInventoryDue = mysql.Reader("inventorydue");
                    string AccountNotes = mysql.Reader("notes");
                    string AccountEC = mysql.Reader("ec");
                    string AccountNumber = mysql.Reader("account");
                    string AccountStatus = mysql.Reader("status");

                    AccountDataView.Rows.Add(AccountID, AccountNumber, AccountEC, AccountDRA, AccountOrg, AccountLastInventoryDate, AccountInventoryDue, AccountNotes, AccountStatus);
                    AccountCount++;
                    if(AccountCount == 1000)
                    {
                        break;
                    }
            }

                mysql.CloseConnection();

                // populate transfers
                mysql.OpenConnection();
                mysql.SelectQuery("SELECT * FROM transfers ORDER BY id DESC");
                int TransferCount = 0;

                while (mysql.Result.Read())
                {
                    string TransferID = mysql.Reader("id");
                    string TransferItem = mysql.Reader("item");
                    string TransferTo = mysql.Reader("transferto");
                    string TransferFrom = mysql.Reader("transferfrom");
                    string TransferDate = mysql.Reader("transferdate");
                    string TransferSN = mysql.Reader("serialnumber");
                    string TransferLosing = mysql.Reader("losingaccount");
                    string TransferGaining = mysql.Reader("gainingaccount");
                    string TransferBy = mysql.Reader("transferby");
                    string TransferNotes = mysql.Reader("notes");


                    TransferDataView.Rows.Add(TransferID, TransferItem, TransferTo, TransferFrom,
                        TransferDate, TransferSN, TransferLosing, TransferGaining, TransferBy, TransferNotes);
                    TransferCount++;
                    if (TransferCount == 1000)
                    {
                        break;
                    }
                }

                // populate temporary issued items
                mysql.OpenConnection();
                mysql.SelectQuery("SELECT * FROM issued ORDER BY id DESC");
                int ItemCount = 0;

                while (mysql.Result.Read())
                {
                    string ItemID = mysql.Reader("id");
                    string IssuedTo = mysql.Reader("issuedto");
                    string IssuedBy = mysql.Reader("issuedby");
                    string Account = mysql.Reader("account");
                    string dsn = mysql.Reader("dsn");
                    string dateofissue = mysql.Reader("dateofissue");
                    string dateofreturn = mysql.Reader("dateofreturn");
                    string items = mysql.Reader("items");
                    string notes = mysql.Reader("notes");


                    IssuedDataView.Rows.Add(ItemID, IssuedTo, IssuedBy, Account, dsn, dateofissue, dateofreturn, items, notes);

                    ItemCount++;
                    if (ItemCount== 1000)
                    {
                        break;
                    }
                }

                mysql.CloseConnection();

                // populate action log
                mysql.OpenConnection();
                mysql.SelectQuery("SELECT * from log ORDER BY id DESC");
                int LogCount = 0;
                while(mysql.Result.Read())
                {
                    string id = mysql.Reader("id");
                    string date = mysql.Reader("date");
                    string who = mysql.Reader("who");
                    string action = mysql.Reader("action");
                    ActionLogDataView.Rows.Add(id, date, who, action);

                    LogCount++;
                    if (LogCount == 1000)
                    {
                        break;
                    }
                }
                mysql.CloseConnection();
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
                AssetDetailView.UserViewingAsset = BOAUser;
                AssetDetailView.Show();
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

  
        private void assetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAssetWindow NewAssetWindow = new NewAssetWindow();
            NewAssetWindow.UserCreatingAsset = BOAUser;
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
            NewAssetWindow NewAsset = new NewAssetWindow();
            NewAsset.UserCreatingAsset = BOAUser;
            NewAsset.Show();
        }

        private void equipmentCustodianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewECWindow NewECWindow = new NewECWindow();
            NewECWindow.UserCreatingCustodian = BOAUser;
            NewECWindow.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NewECButton_Click(object sender, EventArgs e)
        {
            NewECWindow NewECWindow = new NewECWindow();
            NewECWindow.UserCreatingCustodian = BOAUser;
            NewECWindow.Show();
        }

        private void organizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAccount NewAccount = new NewAccount();
            NewAccount.UserCreatingAccount = BOAUser;
            NewAccount.Show();
        }

        private void NewAccountButton_Click(object sender, EventArgs e)
        {
            NewAccount NewAccount = new Base_Oversight_Accumulator.NewAccount();
            NewAccount.UserCreatingAccount = BOAUser;
            NewAccount.Show();
        }

        private void ECDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string GridID = ECDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
                CustodianDetailView CustodianDetailView = new CustodianDetailView();
                CustodianDetailView.selectedID = GridID;
                CustodianDetailView.UserViewingCustodian = BOAUser;
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
                AccountDetailView.UserViewingAccount = BOAUser;
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

        private void TempIssueButton_Click(object sender, EventArgs e)
        {
            TemporaryItemIssue TemporaryIssueItem = new TemporaryItemIssue();
            TemporaryIssueItem.IssuedBy = BOAUser;
            TemporaryIssueItem.Show();
        }

        private void TransferDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string GridID = TransferDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
                TransferDetailView TransferDetailView = new TransferDetailView();
                TransferDetailView.TransferID = GridID;
                TransferDetailView.Show();
            }
            catch { }
        }

        private void IssuedDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string GridID = IssuedDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
                IssuedItemsView IssuedItems = new IssuedItemsView();
                IssuedItems.ItemID = GridID;
                IssuedItems.Show();
            }
            catch { }
        }

        private void DRMOButton_Click(object sender, EventArgs e)
        {
            PropertyDisposal PropertyDisposal = new PropertyDisposal();
            PropertyDisposal.ItemsDisposedBy = BOAUser;
            PropertyDisposal.Show();
        }

        private void assetDispositionbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertyDisposal PropertyDisposal = new PropertyDisposal();
            PropertyDisposal.ItemsDisposedBy = BOAUser;
            PropertyDisposal.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifyAssetValue ModifyAssetValue = new ModifyAssetValue();
            ModifyAssetValue.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ROSWindow ros = new ROSWindow();
            ros.UserCreatingROS = BOAUser;
            ros.Show();
        }

        private void initiateReportOfSurveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ROSWindow ros = new ROSWindow();
            ros.UserCreatingROS = BOAUser;
            ros.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SearchBOA s = new SearchBOA();
            s.Show();
        }

    }
}
