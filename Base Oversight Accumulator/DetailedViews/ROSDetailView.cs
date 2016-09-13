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
    public partial class ROSDetailView : Form
    {
        public string SerialNumber { get; set; }
        public string UserViewingROS { get; set; }

        public ROSDetailView()
        {
            InitializeComponent();
        }

        private void ROSDetailView_Load(object sender, EventArgs e)
        {
            dbconnect mysql = new dbconnect();
            mysql.SelectQuery("select * from ros where serialnumber='" + SerialNumber + "'");
            while (mysql.Result.Read())
            {
                string doc = mysql.Reader("doc");
                string poc = mysql.Reader("poc");
                string desc = mysql.Reader("description");
                string value = mysql.Reader("value");
                string account = mysql.Reader("account");
                string officer = mysql.Reader("surveyofficer");
                string remarks = mysql.Reader("remarks");
                string date = mysql.Reader("date");
                this.Text = " " + SerialNumber + " " + desc;
                SerialNumberField.Text = SerialNumber;
                DocNumberField.Text = doc;
                POCField.Text = poc;
                DescriptionField.Text = desc;
                ValueField.Text = value;
                AccountField.Text = account;
                SurveyOfficerField.Text = officer;
                RemarksField.Text = remarks;
                DateField.Text = date;
            }
            mysql.CloseConnection();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditItemButton_Click_1(object sender, EventArgs e)
        {
            DocNumberField.ReadOnly = false;
            DocNumberField.BackColor = Color.White;
            DocNumberField.BorderStyle = BorderStyle.FixedSingle;

            POCField.ReadOnly = false;
            POCField.BackColor = Color.White;
            POCField.BorderStyle = BorderStyle.FixedSingle;

            DescriptionField.ReadOnly = false;
            DescriptionField.BackColor = Color.White;
            DescriptionField.BorderStyle = BorderStyle.FixedSingle;

            ValueField.ReadOnly = false;
            ValueField.BackColor = Color.White;
            ValueField.BorderStyle = BorderStyle.FixedSingle;

            SurveyOfficerField.ReadOnly = false;
            SurveyOfficerField.BackColor = Color.White;
            SurveyOfficerField.BorderStyle = BorderStyle.FixedSingle;

            RemarksField.ReadOnly = false;
            RemarksField.BackColor = Color.White;
            RemarksField.BorderStyle = BorderStyle.FixedSingle;

            EditItemButton.Enabled = false;
            SaveChangesButton.Visible = true;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            string doc = DocNumberField.Text;
            string poc = POCField.Text;
            string desc = DescriptionField.Text;
            string value = ValueField.Text;
            string officer = SurveyOfficerField.Text;
            string remarks = RemarksField.Text;

            dbconnect mysql = new dbconnect();
            string UpdateROSQuery = "update ros set doc='" + doc + "', poc='" + poc + "', description='" + desc + "', value='" + value + "', surveyofficer='" + officer +
                "', remarks='" + remarks + "' where serialnumber='" + SerialNumber + "'";
            mysql.InsertQuery(UpdateROSQuery);
            mysql.CloseConnection();
            this.Close();
        }

        private void RecoverItemButton_Click(object sender, EventArgs e)
        {
            string account = AccountField.Text;
            if (MessageBox.Show("Recover asset '" + SerialNumber + "' FROM ACCOUNT " + account + "?",
"Confirm Item Recovery", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dbconnect mysql = new dbconnect();
                string RecoverItem = "DELETE from ros WHERE serialnumber='" + SerialNumber + "'";
                string RecoveredItemLog = "INSERT INTO log (date, who, action) VALUES ('" + DateTime.Now.ToString() + "','" +
                    UserViewingROS + "','RECOVERED ITEM " + SerialNumber + " from account " + account + "')";
                mysql.InsertQuery(RecoverItem);
                mysql.InsertQuery(RecoveredItemLog);
                this.Close();
            }
        }

        private void ItemHistoryButton_Click(object sender, EventArgs e)
        {
            ItemHistoryView ItemHistoryView = new ItemHistoryView();
            ItemHistoryView.SerialNumber = SerialNumber;
            ItemHistoryView.Show();
        }
    }
}
