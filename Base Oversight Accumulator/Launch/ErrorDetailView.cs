using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_Oversight_Accumulator.Launch
{
    public partial class ErrorDetailView : Form
    {
        public string ErrorMessage { get; set; }
        public string ErrorDetails { get; set; }

        public ErrorDetailView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorDetailView_Load(object sender, EventArgs e)
        {
            ErrorMessageLable.Text = ErrorMessage;
            ErrorDetailsField.Text = ErrorDetails;
        }
    }
}
