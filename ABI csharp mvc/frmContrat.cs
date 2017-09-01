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
    public partial class frmContrat : Form
    {
        public frmContrat()
        {
            InitializeComponent();
            this.grdAvenant.Visible = false;
            this.btnAjoutAvenant.Visible = false;
            this.btnDetailsAvenant.Visible = false;
            this.btnMasquer.Visible = false;
            this.ModeCdd();
        }

        /// <summary>
        /// Méthode de changement d'affichage pour un contrat de type CDD
        /// </summary>
        public void ModeCdd()
        {
            this.pnlAgence.Visible = false;
            this.pnlEcole.Visible = false;
            this.pnlIndemnite.Visible = false;
            this.pnlMission.Visible = false;
            this.pnlDateFinPrev.Visible = true;
            this.pnlMotif.Visible = true;
            this.pnlSalaire.Visible = true;
        }

        /// <summary>
        /// Méthode de changement d'affichage pour un contrat de type CDI
        /// </summary>
        public void ModeCdi()
        {
            this.pnlAgence.Visible = false;
            this.pnlEcole.Visible = false;
            this.pnlIndemnite.Visible = false;
            this.pnlMission.Visible = false;
            this.pnlDateFinPrev.Visible = false;
            this.pnlMotif.Visible = false;
            this.pnlSalaire.Visible = true;
        }

        /// <summary>
        /// Méthode de changement d'affichage pour un contrat de type Interim
        /// </summary>
        public void ModeInterim()
        {
            this.pnlAgence.Visible = true;
            this.pnlEcole.Visible = false;
            this.pnlIndemnite.Visible = false;
            this.pnlMission.Visible = false;
            this.pnlDateFinPrev.Visible = true;
            this.pnlMotif.Visible = true;
            this.pnlSalaire.Visible = false;
        }

        /// <summary>
        /// Méthode de changement d'affichage pour un contrat de type Stage
        /// </summary>
        public void ModeStage()
        {
            this.pnlAgence.Visible = false;
            this.pnlEcole.Visible = true;
            this.pnlIndemnite.Visible = true;
            this.pnlMission.Visible = true;
            this.pnlDateFinPrev.Visible = true;
            this.pnlMotif.Visible = true;
            this.pnlSalaire.Visible = false;
        }

        /// <summary>
        /// Méthode rendant la datagridview et ses boutons associés visibles, cela aggrandit la fenêtre et désactive le bouton avenants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAvenants_Click(object sender, EventArgs e)
        {
            this.grdAvenant.Visible = true;
            this.btnAjoutAvenant.Visible = true;
            this.btnDetailsAvenant.Visible = true;
            this.btnMasquer.Visible = true;
            this.btnAvenants.Enabled = false;
            this.flpValidAnnul.Width = 796;
        }

        /// <summary>
        /// Méthode permettant de masquer la datagridview et ses boutons associés et réactive le bouton avenants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMasquer_Click(object sender, EventArgs e)
        {
            this.grdAvenant.Visible = false;
            this.btnAjoutAvenant.Visible = false;
            this.btnDetailsAvenant.Visible = false;
            this.btnMasquer.Visible = false;
            this.btnAvenants.Enabled = true;
            this.flpValidAnnul.Width = 359;
        }

        /// <summary>
        /// Méthode de changement des contrôles affichés si le radioButton rbtCdd est sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtCdd_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtCdd.Checked == true)
                this.ModeCdd();
        }

        /// <summary>
        /// Méthode de changement des contrôles affichés si le radioButton rbtCdi est sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtCdi_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtCdi.Checked == true)
                this.ModeCdi();
        }

        /// <summary>
        /// Méthode de changement des contrôles affichés si le radioButton rbtInterim est sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtInterim_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtInterim.Checked == true)
                this.ModeInterim();
        }

        /// <summary>
        /// Méthode de changement des contrôles affichés si le radioButton rbtStage est sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtStage_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtStage.Checked == true)
                this.ModeStage();
        }
    }
}
