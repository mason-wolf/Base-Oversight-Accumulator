using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_Oversight_Accumulator.NewQueries
{
    public partial class NewItemModification : Form
    {
        public NewItemModification()
        {
            InitializeComponent();
        }

        private void NewItemModification_Load(object sender, EventArgs e)
        {
            AssetDataView.Rows.Clear();
            AssetDataView.RowTemplate.Height = 20;

            dbconnect mysql = new dbconnect();

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
        }

        private void ChangeItemButton_Click(object sender, EventArgs e)
        {
            UpdateItemType UpdateItemType = new UpdateItemType();

            foreach (DataGridViewRow row in AssetDataView.SelectedRows)
            {
                UpdateItemType.ItemsToUpdate.Add(row.Cells[0].Value.ToString());
            }

            UpdateItemType.Show();
        }

        private void ChangeManufacturerButton_Click(object sender, EventArgs e)
        {
            UpdateItemManufacturer UpdateItemManufacturer = new UpdateItemManufacturer();

            foreach (DataGridViewRow row in AssetDataView.SelectedRows)
            {
                UpdateItemManufacturer.ItemsToUpdate.Add(row.Cells[0].Value.ToString());
            }

            UpdateItemManufacturer.Show();
        }

        private void ChangeModelButton_Click(object sender, EventArgs e)
        {
            UpdateItemModel UpdateItemModel = new UpdateItemModel();

            foreach (DataGridViewRow row in AssetDataView.SelectedRows)
            {
                UpdateItemModel.ItemsToUpdate.Add(row.Cells[0].Value.ToString());
            }

            UpdateItemModel.Show();
        }

        private void ChangeLocationButton_Click(object sender, EventArgs e)
        {
            UpdateItemLocation UpdateItemLocation = new UpdateItemLocation();

            foreach (DataGridViewRow row in AssetDataView.SelectedRows)
            {
                UpdateItemLocation.ItemsToUpdate.Add(row.Cells[0].Value.ToString());
            }

            UpdateItemLocation.Show();
        }

        private void ChangeOrgButton_Click(object sender, EventArgs e)
        {
            UpdateItemOrganization UpdateItemOrganization = new UpdateItemOrganization();

            foreach (DataGridViewRow row in AssetDataView.SelectedRows)
            {
                UpdateItemOrganization.ItemsToUpdate.Add(row.Cells[0].Value.ToString());
            }

            UpdateItemOrganization.Show();
        }
    }
}

