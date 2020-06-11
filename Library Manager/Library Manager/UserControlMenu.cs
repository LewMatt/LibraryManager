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
    public partial class UserControlMenu : UserControl
    {
        public UserControlMenu()
        {
            InitializeComponent();
            Color backColor = Color.FromArgb(100, Color.Gray);
            lblBiblioteka.BackColor = backColor;
            lblMojeKsiaz.BackColor = backColor;
            lblMojeDane.BackColor = backColor;
            lblZamowKsiaz.BackColor = backColor;
        }

        public FormMenu fM;

        private void btnBibliotekaPokaz_Click(object sender, EventArgs e)
        {
            fM.btnBiblioteka_Click(sender, e);
        }

        private void btnMojeKsiazkiPokaz_Click(object sender, EventArgs e)
        {
            fM.btnMojeKsiazki_Click(sender, e);
        }

        private void btnMojeDanePokaz_Click(object sender, EventArgs e)
        {
            fM.btnMojeDane_Click(sender, e);
        }

        private void btnZamowKsiazkePokaz_Click(object sender, EventArgs e)
        {
            fM.btnZamowKsiazke_Click(sender, e);
        }
    }
}
