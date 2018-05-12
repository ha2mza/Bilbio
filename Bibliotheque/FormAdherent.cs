using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotheque.DsBiblioTableAdapters;

namespace Bibliotheque
{
    public partial class FormAdherent : Form
    {
        DsBiblio ds = null;
        AdherentTableAdapter AdherentTableAdapter = null;
        BindingSource Mvvm_adherent = null;
        public FormAdherent()
        {
            InitializeComponent();
            ds = new DsBiblio();
            AdherentTableAdapter = new AdherentTableAdapter();
            AdherentTableAdapter.Fill(ds.Adherent);
            empruntTableAdapter emprunt = new empruntTableAdapter();
            emprunt.Fill(ds.emprunt);
            Mvvm_adherent = new BindingSource();
            Mvvm_adherent.DataSource = ds.Adherent;
            dataGridView1.DataSource = Mvvm_adherent;
            nomATextBox.DataBindings.Add("Text", Mvvm_adherent, "nomA", true, DataSourceUpdateMode.Never);
            codeATextBox.DataBindings.Add("Text", Mvvm_adherent, "codeA", true, DataSourceUpdateMode.Never);
            adresseTextBox.DataBindings.Add("Text", Mvvm_adherent, "adresse", true, DataSourceUpdateMode.Never);
            dateInscriptionDateTimePicker.DataBindings.Add("Value", Mvvm_adherent, "dateInscription", true, DataSourceUpdateMode.Never);
            ds.Adherent.codeAColumn.AutoIncrementSeed = ds.Adherent.Count != 0 ? ds.Adherent.AsEnumerable().Max(x => x.codeA) + 1 : 1;
            ds.Adherent.codeAColumn.AutoIncrementStep = 1;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            try
            {
                DsBiblio.AdherentRow adherent = ds.Adherent.FindBycodeA(Parseint(codeATextBox.Text));
                adherent.nomA = nomATextBox.Text;
                adherent.adresse = adresseTextBox.Text;
                adherent.DateInscription = dateInscriptionDateTimePicker.Value;
                Mvvm_adherent.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public int Parseint(string val) => int.Parse(val);
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = null;
                DsBiblio.AdherentRow adherent = ds.Adherent.FindBycodeA(Parseint(codeATextBox.Text));
                    MessageBox.Show(ds.Relations.Count.ToString());
                Mvvm_adherent.ResetBindings(true);
                dataGridView1.DataSource = Mvvm_adherent;
                SqlCommandBuilder cmb = new SqlCommandBuilder(AdherentTableAdapter.Adapter);
                AdherentTableAdapter.Update(ds);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            Mvvm_adherent.Position = Mvvm_adherent.Find("codeA", txtRech.Text);
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            Mvvm_adherent.MoveLast();
            AdherentTableAdapter.Update(ds);
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Mvvm_adherent.MoveNext();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            Mvvm_adherent.MovePrevious();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            Mvvm_adherent.MoveFirst();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            try
            {
                ds.Adherent.AddAdherentRow(nomATextBox.Text, adresseTextBox.Text, dateInscriptionDateTimePicker.Value);
                Mvvm_adherent.ResetBindings(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
