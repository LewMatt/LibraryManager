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
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
            userControlMenuAdmin1.BringToFront();
        }

        Form1 form1obj = new Form1();

        private void btnWyjscie_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            userControlMenuAdmin1.BringToFront();
        }

        private void btnBiblioteka_Click(object sender, EventArgs e)
        {
            List<ListViewItem> ksiazki = new List<ListViewItem>();

            string query = "SELECT * FROM books";
            ksiazki = form1obj.sendQueryRetBooks(query);

            userControlBibliotekaAdmin1.listViewBibliotekaAdmin.Items.Clear();

            foreach (ListViewItem item in ksiazki)
            {
                userControlBibliotekaAdmin1.listViewBibliotekaAdmin.Items.Add(item);
            }

            userControlBibliotekaAdmin1.BringToFront();

        }

        private void btnKsiazkiWypozyczone_Click(object sender, EventArgs e)
        {
            List<ListViewItem> ksiazki_wyp = new List<ListViewItem>();

            string query = "SELECT COUNT(*) FROM books_borrowed";

            int are_books_in = int.Parse(form1obj.sendQueryRetString(query));

            if (are_books_in != 0)
            {
                query = "SELECT * FROM books_borrowed";
                ksiazki_wyp = form1obj.sendQueryRetBooksBorrowed(query);
            }

            userControlKsiazkiWypAdmin1.listViewKsiazkiWyp.Items.Clear();

            foreach(ListViewItem item in ksiazki_wyp)
            {
                userControlKsiazkiWypAdmin1.listViewKsiazkiWyp.Items.Add(item);
            }

            userControlKsiazkiWypAdmin1.BringToFront();
        }

        private void btnUzytkownicy_Click(object sender, EventArgs e)
        {
            List<ListViewItem> uzytkownicy = new List<ListViewItem>();

            string query = "SELECT * FROM users WHERE user_id > 0";
            uzytkownicy = form1obj.sendQueryRetUsers(query);

            userControlUzytkownicyAdmin1.listViewUzytkownicy.Items.Clear();

            foreach(ListViewItem item in uzytkownicy)
            {
                userControlUzytkownicyAdmin1.listViewUzytkownicy.Items.Add(item);
            }

            userControlUzytkownicyAdmin1.BringToFront();
        }
    }
}
