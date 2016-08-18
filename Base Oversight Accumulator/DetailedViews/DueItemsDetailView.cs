using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_Oversight_Accumulator.DetailedViews
{
    public partial class DueItemsDetailView : Form
    {
        public List<string> AccountsDue { get; set; }

        public DueItemsDetailView()
        {
            InitializeComponent();
        }

        private void DueItemsDetailView_Load(object sender, EventArgs e)
        {
            dbconnect mysql = new dbconnect();
            foreach(string item in AccountsDue)
            {
                mysql.SelectQuery("SELECT * from itam where inventorydue LIKE '%" + item.Remove(9) + "%'");
                while(mysql.Result.Read())
                {
                    string AccountDue = mysql.Reader("account");
                    AccountsList.Items.Add(AccountDue);
                }
                mysql.CloseConnection();
            }
        }

        private void ViewAccountButton_Click(object sender, EventArgs e)
        {
            dbconnect mysql = new dbconnect();
            string WhichAccount = AccountsList.GetItemText(AccountsList.SelectedItem);
            mysql.SelectQuery("SELECT * from itam where account='" + WhichAccount + "'");
            while(mysql.Result.Read())
            {
                string id = mysql.Reader("id");
                AccountDetailView Account = new AccountDetailView();
                Account.gridid = id;
                Account.Show();
                this.Hide();
            }
        }
    }
}
