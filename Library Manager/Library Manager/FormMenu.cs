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
            userControlMenu1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            userControlMenu1.BringToFront();
        }

        private void btnBiblioteka_Click(object sender, EventArgs e)
        {
            userControlBiblioteka1.BringToFront();
        }

        private void btnMojeKsiazki_Click(object sender, EventArgs e)
        {
            userControlMojeKsiazki1.BringToFront();
        }

        private void btnMojeDane_Click(object sender, EventArgs e)
        {
            userControlMojeDane1.BringToFront();
        }

        private void btnZamowKsiazke_Click(object sender, EventArgs e)
        {
            userControlZamowKsiazke1.BringToFront();
        }
    }
}
