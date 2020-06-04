﻿using System;
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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            userControlMenu1.BringToFront();
        }

        Form1 form1obj = new Form1();

        public string logged_user = "";

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            userControlMenu1.BringToFront();
        }

        private void btnBiblioteka_Click(object sender, EventArgs e)
        {
            List<ListViewItem> ksiazki = new List<ListViewItem>();

            string query = "SELECT * FROM books";
            ksiazki = form1obj.sendQueryRetBooks(query);

            userControlBiblioteka1.listViewBiblioteka.Items.Clear();

            foreach(ListViewItem item in ksiazki)
            {
                userControlBiblioteka1.listViewBiblioteka.Items.Add(item);
            }

            userControlBiblioteka1.user = logged_user;

            userControlBiblioteka1.BringToFront();
        }

        private void btnMojeKsiazki_Click(object sender, EventArgs e)
        {
            userControlMojeKsiazki1.BringToFront();
        }

        

        private void btnMojeDane_Click(object sender, EventArgs e)
        {
            string query = "SELECT user_fname FROM users WHERE user_login LIKE '" + logged_user + "'";
            string imie = form1obj.sendQueryRetString(query);
            userControlMojeDane1.lblPokazImie.Text = imie;

            query = "SELECT user_lname FROM users WHERE user_login LIKE '" + logged_user + "'";
            string nazwisko = form1obj.sendQueryRetString(query);
            userControlMojeDane1.lblPokazNazwisko.Text = nazwisko;

            query = "SELECT user_email FROM users WHERE user_login LIKE '" + logged_user + "'";
            string email = form1obj.sendQueryRetString(query);
            userControlMojeDane1.lblPokazEmail.Text = email;

            query = "SELECT user_phone FROM users WHERE user_login LIKE '" + logged_user + "'";
            string tel = form1obj.sendQueryRetString(query);
            userControlMojeDane1.lblTelefonPokaz.Text = tel;

            userControlMojeDane1.BringToFront();
        }

        private void btnZamowKsiazke_Click(object sender, EventArgs e)
        {
            userControlZamowKsiazke1.BringToFront();
        }
    }
}
