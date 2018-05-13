using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotheque.DsBiblioTableAdapters;

namespace Bibliotheque
{
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
            Mvvm_theme = new BindingSource();
            themeTableAdapter.Fill(ds.theme);
            Mvvm_theme.DataSource = ds.theme;

            codethTextBox.DataBindings.Add("Text", Mvvm_theme, "codeth", false, DataSourceUpdateMode.Never);
            intituleThTextBox.DataBindings.Add("Text", Mvvm_theme, "intituleTh", false, DataSourceUpdateMode.Never);


        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            try
            {
                ds.theme.AddthemeRow(intituleThTextBox.Text);
                Mvvm_theme.ResetBindings(true);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                DsBiblio.themeRow themerow = ds.theme.FindBycodeth(int.Parse(codethTextBox.Text));
                themerow.codeth = int.Parse(codethTextBox.Text);
                themerow.intituleTh = intituleThTextBox.Text;
                Mvvm_theme.ResetBindings(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                ds.theme.RemovethemeRow(ds.theme.FindBycodeth(int.Parse(codethTextBox.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            Mvvm_theme.MoveLast();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Mvvm_theme.MoveNext();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            Mvvm_theme.MovePrevious();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            Mvvm_theme.MoveFirst();

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            Mvvm_theme.Find("codeth", txtRech.Text);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }
    }
}
