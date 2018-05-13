using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotheque
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public void closesForm()
        {
            if (Program.fa != null)
            {
                Program.fa.Close();
                Program.fa = null;
            }



            if (Program.fl != null)
            {
                Program.fl.Close();
                Program.fl = null;
            }


            if (Program.ft != null)
            {
                Program.ft.Close();
                Program.ft = null;
            }
        }

        private void enregisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.AdherentTableAdapter.Update(Program.ds.Adherent);
        }

        private void saisieRetourToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empruntToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thèmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.ft == null)
            {
                closesForm();
                Program.ft = new FormTheme();
                Program.ft.MdiParent = this;
                Program.ft.Show();
            }
        }

        private void livreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.fl == null)
            {
                closesForm();
                Program.fl = new FormLivre();
                Program.fl.MdiParent = this;
                Program.fl.Show();
            }
        }

        private void adhérentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.fa == null)
            {
                closesForm();
                Program.fa = new FormAdherant();
                Program.fa.MdiParent = this;
                Program.fa.Show();
            }
        }
    }
}
