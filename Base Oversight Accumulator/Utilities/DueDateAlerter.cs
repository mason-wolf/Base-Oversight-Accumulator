using Base_Oversight_Accumulator.DetailedViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_Oversight_Accumulator.Utilities
{
    public partial class DueDateAlerter : Form
    {
        DueItemsDetailView DueItems = new DueItemsDetailView();
        public bool ItemFound;

        public DueDateAlerter()
        {
            InitializeComponent();
        }

        private void DueDateAlerter_Load(object sender, EventArgs e)
        {
            List<DateTime> DueDates = new List<DateTime>();
            List<String> Accounts = new List<String>();

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

            mysql.CloseConnection();

            DueItems.AccountsDue = Accounts;

            foreach (DateTime date in DueDates)
            {
                if (date >= DateTime.Now.Date)
                {
                    ItemFound = true;
                    notifyIcon1.ShowBalloonTip(100, "ITAM Notice", "Accounts are due to conduct or update their inventories.", ToolTipIcon.Info);
                    Accounts.Add(date.ToString());
                    notifyIcon1.MouseClick += NotifyIcon1_MouseClick;
                }
            }

            if(ItemFound == false)
            {
                MessageBox.Show("All account inventory dates are current.");
            }
        }

        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            DueItems.Show();
        }
    }
}
