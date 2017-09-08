using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABI_csharp_mvc
{
    class ctrlVisuCollab
    {
        private frmCollab leForm;
        private Collaborateur leCollab;

        public ctrlVisuCollab(Collaborateur unCollab)
        {
            leCollab = unCollab;
            leForm = new frmCollab(unCollab);
            leForm.Text = unCollab.PrenomCollabo + " " + unCollab.NomCollabo;
            leForm.MdiParent = frmMDI.getInstance();
            leForm.grdContrats.DataSource = unCollab.ListerContrats();
            leForm.grdContrats.CellDoubleClick += this.grdContrats_CellDoubleClick;
            leForm.btnDetailsContrat.Click += this.btnVoirContrat_Click;
            leForm.btnAjoutContrat.Click += this.btnAjoutContrat_Click;
            leForm.Show();
        }

        /// <summary>
        /// Méthode évenementielle d'affichage de frmContrat au double clic sur une ligne de la gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void grdContrats_CellDoubleClick(object sender, EventArgs e)
        {
            selectContrat();
        }

        /// <summary>
        /// Méthode évenementielle d'affichage de frmContrat au clic sur btnDetailsContrat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnVoirContrat_Click(Object sender, EventArgs e)
        {
            selectContrat();
        }

        /// <summary>
        /// Méthode évenementielle d'affichage du frmContrat pour l'ajout d'un nouveau contrat au clic sur btnAjoutContrat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnAjoutContrat_Click(Object sender, EventArgs e)
        {
            ctrlNouvContrat leFormNouvContrat = new ctrlNouvContrat();
            if (leFormNouvContrat.Resultat() == DialogResult.OK)
            {
                leCollab.AddContrat(leFormNouvContrat.Contrat());
                leForm.grdContrats.DataSource=leCollab.ListerContrats();
            }
        }

        /// <summary>
        /// Méthode de sélection de contrat dans la liste du collaborateur d'après le numéro récupéré dans la première cellule de la ligne de la gridview sélectionnée
        /// </summary>
        private void selectContrat()
        {
            Contrat leContrat;
            leContrat = leCollab.RetourneContrat(Convert.ToInt32(leForm.grdContrats.CurrentRow.Cells[0].Value));
            ctrlVisuContrat leFormContrat = new ctrlVisuContrat(leContrat);
        }
    }
}
