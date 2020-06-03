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
            userControlBibliotekaAdmin1.BringToFront();
        }

        private void btnKsiazkiWypozyczone_Click(object sender, EventArgs e)
        {
            userControlKsiazkiWypAdmin1.BringToFront();
        }

        private void btnUzytkownicy_Click(object sender, EventArgs e)
        {
            userControlUzytkownicyAdmin1.BringToFront();
        }
    }
}
