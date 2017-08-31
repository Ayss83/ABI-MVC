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
        /// Constructeur sans paramètre pour la création d'un nouveau collaborateur
        /// </summary>
        public frmCollab()
        {
            InitializeComponent();
            //this.lblListeContrats.Visible = false;
            //this.grdContrats.Visible = false;
            //this.btnAjoutContrat.Visible = false;
            //this.btnDetailsContrat.Visible = false;
            this.flpValidAnnul.Width = 856; //NPMM : Valeur avec datagridview visible : 856
            this.pbPhoto.Visible = false;
        }

        /// <summary>
        /// Constructeur avec un collaborateur en paramètre pour affichage du détail
        /// </summary>
        /// <param name="unCollab"></param>
        public frmCollab(Collaborateur unCollab)
        {
            this.txtMatricule.Text = Convert.ToString(unCollab.Matricule);
            this.txtNom.Text = unCollab.NomCollabo;
            this.txtPrenom.Text = unCollab.PrenomCollabo;
            this.txtAdresse.Text = unCollab.Adresse;
            this.cbxFonction.SelectedText = unCollab.FonctionCollabo;
            this.cbxSituation.SelectedText = unCollab.SituationFamiliale;
        }

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
