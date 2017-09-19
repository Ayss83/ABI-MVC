using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassesMetier;
using ABIDAO;

namespace ABI_csharp_mvc
{
    class ctrlVisuCollab
    {
        private frmCollab leForm;
        private MCollaborateur leCollab;

        /// <summary>
        /// Constructeur, instancie et configure un frmCollab de visualisation, le remplit avec les informations du collaborateur reçu en paramètre
        /// </summary>
        /// <param name="unCollab">une instance de Collaborateur</param>
        public ctrlVisuCollab(MCollaborateur unCollab)
        {
            leCollab = unCollab;
            leForm = new frmCollab(unCollab);
            leForm.Text = unCollab.PrenomCollabo + " " + unCollab.NomCollabo;
            leForm.MdiParent = frmMDI.getInstance();
            CollaborateurDAOEFStatic.InstancieContrats(leCollab);
            leForm.grdContrats.DataSource = unCollab.ListerContrats();
            leForm.grdContrats.CellDoubleClick += this.grdContrats_CellDoubleClick;
            leForm.btnDetailsContrat.Click += this.btnVoirContrat_Click;
            leForm.btnAjoutContrat.Click += this.btnAjoutContrat_Click;
            leForm.btnAnnuler.Click += this.btnOK_Click;
            leForm.btnCloture.Click += this.btnCloturer_Click;
            
            //Désactivation des contrôles pour visualiser uniquement
            foreach (Control c in leForm.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = c as TextBox;
                    t.ReadOnly = true;
                }
                if (c is ComboBox)
                {
                    ComboBox cbx = c as ComboBox;
                    cbx.Enabled = false;
                }
                if (c is RadioButton)
                {
                    RadioButton rbt = c as RadioButton;
                    rbt.Enabled = false;
                }
            }

            //Masquage du label photo si pas de photo associée au collaborateur
            if (leCollab.Photo == null || leCollab.Photo.Length < 7) 
            {
                leForm.lblPhoto.Visible = false;
            }

            leForm.btnChoixImage.Visible = false;
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
                ContratDAOEFStatic.InsereContrat(leFormNouvContrat.Contrat(), DonneesDAO.DbContextAbiDao.CollaborateurSet.Find(leCollab.Matricule));
                leForm.grdContrats.DataSource=leCollab.ListerContrats();
            }
        }

        /// <summary>
        /// Méthode évenementielle de fermeture du frmCollab au clic sur le btnAnnuler (marqué "OK")
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnOK_Click(Object sender, EventArgs e)
        {
            this.leForm.Close();
            this.leForm = null;
        }

        /// <summary>
        /// Méthode de sélection de contrat dans la liste du collaborateur d'après le numéro récupéré dans la première cellule de la ligne de la gridview sélectionnée
        /// </summary>
        private void selectContrat()
        {
            MContrat leContrat;
            leContrat = leCollab.RetourneContrat(Convert.ToInt32(leForm.grdContrats.CurrentRow.Cells[0].Value));

            ctrlVisuContrat leFormContrat = new ctrlVisuContrat(leContrat);
        }

        public void btnCloturer_Click(object sender, EventArgs e)
        {
            Contrat contratACloturer;
            contratACloturer = DonneesDAO.DbContextAbiDao.ContratSet.Find(Convert.ToInt32(leForm.grdContrats.CurrentRow.Cells[0].Value));
            if (contratACloturer.Cloture == true)
            {
                MessageBox.Show("Ce contrat est déjà cloturé en date du " + contratACloturer.getDateFin(), "Erreur", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Voulez vous vraiment clôturer ce contrat?", "Confirmation de clôture", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    contratACloturer.Cloture = true;
                    contratACloturer.setDateFin(DateTime.Now);
                    Collaborateur collabAModifier = DonneesDAO.DbContextAbiDao.CollaborateurSet.Find(leCollab.Matricule);
                    collabAModifier.ContratActif = null;
                    DonneesDAO.DbContextAbiDao.SaveChanges();
                }
            }
        }
    }
}
