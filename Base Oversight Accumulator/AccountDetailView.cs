﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Base_Oversight_Accumulator
{
    public partial class AccountDetailView : Form
    {
        public string gridid { get; set; }
        public string AssetAccountNumber { get; set; }
        public string AccountStatus { get; set; }
        public string AssetEquipmentCustodian { get; set; }
        public string UserViewingAccount { get; set; }

        public AccountDetailView()
        {
            InitializeComponent();
        }

        private void AccountDetailView_Load(object sender, EventArgs e)
        {
            // accounts
            dbconnect mysql = new dbconnect();
            mysql.OpenConnection();
            mysql.SelectQuery("SELECT * FROM itam where id=" + gridid);
            while (mysql.Result.Read())
            {
                AssetAccountNumber = mysql.Reader("account");
                AccountStatus = mysql.Reader("status");
                AccountNumberField.Text = AssetAccountNumber;
                AccountStatusField.Text = AccountStatus;
                if(AccountStatusField.Text == "NORMAL")
                {
                    AccountStatusField.BackColor = Color.Green;
                    AccountStatusField.ForeColor = Color.White;
                }
                if(AccountStatusField.Text == "FROZEN")
                {
                    AccountStatusField.BackColor = Color.Red;
                    AccountStatusField.ForeColor = Color.White;
                    UnfreezeAccountButton.Visible = true;
                    FreezeAccountButton.Enabled = false;
                }
            }
            mysql.CloseConnection();

            // total assets
            mysql.OpenConnection();
            string TotalAssets = mysql.CountQuery("SELECT COUNT(*) FROM assets WHERE accountnumber='" + AssetAccountNumber + "'");
            TotalAssetsField.Text = TotalAssets;


            // total asset value
            string TotalAssetValue = mysql.SumCurrencyQuery("SELECT SUM(value) FROM assets WHERE accountnumber='" + AssetAccountNumber + "'");
            TotalValueField.Text = TotalAssetValue;

            mysql.CloseConnection();

            // equipment custodian
            mysql.OpenConnection();
            mysql.SelectQuery("SELECT * FROM itam WHERE account='" + AssetAccountNumber + "'");
            while (mysql.Result.Read())
            {
                AssetEquipmentCustodian = mysql.Reader("ec");
                string InventoryDate = mysql.Reader("lastinventory");
                string InventoryDueDate = mysql.Reader("inventorydue");
                string Notes = mysql.Reader("notes");
                string org = mysql.Reader("org");
                ECField.Text = AssetEquipmentCustodian;
                LastInventoryField.Text = InventoryDate;
                InventoryDueField.Text = InventoryDueDate;
                OrganizationField.Text = org;
                AccountNotesField.Text = Notes;
            }
            mysql.CloseConnection();

            // assets 
            mysql.OpenConnection();
            mysql.SelectQuery("SELECT * from assets where accountnumber='" + AssetAccountNumber + "'");
            while (mysql.Result.Read())
            {
                string manufacturer = mysql.Reader("manufacturer");
                string model = mysql.Reader("model");
                string serial = mysql.Reader("serialnumber");
                AccountAssets.Items.Add(manufacturer + " " + model + " " + serial);
            }
            mysql.CloseConnection();

            // drmo 
            mysql.OpenConnection();
            mysql.SelectQuery("SELECT * from drmo where account='" + AssetAccountNumber + "'");
            while (mysql.Result.Read())
            {
                string item = mysql.Reader("item");
                string date = mysql.Reader("date");
                AccountDRMO.Items.Add("# " + date + " " + item);
            }
            int drmoCount = AccountDRMO.Items.Count;
            NumDRMOItems.Text = drmoCount.ToString();

            mysql.CloseConnection();

            // ros
            mysql.OpenConnection();
            mysql.SelectQuery("SELECT * from ros where account='" + AssetAccountNumber + "'");
            while (mysql.Result.Read())
            {
                string item = mysql.Reader("description");
                string date = mysql.Reader("date");
                AccountROS.Items.Add("#" + date + " " + item);
            }
            int rosCount = AccountROS.Items.Count;
            NumROSItems.Text = rosCount.ToString();

            mysql.CloseConnection();

            // action log
            mysql.OpenConnection();
            mysql.SelectQuery("SELECT * from log where account='" + AssetAccountNumber + "'");
            while (mysql.Result.Read())
            {
                string date = mysql.Reader("date");
                string who = mysql.Reader("who");
                string action = mysql.Reader("action");
                AccountActionLog.Items.Add("#" + date + " " + who + " " + action);
            }
            mysql.CloseConnection();

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this account? This action cannot be undone.",
"Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dbconnect mysql = new dbconnect();
                string DeleteAccount = "DELETE from itam WHERE id=" + gridid;
                string AccountDeletionLog = "INSERT INTO log (date, who, action) VALUES ('" + DateTime.Now.ToString() + "','" +
                    UserViewingAccount + "','DELETE ACCOUNT " + AssetAccountNumber + "'";
                mysql.InsertQuery(DeleteAccount);
                mysql.InsertQuery(AccountDeletionLog);
                this.Close();
            }
        }

        private void AccountDetailsBox_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ECField_TextChanged(object sender, EventArgs e)
        {

        }

        private void FreezeAccountButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to freeze this account?",
"Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dbconnect mysql = new dbconnect();
                string notes = AccountNotesField.Text.ToUpper();
                string query = "UPDATE itam SET status='FROZEN' WHERE id='" + gridid + "'";
                string FreezeAccountLog = "INSERT INTO log (date, who, action) VALUES ('" + DateTime.Now.ToString() + "','" +
    UserViewingAccount + "','FROZE ACCOUNT " + AssetAccountNumber + " " + notes + "')";
                mysql.InsertQuery(query);
                mysql.InsertQuery(FreezeAccountLog);
                UnfreezeAccountButton.Visible = true;
                FreezeAccountButton.Enabled = false;
            }
        }

        private void UnfreezeAccountButton_Click(object sender, EventArgs e)
        {
            AccountStatusField.BackColor = Color.Green;
            AccountStatusField.ForeColor = Color.White;
            AccountStatusField.Text = "NORMAL";
            FreezeAccountButton.Enabled = true;
            UnfreezeAccountButton.Visible = false;
            dbconnect mysql = new dbconnect();
            string query = "UPDATE itam SET status='NORMAL' WHERE id='" + gridid + "'";
            string UnFreezeAccountLog = "INSERT INTO log (date, who, action) VALUES ('" + DateTime.Now.ToString() + "','" +
UserViewingAccount + "','UNFROZE ACCOUNT " + AssetAccountNumber + " " + AccountNotesField.Text.ToUpper() + "')";
            mysql.InsertQuery(query);
            mysql.InsertQuery(UnFreezeAccountLog);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string notes = AccountNotesField.Text;
            dbconnect mysql = new dbconnect();
            mysql.InsertQuery("UPDATE itam set notes='" + notes + "'");
            MessageBox.Show("Account updated.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
