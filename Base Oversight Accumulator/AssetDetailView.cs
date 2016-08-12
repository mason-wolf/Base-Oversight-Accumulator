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
    public partial class AssetDetailView : Form
    {

        public string selectedID { get; set; }
        public string ec { get; private set; }
        public string UserViewingAsset { get; set; }

        public AssetDetailView()
        {
            InitializeComponent();

        }

        private void AssetDetailView_Load(object sender, EventArgs e)
        {


            dbconnect mysql = new dbconnect();
            mysql.OpenConnection();
            mysql.SelectQuery("SELECT * FROM assets where id=" + selectedID);
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
                string value = mysql.Reader("value");
                string notes = mysql.Reader("notes");
                this.Text = manufacturer.ToUpper() + " " + model.ToUpper();
                AssetTypeField.Text = item.ToUpper();
                SerialNumberField.Text = serialnumber.ToUpper();
                ManufacturerField.Text = manufacturer.ToUpper();
                ModelField.Text = model.ToUpper();
                AccountField.Text = account.ToUpper();
                OrganizationField.Text = organization.ToUpper();
                ECField.Text = ec.ToUpper();
                BuildingField.Text = building.ToUpper();
                RoomField.Text = room.ToUpper();
                ValueField.Text = value.ToUpper();
                AssetNotes.Text = notes;
                AssetID.Text = id;
            }
            mysql.CloseConnection();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            AssetTypeField.ReadOnly = false;
            AssetTypeField.BackColor = Color.White;
            AssetTypeField.BorderStyle = BorderStyle.FixedSingle;

            SerialNumberField.ReadOnly = false;
            SerialNumberField.BackColor = Color.White;
            SerialNumberField.BorderStyle = BorderStyle.FixedSingle;

            ManufacturerField.ReadOnly = false;
            ManufacturerField.BackColor = Color.White;
            ManufacturerField.BorderStyle = BorderStyle.FixedSingle;

            ModelField.ReadOnly = false;
            ModelField.BackColor = Color.White;
            ModelField.BorderStyle = BorderStyle.FixedSingle;

            OrganizationField.ReadOnly = false;
            OrganizationField.BackColor = Color.White;
            OrganizationField.BorderStyle = BorderStyle.FixedSingle;

            BuildingField.ReadOnly = false;
            BuildingField.BackColor = Color.White;
            BuildingField.BorderStyle = BorderStyle.FixedSingle;

            RoomField.ReadOnly = false;
            RoomField.BackColor = Color.White;
            RoomField.BorderStyle = BorderStyle.FixedSingle;

            ValueField.ReadOnly = false;
            ValueField.BackColor = Color.White;
            ValueField.BorderStyle = BorderStyle.FixedSingle;

            EditButton.Enabled = false;
            SaveChangesButton.Visible = true;

            AssetNotes.ReadOnly = false;
            AssetNotes.BackColor = Color.White;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            dbconnect mysql = new dbconnect();
            string AssetType = AssetTypeField.Text;
            string SerialNumber = SerialNumberField.Text;
            string Manufacturer = ManufacturerField.Text;
            string Model = ModelField.Text;
            string AccountNumber = AccountField.Text;
            string Organization = OrganizationField.Text;
            string Building = BuildingField.Text;
            string Room = RoomField.Text;
            string Value = ValueField.Text;
            string Notes = AssetNotes.Text;
            string ID = AssetID.Text;

                string UpdateAssets = "UPDATE assets SET item='" + AssetType + "', serialnumber='" + SerialNumber + "', manufacturer='" +
                    Manufacturer + "', model='" + Model + "', accountnumber='" + AccountNumber + "', organization='" + Organization +
                    "', building='" + Building + "', room='" + Room + "',value='" + Value + "', notes='" + Notes + "' where id='" + ID + "'";
            mysql.InsertQuery(UpdateAssets);

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this asset?",
       "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                try
                {
                    dbconnect mysql = new dbconnect();
                    string ID = AssetID.Text;
                    string asset = ManufacturerField.Text + " " + ModelField.Text + " " + SerialNumberField.Text;
                    string DeleteAsset = "DELETE from assets WHERE id=" + ID;
                    mysql.InsertQuery(DeleteAsset);
                    mysql.InsertQuery("INSERT INTO log (date, who, action, account) VALUES ('" + DateTime.Now.ToString() + "','" + UserViewingAsset +
                        "','DELETED ASSET " + asset + " FROM ACCOUNT " + AccountField.Text + "','" + AccountField.Text + "')");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Asset has already been removed from database. Refresh view to see changes.");
                    this.Close();
                }
            }
       
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            transfer.TransferedBy = UserViewingAsset;
            transfer.LosingAccountField.Text = AccountField.Text;
            transfer.SerialNumberField.Text = SerialNumberField.Text;
            this.Close();
            transfer.Show();
        }

        private void ROS_Click(object sender, EventArgs e)
        {
            string description = ManufacturerField.Text + " " + ModelField.Text;
            string account = AccountField.Text;
            string value = ValueField.Text;
            string serialnumber = SerialNumberField.Text;

            ROSWindow ros = new ROSWindow();
            ros.UserCreatingROS = UserViewingAsset;
            ros.ItemAccount = account;
            ros.ItemSerialNumber = serialnumber;
            ros.ItemDescription = description;
            ros.ItemValue = value;
            ros.ROSItemSelected = true;
            ros.Show();
            this.Close();

        }

        private void DRMO_Click(object sender, EventArgs e)
        {
            PropertyDisposal drmo = new PropertyDisposal();
            drmo.ItemsDisposedBy = UserViewingAsset;
            drmo.ItemSelected = true;
            drmo.ItemSerialNumber = SerialNumberField.Text;
            drmo.ItemAccount = AccountField.Text;
            drmo.Show();
            this.Close();
        }
    }
}
