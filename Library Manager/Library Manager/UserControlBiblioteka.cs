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
    public partial class UserControlBiblioteka : UserControl
    {
        public UserControlBiblioteka()
        {
            InitializeComponent();
 
        }

        Form1 formObj = new Form1();
        

        public string user = "";
        public int user_id = 0;

        public string data_za_mies;



        private void btnWypozyczKsiazke_Click(object sender, EventArgs e)
        {
            int index = int.Parse(listViewBiblioteka.SelectedItems[0].Index.ToString()) + 1;

            string query = "SELECT COUNT(*) FROM books WHERE book_id LIKE " + index.ToString() + " AND book_amount_available > 0";

            string result = formObj.sendQueryRetString(query);

            int res = int.Parse(result);

            if(res == 0)
            {
                MessageBox.Show("Brak książek na stanie.");
            }
            else
            {

                string book_id = index.ToString();
                string book_name = listViewBiblioteka.SelectedItems[0].SubItems[1].Text;
                string book_author = listViewBiblioteka.SelectedItems[0].SubItems[2].Text;

                string q = "SELECT COUNT(*) FROM books_" + user + " WHERE book_id LIKE " + book_id;

                int is_borrowed = int.Parse(formObj.sendQueryRetString(q));

                if(is_borrowed == 0)
                {
                    string que = "INSERT INTO `books_" + user + "` (`book_id`, `book_title`, `book_author`, `book_return_date`) VALUES (" + book_id + ", '" + book_name + "', '" + book_author + "', '"+data_za_mies+"')";

                    string trash_result = formObj.sendQueryRetString(que);

                    que = "SELECT book_amount_available FROM books WHERE book_id like " + book_id;

                    string book_amount = formObj.sendQueryRetString(que);

                    int book_amount_updated = int.Parse(book_amount) - 1;

                    que = "UPDATE books SET book_amount_available = " + book_amount_updated.ToString() + " WHERE book_id like " + book_id;

                    trash_result = formObj.sendQueryRetString(que);

                    que = "INSERT INTO `books_borrowed` (`book_id`, `user_id`, `book_title`, `book_return_date`) VALUES('" +book_id + "', '" + user_id + "', '"+ book_name + "', '"+data_za_mies+"')";

                    trash_result = formObj.sendQueryRetString(que);

                    List<ListViewItem> list_updated = new List<ListViewItem>();

                    que = "SELECT * FROM books";

                    list_updated = formObj.sendQueryRetBooks(que);

                    listViewBiblioteka.Items.Clear();

                    foreach(ListViewItem item in list_updated)
                    {
                        listViewBiblioteka.Items.Add(item);
                    }

                    MessageBox.Show("Książka wypożyczona");
                    
                }
                else
                {
                    MessageBox.Show("Książka została już wypożyczona.");
                }
                
                

            }
        }
    }
}
