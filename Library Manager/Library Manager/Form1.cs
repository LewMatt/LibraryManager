﻿using System;
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
using Renci.SshNet.Messages;
//db name : lib
//table name: users
namespace Library_Manager
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public string sendQueryRetString(string query)
        {
            string someStringFromColumnZero = "";
            string result = "";
            var dbCon = DBConnection.Instance();
            dbCon.DatabaseName = "mylibrarydb";
            if (dbCon.IsConnect())
            {
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    someStringFromColumnZero = reader.GetString(0);
                    result = someStringFromColumnZero;
                }
                dbCon.Close();
            }
            return result;
        }

        public List<ListViewItem> sendQueryRetBooks(string query)
        {
            List<ListViewItem> lista = new List<ListViewItem>();

            var dbCon = DBConnection.Instance();
            dbCon.DatabaseName = "mylibrarydb";
            if (dbCon.IsConnect())
            {
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int ile = reader.FieldCount;
    
                    for(int i = 0;i<ile;i+=6)
                    {
                        ListViewItem ksiazka = new ListViewItem();
                        ksiazka.Text = reader.GetString(i);
                        ksiazka.SubItems.Add(reader.GetString(i + 1));
                        ksiazka.SubItems.Add(reader.GetString(i + 2));
                        ksiazka.SubItems.Add(reader.GetString(i + 3));
                        ksiazka.SubItems.Add(reader.GetString(i + 4));
                        ksiazka.SubItems.Add(reader.GetString(i + 5));
                        lista.Add(ksiazka);
                    }
                }
                dbCon.Close();
            }
            return lista;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM users WHERE user_login like '" + textBoxLogin.Text + "' AND user_password like '" + textBoxPassword.Text + "'";
            string result = "";

            result = sendQueryRetString(query);

            int res = int.Parse(result);
            if (res == 1 && textBoxLogin.Text == "admin")
            {
                MessageBox.Show("Zalogowano");
                FormMenuAdmin fMenuAdmin = new FormMenuAdmin();
                this.Hide();
                fMenuAdmin.Show();
            }
            else if (res == 1)
            {
                MessageBox.Show("Zalogowano");
                FormMenu fMenu = new FormMenu();
                this.Hide();
                fMenu.Show();
            }
            else
            {
                MessageBox.Show("Błędny login lub hasło");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }

    public class DBConnection
    {
        private DBConnection()
        {
        }

        private string databaseName = string.Empty;
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        public string Password { get; set; }
        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        public bool IsConnect()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                    return false;
                string connstring = string.Format("Server=localhost; database={0}; UID=root; password=", databaseName);
                connection = new MySqlConnection(connstring);
                connection.Open();
            }

            return true;
        }

        public void Close()
        {
            connection.Close();
            connection = null;
        }
    }
}