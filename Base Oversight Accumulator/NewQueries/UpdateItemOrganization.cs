﻿using System;
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
    public partial class UpdateItemOrganization : Form
    {
        public List<string> ItemsToUpdate = new List<string>();

        public UpdateItemOrganization()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to make these modifications? This action cannot be undone.",
"Confirm Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string Organization = OrgField.Text;
                foreach (string item in ItemsToUpdate)
                {
                    dbconnect mysql = new dbconnect();
                    mysql.SelectQuery("UPDATE assets SET organization='" + Organization + "' WHERE id='" + item + "'");
                    mysql.CloseConnection();
                }
                MessageBox.Show("Update complete.");
            }
            this.Close();
        }
    }
}
