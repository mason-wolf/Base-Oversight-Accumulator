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
    public partial class ModifyAssetValue : Form
    {
        public ModifyAssetValue()
        {
            InitializeComponent();
        }

        private void AssignValueButton_Click(object sender, EventArgs e)
        {
            string manufacturer = ManufacturerField.Text;
            string model = ModelField.Text;
            string value = ValueField.Text;

            dbconnect mysql = new dbconnect();
            string query = "UPDATE assets SET value='" + value + "' WHERE model='" + model + "'";
            try
            {
                mysql.insert(query);
                this.Close();
            }
            catch { }
        }
    }
}
