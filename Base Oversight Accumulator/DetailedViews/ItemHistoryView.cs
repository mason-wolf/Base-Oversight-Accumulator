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
    public partial class ItemHistoryView : Form
    {
        public string SerialNumber { get; set; }

        public ItemHistoryView()
        {
            InitializeComponent();
        }

        private void ItemHistoryView_Load(object sender, EventArgs e)
        {
            dbconnect mysql = new dbconnect();
            mysql.SelectQuery("select * from log where action LIKE '%" + SerialNumber + "%'");
            while(mysql.Result.Read())
            {
                string date = mysql.Reader("date");
                string who = mysql.Reader("who");
                string action = mysql.Reader("action");
                ItemHistory.AppendText(date + " " + who + " " + action + "\n");
                this.Text = " Item History: " + SerialNumber;
            }
        }
    }
}
