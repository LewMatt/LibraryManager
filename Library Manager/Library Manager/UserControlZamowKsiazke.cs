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
    public partial class UserControlZamowKsiazke : UserControl
    {
        public UserControlZamowKsiazke()
        {
            InitializeComponent();
        }

        public int my_user_id;

        public string my_user_login;

        Form1 form1obj = new Form1();

        /// <summary>
        /// Funkcja odpowiedzialna za zamówienie książki przez użytkownika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZamow_Click(object sender, EventArgs e)
        {
            if (listViewKsiazkiZamow.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Wybierz ksiazke z listy");
            }
            else
            {
                int book_id = int.Parse(listViewKsiazkiZamow.SelectedItems[0].Text);

                string query = "SELECT COUNT(*) FROM books_ordered WHERE user_id LIKE " + my_user_id.ToString() + " AND book_id LIKE " + book_id.ToString();

                int res = int.Parse(form1obj.sendQueryRetString(query));

                if (res == 1)
                {
                    MessageBox.Show("Już zamówiłeś tę książkę.");
                }
                else
                {
                    query = "SELECT COUNT(*) FROM books_" + my_user_login + " WHERE book_id LIKE " + book_id.ToString();

                    res = int.Parse(form1obj.sendQueryRetString(query));

                    if (res == 1)
                    {
                        MessageBox.Show("Posiadasz już tą książkę.");
                    }
                    else
                    {
                        query = "INSERT INTO `books_ordered` (`book_id`, `user_id`) VALUES ('" + book_id.ToString() + "', '" + my_user_id + "')";

                        string trash_res = form1obj.sendQueryRetString(query);

                        MessageBox.Show("Zamówiono książkę.");
                    }

                }
            }
            

        }
    }
}
