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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            Color panelColor = Color.FromArgb(100, Color.Gray);
            panel1.BackColor = panelColor;
            panel2.BackColor = panelColor;
            panel3.BackColor = panelColor;

            userControlMenu1.fM = this;
            userControlMenu1.BringToFront();
        }

        Form1 form1obj = new Form1();

        public string logged_user = "";
        public int logged_user_id;

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            userControlMenu1.BringToFront();
        }

        public void btnBiblioteka_Click(object sender, EventArgs e)
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
            userControlBiblioteka1.user_id = logged_user_id;

            int czas_do_oddania = 1;

            var act_date = DateTime.Today.AddMonths(czas_do_oddania);

            string act_date_str = act_date.ToString("dd MMMM, yyyy");

            userControlBiblioteka1.data_za_mies = act_date_str;

            userControlBiblioteka1.BringToFront();
        }

        public void btnMojeKsiazki_Click(object sender, EventArgs e)
        {
            List<ListViewItem> moje_ksiazki = new List<ListViewItem>();

            string query = "SELECT COUNT(*) FROM books_" + logged_user;

            int result = int.Parse(form1obj.sendQueryRetString(query));

            if(result>0)
            {
                query = "SELECT * FROM books_" + logged_user;
                moje_ksiazki = form1obj.sendQueryRetUserBooks(query);

                userControlMojeKsiazki1.listViewMojeKsiazki.Items.Clear();

                foreach(ListViewItem item in moje_ksiazki)
                {
                    userControlMojeKsiazki1.listViewMojeKsiazki.Items.Add(item);
                }
            }
            else
            {
                userControlMojeKsiazki1.listViewMojeKsiazki.Items.Clear();
            }

            userControlMojeKsiazki1.my_id = logged_user_id;

            userControlMojeKsiazki1.BringToFront();
        }


        public void btnMojeDane_Click(object sender, EventArgs e)
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

            userControlMojeDane1.my_id = logged_user_id;
            userControlMojeDane1.my_login = logged_user;

            userControlMojeDane1.BringToFront();
        }

        public void btnZamowKsiazke_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM books WHERE book_amount_available LIKE 0";

            int res = int.Parse(form1obj.sendQueryRetString(query));

            if(res == 0)
            {
                userControlZamowKsiazke1.labelZamowKsiazke.Text = "Wszystkie dostępne książki są na stanie";
                userControlZamowKsiazke1.listViewKsiazkiZamow.Items.Clear();
            }
            else
            {
                List<ListViewItem> lista = new List<ListViewItem>();

                string qu = "SELECT * FROM books WHERE book_amount_available LIKE 0";

                lista = form1obj.sendQueryRetBooks(qu);

                userControlZamowKsiazke1.listViewKsiazkiZamow.Items.Clear();

                foreach(ListViewItem item in lista)
                {
                    userControlZamowKsiazke1.listViewKsiazkiZamow.Items.Add(item);
                }
            }

            userControlZamowKsiazke1.my_user_id = logged_user_id;
            userControlZamowKsiazke1.my_user_login = logged_user;

            userControlZamowKsiazke1.BringToFront();
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
