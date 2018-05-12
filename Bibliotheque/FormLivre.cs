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
    public partial class FormLivre : Form
    {
        DsBiblio ds = null;
        livreTableAdapter livreTableAdapter = null;
        BindingSource Mvvm_livre = null;
        public FormLivre()
        {
            InitializeComponent();
            ds = new DsBiblio();
            livreTableAdapter = new livreTableAdapter();
            livreTableAdapter.Fill(ds.livre);
            Mvvm_livre = new BindingSource();
            Mvvm_livre.DataSource = ds.livre;

            codeLTextBox.DataBindings.Add("Text", Mvvm_livre, "codeL", true, DataSourceUpdateMode.Never);
            titreTextBox.DataBindings.Add("Text", Mvvm_livre, "titre", true, DataSourceUpdateMode.Never);
            auteurTextBox.DataBindings.Add("Text", Mvvm_livre, "auteur", true, DataSourceUpdateMode.Never);
            nbExemplaireTextBox.DataBindings.Add("Text", Mvvm_livre, "nbExemplaire", true, DataSourceUpdateMode.Never);
            codeThComboBox.DataSource = ds.theme;
            codeThComboBox.ValueMember = "codeth";
            codeThComboBox.DisplayMember = "intituleTh";
            ds.livre.CodeLColumn.AutoIncrementSeed = ds.livre.Count != 0 ? ds.livre.AsEnumerable().Max(x => x.CodeL) + 1 : 1;
            ds.Adherent.codeAColumn.AutoIncrementStep = 1;

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            try
            {
                ds.livre.AddlivreRow(titreTextBox.Text, auteurTextBox.Text, int.Parse(nbExemplaireTextBox.Text), ds.theme.FindBycodeth((int)codeThComboBox.SelectedValue));
                Mvvm_livre.ResetBindings(true);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            DsBiblio.livreRow livrerow = ds.livre.FindByCodeL(int.Parse(codeLTextBox.Text));
            livrerow.Titre = titreTextBox.Text;
            livrerow.Auteur = auteurTextBox.Text;
            livrerow.NbExemplaire = int.Parse(nbExemplaireTextBox.Text);
            livrerow.CodeTh = int.Parse(codeThComboBox.Text);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try { Mvvm_livre.RemoveAt(Mvvm_livre.Find("codeL", codeLTextBox.Text)); }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            Mvvm_livre.Find("codeL", txtRech.Text);
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            Mvvm_livre.MoveLast();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Mvvm_livre.MoveNext();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            Mvvm_livre.MovePrevious();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            Mvvm_livre.MoveFirst();
        }

        private void FormLivre_Load(object sender, EventArgs e)
        {

        }
    }
}
