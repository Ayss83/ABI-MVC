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
using ABIDAO;

namespace ABI_csharp_mvc
{
    public partial class frmContrat : Form
    {
        internal MContrat Contrat;

        /// <summary>
        /// Constructeur basique pour la création d'un nouveau contrat, initialise les controles en mode cdd
        /// </summary>
        public frmContrat()
        {
            InitializeComponent();
            this.masqueGridview();
            this.ModeCdd();
        }

        /// <summary>
        /// Constructeur, remplit les champs avec les informations du MContrat reçu en paramètre et initialise selon le type de contrat
        /// </summary>
        /// <param name="unContrat">instance du contrat à afficher</param>
        public frmContrat(MContrat unContrat)
        {
            if(unContrat is MCdd)
            {
                InitializeComponent();
                this.ModeCdd();
                this.masqueGridview();
                this.txtNumContrat.Text = Convert.ToString(unContrat.NumContrat);
                this.txtQualif.Text = unContrat.Qualification;
                this.txtMotif.Text = (unContrat as MCdd).Motif;
                this.dtpDateDebut.Value = unContrat.DateDebutContrat;
                this.dtpDateFinPrev.Value = (unContrat as MCdd).DateFinPrevue;
                this.txtSalaire.Text = Convert.ToString((unContrat as MCdd).SalaireBrut);
                if((unContrat as MCdd).DateFinContrat == null)
                {
                    this.chkFinNonConnue.Checked = true;
                    this.dtpDateFin.Enabled = false;
                }else
                {
                    this.chkFinNonConnue.Checked = false;
                    this.dtpDateFin.Value = (DateTime)unContrat.DateFinContrat;
                }

                AvenantDAOEFStatic.InstancieAvenants(unContrat);
                this.grdAvenant.DataSource = unContrat.ListerAvenants();
                this.grdAvenant.Refresh();
            }
            else if(unContrat is MCdi)
            {
                InitializeComponent();
                this.ModeCdi();
                this.rbtCdi.Checked = true;
                this.masqueGridview();
                this.txtNumContrat.Text = Convert.ToString(unContrat.NumContrat);
                this.txtQualif.Text = unContrat.Qualification;
                this.dtpDateDebut.Value = unContrat.DateDebutContrat;
                this.txtSalaire.Text = Convert.ToString((unContrat as MCdi).SalaireBrut);
                if ((unContrat as MCdi).DateFinContrat == null)
                {
                    this.chkFinNonConnue.Checked = true;
                    this.dtpDateFin.Enabled = false;
                }
                else
                {
                    this.chkFinNonConnue.Checked = false;
                    this.dtpDateFin.Value = (DateTime)unContrat.DateFinContrat;
                }

                AvenantDAOEFStatic.InstancieAvenants(unContrat);
                this.grdAvenant.DataSource = unContrat.ListerAvenants();
                this.grdAvenant.Refresh();
            }
            else if(unContrat is MStage)
            {
                InitializeComponent();
                this.ModeStage();
                this.rbtStage.Checked = true;
                this.masqueGridview();
                this.txtNumContrat.Text = Convert.ToString(unContrat.NumContrat);
                this.txtQualif.Text = unContrat.Qualification;
                this.txtIndemnite.Text = Convert.ToString((unContrat as MStage).Indemnite);
                this.txtMotif.Text = (unContrat as MStage).Motif;
                this.txtMission.Text = (unContrat as MStage).Mission;
                this.dtpDateDebut.Value = unContrat.DateDebutContrat;
                this.dtpDateFinPrev.Value = (unContrat as MStage).DateFinPrevue;
                if ((unContrat as MStage).DateFinContrat == null)
                {
                    this.chkFinNonConnue.Checked = true;
                    this.dtpDateFin.Enabled = false;
                }
                else
                {
                    this.chkFinNonConnue.Checked = false;
                    this.dtpDateFin.Value = (DateTime)unContrat.DateFinContrat;
                }
                this.txtEcole.Text = (unContrat as MStage).Ecole;

                AvenantDAOEFStatic.InstancieAvenants(unContrat);
                this.grdAvenant.Refresh();
                this.grdAvenant.DataSource = unContrat.ListerAvenants();
            }
            else
            {
                InitializeComponent();
                this.ModeInterim();
                this.rbtInterim.Checked = true;
                this.masqueGridview();
                this.txtNumContrat.Text = Convert.ToString(unContrat.NumContrat);
                this.txtQualif.Text = unContrat.Qualification;
                this.txtMotif.Text = (unContrat as MInterim).Motif;
                this.dtpDateDebut.Value = unContrat.DateDebutContrat;
                this.dtpDateFinPrev.Value = (unContrat as MInterim).DateFinPrevue;
                if ((unContrat as MInterim).DateFinContrat == null)
                {
                    this.chkFinNonConnue.Checked = true;
                    this.dtpDateFin.Enabled = false;
                }
                else
                {
                    this.chkFinNonConnue.Checked = false;
                    this.dtpDateFin.Value = (DateTime)unContrat.DateFinContrat;
                }
                this.txtAgence.Text = (unContrat as MInterim).AgenceInterim;

                AvenantDAOEFStatic.InstancieAvenants(unContrat);
                this.grdAvenant.Refresh();
                this.grdAvenant.DataSource = unContrat.ListerAvenants();
            }
        }

