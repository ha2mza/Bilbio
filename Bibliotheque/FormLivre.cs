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
    using DsBiblioTableAdapters;
    public partial class FormLivre : Form
    {
        DsBiblio ds = null;
        public FormLivre()
        {
            InitializeComponent();
            ds = new DsBiblio();
            livreTableAdapter livreTableAdapter = new livreTableAdapter();
            livreTableAdapter.Fill(ds.livre);
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void btnfirst_Click(object sender, EventArgs e)
        {

        }

        private void btnprevious_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {

        }

        private void btnlast_Click(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {

        }
    }
}
