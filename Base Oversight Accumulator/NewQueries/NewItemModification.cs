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
            UpdateItemType UpdateItems = new UpdateItemType();

            foreach (DataGridViewCell cell in AssetDataView.SelectedCells)
            {
                UpdateItems.ItemsToUpdate.Add(cell.Value.ToString());
            }

            UpdateItems.Show();
        }

        private void ChangeManufacturerButton_Click(object sender, EventArgs e)
        {
            UpdateItemManufacturer UpdateItemManufacturer = new UpdateItemManufacturer();

            foreach (DataGridViewCell cell in AssetDataView.SelectedCells)
            {
                UpdateItemManufacturer.ItemsToUpdate.Add(cell.Value.ToString());
            }

            UpdateItemManufacturer.Show();
        }

        private void ChangeModelButton_Click(object sender, EventArgs e)
        {
            UpdateItemModel UpdateItemModel = new UpdateItemModel();

            foreach (DataGridViewCell cell in AssetDataView.SelectedCells)
            {
                UpdateItemModel.ItemsToUpdate.Add(cell.Value.ToString());
            }

            UpdateItemModel.Show();
        }

        private void ChangeLocationButton_Click(object sender, EventArgs e)
        {
            UpdateItemLocation UpdateItemLocation = new UpdateItemLocation();

            foreach (DataGridViewCell cell in AssetDataView.SelectedCells)
            {
                UpdateItemLocation.ItemsToUpdate.Add(cell.Value.ToString());
            }

            UpdateItemLocation.Show();
        }
    }
}

