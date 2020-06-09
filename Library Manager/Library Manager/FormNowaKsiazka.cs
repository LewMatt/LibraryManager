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
    public partial class FormNowaKsiazka : Form
    {
        public FormNowaKsiazka()
        {
            InitializeComponent();
        }

        Form1 form1obj = new Form1();

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            textBoxTytul.Text = "";
            textBoxAutor.Text = "";
            textBoxGatunek.Text = "";
            textBoxDataWyd.Text = "";
            textBoxIlosc.Text = "";
            this.Hide();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(textBoxTytul.Text == "")
            {
                MessageBox.Show("Podaj tytuł.");
            }
            else
            {
                if(textBoxAutor.Text == "")
                {
                    MessageBox.Show("Podaj autora.");
                }
                else
                {
                    if(textBoxGatunek.Text == "")
                    {
                        MessageBox.Show("Podaj gatunek.");
                    }
                    else
                    {
                        if(int.TryParse(textBoxDataWyd.Text,out int x) == false || textBoxDataWyd.Text == "")
                        {
                            MessageBox.Show("Podaj prawidłowy rok wydania.");
                        }
                        else
                        {
                            if(int.TryParse(textBoxIlosc.Text,out int y) == false || textBoxIlosc.Text == "")
                            {
                                MessageBox.Show("Podaj poprawną ilość");
                            }
                            else
                            {
                                string query = "SELECT COUNT(*) FROM books";

                                int book_id = int.Parse(form1obj.sendQueryRetString(query)) + 1;

                                string book_title = textBoxTytul.Text;

                                string book_author = textBoxAutor.Text;

                                string book_genre = textBoxGatunek.Text;

                                int book_release_date = int.Parse(textBoxDataWyd.Text);

                                int book_amount = int.Parse(textBoxIlosc.Text);

                                query = "INSERT INTO `books` (`book_id`, `book_title`, `book_author`, `book_genre`, `book_release_date`, `book_amount_available`) VALUES (" + book_id.ToString() + ", '" + book_title + "', '" + book_author + "', '" + book_genre + "', " + book_release_date.ToString() + ", "+book_amount.ToString() +")";

                                string trash_res = form1obj.sendQueryRetString(query);
                                
                                MessageBox.Show("Książka dodana");

                                textBoxTytul.Text = "";
                                textBoxAutor.Text = "";
                                textBoxGatunek.Text = "";
                                textBoxDataWyd.Text = "";
                                textBoxIlosc.Text = "";
                            }
                        }
                    }
                }
            }
        }

        private void textBoxTytul_Enter(object sender, EventArgs e)
        {
            if (textBoxTytul.Text == "Tytuł")
            {
                textBoxTytul.Text = "";
                textBoxTytul.ForeColor = Color.Black;
            }
        }

        private void textBoxTytul_Leave(object sender, EventArgs e)
        {
            if (textBoxTytul.Text == "")
            {
                textBoxTytul.Text = "Tytuł";
                textBoxTytul.ForeColor = Color.Gray;
            }
        }

        private void textBoxAutor_Enter(object sender, EventArgs e)
        {
            if (textBoxAutor.Text == "Autor")
            {
                textBoxAutor.Text = "";
                textBoxAutor.ForeColor = Color.Black;
            }
        }

        private void textBoxAutor_Leave(object sender, EventArgs e)
        {
            if (textBoxAutor.Text == "")
            {
                textBoxAutor.Text = "Autor";
                textBoxAutor.ForeColor = Color.Gray;
            }
        }

        private void textBoxGatunek_Enter(object sender, EventArgs e)
        {
            if (textBoxGatunek.Text == "Gatunek")
            {
                textBoxGatunek.Text = "";
                textBoxGatunek.ForeColor = Color.Black;
            }
        }

        private void textBoxGatunek_Leave(object sender, EventArgs e)
        {
            if (textBoxGatunek.Text == "")
            {
                textBoxGatunek.Text = "Gatunek";
                textBoxGatunek.ForeColor = Color.Gray;
            }
        }

        private void textBoxDataWyd_Enter(object sender, EventArgs e)
        {
            if (textBoxDataWyd.Text == "Data wydania")
            {
                textBoxDataWyd.Text = "";
                textBoxDataWyd.ForeColor = Color.Black;
            }
        }

        private void textBoxDataWyd_Leave(object sender, EventArgs e)
        {
            if (textBoxDataWyd.Text == "")
            {
                textBoxDataWyd.Text = "Data wydania";
                textBoxDataWyd.ForeColor = Color.Gray;
            }
        }

        private void textBoxIlosc_Enter(object sender, EventArgs e)
        {
            if (textBoxIlosc.Text == "Ilość")
            {
                textBoxIlosc.Text = "";
                textBoxIlosc.ForeColor = Color.Black;
            }
        }

        private void textBoxIlosc_Leave(object sender, EventArgs e)
        {
            if (textBoxIlosc.Text == "")
            {
                textBoxIlosc.Text = "Ilość";
                textBoxIlosc.ForeColor = Color.Gray;
            }
        }
    }
}
