using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_Oversight_Accumulator
{
    public partial class SaveDataGridView : Form
    {
        public object DataGrid { get; set; }
        DataGridView whichGrid;

        public SaveDataGridView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainWindow DataSets = new MainWindow(null);
            string set = DataGrid.ToString();
            if (set == "assets")
            {
                whichGrid = DataSets.AssetDataView;
            }
            if(set == "ec")
            {
                whichGrid = DataSets.ECDataView;
            }
            if(set == "accounts")
            {
                whichGrid = DataSets.AccountDataView;
            }
            if(set == "transfers")
            {
                whichGrid = DataSets.TransferDataView;
            }
            if(set == "issueditems")
            {
                whichGrid = DataSets.IssuedDataView;
            }
            if(set == "actionlog")
            {
                whichGrid = DataSets.ActionLogDataView;
            }
            SaveFile SaveFile = new SaveFile();
            SaveFile.DataView = whichGrid;
            SaveFile.Save();
            this.Hide();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DataGrid = AssetsButton.Tag;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DataGrid = ECButton.Tag;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            DataGrid = AccountsButton.Tag;
        }

        private void TransfersButton_CheckedChanged(object sender, EventArgs e)
        {
            DataGrid = TransfersButton.Tag;
        }

        private void IssuedItemsButton_CheckedChanged(object sender, EventArgs e)
        {
            DataGrid = IssuedItemsButton.Tag;
        }

        private void ActionLogButton_CheckedChanged(object sender, EventArgs e)
        {
            DataGrid = ActionLogButton.Tag;
        }
    }
}

