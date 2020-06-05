using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manager
{
    public partial class UserControlMojeDane : UserControl
    {
        public UserControlMojeDane()
        {
            InitializeComponent();
        }

        public int my_id;
        public string my_login;

        Form1 form1obj = new Form1();

        private void btnZmienEmail_Click(object sender, EventArgs e)
        {
            FormZmienEmail fZmienEmail = new FormZmienEmail();
            fZmienEmail.my_user_id = my_id;
            fZmienEmail.Show();
            fZmienEmail.BringToFront();
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            string query = "SELECT user_fname FROM users WHERE user_login LIKE '" + my_login + "'";
            string imie = form1obj.sendQueryRetString(query);
            lblPokazImie.Text = imie;

            query = "SELECT user_lname FROM users WHERE user_login LIKE '" + my_login + "'";
            string nazwisko = form1obj.sendQueryRetString(query);
            lblPokazNazwisko.Text = nazwisko;

            query = "SELECT user_email FROM users WHERE user_login LIKE '" + my_login + "'";
            string email = form1obj.sendQueryRetString(query);
            lblPokazEmail.Text = email;

            query = "SELECT user_phone FROM users WHERE user_login LIKE '" + my_login + "'";
            string tel = form1obj.sendQueryRetString(query);
            lblTelefonPokaz.Text = tel;
        }
    }
}
