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
    public partial class SearchOptions : Form
    {
        public string UserSelectingSearch {get; set;}

        public SearchOptions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchWindow SearchWindow = new SearchWindow();
            SearchWindow.SearchItem = "assets";
            SearchWindow.UserPerformingSearch = UserSelectingSearch;
            SearchWindow.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchWindow SearchWindow = new SearchWindow();
            SearchWindow.SearchItem = "ec";
            SearchWindow.UserPerformingSearch = UserSelectingSearch;
            SearchWindow.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchWindow SearchWindow = new SearchWindow();
            SearchWindow.SearchItem = "accounts";
            SearchWindow.UserPerformingSearch = UserSelectingSearch;
            SearchWindow.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TransferSearch TransferSearch = new TransferSearch();
            TransferSearch.Show();
            this.Close();
        }

        private void SearchBOA_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            IssuedSearch IssuedSearch = new IssuedSearch();
            IssuedSearch.Show();
            this.Close();
        }
    }
}
