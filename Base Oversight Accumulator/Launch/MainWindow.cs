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
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using MySql.Data.MySqlClient;
using Base_Oversight_Accumulator.NewQueries;
using Base_Oversight_Accumulator.Search;
using Base_Oversight_Accumulator.Utilities;
using System.Text.RegularExpressions;

namespace Base_Oversight_Accumulator
{
    public partial class MainWindow : Form
    {
        // set user profile
        public string BOAUser { get; set; }

        // accessors for overview section to use for quick views
        public string QuickViewAccount { get; set; }
        public string QuickViewItem { get; set; }
        public string QuickViewSerialNumber { get; set; }
        public List<string> BackwardPages = new List<string>();
        public List<string> ForwardPages = new List<string>();
        public bool SearchEnabled;

        public MainWindow(string username)
        {
            InitializeComponent();
            populate();
            BOAUser = username;
            this.KeyDown += new KeyEventHandler(this.CTRL_F_Pressed);
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

                Overview.Rows.Clear();
                Overview.RowTemplate.Height = 20;

                Overview.DefaultCellStyle.BackColor = Color.Transparent;
                Overview.DefaultCellStyle.SelectionBackColor = Color.Transparent;

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
                    if (assetCount == 1000)
                    {
                        break;
                    }
                }

                mysql.CloseConnection();

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

                    ECDataView.Rows.Add(ECID, ECLastName, ECFirstName, ECRank, ECAccount, ECEmail, ECDSN, ECOrg, ECLocation);
                    CustodianCount++;

                    if (CustodianCount == 1000)
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
                    if (AccountCount == 1000)
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
                mysql.CloseConnection();
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
                    if (ItemCount == 1000)
                    {
                        break;
                    }
                }

                mysql.CloseConnection();

                // populate action log
                mysql.OpenConnection();
                mysql.SelectQuery("SELECT * from log ORDER BY id DESC");
                int LogCount = 0;
                while (mysql.Result.Read())
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
                MySqlConnection.ClearAllPools();

                // populate detail view 

                string[] totals = new string[]
                {
                    "Desktop",
                    "Laptop",
                    "Printer",
                    "Scanner",
                    "Projector",
                    "VOIP",
                    "VTC",
                    "Phone",
                    "LMR",
                    "Switch",
                    "Other"
                };

