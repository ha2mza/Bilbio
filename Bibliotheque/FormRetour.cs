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
    public partial class FormRetour : Form
    {
        DsBiblio ds = null;
        empruntTableAdapter empruntTableAdapter = null;
        public FormRetour()
        {
            InitializeComponent();
            ds = Program.ds;
            codeAComboBox.ValueMember = "codeA";
            codeAComboBox.DataSource = ds.Adherent;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow r in retourDataGridView.SelectedRows)
                {
                    DsBiblio.empruntRow emprunt = ds.emprunt.FindBycodeLcodeAdate_emprunt(
                        (int)r.Cells[0].Value,
                    (int)r.Cells[1].Value,
                    (DateTime)r.Cells[2].Value);
                    if (emprunt.Isdate_retourNull())
                        emprunt.date_retour = dateretourDateTimePicker.Value;
                    else
                        MessageBox.Show("date deja affecter");
                }

                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void codeAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtnomAdr.Text = (
                from adherant in ds.Adherent
                where adherant.codeA == (int)codeAComboBox.SelectedValue
                select adherant.nomA).First();

            retourDataGridView.DataSource = (
                from emprunt in ds.emprunt
                where emprunt.codeA == (int)codeAComboBox.SelectedValue
                select new { emprunt.codeL, emprunt.codeA, emprunt.date_emprunt, date_retour = (emprunt.Isdate_retourNull())?(DateTime?)null:emprunt.date_retour }
                ).ToList();
        }

        private void FormRetour_Load(object sender, EventArgs e)
        {

        }
    }
}
