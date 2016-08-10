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
    public partial class CustodianSelection : Form
    {


        public CustodianSelection()
        {
            InitializeComponent();
        }

        public void CustodianSelection_Load(object sender, EventArgs e)
        {
        }
        
        private void ECDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string GridID = ECDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
            NewAssetWindow NewAssetWindow = new NewAssetWindow();

            dbconnect mysql = new dbconnect();
            mysql.SelectQuery("SELECT * FROM ec WHERE id=" + GridID);

            DataTable ECDataTable = new DataTable();

            ECDataTable.Columns.Add("Last Name", typeof(String));
            ECDataTable.Columns.Add("First Name", typeof(String));
            ECDataTable.Columns.Add("Rank", typeof(String));

            while (mysql.Result.Read())
            {
                string ECLastName = mysql.Reader("lastname");
                string ECFirstName = mysql.Reader("firstname");
                string ECRank = mysql.Reader("rank");
                NewAssetWindow.NewEC.Text = ECLastName.ToUpper() + ", " + ECFirstName.ToUpper() + " " + ECRank.ToUpper();
                    NewAssetWindow.Show();

            }

            mysql.CloseConnection();
           
            this.Close();
        }

        public void ECKeyWords_TextChanged(object sender, EventArgs e)
        {
            dbconnect mysql = new dbconnect();
            mysql.SelectQuery("SELECT * from ec");

            DataTable ECDataTable = new DataTable();
            ECDataTable.Columns.Add("ID", typeof(String));

            ECDataTable.Columns.Add("Last Name", typeof(String));
            ECDataTable.Columns.Add("First Name", typeof(String));
            ECDataTable.Columns.Add("Rank", typeof(String));
            ECDataTable.Columns.Add("Org", typeof(String));
            ECDataTable.Columns.Add("Email", typeof(String));
            ECDataTable.Columns.Add("DSN", typeof(String));
            ECDataTable.Columns.Add("Acct#", typeof(String));

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


                ECDataTable.Rows.Add(ECID, ECLastName, ECFirstName, ECRank, ECOrg, ECEmail, ECDSN, ECAccount);
                
            }
            ECDataView.DataSource = ECDataTable;
            mysql.CloseConnection();

            BindingSource bs = new BindingSource();
            bs.DataSource = ECDataView.DataSource;
            bs.Filter = "[Last Name] Like '%" + ECKeyWords.Text + "%'";
            ECDataView.DataSource = bs;
        }

    }
}

