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
    public partial class FormAdherant : Form
    {
        DsBiblio ds = null;
        BindingSource Mvvm_adherant = null;
        // Test finaaal
        public FormAdherant()
        {
            InitializeComponent();
            ds = Program.ds;
            Mvvm_adherant = new BindingSource();
            Mvvm_adherant.DataSource = ds.Adherent;
            
                codeATextBox.DataBindings.Add("Text", Mvvm_adherant, "codeA", true, DataSourceUpdateMode.Never);
                nomATextBox.DataBindings.Add("Text", Mvvm_adherant, "nomA", true, DataSourceUpdateMode.Never);
                adresseTextBox.DataBindings.Add("Text", Mvvm_adherant, "adresse", true, DataSourceUpdateMode.Never);
                dateInscriptionDateTimePicker.DataBindings.Add("Value", Mvvm_adherant, "DateInscription", true, DataSourceUpdateMode.Never);
            ds.Adherent.codeAColumn.AutoIncrementSeed = ds.Adherent.Count != 0 ? ds.Adherent.AsEnumerable().Max(x => x.codeA) + 1 : 1;
            ds.Adherent.codeAColumn.AutoIncrementStep = 1;
            

            
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            codeATextBox.Clear();
            nomATextBox.Clear();
            adresseTextBox.Clear();
            dateInscriptionDateTimePicker.Value = DateTime.Now;
            btnajouter.Text = "Ajouter";
            try
            {
                ds.Adherent.AddAdherentRow(nomATextBox.Text, adresseTextBox.Text, dateInscriptionDateTimePicker.Value);
                Mvvm_adherant.ResetBindings(true);
                
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
           DsBiblio.AdherentRow adherentrow= ds.Adherent.FindBycodeA(int.Parse(codeATextBox.Text));
            adherentrow.nomA = nomATextBox.Text;
            adherentrow.adresse = adresseTextBox.Text;
            adherentrow.DateInscription = dateInscriptionDateTimePicker.Value;
            Mvvm_adherant.ResetBindings(true);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try {
                 Mvvm_adherant.RemoveAt(Mvvm_adherant.Find("codeA", txtRech.Text));
                MessageBox.Show("Suppression avec succes");
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
           Mvvm_adherant.Find("codeA", txtRech.Text);
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            Mvvm_adherant.MoveLast();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Mvvm_adherant.MoveNext();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            Mvvm_adherant.MovePrevious();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            Mvvm_adherant.MoveFirst();
        }

        private void FormAdherant_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.fa = null;
        }
    }
}
