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
    public partial class CustodianWindow : Form
    {
        public string UserViewingCustodians { get; set; }
        public CustodianWindow()
        {
            InitializeComponent();

            // populate equipment custodians
            dbconnect mysql = new dbconnect();
            mysql.OpenConnection();
            string ECCount = mysql.CountQuery("SELECT COUNT(*) FROM ec");
            this.Text = " " + ECCount + " Custodians";

            ECDataView.Rows.Clear();
            ECDataView.RowTemplate.Height = 20;

            mysql.SelectQuery("SELECT * FROM ec ORDER BY id DESC");

            int CustodianCount = 0;

            while (mysql.Result.Read())
            {
                string ECID = mysql.Reader("id");
                string ECLastName = mysql.Reader("lastname");
                string ECFirstName = mysql.Reader("firstname");
                string ECRank = mysql.Reader("rank");
                string ECOrg = mysql.Reader("org");
                string ECEmail = mysql.Reader("email");
                string ECDSN = mysql.Reader("dsn");
                string ECAccount = mysql.Reader("account");
                string ECLocation = mysql.Reader("location");

                ECDataView.Rows.Add(ECID, ECLastName, ECFirstName, ECRank, ECAccount, ECEmail, ECDSN, ECOrg, ECLocation);
                CustodianCount++;

                if (CustodianCount == 1000)
                {
                    break;
                }
            }

            mysql.CloseConnection();
        }

        private void ECDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string GridID = ECDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
                CustodianDetailView CustodianDetailView = new CustodianDetailView();
                CustodianDetailView.UserViewingCustodian = UserViewingCustodians;
                CustodianDetailView.selectedID = GridID;
                CustodianDetailView.Show();
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        private void ECDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
