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
        BindingSource Mvvm_theme = null;

        public FormTheme()
        {
            InitializeComponent();
            ds = Program.ds;
            Mvvm_theme = new BindingSource();
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
                themerow.BeginEdit();
                themerow.codeth = int.Parse(codethTextBox.Text);
                themerow.intituleTh = intituleThTextBox.Text;
                themerow.EndEdit();
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
                if (ds.theme.FindBycodeth(int.Parse(codethTextBox.Text)).GetlivreRows().Count() > 0)
                {
                    DialogResult res = MessageBox.Show("ce theme a des livres voulez vous vraiment le supprimer", "Suppession", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (res == DialogResult.OK)
                    {
                        var livres = ds.theme.FindBycodeth(int.Parse(codethTextBox.Text)).GetlivreRows().ToList();
                        if (livres.Where(livre => livre.GetempruntRows().Count() > 0).Count() > 0)
                        {
                            DialogResult resu = MessageBox.Show("Certain livres ont des emprunts voulez vous vraiment les supprimer", "Suppession", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (res == DialogResult.OK)
                            {
                                var livresExcepetion = livres.Where(livre => livre.GetempruntRows().Count() > 0).ToList();
                                livresExcepetion.ForEach(livre => 
                                livre.GetempruntRows().ToList().ForEach(emprunt=>
                                emprunt.Delete()));
                            }
                            livres.ForEach(x => x.Delete());
                            Mvvm_theme.RemoveCurrent();
                            MessageBox.Show("Suppression avec succes");

                        }
                        else
                        {
                            livres.ForEach(x => x.Delete());
                            Mvvm_theme.RemoveCurrent();
                            MessageBox.Show("Suppression avec succes");
                        }
                    }

                }
                else
                    Mvvm_theme.RemoveCurrent();

                MessageBox.Show("Suppression avec succes");
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

        private void FormTheme_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ft = null;
        }
    }
}
