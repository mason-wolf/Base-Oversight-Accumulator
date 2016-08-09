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
    public partial class AccountDetailView : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;

        public string gridid { get; set; }
        public string AssetAccountNumber { get; set; }

        public AccountDetailView()
        {
            InitializeComponent();
        }

        private void AccountDetailView_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "boa";
            user = "root";
            password = "root";
            string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionstring);

            connection.Open();
            
            // account id
            MySqlCommand AssetIDQuery = connection.CreateCommand();
            AssetIDQuery.CommandText = "SELECT * FROM itam where id=" + gridid;
            AssetIDQuery.Connection = connection;
            MySqlDataReader AssetIDResult = AssetIDQuery.ExecuteReader();
            while (AssetIDResult.Read())
            {
                AssetAccountNumber = Convert.ToString(AssetIDResult["account"]);
            }
            connection.Close();

            // total assets
            connection.Open();
            int count;
            string query = "SELECT Count(*) FROM assets WHERE accountnumber='" + AssetAccountNumber + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            count = int.Parse(cmd.ExecuteScalar().ToString());
            TotalAssetsField.Text = count.ToString();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
