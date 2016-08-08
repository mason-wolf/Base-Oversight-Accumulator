using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Base_Oversight_Accumulator
{

    class dbconnect
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;

        public dbconnect()
        {
            initialize();
        }

        private void initialize()
        {
            server = "localhost";
            database = "boa";
            user = "root";
            password = "root";
            string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionstring);
        }

        private bool openconnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool closeconnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void insert(string query)
        {
            if (this.openconnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.closeconnection();
            }
        }

        public void update()
        {
            string query = "";
            if (this.openconnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.closeconnection();
            }
        }

        public void delete()
        {
            string query = "";
            if (this.openconnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.closeconnection();
            }
        }


        public int count()
        {
            string query = "SELECT Count(*) FROM table";
            int count = -1;
            if (this.openconnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                count = int.Parse(cmd.ExecuteScalar() + "");
                this.closeconnection();
                return count;
            }
            else
            {
                return count;
            }
        }
    }
}