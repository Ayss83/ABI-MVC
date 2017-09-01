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
    public partial class frmCollab : Form
    {
        /// <summary>
        /// Constructeur sans paramètre pour la création d'un nouveau collaborateur, liste de contrats masquée
        /// </summary>
        public frmCollab()
        {
            InitializeComponent();
            this.lblListeContrats.Visible = false;
            this.grdContrats.Visible = false;
            this.btnAjoutContrat.Visible = false;
            this.btnDetailsContrat.Visible = false;
            this.btnMasquer.Visible = false;
            this.flpValidAnnul.Width = 422; //NPMM : Valeur avec datagridview visible : 856
            this.pbPhoto.Visible = false;

            //bouton valider désactivé car validation impossible avant d'avoir créé un contrat
            this.btnValider.Enabled = false;
            this.btnValider.Text = "Créez un contrat avant de pouvoir valider";
        }

        /// <summary>
        /// Constructeur avec un collaborateur en paramètre pour affichage du détail
        /// </summary>
        /// <param name="unCollab"></param>
        public frmCollab(Collaborateur unCollab)
        {
            InitializeComponent();
            this.txtMatricule.Text = Convert.ToString(unCollab.Matricule);
            this.txtNom.Text = unCollab.NomCollabo;
            this.txtPrenom.Text = unCollab.PrenomCollabo;
            this.txtAdresse.Text = unCollab.Adresse;
            this.cbxFonction.Text = unCollab.FonctionCollabo;
            this.cbxSituation.SelectedText = unCollab.SituationFamiliale;
        }

        /// <summary>
        /// Action du bouton masquer, cache la liste de contrats et les boutons associés et change la position des boutons valider et annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMasquer_Click(object sender, EventArgs e)
        {
            this.lblListeContrats.Visible = false;
            this.grdContrats.Visible = false;
            this.btnAjoutContrat.Visible = false;
            this.btnDetailsContrat.Visible = false;
            this.btnMasquer.Visible = false;
            this.flpValidAnnul.Width = 422;
        }
    }
}
