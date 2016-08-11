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
    public partial class ROSWindow : Form
    {
        public ROSWindow()
        {
            InitializeComponent();
        }

        private void CreateReportButton_Click(object sender, EventArgs e)
        {
            string doc = DocNumberField.Text;
            string poc = POCField.Text;
            string description = DescriptionField.Text;
            string value = ValueField.Text;
            string account = AccountField.Text;
            string surveyofficer = SurveyOfficerField.Text;
            string remarks = RemarksField.Text;

            dbconnect mysql = new dbconnect();
            mysql.InsertQuery("INSERT into ros (doc, poc, description, value, account, surveyofficer, remarks, date) VALUES('" +
                doc.ToUpper() + "','" + poc.ToUpper() + "','" + description.ToUpper() + "','" + value.ToUpper() + "','" + account.ToUpper() + "','" + surveyofficer.ToUpper() + "','" + remarks.ToUpper() + "','" + DateTime.Now.ToString() + "')");
            MessageBox.Show("Report of Survey created for: ");
            this.Close();
        }
    }
}
