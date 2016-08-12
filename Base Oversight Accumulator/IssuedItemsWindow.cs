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
    public partial class IssuedItemsWindow : Form
    {
        public string UserViewingItems { get; set; }

        public IssuedItemsWindow()
        {
            InitializeComponent();

            dbconnect mysql = new dbconnect();
            mysql.OpenConnection();
            string ItemCount = mysql.CountQuery("SELECT COUNT(*) FROM transfers");
            this.Text = " " + ItemCount + " Items";

            IssuedDataView.Rows.Clear();
            IssuedDataView.RowTemplate.Height = 20;

            mysql.OpenConnection();
            mysql.SelectQuery("SELECT * FROM issued ORDER BY id DESC");
            int ItemC = 0;

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

                ItemC++;
                if (ItemC == 1000)
                {
                    break;
                }
            }


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
    }
}