        /// <summary>
        /// Méthode qui masque la datagridview des avenants et ses boutons associés
        /// </summary>
        private void masqueGridview()
        {
            this.grdAvenant.Visible = false;
            this.btnAjoutAvenant.Visible = false;
            this.btnDetailsAvenant.Visible = false;
            this.btnMasquer.Visible = false;
        }

        /// <summary>
        /// Méthode pour sélectionner le constructeur adéquat pour instancier un contrat
        /// </summary>
        /// <returns>Booleen pour la réussite de l'instanciation</returns>
        public bool Instancie()
        {
            //numéro de contrat déclaré à 0 dans tous les constructeurs car attribué par la base de données
            if (this.rbtCdd.Checked == true)
            {
                if (this.chkFinNonConnue.Checked == true)
                {
                    Contrat = new MCdd(Convert.ToDecimal(this.txtSalaire.Text), this.dtpDateDebut.Value.Date, this.txtQualif.Text, 0, this.txtMotif.Text, this.dtpDateFinPrev.Value.Date);
                    return true;
                } else
                {
                    Contrat = new MCdd(Convert.ToDecimal(this.txtSalaire.Text), this.dtpDateDebut.Value.Date, this.txtQualif.Text, 0, this.txtMotif.Text, this.dtpDateFinPrev.Value.Date, this.dtpDateFin.Value.Date);
                    return true;
                }
            }else if (this.rbtCdi.Checked == true)
            {
                if (this.chkFinNonConnue.Checked == true)
                {
                    Contrat = new MCdi(Convert.ToDecimal(this.txtSalaire.Text), 0, this.txtQualif.Text, this.dtpDateDebut.Value.Date);
                    return true;
                }
                else
                {
                    Contrat = new MCdi(Convert.ToDecimal(this.txtSalaire.Text), 0, this.txtQualif.Text, this.dtpDateDebut.Value.Date, this.dtpDateFin.Value.Date);
                    return true;
                }
            }else if (this.rbtInterim.Checked == true)
            {
                if (this.chkFinNonConnue.Checked == true)
                {
                    Contrat = new MInterim(this.txtAgence.Text, this.txtMotif.Text, this.dtpDateFinPrev.Value.Date, 0, this.txtQualif.Text, this.dtpDateDebut.Value.Date);
                    return true;
                }else
                {
                    Contrat = new MInterim(this.txtAgence.Text, this.txtMotif.Text, this.dtpDateFinPrev.Value.Date, 0, this.txtQualif.Text, this.dtpDateDebut.Value.Date, this.dtpDateFin.Value.Date);
                    return true;
                }
            }else if (this.rbtStage.Checked == true)
            {
                if (this.chkFinNonConnue.Checked == true)
                {
                Contrat = new MStage(this.txtEcole.Text, this.txtMission.Text, Convert.ToDecimal(this.txtIndemnite.Text), this.txtMotif.Text, this.dtpDateFinPrev.Value.Date, 0, this.txtQualif.Text, this.dtpDateDebut.Value.Date);
                return true;
                }
                else
                {
                    Contrat = new MStage(this.txtEcole.Text, this.txtMission.Text, Convert.ToDecimal(this.txtIndemnite.Text), this.txtMotif.Text, this.dtpDateFinPrev.Value.Date, 0, this.txtQualif.Text, this.dtpDateDebut.Value.Date, this.dtpDateFin.Value.Date);
                    return true;
                }
            }else
            {
                return false;
            }
        }

