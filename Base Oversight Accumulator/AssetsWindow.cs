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
    public partial class AssetsWindow : Form
    {
        public string UserViewingAssetWindow { get; set; }
        public AssetsWindow()
        {
            InitializeComponent();
            dbconnect mysql = new dbconnect();
            mysql.OpenConnection();
            string AssetCount = mysql.CountQuery("SELECT COUNT(*) FROM assets");
            this.Text = " Assets: " + AssetCount + " Items";

            AssetDataView.Rows.Clear();
            AssetDataView.RowTemplate.Height = 20;

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
            mysql.CloseConnection();
        }

        private void AssetDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string GridID = AssetDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
                AssetDetailView AssetDetailView = new AssetDetailView();
                AssetDetailView.selectedID = GridID;
                AssetDetailView.UserViewingAsset = UserViewingAssetWindow;
                AssetDetailView.Show();
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

    }
}
