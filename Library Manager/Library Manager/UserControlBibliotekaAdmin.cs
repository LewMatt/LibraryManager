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
    public partial class UserControlBibliotekaAdmin : UserControl
    {
        public UserControlBibliotekaAdmin()
        {
            InitializeComponent();
        }

        Form1 form1obj = new Form1();

        private void btnDodajIloscKsiazek_Click(object sender, EventArgs e)
        {
            if(listViewBibliotekaAdmin.SelectedItems.Count <=0)
            {
                MessageBox.Show("Wybierz ksiazke.");
            }
            else
            {
                if (textBoxIloscKsiazek.Text == "")
                {
                    MessageBox.Show("Wprowadź ilość książek");
                }
                else
                {
                    if (int.TryParse(textBoxIloscKsiazek.Text, out int x) == false)
                    {
                        MessageBox.Show("Wprowadź poprawną ilość.");
                    }
                    else
                    {
                        int ile_dodac = int.Parse(textBoxIloscKsiazek.Text);

                        string id_ksiazki = listViewBibliotekaAdmin.SelectedItems[0].Text;

                        string query = "SELECT book_amount_available FROM books WHERE book_id LIKE '" + id_ksiazki + "'";

                        int books_available = int.Parse(form1obj.sendQueryRetString(query));

                        int books_after_add = books_available + ile_dodac;

                        query = "UPDATE books SET book_amount_available = " + books_after_add.ToString() + " WHERE book_id LIKE " + id_ksiazki;

                        string trash_res = form1obj.sendQueryRetString(query);


                        List<ListViewItem> list_upd = new List<ListViewItem>();

                        query = "SELECT * FROM books";

                        list_upd = form1obj.sendQueryRetBooks(query);

                        listViewBibliotekaAdmin.Items.Clear();

                        foreach (ListViewItem item in list_upd)
                        {
                            listViewBibliotekaAdmin.Items.Add(item);
                        }

                        textBoxIloscKsiazek.Text = "";


                        MessageBox.Show("Dodano książki.");

                    }
                }
            }

           
        }

        private void btnNowaKsiazka_Click(object sender, EventArgs e)
        {
            FormNowaKsiazka fKsiazka = new FormNowaKsiazka();

            fKsiazka.Show();
            fKsiazka.BringToFront();
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            List<ListViewItem> list_upd = new List<ListViewItem>();

            string query = "SELECT * FROM books";

            list_upd = form1obj.sendQueryRetBooks(query);

            listViewBibliotekaAdmin.Items.Clear();

            foreach (ListViewItem item in list_upd)
            {
                listViewBibliotekaAdmin.Items.Add(item);
            }
        }
    }
}