        /// <summary>
        /// Méthode de vérification de la cohérence des champs, affiche les labels erreurs correspondants
        /// </summary>
        /// <returns>Cohérence vraie ou fausse</returns>
        public bool VerifChamps()
        {
            bool resultat = true;
            
            if(this.txtQualif.Text=="" || this.txtQualif.Text == null)
            {
                resultat = false;
                this.lblErreurQualif.Visible = true;
            }

            if (this.txtMotif.Visible == true)
            {
                if(this.txtMotif.Text=="" || this.txtMotif.Text == null)
                {
                    resultat = false;
                    this.lblErreurMotif.Visible = true;
                }
            }

            if (this.txtSalaire.Visible == true)
            {
                Decimal salaire;
                
                if(String.IsNullOrWhiteSpace(this.txtSalaire.Text))
                {
                    resultat = false;
                    this.lblErreurSalaire.Text = "Le salaire ne peut pas être négatif";
                    this.lblErreurSalaire.Visible = true;
                }
                else
                {
                    if (!Decimal.TryParse(txtSalaire.Text, out salaire) && salaire <= 0)
                    {
                        this.lblErreurSalaire.Text = "saisie salaire incorrect";
                        this.lblErreurSalaire.Visible = true;
                        resultat = false;
                    }
                }
            }

            if (this.dtpDateDebut.Value == null)
            {
                resultat = false;
                this.lblErreurDateDebut.Visible = true;
            }

            if (this.txtIndemnite.Visible == true)
            {
                Decimal indemnite;

                if (String.IsNullOrWhiteSpace(this.txtIndemnite.Text))
                {
                    resultat = false;
                    this.lblErreurIndemnite.Text = "Veuillez saisir une indemnité";
                    this.lblErreurIndemnite.Visible = true;
                }
                else
                {
                    if(!Decimal.TryParse(this.txtIndemnite.Text, out indemnite) && indemnite <=0)
                    {
                        resultat = false;
                        this.lblErreurIndemnite.Text = "L'indemnité doit être composée de chiffres et positive";
                        this.lblErreurIndemnite.Visible = true;
                    }
                }
            }

            if (this.txtAgence.Visible == true)
            {
                if(this.txtAgence.Text=="" || this.txtAgence.Text == null)
                {
                    resultat = false;
                    this.lblErreurAgence.Visible = true;
                }
            }

            if (this.txtEcole.Visible == true)
            {
                if(this.txtEcole.Text=="" || this.txtEcole.Text == null)
                {
                    resultat = false;
                    this.lblErreurEcole.Visible = true;
                }
            }

            if (this.txtMission.Visible == true)
            {
                if(this.txtMission.Text=="" || this.txtMission.Text == null)
                {
                    resultat = false;
                    this.lblErreurMission.Visible = true;
                }
            }

            if (this.chkFinNonConnue.Checked == false)
            {
                if(this.dtpDateFin.Value==null || this.dtpDateFin.Value < this.dtpDateDebut.Value) //penser a diviser les contrôles pour détailler les futurs labels erreurs
                {
                    resultat = false;
                    this.lblErreurDateFin.Visible = true;
                }
            }

            if (this.dtpDateFinPrev.Visible == true)
            {
                if (this.dtpDateFinPrev.Value == null || this.dtpDateFinPrev.Value < this.dtpDateDebut.Value)
                {
                    resultat = false;
                    this.lblErreurFinPrevue.Visible = true;
                }
            }

            return resultat;
        }

