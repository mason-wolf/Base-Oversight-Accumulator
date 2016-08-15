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
    public partial class TransferSearch : Form
    {
   //     public string UserSelectingTransfer { get; set; }

        public TransferSearch()
        {
            InitializeComponent();
        }

        private void TransferDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string GridID = TransferDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
            TransferDetailView TransferView = new TransferDetailView();

            dbconnect mysql = new dbconnect();
            mysql.SelectQuery("Select * from transfers where id='" + GridID +"'");


            while(mysql.Result.Read())
            {
                string id = mysql.Reader("id");
                TransferView.TransferID = id;
                TransferView.Show();
            }
            mysql.CloseConnection();
            this.Close();
        }

        private void FromAccountField_TextChanged(object sender, EventArgs e)
        {
            dbconnect mysql = new dbconnect();
            mysql.SelectQuery("SELECT * from transfers");

            DataTable TransferTable = new DataTable();
            TransferTable.Columns.Add("ID", typeof(String));
            TransferTable.Columns.Add("From", typeof(String));
            TransferTable.Columns.Add("To", typeof(String));
            TransferTable.Columns.Add("Item", typeof(String));
            TransferTable.Columns.Add("Date", typeof(String));

            while (mysql.Result.Read())
            {
                string id = mysql.Reader("id");
                string from = mysql.Reader("losingaccount");
                string to = mysql.Reader("gainingaccount");
                string item = mysql.Reader("serialnumber");
                string date = mysql.Reader("transferdate");

                TransferTable.Rows.Add(id, from, to, item, date);
            }
            TransferDataView.DataSource = TransferTable;
            mysql.CloseConnection();

            BindingSource bs = new BindingSource();
            bs.DataSource = TransferDataView.DataSource;
            bs.Filter = "[From] Like '%" + FromAccountField.Text + "%'";
            TransferDataView.DataSource = bs;
            TransferDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
