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
    public partial class FormZmienHaslo : Form
    {
        public FormZmienHaslo()
        {
            InitializeComponent();
        }

        readonly func fnc= new func();

        public int my_act_id;

        Form1 form1obj = new Form1();

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            textBoxAktHaslo.Text = "";
            textBoxNoweHaslo.Text = "";
            textBoxNoweHasloPow.Text = "";
            this.Hide();
        }

        /// <summary>
        /// Funkcja odpowiedzialna za zmiane hasła.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZmienHaslo_Click(object sender, EventArgs e)
        {
            if(textBoxAktHaslo.Text == "")
            {
                MessageBox.Show("Wpisz hasło.");
            }
            else
            {
                string query = "SELECT COUNT(*) FROM users WHERE user_id LIKE "+my_act_id.ToString()+" AND user_password LIKE '"+textBoxAktHaslo.Text+"'";
                int res = int.Parse(form1obj.sendQueryRetString(query));

                if(res == 0)
                {
                    MessageBox.Show("Aktualne hasło nieprawidłowe.");
                }
                else
                {
                    if (textBoxNoweHaslo.Text != textBoxNoweHasloPow.Text || textBoxNoweHaslo.Text == "")
                    {
                        MessageBox.Show("Nowe hasło niepoprawne.");
                    }
                    else
                    {
                        //fnc.UpdatePass(textBoxNoweHaslo.Text, my_act_id.ToString());
                        //query = "UPDATE users SET user_password = '"+textBoxNoweHaslo.Text+"' WHERE user_id LIKE "+my_act_id.ToString();
                        string trash_res = fnc.UpdatePass(textBoxNoweHaslo.Text, my_act_id.ToString()); //form1obj.sendQueryRetString(query);
                        MessageBox.Show("Hasło zmienione.");
                        textBoxAktHaslo.Text = "";
                        textBoxNoweHaslo.Text = "";
                        textBoxNoweHasloPow.Text = "";
                        this.Hide();
                    }
                }
            }
        }

        private void textBoxAktHaslo_Enter(object sender, EventArgs e)
        {
            if (textBoxAktHaslo.Text == "Aktualne hasło")
            {
                textBoxAktHaslo.Text = "";
                textBoxAktHaslo.ForeColor = Color.Black;
                textBoxAktHaslo.PasswordChar = char.Parse("*");
            }
        }

        private void textBoxAktHaslo_Leave(object sender, EventArgs e)
        {
            if (textBoxAktHaslo.Text == "")
            {
                textBoxAktHaslo.Text = "Aktualne hasło";
                textBoxAktHaslo.ForeColor = Color.Gray;
                textBoxAktHaslo.PasswordChar = '\0';
            }
        }

        private void textBoxNoweHaslo_Enter(object sender, EventArgs e)
        {
            if (textBoxNoweHaslo.Text == "Nowe hasło")
            {
                textBoxNoweHaslo.Text = "";
                textBoxNoweHaslo.ForeColor = Color.Black;
                textBoxNoweHaslo.PasswordChar = char.Parse("*");
            }
        }

        private void textBoxNoweHaslo_Leave(object sender, EventArgs e)
        {
            if (textBoxNoweHaslo.Text == "")
            {
                textBoxNoweHaslo.Text = "Nowe hasło";
                textBoxNoweHaslo.ForeColor = Color.Gray;
                textBoxNoweHaslo.PasswordChar = '\0';
            }
        }

        private void textBoxNoweHasloPow_Enter(object sender, EventArgs e)
        {
            if (textBoxNoweHasloPow.Text == "Powtórz nowe hasło")
            {
                textBoxNoweHasloPow.Text = "";
                textBoxNoweHasloPow.ForeColor = Color.Black;
                textBoxNoweHasloPow.PasswordChar = char.Parse("*");
            }
        }

        private void textBoxNoweHasloPow_Leave(object sender, EventArgs e)
        {
            if (textBoxNoweHasloPow.Text == "")
            {
                textBoxNoweHasloPow.Text = "Powtórz nowe hasło";
                textBoxNoweHasloPow.ForeColor = Color.Gray;
                textBoxNoweHasloPow.PasswordChar = '\0';
            }
        }
    }

    public class func
    {
        public string UpdatePass(string nowe_haslo, string id)
        {
            string query = "UPDATE users SET user_password = '" + nowe_haslo + "' WHERE user_id LIKE " + id;


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
            return "done";
        }

        public string CheckPass(string id)
        {
            string query = "SELECT user_password from users where user_id like '"+ id+"'";
            string res="";
            var dbCon = DBConnection.Instance();
            dbCon.DatabaseName = "mylibrarydb";
            if (dbCon.IsConnect())
            {
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    res = reader.GetString(0);
                }
                dbCon.Close();
            }
            return res;
        }


    }
}
