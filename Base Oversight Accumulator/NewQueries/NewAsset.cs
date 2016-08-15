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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void NewAssetWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

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

                string NewAssetQuery = "INSERT INTO assets(item, manufacturer, model, serialnumber, accountnumber, organization, ec, building, room, value, notes) VALUES ('" +
                                item + "','" + manufacturer + "','" +
                                model + "','" + serialnumber + "','" + owner + "','" + organization + "','" +
                                ec + "','" + building + "','" + room + "','" + value + "','" + notes + "')";

                mysql.InsertQuery(NewAssetQuery);
               
                this.Close();
                
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
