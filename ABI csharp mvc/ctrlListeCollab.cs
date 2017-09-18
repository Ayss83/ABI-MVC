using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using ClassesMetier;
using ABIDAO;

namespace ABI_csharp_mvc
{
    class ctrlListeCollab
    {
        private frmListeCollab leForm;
        private MListeCollab lesCollabs;

        /// <summary>
        /// Constructeur, initialise la liste de collaborateurs et le form frmListeCollab puis l'affiche, attribue les actions aux boutons
        /// </summary>
        public ctrlListeCollab()
        {
            lesCollabs = new MListeCollab();
            CollaborateurDAOEFStatic.InstancieCollaborateurs(lesCollabs);
            leForm = new frmListeCollab(lesCollabs.ListerCollab());
            leForm.grdCollab.CellDoubleClick += new DataGridViewCellEventHandler(this.grdCollabs_DoubleClick);
            leForm.btnAjouter.Click += new EventHandler(this.ajoutCollab);
            leForm.btnVisualiser.Click += new EventHandler(this.voirCollab);
            leForm.btnModifier.Click += new EventHandler(this.modifCollab);
            leForm.MdiParent = frmMDI.getInstance();
            leForm.Show();
        }

//Méthodes évenementielles
        /// <summary>
        /// Méthode évenementielle au double clic sur une case de la datagridview, instancie un controleur ctrlVisuCollab avec le collaborateur correspondant à la ligne en paramètre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdCollabs_DoubleClick(object sender, EventArgs e)
        {
            ctrlVisuCollab ctrlVisu = new ctrlVisuCollab(this.selectLigne());
        }

        /// <summary>
        /// Méthode évenementielle du bouton Ajouter, instancie un controleur ctrlNouvCollab et ajoute le collaborateur créé au dictionnaire à la fin si retour OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajoutCollab(object sender, EventArgs e)
        {
            ctrlNouvCollab nouvCollab = new ctrlNouvCollab();
            if (nouvCollab.Retour == DialogResult.OK)
            {
                Collaborateur collabEnCours;
                //Récupération du collaborateur créé dans le form et ajout dans la liste
                collabEnCours = CollaborateurDAOEFStatic.InsereCollaborateur(nouvCollab.leCollab);

                ContratDAOEFStatic.InsereContrat(nouvCollab.leContrat, collabEnCours);
                //Mise à jour de la liste de collaborateurs depuis la DB
                CollaborateurDAOEFStatic.InstancieCollaborateurs(lesCollabs);
                //Remise à jour de l'affichage
                this.leForm.grdCollab.DataSource=lesCollabs.ListerCollab();
            }
        }

        /// <summary>
        /// Méthode évenementielle du bouton voir détails, instancie un controleur ctrlVisuCollab avec le collaborateur correspondant à la ligne sélectionnée en paramètre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void voirCollab(object sender, EventArgs e)
        {
            ctrlVisuCollab visuCollab = new ctrlVisuCollab(this.selectLigne());
        }

        /// <summary>
        /// Méthode évenementielle du bouton Modifier, instancie un controleur ctrlModifCollab avec le collaborateur correspondant à la ligne sélectionnée en paramètre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifCollab(object sender, EventArgs e)
        {
            //Instancie un frmCollab via le contrôleur de modification de collaborateur (affiche en modal)
            ctrlModifCollab modifCollab = new ctrlModifCollab(this.selectLigne());
            //Met à jour la listeCollab
            CollaborateurDAOEFStatic.InstancieCollaborateurs(lesCollabs);
            //Met à jour la datasource de la datagridview
            this.leForm.grdCollab.DataSource = lesCollabs.ListerCollab();
            //Raffraîchit l'affichage
            this.leForm.Refresh();
        }
//Fin méthodes évenementielles

//Méthode d'instance
        /// <summary>
        /// Méthode retournant l'objet collaborateur correspondant à la ligne actuellement sélectionnée
        /// </summary>
        /// <returns>Collaborateur correspondant à la ligne</returns>
        private MCollaborateur selectLigne()
        {
            Int32 matricule;
            //Récupération valeur du matricule dans la première case de la rangée
            matricule = (Int32)leForm.grdCollab.CurrentRow.Cells[0].Value;
            //MCollaborateur unCollab;
            ////Recherche du collaborateur correspondant au matricule dans le dictionnaire
            //unCollab = lesCollabs.RestituerCollaborateur(matricule);
            //return unCollab;
            return CollaborateurDAOEFStatic.RetourneCollaborateur(matricule);
        }
    }
}
