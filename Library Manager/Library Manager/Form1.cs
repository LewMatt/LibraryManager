using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manager
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = "tak";
            string password = "123";

            if (textBoxLogin.Text == login && textBoxPassword.Text == password)
            {
                MessageBox.Show("Zalogowano.");

                FormMenu fMenu = new FormMenu();
                this.Hide();
                fMenu.Show();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
