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
        empruntTableAdapter empruntTableAdapter = null;
        public FormEmprunt()
        {
            InitializeComponent();
            ds = new DsBiblio();
            empruntTableAdapter = new empruntTableAdapter();
            empruntTableAdapter.Fill(ds.emprunt);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void codethComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstBoxLivres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void codeAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
