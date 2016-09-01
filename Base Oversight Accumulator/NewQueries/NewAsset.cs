using Base_Oversight_Accumulator.Properties;
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
    public partial class NewAssetWindow : Form
    {
        string item;

        public string UserCreatingAsset { get; set; }


        public NewAssetWindow()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(this.QuickAdd);
            if (Settings.Default.WorkingCustodian != null)
            {
                NewEC.Text = Settings.Default.WorkingCustodian;
                NewItemOrganization.Text = Settings.Default.WorkingOrganization;
                NewItemOwner.Text = Settings.Default.WorkingAccount;
            }
        }

        public void QuickAdd(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AddAssetButton.PerformClick();
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                item = NewItemType.SelectedItem.ToString();
            }
            catch
            { }
            string manufacturer = NewItemManufacturer.Text;
            string model = NewItemModel.Text;
            string serialnumber = NewItemSerialNumber.Text;
            string owner = NewItemOwner.Text;
            string organization = NewItemOrganization.Text;
            string ec = NewEC.Text;
            string building = NewBuilding.Text;
            string room = NewRoom.Text;
            string value = NewEstimatedValue.Text;
            string notes = NewAssetNotes.Text + "# asset added " + DateTime.Now;
            string NewAssetLog = "INSERT INTO log (date, who, action, account) VALUES ('" + DateTime.Now.ToString() + "','" + this.UserCreatingAsset + "','CREATED NEW ASSET " + manufacturer.ToUpper() + " " + model.ToUpper() +
                " WITH SERIAL NUMBER " + serialnumber + " FOR ACCOUNT " + owner + " ASSIGNED TO " + ec + "', '" + owner + "')";
            dbconnect mysql = new dbconnect();
            mysql.InsertQuery(NewAssetLog);
            if (string.IsNullOrEmpty(manufacturer ?? model ?? serialnumber ?? owner ?? organization ?? ec ?? building ?? room ?? value ?? notes)) {
                MessageBox.Show("Please finish completing the form.", "New Asset", MessageBoxButtons.OK,MessageBoxIcon.Exclamation,
      MessageBoxDefaultButton.Button1);
            }
            else {
                // first check to see if the item already exists
                mysql.SelectQuery("SELECT * from assets where serialnumber='" + serialnumber + "'");
                if (!mysql.Result.Read())
                {
                    string NewAssetQuery = "INSERT INTO assets(item, manufacturer, model, serialnumber, accountnumber, organization, ec, building, room, value, notes) VALUES ('" +
                                    item.ToUpper() + "','" + manufacturer + "','" +
                                    model + "','" + serialnumber + "','" + owner + "','" + organization + "','" +
                                    ec + "','" + building + "','" + room + "','" + value + "','" + notes + "')";

                    mysql.InsertQuery(NewAssetQuery);
                    Settings.Default.WorkingCustodian = ec;
                    Settings.Default.WorkingOrganization = organization;
                    Settings.Default.WorkingAccount = owner;
                    Settings.Default.Save();
                    this.Close();
                    mysql.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Asset already exists.");
                }

            }
          
        }

        private void ECSelectionButton_Click(object sender, EventArgs e)
        {
            CustodianSelectionSearch CustodianSelection = new CustodianSelectionSearch();
            CustodianSelection.UserSelectingCustodian = this.UserCreatingAsset;
            CustodianSelection.Show();
            this.Close();
        }

        private void AddBatchButton_Click(object sender, EventArgs e)
        {
            try
            {
                NewAssetBatch NewAssetBatch = new NewAssetBatch();
                NewAssetBatch.UserAddingAssetBatch = this.UserCreatingAsset;
                NewAssetBatch.item = NewItemType.SelectedItem.ToString();
                NewAssetBatch.manufacturer = NewItemManufacturer.Text;
                NewAssetBatch.model = NewItemModel.Text;
                NewAssetBatch.serialnumber = NewItemSerialNumber.Text;
                NewAssetBatch.owner = NewItemOwner.Text;
                NewAssetBatch.org = NewItemOrganization.Text;
                NewAssetBatch.ec = NewEC.Text;
                NewAssetBatch.bldg = NewBuilding.Text;
                NewAssetBatch.room = NewRoom.Text;
                NewAssetBatch.value = NewEstimatedValue.Text;
                NewAssetBatch.notes = NewAssetNotes.Text + "# asset added " + DateTime.Now;
                this.Close();
                NewAssetBatch.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill out the form prior to adding batch of serial numbers for the assets.");
            }
        }

        private void AssetBatchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AssetBatchCheckBox.Checked == false)
            {
                NewItemSerialNumber.Enabled = true;
                AddBatchButton.Enabled = false;
            }
            else
            {
                NewItemSerialNumber.Enabled = false;
                AddBatchButton.Enabled = true;
            }
        }
    }
}
