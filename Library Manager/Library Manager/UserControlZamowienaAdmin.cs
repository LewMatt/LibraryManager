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

        

        private void btnDodajDoBib_Click(object sender, EventArgs e)
        {
            string user_id = listViewZamowienia.SelectedItems[0].Text;
            string book_id = listViewZamowienia.SelectedItems[0].SubItems[1].Text;

            

            string quer = "DELETE FROM books_ordered WHERE book_id LIKE " + book_id + " AND user_id LIKE " + user_id;

            Form1 form1o = new Form1();

            MessageBox.Show(quer);

            string ress_trash = form1o.sendQueryRetString(quer);


            /*

            listViewZamowienia.Items.Clear();

            List<ListViewItem> listaa = new List<ListViewItem>();

            query = "SELECT * FROM books_ordered";

            listaa = form1obj.sendQueryRetBooksOrdered(query);

            foreach(ListViewItem item in listaa)
            {
                listViewZamowienia.Items.Add(item);
            }

            //
            string user_login;
            string book_title;
            string book_author;
            string book_ret_date = "brak";


            query = "SELECT user_login FROM users WHERE user_id LIKE "+user_id.ToString();

            user_login = form1obj.sendQueryRetString(query);

            query = "SELECT book_title FROM books WHERE book_id LIKE "+book_id.ToString();

            book_title = form1obj.sendQueryRetString(query);

            query = "SELECT book_author FROM books WHERE book_id LIKE "+book_id.ToString()+"";

            book_author = form1obj.sendQueryRetString(query);

            query = "INSERT INTO `books_"+user_login+"` (`book_id`, `book_title`, `book_author`, `book_return_date`) VALUES (" + book_id.ToString() +", '"+book_title+"', '"+book_author+"', '"+book_ret_date+"')";

            string trash_result = form1obj.sendQueryRetString(query);
            //
            */


            MessageBox.Show("Dodano do biblioteki");
        }
    }
}
