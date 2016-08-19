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
    public partial class UpdateItemLocation : Form
    {
        public List<string> ItemsToUpdate = new List<string>();

        public UpdateItemLocation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to make these modifications? This action cannot be undone.",
"Confirm Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string Building = BuildingField.Text;
                string Room = RoomField.Text;
                foreach (string item in ItemsToUpdate)
                {
                    dbconnect mysql = new dbconnect();
                    mysql.SelectQuery("UPDATE assets SET building='" + Building + "', room='" + Room + "' WHERE id='" + item + "'");
                    mysql.CloseConnection();
                }
                MessageBox.Show("Update complete.");
            }
            this.Close();
        }
    }
    }

