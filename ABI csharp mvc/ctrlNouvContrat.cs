using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABI_csharp_mvc
{
    class ctrlNouvContrat
    {
        private frmContrat leForm;
        private DialogResult resultat;

        /// <summary>
        /// Constructeur, instancie et affiche un form frmContrat vide et Ajoute les actions aux boutons Valider et Annuler
        /// </summary>
        public ctrlNouvContrat()
        {
            leForm = new frmContrat();
            leForm.btnAnnuler.Click += new EventHandler(this.btnAnnuler_Click);
            leForm.btnValider.Click += new EventHandler(this.btnValider_Click);
            leForm.ShowDialog();
        }

        /// <summary>
        /// Méthode d'evenement du bouton Valider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnValider_Click(object sender, EventArgs e)
        {
            //Demander vérification des champs avant
            leForm.DialogResult = DialogResult.OK;
            resultat = leForm.DialogResult;
        }

        /// <summary>
        /// Méthode d'evenement du bouton Annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnAnnuler_Click(object sender, EventArgs e)
        {
            leForm.DialogResult = DialogResult.Cancel;
        }

        public DialogResult Resultat()
        {
            return resultat;
        }
    }
}
