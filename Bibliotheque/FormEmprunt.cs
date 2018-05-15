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
    public partial class FormEmprunt : Form
    {
        DsBiblio ds = null;
        public FormEmprunt()
        {
            InitializeComponent();
            ds = Program.ds;
            //codeAComboBox.DisplayMember = "codeA";
            codeAComboBox.ValueMember = "codeA";
            codeAComboBox.DataSource = ds.Adherent;
            codethComboBox.DisplayMember = "intituleTh";
            codethComboBox.ValueMember = "codeth";
            codethComboBox.DataSource = ds.theme;
            empruntDataGridView.DataSource = ds.emprunt;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DsBiblio.livreRow livre in lstBoxLivres.SelectedItems)
                {
                    ds.emprunt.AddempruntRow(livre,
                        ds.Adherent.FindBycodeA((int)codeAComboBox.SelectedValue),
                        date_empruntDateTimePicker.Value,
                        DateTime.Now);
                    ds.emprunt.Last().Setdate_retourNull();

                }

                empruntDataGridView.DataSource = ds.emprunt;
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void codethComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBoxLivres.DataSource = (
                from livre in ds.livre
                where livre.CodeTh == (int)codethComboBox.SelectedValue
                select livre).ToList();
            lstBoxLivres.DisplayMember = "Titre";
            lstBoxLivres.ValueMember = "codeL";

        }

        private void lstBoxLivres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void codeAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtnomAdr.Text = (
                from adherant in ds.Adherent
                where adherant.codeA == (int)codeAComboBox.SelectedValue
                select adherant.nomA

                ).First();
        }
    }
}
