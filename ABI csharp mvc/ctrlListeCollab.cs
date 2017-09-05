using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ABI_csharp_mvc
{
    class ctrlListeCollab
    {
        private frmListeCollab leForm;
        private ListeCollab lesCollabs;

        public ctrlListeCollab()
        {
            lesCollabs = new ListeCollab();
            leForm = new frmListeCollab(lesCollabs.ListerCollab());
            leForm.grdCollab.CellDoubleClick += new DataGridViewCellEventHandler(this.grdCollabs_DoubleClick);
            leForm.btnAjouter.Click += new EventHandler(this.ajoutCollab);
            leForm.btnVisualiser.Click += new EventHandler(this.voirCollab);
            leForm.btnModifier.Click += new EventHandler(this.modifCollab);
            leForm.MdiParent = frmMDI.getInstance();
            leForm.Show();
        }

        private void grdCollabs_DoubleClick(object sender, EventArgs e)
        {
            Int32 matricule;
            Collaborateur unCollab;
            matricule = (Int32)leForm.grdCollab.CurrentRow.Cells[0].Value;
            unCollab = lesCollabs.RestituerCollaborateur(matricule);
            ctrlVisuCollab ctrlVisu = new ctrlVisuCollab(unCollab);
        }

        private void ajoutCollab(object sender, EventArgs e)
        {
            ctrlNouvCollab nouvCollab = new ctrlNouvCollab();
            if (nouvCollab.Retour == DialogResult.OK)
            {
                this.leForm.grdCollab.DataSource=lesCollabs.ListerCollab();
            }
        }

        private void voirCollab(object sender, EventArgs e)
        {
            ctrlVisuCollab visuCollab = new ctrlVisuCollab(this.selectLigne());
        }

        private void modifCollab(object sender, EventArgs e)
        {
            ctrlModifCollab modifCollab = new ctrlModifCollab(this.selectLigne());
        }

        /// <summary>
        /// Méthode retournant l'objet collaborateur correspondant à la ligne actuellement sélectionnée
        /// </summary>
        /// <returns>Collaborateur correspondant à la ligne</returns>
        private Collaborateur selectLigne()
        {
            Int32 matricule;
            //Récupération valeur du matricule dans la première case de la rangée
            matricule = (Int32)leForm.grdCollab.CurrentRow.Cells[0].Value;
            Collaborateur unCollab;
            //Recherche du collaborateur correspondant au matricule dans le dictionnaire
            unCollab = lesCollabs.RestituerCollaborateur(matricule);
            return unCollab;
        }
    }
}
