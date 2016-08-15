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
    public partial class NewAssetValueModification : Form
    {
        public NewAssetValueModification()
        {
            InitializeComponent();
        }

        private void AssignValueButton_Click(object sender, EventArgs e)
        {
            string manufacturer = ManufacturerField.Text;
            string model = ModelField.Text;
            string value = ValueField.Text;

            dbconnect mysql = new dbconnect();
            string ModifyAssets = "UPDATE assets SET value='" + value + "' WHERE model='" + model + "'";
            try
            {
                mysql.InsertQuery(ModifyAssets);
                this.Close();
            }
            catch { }
        }

        private void ModifyAssetValue_Load(object sender, EventArgs e)
        {

        }
    }
}