                Overview.ColumnHeadersVisible = false;
                Overview.Rows.Add("");
                mysql.OpenConnection();
                string TotalAssets = OverviewCount("ASSETS");
                string TotalValue = mysql.SumCurrencyQuery("SELECT SUM(value) FROM ASSETS");
                string TotalCustodians = OverviewCount("ec");
                string TotalAccounts = OverviewCount("itam");
                string TotalTransfers = OverviewCount("transfers");
                string TotalIssuances = OverviewCount("issued");
                string TotalActions = OverviewCount("log");
                Overview.Rows.Add("Total Assets    ", TotalAssets, TotalValue);
                Overview.Rows.Add("Custodians", TotalCustodians);
                Overview.Rows.Add("Accounts", TotalAccounts);
                Overview.Rows.Add("Transfers", TotalTransfers);
                Overview.Rows.Add("Issuances", TotalIssuances);
                Overview.Rows.Add("Actions", TotalActions);
                foreach (string asset in totals)
                {
                    string count = AssetCount(asset);
                    string value = AssetValue(asset);
                    Overview.Rows.Add(asset, count + "    ", value);
                    Overview.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control);
                    Overview.DefaultCellStyle.SelectionBackColor = Color.FromKnownColor(KnownColor.Control);
                    foreach (DataGridViewColumn c in Overview.Columns)
                    {
                        c.DefaultCellStyle.Font = new Font("Courier New", 8F);
                    }
                }
                mysql.CloseConnection();
                MySqlConnection.ClearAllPools();
                ConnectionStatus.Text = "Connected to: " + Properties.Settings.Default.ServerAddress;
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Unable to contact database server.", "Connection Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string OverviewCount(string table)
        {
            dbconnect mysql = new dbconnect();
            mysql.OpenConnection();
            string count = mysql.CountQuery("SELECT COUNT(*) FROM " + table);
            mysql.CloseConnection();
            MySqlConnection.ClearAllPools();
            return count;
        }
        public string AssetCount(string whichAsset)
        {
            dbconnect mysql = new dbconnect();
            mysql.OpenConnection();
            string count = mysql.CountQuery("SELECT COUNT(*) FROM ASSETS WHERE item='" + whichAsset + "'");
            mysql.CloseConnection();
            MySqlConnection.ClearAllPools();
            return count;
        }

        public string AssetValue(string whichAsset)
        {
            dbconnect mysql = new dbconnect();
            mysql.OpenConnection();
            string value = mysql.SumCurrencyQuery("SELECT SUM(value) FROM assets WHERE item='" + whichAsset + "'");
            mysql.CloseConnection();
            MySqlConnection.ClearAllPools();
            return value;

        }
        private void newEquipmentCustodianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewECWindow NewECWindow = new NewECWindow();
            NewECWindow.Show();
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
            NewTransfer Transfer = new NewTransfer();
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
            NewTransfer Transfer = new NewTransfer();
            Transfer.TransferedBy = BOAUser;
            Transfer.Show();
        }

        private void ModifyAssetValueButton_Click(object sender, EventArgs e)
        {
            NewAssetValueModification ModifyAssetValue = new NewAssetValueModification();
            ModifyAssetValue.Show();
        }

        private void TempIssueButton_Click(object sender, EventArgs e)
        {
            NewTemporaryItemIssue TemporaryIssueItem = new NewTemporaryItemIssue();
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
            NewPropertyDisposal PropertyDisposal = new NewPropertyDisposal();
            PropertyDisposal.ItemsDisposedBy = BOAUser;
            PropertyDisposal.Show();
        }

        private void assetDispositionbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPropertyDisposal PropertyDisposal = new NewPropertyDisposal();
            PropertyDisposal.ItemsDisposedBy = BOAUser;
            PropertyDisposal.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewAssetValueModification ModifyAssetValue = new NewAssetValueModification();
            ModifyAssetValue.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NewMissingAsset ros = new NewMissingAsset();
            ros.UserCreatingROS = BOAUser;
            ros.Show();
        }

        private void initiateReportOfSurveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMissingAsset ros = new NewMissingAsset();
            ros.UserCreatingROS = BOAUser;
            ros.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SearchOptions s = new SearchOptions();
            s.UserSelectingSearch = BOAUser;
            s.Show();
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow NewWindow = new MainWindow(BOAUser);
            NewWindow.Show();
        }

        private void assetsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AssetsWindow AssetsWindow = new AssetsWindow();
            AssetsWindow.UserViewingAssetWindow = BOAUser;
            AssetsWindow.Show();
        }

        private void equipmentCustodiansToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CustodianWindow CustodianWindow = new CustodianWindow();
            CustodianWindow.UserViewingCustodians = BOAUser;
            CustodianWindow.Show();
        }

        private void accountsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AccountWindow AccountWindow = new AccountWindow();
            AccountWindow.UserViewingAccounts = BOAUser;
            AccountWindow.Show();
        }

        private void transfersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TransferWindow TransferWindow = new TransferWindow();
            TransferWindow.UserViewingTransfers = BOAUser;
            TransferWindow.Show();
        }

        private void temporarilyIssuedItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssuedItemsWindow IssuedItemsWindow = new IssuedItemsWindow();
            IssuedItemsWindow.UserViewingItems = BOAUser;
            IssuedItemsWindow.Show();
        }

        private void actionLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActionLogWindow ActionLogWindow = new ActionLogWindow();
            ActionLogWindow.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDataGridView SaveDataGridView = new SaveDataGridView();
            SaveDataGridView.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            SaveDataGridView SaveDataGridView = new SaveDataGridView();
            SaveDataGridView.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit BOA?",
"Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataObject dataObj;
            switch (ActionReportDataView.SelectedIndex)
            {
                case 0:
                    AssetDataView.SelectAll();
                    dataObj = AssetDataView.GetClipboardContent();
                    if (dataObj != null)
                        Clipboard.SetDataObject(dataObj);
                    AssetDataView.ClearSelection();

                    break;
                case 1:
                    ECDataView.SelectAll();
                    dataObj = ECDataView.GetClipboardContent();
                    if (dataObj != null)
                        Clipboard.SetDataObject(dataObj);
                    ECDataView.ClearSelection();

                    break;
                case 2:
                    AccountDataView.SelectAll();
                    dataObj = AccountDataView.GetClipboardContent();
                    if (dataObj != null)
                        Clipboard.SetDataObject(dataObj);
                    AccountDataView.ClearSelection();

                    break;
                case 3:
                    TransferDataView.SelectAll();
                    dataObj = TransferDataView.GetClipboardContent();
                    if (dataObj != null)
                        Clipboard.SetDataObject(dataObj);
                    TransferDataView.ClearSelection();

                    break;
                case 4:
                    IssuedDataView.SelectAll();
                    dataObj = IssuedDataView.GetClipboardContent();
                    if (dataObj != null)
                        Clipboard.SetDataObject(dataObj);
                    IssuedDataView.ClearSelection();
                    break;
                case 5:
                    ActionLogDataView.SelectAll();
                    dataObj = ActionLogDataView.GetClipboardContent();
                    if (dataObj != null)
                        Clipboard.SetDataObject(dataObj);
                    ActionLogDataView.ClearSelection();
                    break;
            }
            MessageBox.Show("Dataset copied to clipboard.");
        }

        public void NewSearchWindow(string searchItem)
        {
            SearchWindow SearchWindow = new SearchWindow();
            SearchWindow.UserPerformingSearch = BOAUser;
            SearchWindow.SearchItem = searchItem;
            SearchWindow.Show();
        }

        private void selectAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            switch (ActionReportDataView.SelectedIndex)
            {
                case 0:
                    AssetDataView.SelectAll();
                    break;
                case 1:
                    ECDataView.SelectAll();
                    break;
                case 2:
                    AccountDataView.SelectAll();
                    break;
                case 3:
                    TransferDataView.SelectAll();
                    break;
                case 4:
                    IssuedDataView.SelectAll();
                    break;
                case 5:
                    ActionLogDataView.SelectAll();
                    break;
            }
        }

        public void CTRL_F_Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F)
            {
                switch (ActionReportDataView.SelectedIndex) {
                    case 0:
                        NewSearchWindow("assets");
                        break;
                    case 1:
                        NewSearchWindow("ec");
                        break;
                    case 2:
                        NewSearchWindow("accounts");
                        break;
                    case 3:
                        TransferSearch TransferSearch = new TransferSearch();
                        TransferSearch.Show();
                        break;
                    case 4:
                        IssuedSearch IssuedSearch = new IssuedSearch();
                        IssuedSearch.Show();
                        break;
                    case 5:
                        ActionLogDataView.SelectAll();
                        break;
                }
            }
        }

        private void reportBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBugReport NewBugReport = new NewBugReport();
            NewBugReport.UserSubmittingReport = BOAUser;
            NewBugReport.Show();
        }

        private void NewSlotNumberButton_Click(object sender, EventArgs e)
        {
            NewSlotNumber NewSlotNumber = new NewSlotNumber();
            NewSlotNumber.Show();
        }

        private void nationalSlotNumbersNSNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SlotNumberSearch SlotNumberSearch = new SlotNumberSearch();
            SlotNumberSearch.Show();
        }

        private void checkAccountsDueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DueDateAlerter DueDateAlerter = new DueDateAlerter();
            DueDateAlerter.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NewItemModification NewItemModification = new NewItemModification();
            NewItemModification.Show();
        }

        private void assetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWindow SearchItem = new SearchWindow();
            SearchItem.UserPerformingSearch = BOAUser;
            SearchItem.SearchItem = "assets";
            SearchItem.Show();
        }

        private void equipmentCustodiansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWindow SearchItem = new SearchWindow();
            SearchItem.UserPerformingSearch = BOAUser;
            SearchItem.SearchItem = "accounts";
            SearchItem.Show();
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWindow SearchItem = new SearchWindow();
            SearchItem.UserPerformingSearch = BOAUser;
            SearchItem.SearchItem = "ec";
            SearchItem.Show();
        }

        private void transfersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferSearch TransferSearch = new TransferSearch();
            TransferSearch.Show();
        }

        private void AssetDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string AssetID = AssetDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
                QuickViewItem = AssetID;
                DetailViewBox.Visible = false;
                AssetDetailBox.Visible = true;
                AssetDetail.Clear();
                dbconnect mysql = new dbconnect();
                mysql.OpenConnection();
                mysql.SelectQuery("SELECT * from assets where id='" + AssetID + "'");
                while (mysql.Result.Read())
                {
                    string manufacturer = mysql.Reader("manufacturer");
                    string model = mysql.Reader("model");
                    QuickViewSerialNumber = mysql.Reader("serialnumber");
                    QuickViewAccount = mysql.Reader("accountnumber");

             //       AssetDetailBox.Text = QuickViewSerialNumber;
                    AssetDetail.AppendText(manufacturer + " " + model + " " + QuickViewSerialNumber + "\n\n");
                }
                mysql.SelectQuery("SELECT * from log where action LIKE '%" + QuickViewSerialNumber + "%' ORDER BY ID desc");

                while (mysql.Result.Read())
                {
                    string date = mysql.Reader("date");
                    date = date.Remove(date.Length - 11);
                    string action = mysql.Reader("action");
                    AssetDetail.AppendText(date + " " + action + "\n\n");
                }

                //        HighlightText(AssetDetail, QuickViewSerialNumber, Color.Green);
                string PageContent = AssetDetail.Text;
                BackwardPages.Add(PageContent);
                BackButton.Enabled = true;
                ForwardButton.Enabled = true;
                mysql.CloseConnection();
            }
            catch { }
        }

        private void HighlightText(RichTextBox myRtb, string word, Color color)
        {

            if (word == "")
            {
                return;
            }

            int s_start = myRtb.SelectionStart, startIndex = 0, index;

            while ((index = myRtb.Text.IndexOf(word, startIndex)) != -1)
            {
                myRtb.Select(index, word.Length);
                myRtb.SelectionColor = color;

                startIndex = index + word.Length;
            }

            myRtb.SelectionStart = s_start;
            myRtb.SelectionLength = 0;
            myRtb.SelectionColor = Color.Black;
        }

        private void MainOverviewButton_Click(object sender, EventArgs e)
        {
            AssetDetailBox.Visible = false;
            DetailViewBox.Visible = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            try
            {
                string PageContent = AssetDetail.Text;
                ForwardPages.Add(PageContent);
                var LastPage = BackwardPages[BackwardPages.Count - 2];
                AssetDetail.Text = LastPage;
                BackButton.Enabled = false;
                ForwardButton.Enabled = true;
            }
            catch
            {
            }
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            try
            {
                var FirstPage = ForwardPages.Last();
                AssetDetail.Text = FirstPage;
                BackButton.Enabled = true;
                ForwardButton.Enabled = false;
            }
            catch
            {

            }
        }

        private void OverviewSearch_TextChanged(object sender, EventArgs e)
        {
                    HighlightText(AssetDetail, OverviewSearch.Text, Color.Green);
        }

        private void SearchOverviewButton_Click(object sender, EventArgs e)
        {
            if(SearchEnabled == false)
            {
                OverviewSearch.Visible = true;
                SearchEnabled = true;
            }
            else
            {
                OverviewSearch.Visible = false;
                SearchEnabled = false;
            }
        }
    } 
    }
    
    
    

