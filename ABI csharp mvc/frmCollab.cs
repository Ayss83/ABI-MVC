using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassesMetier;

namespace ABI_csharp_mvc
{
    public partial class frmCollab : Form
    {

        private List<String> fonctions = new List<string>();
        private List<String> situations = new List<string>();
        internal MCollaborateur Collab;

        

        /// <summary>
        /// Constructeur sans paramètre pour la création d'un nouveau collaborateur, liste de contrats masquée
        /// </summary>
        public frmCollab()
        {
            InitializeComponent();
            //Masquage des éléments de la zone d'affichage des contrats
            this.lblListeContrats.Visible = false;
            this.grdContrats.Visible = false;
            this.btnAjoutContrat.Visible = false;
            this.btnDetailsContrat.Visible = false;
            this.btnMasquer.Visible = false;

            this.alimenteBox();
            this.flpValidAnnul.Width = 422; //NPMM : Valeur avec datagridview visible : 856
            this.pbPhoto.Visible = false;

            //bouton valider désactivé car validation impossible avant d'avoir créé un contrat
            this.btnValider.Enabled = false;
            this.btnValider.Text = "Créez un contrat avant de pouvoir valider";
        }

        /// <summary>
        /// Constructeur avec un collaborateur en paramètre pour affichage du détail
        /// </summary>
        /// <param name="unCollab">Une instance de collaborateur</param>
        public frmCollab(MCollaborateur unCollab)
        {
            InitializeComponent();

            //Affichage des contenus
            this.txtMatricule.Text = Convert.ToString(unCollab.Matricule);
            this.txtNom.Text = unCollab.NomCollabo;
            this.txtPrenom.Text = unCollab.PrenomCollabo;
            this.txtAdresse.Text = unCollab.Adresse;

            if (unCollab.Photo.Length < 7) // Condition temporaire, à modifier plus tard si besoin
            {
                this.pbPhoto.Visible = false;
            }

            this.alimenteBox();
            this.cbxFonction.Text = unCollab.FonctionCollabo;
            this.cbxSituation.Text = unCollab.SituationFamiliale;

            //Gestion d'affichage d'éléments d'interface graphique
           
            this.btnContratInit.Text = "Voir la liste de contrats";
            this.btnValider.Visible = false;
            this.btnAnnuler.Text = "OK";
            this.lblListeContrats.Visible = false;
            this.grdContrats.Visible = false;
            this.btnAjoutContrat.Visible = false;
            this.btnDetailsContrat.Visible = false;
            this.btnMasquer.Visible = false;
            this.flpValidAnnul.Width = 422;
            this.btnContratInit.Click += new EventHandler(this.btnContratInit_Click);
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

        /// <summary>
        /// Action attribuée au bouton btnContratInit quand le constructeur destiné à la visualisation/modification est appelé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContratInit_Click(object sender, EventArgs e)
        {
            this.lblListeContrats.Visible = true;
            this.grdContrats.Visible = true;
            this.btnAjoutContrat.Visible = true;
            this.btnDetailsContrat.Visible = true;
            this.btnMasquer.Visible = true;
            this.flpValidAnnul.Width = 856;
        }

        /// <summary>
        /// Méthode de vérification de cohérence des champs saisis
        /// </summary>
        /// <returns>Booleen pour validation réussie ou pas</returns>
        public bool VerifChamps()
        {
            bool resultat = true;
            //Pas de vérification du matricule, celui-ci étant rempli automatiquement et incrémenté par la BDD
            if(this.txtNom.Text=="" || this.txtNom.Text == null)
            {
                resultat = false;
            }
            if(this.txtPrenom.Text=="" || this.txtPrenom.Text == null)
            {
                resultat = false;
            }

            if (this.cbxFonction.SelectedItem == null || (String)this.cbxFonction.SelectedItem == "")
            {
                resultat = false;
            }
            //Pas de vérification pour le reste, car champs non-obligatoires pour certains constructeurs et bouton radio automatiquement coché
            return resultat;
        }

        public bool Instancie()
        {
            try
            {
                if (this.rbtActif.Checked == true)
                {
                    Collab = new MCollaborateur(this.txtNom.Text, this.txtPrenom.Text, (string)this.cbxFonction.SelectedItem, this.txtAdresse.Text, this.ofdChoixImage.FileName, (string)this.cbxSituation.SelectedItem, this.rbtActif.Text);
                    return true;
                }else
                {
                    Collab = new MCollaborateur(this.txtNom.Text, this.txtPrenom.Text, (string)this.cbxFonction.SelectedItem, this.txtAdresse.Text, this.ofdChoixImage.FileName, (string)this.cbxSituation.SelectedItem, this.rbtInactif.Text);
                    return true;
                }
            }catch(Exception ex)
            {
                try
                {
                    if (this.rbtActif.Checked == true)
                    {
                        Collab = new MCollaborateur(this.txtNom.Text, this.txtPrenom.Text, this.txtAdresse.Text, (string)this.cbxFonction.SelectedItem, this.rbtActif.Text);
                        return true;
                    }else
                    {
                        Collab = new MCollaborateur(this.txtNom.Text, this.txtPrenom.Text, this.txtAdresse.Text, (string)this.cbxFonction.SelectedItem, this.rbtInactif.Text);
                        return true;
                    }
                }catch(Exception exc)
                {
                    try
                    {
                        if (this.rbtActif.Checked == true)
                        {
                            Collab = new MCollaborateur(this.txtNom.Text, this.txtPrenom.Text, (string)this.cbxFonction.Text, this.rbtActif.Text);
                            return true;
                        }else
                        {
                            Collab = new MCollaborateur(this.txtNom.Text, this.txtPrenom.Text, (string)this.cbxFonction.Text, this.rbtInactif.Text);
                            return true;
                        }
                    }catch(Exception exce)
                    {
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// Remplit les listes des combobox en dur (en attendant la BDD)
        /// </summary>
        private void alimenteBox()
        {
            fonctions.Add("PDG");
            fonctions.Add("Technicien");
            fonctions.Add("Chef de projet");
            cbxFonction.DataSource = fonctions;

            situations.Add("Célibataire");
            situations.Add("Marié");
            situations.Add("Divorcé");
            situations.Add("Concubinage");
            cbxSituation.DataSource = situations;
        }
    }
}
