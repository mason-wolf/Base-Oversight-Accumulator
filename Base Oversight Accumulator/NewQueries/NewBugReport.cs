using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_Oversight_Accumulator.NewQueries
{
    public partial class NewBugReport : Form
    {
        public string UserSubmittingReport { get; set; }

        public NewBugReport()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string report = BugReportField.Text;
            dbconnect mysql = new dbconnect();
            mysql.InsertQuery("INSERT INTO bugreports (who, what, date) VALUES ('" + UserSubmittingReport + "','" + report + "','" + DateTime.Now.ToString() + "')");
            mysql.CloseConnection();
            MessageBox.Show("Report submitted.");
            this.Close();
        }
    }
}
