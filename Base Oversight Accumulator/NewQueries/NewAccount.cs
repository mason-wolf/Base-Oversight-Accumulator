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
    public partial class NewAccount : Form
    {
        public string UserCreatingAccount { get; set; }
        public NewAccount()
        {
            InitializeComponent();
        }

        private void NewAccountButton_Click(object sender, EventArgs e)
        {
            string newAccountDRA = DRAField.Text;
            string newAccount = AccountNumberField.Text;
            string newAccountOrg = OrganizationField.Text;

            dbconnect mysql = new dbconnect();

            string query = "INSERT INTO itam(dra, account, org, status) VALUES ('" + newAccountDRA + "','" + newAccount +
                "','" + newAccountOrg + "', 'NORMAL')";

            string NewAccountLog = "INSERT INTO log (date, who, action, account) VALUES ('" + DateTime.Now.ToString() + "','" + this.UserCreatingAccount + "', 'CREATED ACCOUNT " + newAccount + "','" + newAccount + "')";
            mysql.InsertQuery(NewAccountLog);
            mysql.InsertQuery(query);
            this.Close();
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