        /// <summary>
        /// Méthode qui masque tous les labels de message d'erreur
        /// </summary>
        public void EffaceErreurs()
        {
            this.lblErreurAgence.Visible = false;
            this.lblErreurDateDebut.Visible = false;
            this.lblErreurDateFin.Visible = false;
            this.lblErreurEcole.Visible = false;
            this.lblErreurFinPrevue.Visible = false;
            this.lblErreurIndemnite.Visible = false;
            this.lblErreurMission.Visible = false;
            this.lblErreurMotif.Visible = false;
            this.lblErreurQualif.Visible = false;
            this.lblErreurSalaire.Visible = false;
        }

        /// <summary>
        /// Méthode de passage des controles en readonly ou disabled pour visualisation sans possibilité de modification
        /// </summary>
        public void ModeVisu()
        {
            //Parcours des controls du form
            foreach(Control c in this.Controls)
            {
                if (c is FlowLayoutPanel)
                {
                    //parcours des controls dans le flowLayoutPanel
                    foreach(Control p in c.Controls)
                    {
                        //parcours des controls dans chaque panel
                        foreach(Control t in p.Controls)
                        {
                            if (t is TextBox)
                                (t as TextBox).ReadOnly = true;
                            if (t is DateTimePicker)
                                t.Enabled = false;
                            if (t is CheckBox)
                                t.Enabled = false;
                        }
                    }
                }
                if (c is RadioButton)
                    c.Enabled = false;
            }
        }

//Méthodes changement de type de contrat
        /// <summary>
        /// Méthode de changement d'affichage pour un contrat de type CDD
        /// </summary>
        public void ModeCdd()
        {
            this.pnlAgence.Visible = false;
            this.pnlEcole.Visible = false;
            this.pnlIndemnite.Visible = false;
            this.pnlMission.Visible = false;
            this.pnlDateFinPrev.Visible = true;
            this.pnlMotif.Visible = true;
            this.pnlSalaire.Visible = true;
            this.EffaceErreurs();
        }

        /// <summary>
        /// Méthode de changement d'affichage pour un contrat de type CDI
        /// </summary>
        public void ModeCdi()
        {
            this.pnlAgence.Visible = false;
            this.pnlEcole.Visible = false;
            this.pnlIndemnite.Visible = false;
            this.pnlMission.Visible = false;
            this.pnlDateFinPrev.Visible = false;
            this.pnlMotif.Visible = false;
            this.pnlSalaire.Visible = true;
            this.EffaceErreurs();
        }

        /// <summary>
        /// Méthode de changement d'affichage pour un contrat de type Interim
        /// </summary>
        public void ModeInterim()
        {
            this.pnlAgence.Visible = true;
            this.pnlEcole.Visible = false;
            this.pnlIndemnite.Visible = false;
            this.pnlMission.Visible = false;
            this.pnlDateFinPrev.Visible = true;
            this.pnlMotif.Visible = true;
            this.pnlSalaire.Visible = false;
            this.EffaceErreurs();
        }

