using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAednevnik
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ItemOsoba_Click(object sender, EventArgs e)
        {
            Osoba nova = new Osoba();
            nova.ShowDialog();
        }

        private void ItemSmer_Click(object sender, EventArgs e)
        {
            Sifarnik nova = new Sifarnik("Smer");
            nova.ShowDialog();
        }

        private void ItemOdeljenje_Click(object sender, EventArgs e)
        {
            
        }

        private void ItemSkGodina_Click(object sender, EventArgs e)
        {
            Sifarnik nova = new Sifarnik("Skolska_godina");
            nova.ShowDialog();
        }

        private void ItemPredmet_Click(object sender, EventArgs e)
        {
            Sifarnik nova = new Sifarnik("Predmet");
            nova.ShowDialog();
        }
    }
}
