using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Library_Manager
{
    public partial class FormZmienTelefon : Form
    {
        public FormZmienTelefon()
        {
            InitializeComponent();
        }

        public int my_user_id;

        Form1 form1obj = new Form1();

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            textBoxTelefon.Text = "";
            textBoxHaslo.Text = "";
            this.Hide();
        }

        /// <summary>
        /// Funkcja odpowiedzialna za zmiane numeru telefonu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZmien_Click(object sender, EventArgs e)
        {
            if (textBoxTelefon.Text == "")
            {
                MessageBox.Show("Podaj nowy nr telefonu.");
            }
            else
            {
                if(int.TryParse(textBoxTelefon.Text,out int x) == false)
                {
                    MessageBox.Show("Podaj poprawny numer telefonu.");
                    textBoxTelefon.Text = "";
                }
                else
                {
                    int nowy_tel = int.Parse(textBoxTelefon.Text);

                    if (textBoxHaslo.Text == "")
                    {
                        MessageBox.Show("Podaj hasło");
                    }
                    else
                    {
                        string query = "SELECT COUNT(*) FROM users WHERE user_id LIKE " + my_user_id.ToString() + " AND user_password LIKE '" + textBoxHaslo.Text + "'";

                        int result = int.Parse(form1obj.sendQueryRetString(query));

                        if (result == 0)
                        {
                            MessageBox.Show("Niepoprawne hasło");
                        }
                        else
                        {
                            query = "UPDATE users SET user_phone = '" + nowy_tel.ToString() + "' WHERE user_id LIKE " + my_user_id.ToString();

                            string trash_res = form1obj.sendQueryRetString(query);

                            textBoxTelefon.Text = "";
                            textBoxHaslo.Text = "";

                            MessageBox.Show("Zmieniono email.");

                            this.Hide();
                        }
                    }
                }

            }
        }

        private void textBoxTelefon_Enter(object sender, EventArgs e)
        {
            if (textBoxTelefon.Text == "Nowy numer")
            {
                textBoxTelefon.Text = "";
                textBoxTelefon.ForeColor = Color.Black;
            }
        }

        private void textBoxTelefon_Leave(object sender, EventArgs e)
        {
            if (textBoxTelefon.Text == "")
            {
                textBoxTelefon.Text = "Nowy numer";
                textBoxTelefon.ForeColor = Color.Gray;
            }
        }

        private void textBoxHaslo_Enter(object sender, EventArgs e)
        {
            if (textBoxHaslo.Text == "Hasło")
            {
                textBoxHaslo.Text = "";
                textBoxHaslo.ForeColor = Color.Black;
                textBoxHaslo.PasswordChar = char.Parse("*");
            }
        }

        private void textBoxHaslo_Leave(object sender, EventArgs e)
        {
            if (textBoxHaslo.Text == "")
            {
                textBoxHaslo.Text = "Hasło";
                textBoxHaslo.ForeColor = Color.Gray;
                textBoxHaslo.PasswordChar = '\0';
            }
        }
    }
}
