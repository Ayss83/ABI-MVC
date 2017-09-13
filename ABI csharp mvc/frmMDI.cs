using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassesMetier;

namespace ABI_csharp_mvc
{
    public partial class frmMDI : Form
    {
        /// <summary>
        /// Collaborateur en dur pour tests
        /// </summary>
        private MCollaborateur collabo = new MCollaborateur("De la Roque", "Jean-Charles", "315 Avenue de la liberté", "PDG");
        private static frmMDI Instance;

        /// <summary>
        /// Constructeur privé
        /// </summary>
        private frmMDI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Méthode statique appelant le constructeur
        /// </summary>
        /// <returns>l'instance de frmMDI</returns>
        public static frmMDI getInstance()
        {
            if(Instance == null)
            {
                Instance = new frmMDI();
            }
            return Instance;
        }

        private void tsiNouvCollab_Click(object sender, EventArgs e)
        {
            ctrlNouvCollab collab = new ctrlNouvCollab();
        }

        private void tsiContrat_Click(object sender, EventArgs e)
        {
            frmContrat contrat = new frmContrat();
            contrat.Show();

        }

        private void tsiVisuCollab_Click(object sender, EventArgs e)
        {
            ctrlVisuCollab collab = new ctrlVisuCollab(collabo);
        }

        private void tsiListeCollab_Click(object sender, EventArgs e)
        {
            ctrlListeCollab listeCollab = new ctrlListeCollab();
        }
    }
}
