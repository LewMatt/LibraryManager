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

        public int my_act_id;

        Form1 form1obj = new Form1();

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            textBoxAktHaslo.Text = "";
            textBoxNoweHaslo.Text = "";
            textBoxNoweHasloPow.Text = "";
            this.Hide();
        }

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
                        query = "UPDATE users SET user_password = '"+textBoxNoweHaslo.Text+"' WHERE user_id LIKE "+my_act_id.ToString();
                        string trash_res = form1obj.sendQueryRetString(query);
                        MessageBox.Show("Hasło zmienione.");
                        textBoxAktHaslo.Text = "";
                        textBoxNoweHaslo.Text = "";
                        textBoxNoweHasloPow.Text = "";
                        this.Hide();
                    }
                }
            }
        }
    }
}
