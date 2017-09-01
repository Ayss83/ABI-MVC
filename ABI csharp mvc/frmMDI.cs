using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABI_csharp_mvc
{
    public partial class frmMDI : Form
    {
        /// <summary>
        /// Collaborateur en dur pour tests
        /// </summary>
        private Collaborateur collabo = new Collaborateur("De la Roque", "Jean-Charles", "315 Avenue de la liberté", "PDG");

        public frmMDI()
        {
            InitializeComponent();
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
            ctrlVisuCollab collab = new ctrlVisuCollab(collabo, this);
        }
    }
}
