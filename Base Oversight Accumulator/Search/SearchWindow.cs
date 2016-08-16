using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Base_Oversight_Accumulator
{
    public partial class SearchWindow : Form
    {
        public string UserPerformingSearch { get; set; }
        public string SearchItem { get; set; }
        public string Table { get; set; }
        public SearchWindow()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(this.QuickSearch);
        }

        public void QuickSearch(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton.PerformClick();
            }
        }

        private void SearchWindow_Load(object sender, EventArgs e)
        {
            if (SearchItem == "assets")
            {
                SearchTermLabel.Text = "S/N: ";
                this.Text = " Search Assets";
                Table = "assets";
            }

            if (SearchItem == "ec")
            {
                SearchTermLabel.Text = "Last Name: ";
                this.Text = " Search Equipment Custodians";
                Table = "ec";
            }

            if (SearchItem == "accounts")
            {
                SearchTermLabel.Text = "Acct#: ";
                this.Text = "Search Accounts";
                Table = "itam";
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (Table == "assets")
            {
                dbconnect mysql = new dbconnect();
                mysql.OpenConnection();
                string query = "select* from " + Table + " WHERE serialnumber = '" + SearchTerms.Text + "'";
                mysql.SelectQuery(query);
                if (mysql.Result.Read() == false)
                {
                    ErrorMessage.Visible = true;
                    ErrorMessage.Text = "Item not found.";
                }
                mysql.CloseConnection();
                mysql.OpenConnection();
                mysql.SelectQuery(query);
                while (mysql.Result.Read())
                {
                    string id = mysql.Reader("id");
                    AssetDetailView AssetView = new AssetDetailView();
                    AssetView.UserViewingAsset = UserPerformingSearch;
                    AssetView.selectedID = id;
                    AssetView.Show();
                    this.Close();
                }
                mysql.CloseConnection();
            }
            if(Table == "ec")
            {
                dbconnect mysql = new dbconnect();
                mysql.OpenConnection();
                string query = "select * from " + Table + " where lastname='" + SearchTerms.Text + "'";
                mysql.SelectQuery(query);
                if(mysql.Result.Read() == false)
                {
                    ErrorMessage.Visible = true;
                    ErrorMessage.Text = "Equipment custodian not found.";
                }
                mysql.CloseConnection();
                mysql.OpenConnection();
                mysql.SelectQuery(query);
                while(mysql.Result.Read())
                {
                    string id = mysql.Reader("id");
                    CustodianDetailView CustodianView = new CustodianDetailView();
                    CustodianView.UserViewingCustodian = UserPerformingSearch;
                    CustodianView.selectedID = id;
                    CustodianView.Show();
                    this.Close();
                }
            }

            if (Table == "itam")
            {
                dbconnect mysql = new dbconnect();
                mysql.OpenConnection();
                string query = "select* from " + Table + " WHERE account = '" + SearchTerms.Text + "'";
                mysql.SelectQuery(query);
                if (mysql.Result.Read() == false)
                {
                    ErrorMessage.Visible = true;
                    ErrorMessage.Text = "Account not found.";
                }
                mysql.CloseConnection();
                mysql.OpenConnection();
                mysql.SelectQuery(query);
                while (mysql.Result.Read())
                {
                    string id = mysql.Reader("id");
                    AccountDetailView AccountView = new AccountDetailView();
                    AccountView.UserViewingAccount = UserPerformingSearch;
                    AccountView.gridid = id;
                    AccountView.Show();
                    this.Close();
                }
                mysql.CloseConnection();
            }

        }

        }
    }
        





    

