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
    public partial class FormZmienHaslo : Form
    {
        public FormZmienHaslo()
        {
            InitializeComponent();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            textBoxAktHaslo.Text = "";
            textBoxNoweHaslo.Text = "";
            textBoxNoweHasloPow.Text = "";
            this.Hide();
        }
    }
}
