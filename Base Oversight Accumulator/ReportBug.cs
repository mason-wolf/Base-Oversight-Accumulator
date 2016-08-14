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
    public partial class ReportBug : Form
    {
        public string UserReportingBug { get; set; }

        public ReportBug()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string desc = BugDescription.Text;
            dbconnect mysql = new dbconnect();
            mysql.InsertQuery("INSERT INTO bugreports (who, what, date) VALUES ('" + UserReportingBug + "','" + desc + "','" + DateTime.Now.ToString() + "')");
            MessageBox.Show("Report has been sent.");
            this.Close();
        }
    }
}
