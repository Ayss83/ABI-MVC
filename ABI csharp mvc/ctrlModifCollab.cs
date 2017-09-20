using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesMetier;
using ABIDAO;
using System.Windows.Forms;

namespace ABI_csharp_mvc
{
    class ctrlModifCollab
    {
        private frmCollab leForm;
        private MCollaborateur leCollab;

        public ctrlModifCollab(MCollaborateur unCollab)
        {
            leForm = new frmCollab(unCollab);
            leCollab = unCollab;
            leForm.Text = unCollab.PrenomCollabo + " " + unCollab.NomCollabo;
            leForm.btnValider.Visible = true;
            leForm.btnAnnuler.Text = "Annuler";
            leForm.btnValider.Click += this.btnOK_Click;
            leForm.btnAnnuler.Click += this.btnAnnuler_Click;
            CollaborateurDAOEFStatic.InstancieContrats(unCollab);
            leForm.grdContrats.DataSource = unCollab.ListerContrats();
            leForm.grdContrats.CellDoubleClick += this.grdContrats_CellDoubleClick;
            leForm.btnDetailsContrat.Click += this.btnVoirContrat_Click;
            leForm.btnAjoutContrat.Click += this.btnAjoutContrat_Click;
            
            //leForm.MdiParent = frmMDI.getInstance();
            if (leForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (leForm.VerifChamps())
                {
                    if (leForm.Instancie())
                    {

                        CollaborateurDAOEFStatic.ModifieCollaborateur(leForm.getCollab());
                        
                    }
                }
            }
        }

        public void btnOK_Click(object sender, EventArgs e)
        {
            this.leForm.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.leForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
                ContratDAOEFStatic.InsereContrat(leFormNouvContrat.Contrat(), DonneesDAO.DbContextAbiDao.CollaborateurSet.Find(leCollab.Matricule));
                leForm.grdContrats.DataSource = leCollab.ListerContrats();
            }
        }

        /// <summary>
        /// Méthode de sélection de contrat dans la liste du collaborateur d'après le numéro récupéré dans la première cellule de la ligne de la gridview sélectionnée
        /// </summary>
        private void selectContrat()
        {
            MContrat leContrat;
            leContrat = leCollab.RetourneContrat(Convert.ToInt32(leForm.grdContrats.CurrentRow.Cells[0].Value));

            ctrlVisuContrat leFormContrat = new ctrlVisuContrat(leContrat, true);
        }
    }
}
