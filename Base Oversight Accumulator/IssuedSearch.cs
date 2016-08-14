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
    public partial class IssuedSearch : Form
    {
        public string UserSearchingIssued { get; set; }

        public IssuedSearch()
        {
            InitializeComponent();
        }

        private void TicketNumberField_TextChanged(object sender, EventArgs e)
        {
            dbconnect mysql = new dbconnect();
            mysql.SelectQuery("SELECT * from issued");
            DataTable IssuedTable = new DataTable();
            IssuedTable.Columns.Add("ID", typeof(String));  
            IssuedTable.Columns.Add("Issued To", typeof(String));   // issuedto
            IssuedTable.Columns.Add("Issued By", typeof(String));   // issuedby
            IssuedTable.Columns.Add("Date", typeof(String));        // dateofissue
            IssuedTable.Columns.Add("Items", typeof(String));       // items

            while (mysql.Result.Read())
            {
                string id = mysql.Reader("id");
                string issuedto = mysql.Reader("issuedto");
                string issuedby = mysql.Reader("issuedby");
                string date = mysql.Reader("dateofissue");
                string items = mysql.Reader("items");

                IssuedTable.Rows.Add(id, issuedto, issuedby, date, items);
            }
            IssuedDataView.DataSource = IssuedTable;
            mysql.CloseConnection();

            BindingSource bs = new BindingSource();
            bs.DataSource = IssuedDataView.DataSource;
            bs.Filter = "[ID] Like '%" + TicketNumberField.Text + "%'";
            IssuedDataView.DataSource = bs;
            IssuedDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void IssuedDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string GridID = IssuedDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
            IssuedItemsView IssuedItems = new IssuedItemsView();

            dbconnect mysql = new dbconnect();
            mysql.SelectQuery("SELECT * from transfers where id='" + GridID + "'");

            while(mysql.Result.Read())
            {
                string id = mysql.Reader("id");
                IssuedItems.ItemID = id;
                IssuedItems.Show();
            }
            mysql.CloseConnection();
            this.Close();
        }
    }
}
