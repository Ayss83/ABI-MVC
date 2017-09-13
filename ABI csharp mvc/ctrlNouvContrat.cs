using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassesMetier;

namespace ABI_csharp_mvc
{
    class ctrlNouvContrat
    {
        private frmContrat leForm;
        private DialogResult resultat;
        private Contrat leContrat;

        /// <summary>
        /// Constructeur, instancie et affiche un form frmContrat vide et Ajoute les actions aux boutons Valider et Annuler
        /// </summary>
        public ctrlNouvContrat()
        {
            leForm = new frmContrat();
            leForm.btnAnnuler.Click += new EventHandler(this.btnAnnuler_Click);
            leForm.btnValider.Click += new EventHandler(this.btnValider_Click);
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
            if (leForm.VerifChamps())
            {
                if (leForm.Instancie())
                {
                    leContrat = leForm.Contrat;
                    leForm.DialogResult = DialogResult.OK;
                    resultat = leForm.DialogResult;
                }
            }
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

//Fin méthodes évenementielles

//Méthodes d'instance
        /// <summary>
        /// Méthode d'accès au résultat de la création de contrat (ok si validé, cancel si annulé)
        /// </summary>
        /// <returns>DialogResult du form de création de contrat</returns>
        public DialogResult Resultat()
        {
            return resultat;
        }

        /// <summary>
        /// Méthode d'accès à la variable leContrat
        /// </summary>
        /// <returns>Instance de Contrat</returns>
        public Contrat Contrat()
        {
            return leContrat;
        }
    }
}
