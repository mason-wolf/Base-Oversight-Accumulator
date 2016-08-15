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
    public partial class TransferDetailView : Form
    {
        public string TransferID { get; set; }
        public TransferDetailView()
        {
            InitializeComponent();
        }

        private void TransferDetailView_Load(object sender, EventArgs e)
        {
            dbconnect mysql = new dbconnect();
            mysql.OpenConnection();
            string query = "SELECT * from transfers WHERE id='" + TransferID + "'";
            mysql.SelectQuery(query);
            while(mysql.Result.Read())
            {
                string item = mysql.Reader("item");
                string transferto = mysql.Reader("transferto");
                string transferfrom = mysql.Reader("transferfrom");
                string transferdate = mysql.Reader("transferdate");
                string serialnumber = mysql.Reader("serialnumber");
                string losingaccount = mysql.Reader("losingaccount");
                string gainingaccount = mysql.Reader("gainingaccount");
                string transferby = mysql.Reader("transferby");
                string notes = mysql.Reader("notes");

                ItemField.Text = item;
                TransferToField.Text = transferto;
                TransferFromField.Text = transferfrom;
                DateField.Text = transferdate;
                SerialNumberField.Text = serialnumber;
                LosingAccountField.Text = losingaccount;
                GainingAccountField.Text = gainingaccount;
                TransferByField.Text = transferby;
                NotesField.Text = notes;
                this.Text = " " + item.ToUpper() + " " + serialnumber.ToUpper();
            }
            mysql.CloseConnection();
        }

        private void RemoveTransferButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove transfer history of this item? This action cannot be undone.",
"Confirm Transfer Removal", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                    dbconnect mysql = new dbconnect();
                    string query = "DELETE from transfers WHERE id=" + TransferID;
                    mysql.InsertQuery(query);
                    this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
