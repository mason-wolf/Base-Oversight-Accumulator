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
    public partial class CustodianSelectionSearch : Form
    {
        public string UserSelectingCustodian { get; set; }

        public CustodianSelectionSearch()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(this.QuickSelect);
        }

        public void CustodianSelection_Load(object sender, EventArgs e)
        {
        }
        
        public void QuickSelect(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int selectedrowindex = ECDataView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = ECDataView.Rows[selectedrowindex];
                string GridID = Convert.ToString(selectedRow.Cells["ID"].Value);
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
                    string org = mysql.Reader("org");
                    string accountnumber = mysql.Reader("account");
                    NewAssetWindow.NewEC.Text = ECLastName.ToUpper() + ", " + ECFirstName.ToUpper() + " " + ECRank.ToUpper();
                    NewAssetWindow.NewItemOwner.Text = accountnumber;
                    NewAssetWindow.NewItemOrganization.Text = org;
                    NewAssetWindow.UserCreatingAsset = UserSelectingCustodian;
                    NewAssetWindow.Show();

                }

                mysql.CloseConnection();

                this.Close();
            }
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
                string org = mysql.Reader("org");
                string accountnumber = mysql.Reader("account");
                NewAssetWindow.NewEC.Text = ECLastName.ToUpper() + ", " + ECFirstName.ToUpper() + " " + ECRank.ToUpper();
                NewAssetWindow.UserCreatingAsset = UserSelectingCustodian;
                NewAssetWindow.NewItemOwner.Text = accountnumber;
                NewAssetWindow.NewItemOrganization.Text = org;
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
            ECDataTable.Columns.Add("Acct#", typeof(String));
            ECDataTable.Columns.Add("Email", typeof(String));
            ECDataTable.Columns.Add("DSN", typeof(String));
            ECDataTable.Columns.Add("Org", typeof(String));

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


                ECDataTable.Rows.Add(ECID, ECLastName, ECFirstName, ECRank, ECAccount, ECEmail, ECDSN, ECOrg);
                
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

