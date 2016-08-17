using Base_Oversight_Accumulator.Search;
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
    public partial class NewSlotNumber : Form
    {
        public NewSlotNumber()
        {
            InitializeComponent();
        }

        private void AddSlotNumberButton_Click(object sender, EventArgs e)
        {
            dbconnect mysql = new dbconnect();
            string nsn = SlotNumberField.Text;
            string makemodel = MakeModelField.Text;
            mysql.InsertQuery("INSERT INTO nsn (nsn, makemodel) VALUES('" + nsn + "','" + makemodel + "')");
            mysql.CloseConnection();
            this.Close();
            SlotNumberSearch SlotNumberSearch = new SlotNumberSearch();
            SlotNumberSearch.Show();
            // show nsns
        }
    }
}
