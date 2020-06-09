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
    public partial class UserControlMojeKsiazki : UserControl
    {
        public UserControlMojeKsiazki()
        {
            InitializeComponent();
        }

        public int my_id;

        Form1 form1obj = new Form1();
        

        private void btnOddajKsiazke_Click(object sender, EventArgs e)
        {
            if (listViewMojeKsiazki.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Wybierz ksiazke");   
            }
            else
            {
                int book_id = int.Parse(listViewMojeKsiazki.SelectedItems[0].Text);

                string query = "SELECT user_login FROM users WHERE user_id LIKE " + my_id.ToString();

                string user_login = form1obj.sendQueryRetString(query);

                query = "DELETE FROM books_" + user_login + " WHERE book_id LIKE " + book_id.ToString();

                string trash_result = form1obj.sendQueryRetString(query);

                query = "DELETE FROM books_borrowed WHERE book_id LIKE " + book_id.ToString() + " AND user_id LIKE " + my_id.ToString();

                trash_result = form1obj.sendQueryRetString(query);

                query = "SELECT book_amount_available FROM books WHERE book_id LIKE " + book_id.ToString();

                string result = form1obj.sendQueryRetString(query);

                int books_after_return = int.Parse(result) + 1;

                query = "UPDATE books SET book_amount_available = " + books_after_return.ToString() + " WHERE book_id LIKE " + book_id.ToString();

                trash_result = form1obj.sendQueryRetString(query);

                List<ListViewItem> list_updated = new List<ListViewItem>();

                query = "SELECT * FROM books_" + user_login;

                list_updated = form1obj.sendQueryRetUserBooks(query);

                listViewMojeKsiazki.Items.Clear();

                foreach (ListViewItem item in list_updated)
                {
                    listViewMojeKsiazki.Items.Add(item);
                }


                MessageBox.Show("Książka oddana.");
            }
            
        }
    }
}
