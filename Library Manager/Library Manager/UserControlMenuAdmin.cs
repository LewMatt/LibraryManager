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
    public partial class UserControlMenuAdmin : UserControl
    {
        public UserControlMenuAdmin()
        {
            InitializeComponent();
            Color backColor = Color.FromArgb(100, Color.Gray);
            lblBiblioteka.BackColor = backColor;
            lblWypozyczone.BackColor = backColor;
            lblUzytkownicy.BackColor = backColor;
            lblZamowienia.BackColor = backColor;
        }

        public FormMenuAdmin fMenAdm;

        private void btnBiblioteka_Click(object sender, EventArgs e)
        {
            fMenAdm.btnBiblioteka_Click(sender, e);
        }

        private void btnWypozyczone_Click(object sender, EventArgs e)
        {
            fMenAdm.btnKsiazkiWypozyczone_Click(sender, e);
        }

        private void btnUzytkownicy_Click(object sender, EventArgs e)
        {
            fMenAdm.btnUzytkownicy_Click(sender, e);
        }

        private void btnZamowienia_Click(object sender, EventArgs e)
        {
            fMenAdm.btnZamowienia_Click(sender, e);
        }
    }
}
