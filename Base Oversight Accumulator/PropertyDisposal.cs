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
    public partial class PropertyDisposal : Form
    {
        public string selecteditem;
        public string Account;

        public PropertyDisposal()
        {
            InitializeComponent();
            AssetsField.RowTemplate.Height = 20;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Account = AccountField.Text;
            DataTable AssetsTable = new DataTable();

            AssetsTable.Columns.Add("Serial Number", typeof(String));

            dbconnect mysql = new dbconnect();
            mysql.SelectQuery("SELECT * FROM assets where accountnumber='" + Account + "'");
            if (mysql.Result.Read() == false)
            {
                ErrorMessage.Visible = true;
            }
            else
            {
                ErrorMessage.Visible = false;
                while (mysql.Result.Read())
                {

                    string serialnumber = mysql.Reader("serialnumber");
                    AssetsTable.Rows.Add(serialnumber);
                }
                AssetsField.DataSource = AssetsTable;
                mysql.CloseConnection();

                BindingSource bs = new BindingSource();
                bs.DataSource = AssetsField.DataSource;
                bs.Filter = "[Serial Number] Like '%" + ItemField.Text + "%'";
                AssetsField.DataSource = bs;
            }
        }

        private void AddAssetButton_Click(object sender, EventArgs e)
        {

            if (AssetsField.SelectedCells.Count > 0)
            {
                int selectedrowindex = AssetsField.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = AssetsField.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["Serial Number"].Value);
                AddedItemsField.Items.Add(a);


            }
        
        }

        private void RemoveAssetButton_Click(object sender, EventArgs e)
        {
            try
            {
                selecteditem = AddedItemsField.SelectedItem.ToString();
                AddedItemsField.Items.Remove(selecteditem);
            }
            catch
            {

            }

        }

        private void CreateReportButton_Click(object sender, EventArgs e)
        {
            dbconnect mysql = new dbconnect();
            int count = AddedItemsField.Items.Count;
            if (count == 1)
            {
                string item = AddedItemsField.Items[0].ToString();
                mysql.InsertQuery("INSERT into drmo (item, account, date) VALUES ('" + item + "','" + Account + "','" + DateTime.Now.ToString() + "')");
                this.Close();
            }
            else
            {
                if (MessageBox.Show("Add these items to the DRMO database?",
    "Confirm Asset Disposition", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (string item in AddedItemsField.Items)
                    {
                        mysql.InsertQuery("INSERT into drmo (item, account, date) VALUES ('" + item + "','" + Account + "','" + DateTime.Now.ToString() + "')");
                        this.Close();

                    }

                }
            }
        }
    }
}
