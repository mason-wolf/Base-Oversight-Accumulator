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
    public partial class IssuedItemsView : Form
    {
        public string ItemID { get; set; }
        public IssuedItemsView()
        {
            InitializeComponent();
        }

        private void IssuedItemsView_Load(object sender, EventArgs e)
        {
            dbconnect mysql = new dbconnect();
            mysql.OpenConnection();
            mysql.SelectQuery("select * from issued");
            while(mysql.Result.Read())
            {
                string issuedto = mysql.Reader("issuedto");
                string issuedby = mysql.Reader("issuedby");
                string account = mysql.Reader("account");
                string dsn = mysql.Reader("dsn");
                string dateofissue = mysql.Reader("dateofissue");
                string dateofreturn = mysql.Reader("dateofreturn");
                string items = mysql.Reader("items");
                string notes = mysql.Reader("notes");
                string returned = mysql.Reader("returned");
                if(returned == "YES")
                {
                    ReturnItemsButton.Enabled = false;
                    RemoveStatusButton.Enabled = false;
                }
                this.Text = " ITEMS ISSUED FROM " + issuedby.ToUpper() + " TO " + issuedto.ToUpper();
                IssuedToField.Text = issuedto;
                IssuedByField.Text = issuedby;
                FromAccountField.Text = account;
                DutyPhoneField.Text = dsn;
                IssueDateField.Text = dateofissue;
                ReturnDateField.Text = dateofreturn;
                ItemsField.Text = items;
                NotesField.Text = notes;
            }
            mysql.CloseConnection();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveStatusButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove 1297 status? This will revert the temporary issue. This action cannot be undone.",
"Confirm 1297 Status Removal", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                    dbconnect mysql = new dbconnect();
                    string query = "DELETE from issued WHERE id=" + ItemID;
                    mysql.InsertQuery(query);
                    this.Close();
            }
        }

        private void ReturnItemsButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Items have been returned?",
"Confirm Item Return", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dbconnect mysql = new dbconnect();
                string query = "UPDATE issued SET returned='YES', notes='#Items returned on: " + DateTime.Now.ToString() + "' WHERE id=" + ItemID;
                mysql.InsertQuery(query);
                this.Close();
            }
        }
    }
}
