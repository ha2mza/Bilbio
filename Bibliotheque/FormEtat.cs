using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bibliotheque
{
    public partial class FormEtat : Form
    {
        public FormEtat()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();

        private void FormEtat_Load(object sender, EventArgs e)
        {
            da.Fill(ds);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
