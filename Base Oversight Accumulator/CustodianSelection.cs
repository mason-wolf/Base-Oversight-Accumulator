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
    public partial class CustodianSelection : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
   

        public CustodianSelection()
        {
            InitializeComponent();
            this.ActiveControl = ECKeyWords;
        }

        public void CustodianSelection_Load(object sender, EventArgs e)
        {
        }
        
        private void ECDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string GridID = ECDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
            NewAssetWindow NewAssetWindow = new NewAssetWindow();

            connection.Open();
            MySqlCommand ECQuery = connection.CreateCommand();
            ECQuery.CommandText = "SELECT * FROM ec WHERE id=" + GridID;
            ECQuery.Connection = connection;
            MySqlDataReader ECQueryResult = ECQuery.ExecuteReader();
            DataTable ECDataTable = new DataTable();
            ECDataTable.Columns.Add("Last Name", typeof(String));
            ECDataTable.Columns.Add("First Name", typeof(String));
            ECDataTable.Columns.Add("Rank", typeof(String));

            while (ECQueryResult.Read())
            {
                string ECLastName = Convert.ToString(ECQueryResult["lastname"]);
                string ECFirstName = Convert.ToString(ECQueryResult["firstname"]);
                string ECRank = Convert.ToString(ECQueryResult["rank"]);
                NewAssetWindow.NewEC.Text = ECRank.ToUpper() + " " + ECLastName.ToUpper() + ", " + ECFirstName.ToUpper();
            }
            connection.Close();
            NewAssetWindow.Show();
            this.Close();
        }

        public void ECKeyWords_TextChanged(object sender, EventArgs e)
        {
            ECDataView.RowTemplate.Height = 15;
            server = "localhost";
            database = "boa";
            user = "root";
            password = "root";
            string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionstring);

            connection.Open();
            MySqlCommand ECQuery = connection.CreateCommand();
            ECQuery.CommandText = "SELECT * FROM ec";
            ECQuery.Connection = connection;
            MySqlDataReader ECQueryResult = ECQuery.ExecuteReader();
            DataTable ECDataTable = new DataTable();
            ECDataTable.Columns.Add("ID", typeof(String));
            ECDataTable.Columns.Add("Last Name", typeof(String));
            ECDataTable.Columns.Add("First Name", typeof(String));
            ECDataTable.Columns.Add("Rank", typeof(String));
            ECDataTable.Columns.Add("Org", typeof(String));
            ECDataTable.Columns.Add("Email", typeof(String));
            ECDataTable.Columns.Add("DSN", typeof(String));
            ECDataTable.Columns.Add("Acct#", typeof(String));

            while (ECQueryResult.Read())
            {
                string ECID = Convert.ToString(ECQueryResult["id"]);
                string ECLastName = Convert.ToString(ECQueryResult["lastname"]);
                string ECFirstName = Convert.ToString(ECQueryResult["firstname"]);
                string ECRank = Convert.ToString(ECQueryResult["rank"]);
                string ECOrg = Convert.ToString(ECQueryResult["org"]);
                string ECEmail = Convert.ToString(ECQueryResult["email"]);
                string ECDSN = Convert.ToString(ECQueryResult["dsn"]);
                string ECAccount = Convert.ToString(ECQueryResult["account"]);
                string ECLocation = Convert.ToString(ECQueryResult["location"]);
      
                ECDataTable.Rows.Add(ECID, ECLastName, ECFirstName, ECRank, ECOrg, ECEmail, ECDSN, ECAccount);
                
            }
            ECDataView.DataSource = ECDataTable;
            connection.Close();

            BindingSource bs = new BindingSource();
            bs.DataSource = ECDataView.DataSource;
            bs.Filter = "[Last Name] Like '%" + ECKeyWords.Text + "%'";
            ECDataView.DataSource = bs;
        }

    }
}

