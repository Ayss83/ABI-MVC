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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void collaborateur_contrat_Click(object sender, EventArgs e)
        {
            frmContrat contrat = new frmContrat();
            contrat.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCollab collab = new frmCollab();
            collab.Show();
        }
    }
}
