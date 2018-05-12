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
    public partial class FormRetour : Form
    {
        DsBiblio ds = null;
        empruntTableAdapter empruntTableAdapter = null;
        public FormRetour()
        {
            InitializeComponent();
            ds = new DsBiblio();
            empruntTableAdapter = new empruntTableAdapter();
            empruntTableAdapter.Fill(ds.emprunt);
            btnSave.Click -= btnSave_Click;
        btnSave.Click += delegate (object s, EventArgs e)
            {
                if(s is Button button)
                {
                    int binaryValue = 0b_0101_0101;

                    MessageBox.Show(binaryValue.ToString());
                }
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("koko");
        }

        private void codeAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
