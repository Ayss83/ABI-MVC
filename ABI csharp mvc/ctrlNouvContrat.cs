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
            leForm.chkFinNonConnue.CheckedChanged += new EventHandler(this.chkFinNonConnue_CheckedChanged);
            leForm.dtpDateFin.Enabled = false;
            leForm.ShowDialog();
        }

//Méthodes évenementielles
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

        /// <summary>
        /// Méthode évenementielle de la checkbox chkFinNonConnue, active ou désactive la sélection de date de fin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void chkFinNonConnue_CheckedChanged(object sender, EventArgs e)
        {
            if (leForm.chkFinNonConnue.Checked == true)
            {
                leForm.dtpDateFin.Enabled = false;
            }else
            {
                leForm.dtpDateFin.Enabled = true;
            }
        }
//Fin méthodes évenementielles

//Méthode d'instance
        /// <summary>
        /// Méthode d'accès au résultat de la création de contrat (ok si validé, cancel si annulé)
        /// </summary>
        /// <returns>DialogResult du form de création de contrat</returns>
        public DialogResult Resultat()
        {
            return resultat;
        }
    }
}
