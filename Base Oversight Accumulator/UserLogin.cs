﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Base_Oversight_Accumulator
{
    public partial class UserLogin : Form
    {

        public UserLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            string username = UsernameField.Text;
            string password = PasswordField.Text;

            dbconnect mysql = new dbconnect();
            mysql.OpenConnection();
            if (mysql.OpenConnection() == false)
            {
                MessageBox.Show("Cannot connect to server.");
                mysql.CloseConnection();
            }
            else
            {
                mysql.SelectQuery("SELECT * FROM users where username='" + username + "'");

                if (mysql.Result.Read() == false)
                {
                    FailedLoginLabel.Visible = true;
                }
                else
                {
                    mysql.CloseConnection();
                    mysql.OpenConnection();
                    mysql.SelectQuery("SELECT * FROM users where username='" + username + "'");

                    while (mysql.Result.Read())
                    {
                        string userPassword = mysql.Reader("password");
                        string UserRank = mysql.Reader("rank");
                        string UserLastName = mysql.Reader("lastname");
                        string UserFirstNamae = mysql.Reader("firstname");
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

        private void UserLogin_Load(object sender, EventArgs e)
        {
            ServerAddressField.Text = Properties.Settings.Default.ServerAddress;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerAddress = ServerAddressField.Text;
            Properties.Settings.Default.Save();
        }
    }
}
