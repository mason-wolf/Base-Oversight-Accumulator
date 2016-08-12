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
    public partial class AccountWindow : Form
    {
        public string UserViewingAccounts { get; set; }
        public AccountWindow()
        {
            InitializeComponent();
            dbconnect mysql = new dbconnect();

            AccountDataView.Rows.Clear();
            AccountDataView.RowTemplate.Height = 20;

            mysql.OpenConnection();
            string AccountCount = mysql.CountQuery("SELECT COUNT(*) FROM itam");
            this.Text = " " + AccountCount + " Accounts";
            mysql.SelectQuery("SELECT * FROM itam ORDER BY id DESC");

            int AccountC = 0;
            while (mysql.Result.Read())
            {
                string AccountID = mysql.Reader("id");
                string AccountDRA = mysql.Reader("dra");
                string AccountOrg = mysql.Reader("org");
                string AccountLastInventoryDate = mysql.Reader("lastinventory");
                string AccountInventoryDue = mysql.Reader("inventorydue");
                string AccountNotes = mysql.Reader("notes");
                string AccountEC = mysql.Reader("ec");
                string AccountNumber = mysql.Reader("account");
                string AccountStatus = mysql.Reader("status");

                AccountDataView.Rows.Add(AccountID, AccountNumber, AccountEC, AccountDRA, AccountOrg, AccountLastInventoryDate, AccountInventoryDue, AccountNotes, AccountStatus);
                AccountC++;
                if (AccountC == 1000)
                {
                    break;
                }
            }

            mysql.CloseConnection();
        }

        private void AccountDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string GridID = AccountDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
                AccountDetailView AccountDetailView = new AccountDetailView();
                AccountDetailView.gridid = GridID;
                AccountDetailView.UserViewingAccount = UserViewingAccounts;
                AccountDetailView.Show();
            }
            catch { }
        }

        private void AccountWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
