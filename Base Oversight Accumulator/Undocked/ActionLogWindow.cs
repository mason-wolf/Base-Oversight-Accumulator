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
    public partial class ActionLogWindow : Form
    {
        public ActionLogWindow()
        {
            InitializeComponent();

            ActionLogDataView.Rows.Clear();
            ActionLogDataView.RowTemplate.Height = 20;

            dbconnect mysql = new dbconnect();

            mysql.OpenConnection();
            mysql.SelectQuery("SELECT * from log ORDER BY id DESC");
            int LogCount = 0;
            while (mysql.Result.Read())
            {
                string id = mysql.Reader("id");
                string date = mysql.Reader("date");
                string who = mysql.Reader("who");
                string action = mysql.Reader("action");
                ActionLogDataView.Rows.Add(id, date, who, action);

                LogCount++;
                if (LogCount == 1000)
                {
                    break;
                }
            }
            mysql.CloseConnection();
        }
    }
    }
