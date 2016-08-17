using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_Oversight_Accumulator.Search
{
    public partial class SlotNumberSearch : Form
    {
        public SlotNumberSearch()
        {
            InitializeComponent();
        }

        private void MakeModelField_TextChanged(object sender, EventArgs e)
        {
            dbconnect mysql = new dbconnect();
            mysql.SelectQuery("SELECT * from nsn");

            DataTable SlotTable = new DataTable();
            SlotTable.Columns.Add("ID", typeof(String));
            SlotTable.Columns.Add("Make/Model", typeof(String));
            SlotTable.Columns.Add("NSN", typeof(String));


            while (mysql.Result.Read())
            {
                string id = mysql.Reader("id");
                string makemodel = mysql.Reader("makemodel");
                string nsn = mysql.Reader("nsn");

                SlotTable.Rows.Add(id, makemodel, nsn);
            }
            SlotNumberDataView.DataSource = SlotTable;
            mysql.CloseConnection();

            BindingSource bs = new BindingSource();
            bs.DataSource = SlotNumberDataView.DataSource;
            bs.Filter = "[Make/Model] Like '%" + MakeModelField.Text + "%'";
            SlotNumberDataView.DataSource = bs;
            SlotNumberDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}

