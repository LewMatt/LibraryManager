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
    public partial class UserControlZamowienaAdmin : UserControl
    {
        public UserControlZamowienaAdmin()
        {
            InitializeComponent();
        }

        public string data_odd;

        /// <summary>
        /// Funkcja odpowiedzialna za dodanie książek zamówionych przez użytkowników.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajDoBib_Click(object sender, EventArgs e)
        {
            if(listViewZamowienia.SelectedItems.Count <= 0 )
            {
                MessageBox.Show("Wybierz opcje z listy");
            }
            else
            { 
            string book_id = listViewZamowienia.SelectedItems[0].Text;
            string user_id = listViewZamowienia.SelectedItems[0].SubItems[1].Text;

            string quer = "DELETE FROM `books_ordered` WHERE book_id LIKE "+book_id+" AND user_id LIKE "+user_id+";";

            Form1 form1o = new Form1();

            string trash_res = form1o.sendQueryRetString(quer);


            listViewZamowienia.Items.Clear();

            List<ListViewItem> listaa = new List<ListViewItem>();

            quer = "SELECT * FROM books_ordered";

            listaa = form1o.sendQueryRetBooksOrdered(quer);

            foreach(ListViewItem item in listaa)
            {
                listViewZamowienia.Items.Add(item);
            }

            
            string user_login;
            string book_title;
            string book_author;


            quer = "SELECT user_login FROM users WHERE user_id LIKE "+user_id.ToString();

            user_login = form1o.sendQueryRetString(quer);

            quer = "SELECT book_title FROM books WHERE book_id LIKE "+book_id.ToString();

            book_title = form1o.sendQueryRetString(quer);

            quer = "SELECT book_author FROM books WHERE book_id LIKE "+book_id.ToString()+"";

            book_author = form1o.sendQueryRetString(quer);

            quer = "INSERT INTO `books_"+user_login+"` (`book_id`, `book_title`, `book_author`, `book_return_date`) VALUES (" + book_id.ToString() +", '"+book_title+"', '"+book_author+"', '"+data_odd+"')";

            trash_res = form1o.sendQueryRetString(quer);

            quer = "INSERT INTO `books_borrowed` (`book_id`, `user_id`, `book_title`, `book_return_date`) VALUES ('"+book_id+"', '"+user_id+"', '"+book_title+"', '"+data_odd+"')";

            trash_res = form1o.sendQueryRetString(quer);

            MessageBox.Show("Dodano do biblioteki");
            }
        }
    }
}
