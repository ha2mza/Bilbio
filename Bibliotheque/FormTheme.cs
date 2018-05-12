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
    public partial class FormTheme : Form
    {
        DsBiblio ds = null;
        themeTableAdapter themeTableAdapter = null;
        BindingSource Mvvm_theme = null;
        public FormTheme()
        {
            InitializeComponent();
            ds = new DsBiblio();
            themeTableAdapter = new themeTableAdapter();
            themeTableAdapter.Fill(ds.theme);
            Mvvm_theme = new BindingSource();
            
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {

        }

        private void btnlast_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {

        }

        private void btnprevious_Click(object sender, EventArgs e)
        {

        }

        private void btnfirst_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }
    }
}
