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
    public partial class TransferWindow : Form
    {
        public string UserViewingTransfers { get; set;}
        public TransferWindow()
        {
            InitializeComponent();
            // populate equipment custodians
            dbconnect mysql = new dbconnect();
            mysql.OpenConnection();
            string TransferCount = mysql.CountQuery("SELECT COUNT(*) FROM transfers");
            this.Text = " " + TransferCount + " Transfers";

            TransferDataView.Rows.Clear();
            TransferDataView.RowTemplate.Height = 20;

            mysql.OpenConnection();
            mysql.SelectQuery("SELECT * FROM transfers ORDER BY id DESC");
            int TransferC = 0;

            while (mysql.Result.Read())
            {
                string TransferID = mysql.Reader("id");
                string TransferItem = mysql.Reader("item");
                string TransferTo = mysql.Reader("transferto");
                string TransferFrom = mysql.Reader("transferfrom");
                string TransferDate = mysql.Reader("transferdate");
                string TransferSN = mysql.Reader("serialnumber");
                string TransferLosing = mysql.Reader("losingaccount");
                string TransferGaining = mysql.Reader("gainingaccount");
                string TransferBy = mysql.Reader("transferby");
                string TransferNotes = mysql.Reader("notes");


                TransferDataView.Rows.Add(TransferID, TransferItem, TransferTo, TransferFrom,
                    TransferDate, TransferSN, TransferLosing, TransferGaining, TransferBy, TransferNotes);
                TransferC++;
                if (TransferC == 1000)
                {
                    break;
                }
            }
        }

        private void TransferWindow_Load(object sender, EventArgs e)
        {

        }

        private void TransferDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string GridID = TransferDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
                TransferDetailView TransferDetailView = new TransferDetailView();
                TransferDetailView.TransferID = GridID;
                TransferDetailView.Show();
            }
            catch { }
        }
    }
}
