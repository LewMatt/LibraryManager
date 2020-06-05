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
    }
}
