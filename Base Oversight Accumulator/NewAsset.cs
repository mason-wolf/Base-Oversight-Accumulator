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
        public NewAssetWindow()
        {
            InitializeComponent();
            NewItemType.Text = "Desktop";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string newAsset_itemType = NewItemType.Text;
            string newAsset_itemManufacturer = NewItemManufacturer.Text;
            string newAsset_itemModel = NewItemModel.Text;
            string newAsset_itemSerialNumber = NewItemSerialNumber.Text;
            string newAsset_itemOwner = NewItemOwner.Text;
            string newAsset_itemOrganization = NewItemOrganization.Text;
            string newAsset_EC = NewEC.Text;
            string newAsset_NewBuilding = NewBuilding.Text;
            string newAsset_NewRoom = NewRoom.Text;
            string newAsset_NewValue = NewEstimatedValue.Text;
            string newAsset_Notes = NewAssetNotes.Text + "# asset added " + DateTime.Now;

            dbconnect mysql = new dbconnect();

            string query = "INSERT INTO assets(item, manufacturer, model, serialnumber, accountnumber, organization, ec, building, room, value, notes) VALUES ('" +
                            newAsset_itemType + "','" + newAsset_itemManufacturer + "','" +
                            newAsset_itemModel + "','" + newAsset_itemSerialNumber + "','" + newAsset_itemOwner + "','" + newAsset_itemOrganization + "','" +
                            newAsset_EC + "','" + newAsset_NewBuilding + "','" + newAsset_NewRoom + "','" + newAsset_NewValue + "','" + newAsset_Notes + "')";

            mysql.insert(query);
            this.Close();
          
        }

        private void ECSelectionButton_Click(object sender, EventArgs e)
        {
            CustodianSelection CustodianSelection = new CustodianSelection();
            CustodianSelection.Show();
            this.Close();
        }
    }
}
