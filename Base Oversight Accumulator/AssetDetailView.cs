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

namespace Base_Oversight_Accumulator
{
    public partial class AssetDetailView : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        public string selectedID { get; set; }
        public string ec { get; private set; }

        public AssetDetailView()
        {
            InitializeComponent();

        }

        private void AssetDetailView_Load(object sender, EventArgs e)
        { 

            server = "localhost";
            database = "boa";
            user = "root";
            password = "root";
            string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionstring);

            connection.Open();
            MySqlCommand AssetIDQuery = connection.CreateCommand();
            AssetIDQuery.CommandText = "SELECT * FROM assets where id=" + selectedID;
            AssetIDQuery.Connection = connection;
            MySqlDataReader AssetIDResult = AssetIDQuery.ExecuteReader();
            while (AssetIDResult.Read())
            {
                string id = Convert.ToString(AssetIDResult["id"]);
                string item = Convert.ToString(AssetIDResult["item"]);
                string serialnumber = Convert.ToString(AssetIDResult["serialnumber"]);
                string manufacturer = Convert.ToString(AssetIDResult["manufacturer"]);
                string model = Convert.ToString(AssetIDResult["model"]);
                string account = Convert.ToString(AssetIDResult["accountnumber"]);
                string organization = Convert.ToString(AssetIDResult["organization"]);
                string ec = Convert.ToString(AssetIDResult["ec"]);
                string building = Convert.ToString(AssetIDResult["building"]);
                string room = Convert.ToString(AssetIDResult["room"]);
                string value = Convert.ToString(AssetIDResult["value"]);
                string notes = Convert.ToString(AssetIDResult["notes"]);

 
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
            connection.Close();
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

                string query = "UPDATE assets SET item='" + AssetType + "', serialnumber='" + SerialNumber + "', manufacturer='" +
                    Manufacturer + "', model='" + Model + "', accountnumber='" + AccountNumber + "', organization='" + Organization +
                    "', building='" + Building + "', room='" + Room + "',value='" + Value + "', notes='" + Notes + "' where id='" + ID + "'";
                mysql.insert(query);

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
                dbconnect mysql = new dbconnect();
                string ID = AssetID.Text;
                string query = "DELETE from assets WHERE id=" + ID;
                mysql.insert(query);
                this.Close();
            }
       
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            transfer.LosingAccountField.Text = AccountField.Text;
            transfer.SerialNumberField.Text = SerialNumberField.Text;
            this.Close();
            transfer.Show();
        }
    }
}
