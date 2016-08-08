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

            string query = "INSERT INTO itam(dra, account, org) VALUES ('" + newAccountDRA + "','" + newAccount +
                "','" + newAccountOrg + "')";
            mysql.insert(query);
            this.Close();
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
