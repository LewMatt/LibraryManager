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
    public partial class FormZmienEmail : Form
    {
        public FormZmienEmail()
        {
            InitializeComponent();
        }

        public int my_user_id;

        Form1 form1obj = new Form1();

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = "";
            textBoxHaslo.Text = "";
            this.Hide();
        }

        private void btnZmien_Click(object sender, EventArgs e)
        {
            if(textBoxEmail.Text == "")
            {
                MessageBox.Show("Podaj nowy email.");
            }
            else
            {
                string nowy_email = textBoxEmail.Text;

                if(textBoxHaslo.Text == "")
                {
                    MessageBox.Show("Podaj hasło");
                }
                else
                {
                    string query = "SELECT COUNT(*) FROM users WHERE user_id LIKE " + my_user_id.ToString() + " AND user_password LIKE '" + textBoxHaslo.Text + "'";

                    int result = int.Parse(form1obj.sendQueryRetString(query));

                    if(result == 0)
                    {
                        MessageBox.Show("Niepoprawne hasło");
                    }
                    else
                    {
                        query = "UPDATE users SET user_email = '" + nowy_email + "' WHERE user_id LIKE "+ my_user_id.ToString();

                        string trash_res = form1obj.sendQueryRetString(query);

                        textBoxEmail.Text = "";
                        textBoxHaslo.Text = "";

                        MessageBox.Show("Zmieniono email.");

                        this.Hide();
                    }
                }
                
            }
            


        }
    }
}
