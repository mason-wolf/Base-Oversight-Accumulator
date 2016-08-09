using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Base_Oversight_Accumulator
{
    public partial class UserLogin : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string dbpassword;

        public UserLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            server = "localhost";
            database = "boa";
            user = "root";
            dbpassword = "root";
            string connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + dbpassword + ";";
            connection = new MySqlConnection(connectionstring);

            string username = UsernameField.Text;

            string password = PasswordField.Text;

            MySqlCommand UserQuery = connection.CreateCommand();
            UserQuery.CommandText = "SELECT * FROM users where username='" + username + "'";
            UserQuery.Connection = connection;
            connection.Open();
            MySqlDataReader UserQueryResult = UserQuery.ExecuteReader();
            if(UserQueryResult.Read() == false)
            {
                FailedLoginLabel.Visible = true;
            }
            else
            {
                connection.Close();
                connection.Open();
                MySqlCommand PasswordQuery = connection.CreateCommand();
                PasswordQuery.CommandText = "SELECT * FROM users where username='" + username + "'";
                PasswordQuery.Connection = connection;
                MySqlDataReader PasswordQueryResult = PasswordQuery.ExecuteReader();
                while(PasswordQueryResult.Read())
                {
                    string userPassword = Convert.ToString(PasswordQueryResult["password"]);
                    string UserRank = Convert.ToString(PasswordQueryResult["rank"]);
                    string UserLastName = Convert.ToString(PasswordQueryResult["lastname"]);
                    string UserFirstNamae = Convert.ToString(PasswordQueryResult["firstname"]);
                    string BOAUser = UserRank + " " + UserLastName + ", " + UserFirstNamae;

                    if (password != userPassword)
                    {
                        FailedLoginLabel.Visible = true;
                    }
                    else
                    {
                        var t = new Thread(() => Application.Run(new MainWindow(BOAUser.ToUpper())));
                        t.SetApartmentState(ApartmentState.STA);
                        t.Start();
                        this.Close();
                    }
                }
            }
        }
    }
}