        /// <summary>
        /// Méthode de changement d'affichage pour un contrat de type Stage
        /// </summary>
        public void ModeStage()
        {
            this.pnlAgence.Visible = false;
            this.pnlEcole.Visible = true;
            this.pnlIndemnite.Visible = true;
            this.pnlMission.Visible = true;
            this.pnlDateFinPrev.Visible = true;
            this.pnlMotif.Visible = true;
            this.pnlSalaire.Visible = false;
            this.EffaceErreurs();
        }
//Fin méthodes changement de type de contrat


//Méthodes évenementielles
        /// <summary>
        /// Méthode permettant de masquer la datagridview et ses boutons associés et réactive le bouton avenants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMasquer_Click(object sender, EventArgs e)
        {
            this.grdAvenant.Visible = false;
            this.btnAjoutAvenant.Visible = false;
            this.btnDetailsAvenant.Visible = false;
            this.btnMasquer.Visible = false;
            this.btnAvenants.Enabled = true;
            this.flpValidAnnul.Width = 359;
        }

        /// <summary>
        /// Méthode rendant la datagridview et ses boutons associés visibles, cela agrandit la fenêtre et désactive le bouton avenants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAvenants_Click(object sender, EventArgs e)
        {
            this.grdAvenant.Visible = true;
            this.btnAjoutAvenant.Visible = true;
            this.btnDetailsAvenant.Visible = true;
            this.btnMasquer.Visible = true;
            this.btnAvenants.Enabled = false;
            this.flpValidAnnul.Width = 796;
        }

   //Méthodes évenementielles des boutons radios de changement de type de contrat
        /// <summary>
        /// Méthode de changement des contrôles affichés si le radioButton rbtCdd est sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtCdd_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtCdd.Checked == true)
                this.ModeCdd();
        }

        /// <summary>
        /// Méthode de changement des contrôles affichés si le radioButton rbtCdi est sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtCdi_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtCdi.Checked == true)
                this.ModeCdi();
        }

        /// <summary>
        /// Méthode de changement des contrôles affichés si le radioButton rbtInterim est sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtInterim_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtInterim.Checked == true)
                this.ModeInterim();
        }

        /// <summary>
        /// Méthode de changement des contrôles affichés si le radioButton rbtStage est sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtStage_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtStage.Checked == true)
                this.ModeStage();
        }

     //Fin méthodes évenementielles des boutons radios de changement de type de contrat

     //Méthodes évenementielles d'effacement de label erreur correspondant au contrôle utilisé
        private void txtQualif_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lblErreurQualif.Visible = false;
        }

        private void txtSalaire_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lblErreurSalaire.Visible = false;
        }

        private void txtIndemnite_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lblErreurIndemnite.Visible = false;
        }

        private void txtMotif_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lblErreurMotif.Visible = false;
        }

        private void txtMission_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lblErreurMission.Visible = false;
        }

        private void dtpDateFinPrev_Enter(object sender, EventArgs e)
        {
            this.lblErreurFinPrevue.Visible = false;
        }

        private void dtpDateDebut_Enter(object sender, EventArgs e)
        {
            this.lblErreurDateDebut.Visible = false;
        }

        private void dtpDateFin_Enter(object sender, EventArgs e)
        {
            this.lblErreurDateFin.Visible = false;
        }

        private void dtpDateFin_EnabledChanged(object sender, EventArgs e)
        {
            if (this.dtpDateFin.Enabled == false)
            {
                this.lblErreurDateFin.Visible = false;
            }
        }

        private void txtAgence_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lblErreurAgence.Visible = false;
        }

        private void txtEcole_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lblErreurEcole.Visible = false;
        }

     //Fin méthodes évenementielles d'effacement de label erreur correspondant

        /// <summary>
        /// Méthode évenementielle d'activation ou désactivation du dtpFinContrat selon la coche de chkFinNonConnue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkFinNonConnue_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkFinNonConnue.Checked == true)
            {
                this.dtpDateFin.Enabled = false;
            }
            else
            {
                this.dtpDateFin.Enabled = true;
            }
        }

//Fin méthodes évenementielles
    }
}
