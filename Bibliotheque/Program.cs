using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotheque
{
    using DsBiblioTableAdapters;
    static class Program
    {

        public static DsBiblio ds = null;

        public static AdherentTableAdapter AdherentTableAdapter = null;

        public static FormAdherant fa = null;
        public static FormLivre fl = null;
        public static FormTheme ft = null;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            ds = new DsBiblio();
            AdherentTableAdapter = new AdherentTableAdapter();
            AdherentTableAdapter.Fill(ds.Adherent);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());


        }
    }
}
