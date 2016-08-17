using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_Oversight_Accumulator.Utilities
{
    public partial class DueDateAlerter : Form
    {
        public DueDateAlerter()
        {
            InitializeComponent();
        }

        private void DueDateAlerter_Load(object sender, EventArgs e)
        {
            List<DateTime> DueDates = new List<DateTime>();

            dbconnect mysql = new dbconnect();
            mysql.SelectQuery("SELECT * from itam");

            while (mysql.Result.Read())
            {
                string InventoryDueDate = mysql.Reader("inventorydue");
                if (!string.IsNullOrEmpty(InventoryDueDate))
                {
                    DateTime InventoryDates = DateTime.Parse(InventoryDueDate);
                    DueDates.Add(InventoryDates);
                }
            }

            foreach (DateTime date in DueDates)
            {
                if (date >= DateTime.Now.Date)
                {
                    notifyIcon1.ShowBalloonTip(100, "ITAM Notice", "Accounts are due to conduct or update their inventories. Click to view more.", ToolTipIcon.Info);
                }
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
