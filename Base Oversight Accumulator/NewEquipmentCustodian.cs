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
    public partial class NewECWindow : Form
    {

        public string selectedEC { get; set; }

        public NewECWindow()
        {
            InitializeComponent();
        }

        private void NewECWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastname = NewECLastName.Text;
            string firstname = NewECFirstName.Text;
            string rank = NewECRank.Text;
            string org = NewECOrg.Text;
            string email = NewECEmail.Text;
            string dsn = NewECDSN.Text;
            string account = NewECAcct.Text;
            string location = NewECLocation.Text;

            try
            {
                dbconnect mysql = new dbconnect();

                string NewECQuery = "INSERT INTO ec(lastname, firstname, rank, org, email, dsn, account, location) VALUES ('" +
                    lastname + "','" + firstname + "','" + rank + "','" + org + "','" + email + "','" +
                    dsn + "','" + account + "','" + location + "')";

                string AccountUpdateQuery = "UPDATE itam SET ec='" + rank.ToUpper() + " " + lastname.ToUpper() + "," + firstname.ToUpper() +
                    "' where account='" + account + "'";

                string AssetUpdateQuery = "UPDATE assets SET ec='" + rank.ToUpper() + " " + lastname.ToUpper() + "," + firstname.ToUpper() +
                   "' where account='" + account + "'";

                mysql.insert(NewECQuery);
                mysql.insert(AccountUpdateQuery);
                mysql.insert(AssetUpdateQuery);
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
