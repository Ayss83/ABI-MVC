using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABI_csharp_mvc
{
    class ctrlNouvCollab
    {
        private frmCollab leForm;
        private ListeCollab laListe;
        internal DialogResult Retour;

        /// <summary>
        /// Constructeur, instancie, affecte les actions à différents boutons et affiche un form pour créer un nouveau collaborateur
        /// </summary>
        public ctrlNouvCollab()
        {
            leForm = new frmCollab();
            leForm.btnContratInit.Click += new EventHandler(this.btnContratInit_Click);
            leForm.btnValider.Click += new EventHandler(this.btnValider_Click);
            leForm.btnAnnuler.Click += new EventHandler(this.btnAnnuler_Click);
            leForm.ShowDialog();
        }

        /// <summary>
        /// Action attribuée au bouton de création du contrat initial, appelle le controleur ctrlNouvContrat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContratInit_Click(object sender, EventArgs e)
        {
            ctrlNouvContrat Contrat = new ctrlNouvContrat();
            if (Contrat.Resultat()==DialogResult.OK)
            {
                leForm.btnValider.Text = "Valider";
                leForm.btnValider.Enabled = true;
                leForm.btnValider.Width = 75;
            }
        }

        /// <summary>
        /// Action attribuée au bouton valider, définit un dialogresult OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            //Appeler les vérifications de champs et si OK, ajouter le collab à la liste et retourner OK
            if (leForm.VerifChamps())
            {
                if (leForm.Instancie())
                {
                    laListe = new ListeCollab();
                    laListe.AjouterCollaborateur(leForm.Collab);
                    leForm.DialogResult = DialogResult.OK;
                    this.Retour = DialogResult.OK;
                }
            }
        }

        /// <summary>
        /// Action attribuée au bouton annuler, définit un dialogresult cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            leForm.DialogResult = DialogResult.Cancel;
        }
    }
}
