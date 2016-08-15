﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data;
using MySql.Data.MySqlClient;
using Base_Oversight_Accumulator.Launch;

namespace Base_Oversight_Accumulator
{

    class dbconnect
    {
        private MySqlConnection Connection;
        private string ConnectionString;
        public MySqlDataReader Result;
        public string CurrencySum;

        public dbconnect()
        {
            initialize();
        }

        private void initialize()
        {
        }

        public bool OpenConnection() 
        {
            int ExceptionCount = 0;
            try
            {
                string server = Properties.Settings.Default.ServerAddress;
                ConnectionString = "HOST=" + server + "; DATABASE=boa;" + "user=wolf;" + "PASSWORD=wolf;";
                Connection = new MySqlConnection(ConnectionString);
                Connection.Open();
                ExceptionCount++;
                return true;
            }
            catch (MySqlException ConnectionException)
            {
                ErrorDetailView ErrorDetailView = new ErrorDetailView();
                ErrorDetailView.ErrorMessage = "Unable to contact database server.";
                ErrorDetailView.ErrorDetails = ConnectionException.ToString();
                ErrorDetailView.Show();
                Connection.Close();
                return false;
            }
        }

        public bool CloseConnection()
        {

                Connection.Close();
                  return true;

        }

        public void InsertQuery(string query)
        {

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void SelectQuery(string query)
        {
            OpenConnection();
            MySqlCommand Select = Connection.CreateCommand();
            Select.CommandText = query;
            Select.Connection = Connection;
            Result = Select.ExecuteReader();
         }

        public string CountQuery(string query)
        {
            int c;
            MySqlCommand CountQuery = new MySqlCommand(query, Connection);
            c = int.Parse(CountQuery.ExecuteScalar().ToString());
            Connection.Close();
            return c.ToString();
        }

        public string SumCurrencyQuery(string query)
        {
            Connection.Open();

            try
            {
                MySqlCommand SumQuery = new MySqlCommand(query, Connection);
                CurrencySum = "$" + double.Parse(SumQuery.ExecuteScalar().ToString()).ToString("N0");
            }
            catch { }
            Connection.Close();
            return CurrencySum;
        }

        public string Reader(string row)
        {
            string FetchedRow = Convert.ToString(Result[row]);
            return FetchedRow;
        }

    }
    }