namespace ABI_csharp_mvc
{
    partial class frmContrat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumContrat = new System.Windows.Forms.Label();
            this.lblQualif = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblSalaire = new System.Windows.Forms.Label();
            this.lblDateFinPrev = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblAgence = new System.Windows.Forms.Label();
            this.lblEcole = new System.Windows.Forms.Label();
            this.lblMission = new System.Windows.Forms.Label();
            this.lblIndemnite = new System.Windows.Forms.Label();
            this.flpContrat = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlNumContrat = new System.Windows.Forms.Panel();
            this.txtNumContrat = new System.Windows.Forms.TextBox();
            this.pnlQualif = new System.Windows.Forms.Panel();
            this.txtQualif = new System.Windows.Forms.TextBox();
            this.pnlSalaire = new System.Windows.Forms.Panel();
            this.txtSalaire = new System.Windows.Forms.TextBox();
            this.pnlIndemnite = new System.Windows.Forms.Panel();
            this.txtIndemnite = new System.Windows.Forms.TextBox();
            this.pnlMotif = new System.Windows.Forms.Panel();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.pnlMission = new System.Windows.Forms.Panel();
            this.txtMission = new System.Windows.Forms.TextBox();
            this.pnlDateDeb = new System.Windows.Forms.Panel();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.pnlDateFinPrev = new System.Windows.Forms.Panel();
            this.dtpDateFinPrev = new System.Windows.Forms.DateTimePicker();
            this.pnlDateFin = new System.Windows.Forms.Panel();
            this.chkFinNonConnue = new System.Windows.Forms.CheckBox();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.pnlAgence = new System.Windows.Forms.Panel();
            this.txtAgence = new System.Windows.Forms.TextBox();
            this.pnlEcole = new System.Windows.Forms.Panel();
            this.txtEcole = new System.Windows.Forms.TextBox();
            this.btnAvenants = new System.Windows.Forms.Button();
            this.lblTypeContrat = new System.Windows.Forms.Label();
            this.rbtCdd = new System.Windows.Forms.RadioButton();
            this.rbtCdi = new System.Windows.Forms.RadioButton();
            this.rbtInterim = new System.Windows.Forms.RadioButton();
            this.rbtStage = new System.Windows.Forms.RadioButton();
            this.grdAvenant = new System.Windows.Forms.DataGridView();
            this.NumAvenant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAvenant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjoutAvenant = new System.Windows.Forms.Button();
            this.btnDetailsAvenant = new System.Windows.Forms.Button();
            this.btnMasquer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.flpValidAnnul = new System.Windows.Forms.FlowLayoutPanel();
            this.lblErreurQualif = new System.Windows.Forms.Label();
            this.lblErreurSalaire = new System.Windows.Forms.Label();
            this.lblErreurIndemnite = new System.Windows.Forms.Label();
            this.lblErreurMotif = new System.Windows.Forms.Label();
            this.lblErreurMission = new System.Windows.Forms.Label();
            this.lblErreurDateDebut = new System.Windows.Forms.Label();
            this.lblErreurDateFin = new System.Windows.Forms.Label();
            this.lblErreurAgence = new System.Windows.Forms.Label();
            this.lblErreurEcole = new System.Windows.Forms.Label();
            this.lblErreurFinPrevue = new System.Windows.Forms.Label();
            this.flpContrat.SuspendLayout();
            this.pnlNumContrat.SuspendLayout();
            this.pnlQualif.SuspendLayout();
            this.pnlSalaire.SuspendLayout();
            this.pnlIndemnite.SuspendLayout();
            this.pnlMotif.SuspendLayout();
            this.pnlMission.SuspendLayout();
            this.pnlDateDeb.SuspendLayout();
            this.pnlDateFinPrev.SuspendLayout();
            this.pnlDateFin.SuspendLayout();
            this.pnlAgence.SuspendLayout();
            this.pnlEcole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvenant)).BeginInit();
            this.flpValidAnnul.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumContrat
            // 
            this.lblNumContrat.AutoSize = true;
            this.lblNumContrat.Location = new System.Drawing.Point(3, 6);
            this.lblNumContrat.Name = "lblNumContrat";
            this.lblNumContrat.Size = new System.Drawing.Size(95, 13);
            this.lblNumContrat.TabIndex = 0;
            this.lblNumContrat.Text = "Numéro de contrat";
            // 
            // lblQualif
            // 
            this.lblQualif.AutoSize = true;
            this.lblQualif.Location = new System.Drawing.Point(3, 6);
            this.lblQualif.Name = "lblQualif";
            this.lblQualif.Size = new System.Drawing.Size(65, 13);
            this.lblQualif.TabIndex = 1;
            this.lblQualif.Text = "Qualification";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(3, 6);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(126, 13);
            this.lblDateDebut.TabIndex = 2;
            this.lblDateDebut.Text = "Date de début de contrat";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(3, 6);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(110, 13);
            this.lblDateFin.TabIndex = 3;
            this.lblDateFin.Text = "Date de fin de contrat";
            // 
            // lblSalaire
            // 
            this.lblSalaire.AutoSize = true;
            this.lblSalaire.Location = new System.Drawing.Point(3, 6);
            this.lblSalaire.Name = "lblSalaire";
            this.lblSalaire.Size = new System.Drawing.Size(60, 13);
            this.lblSalaire.TabIndex = 4;
            this.lblSalaire.Text = "Salaire brut";
            // 
            // lblDateFinPrev
            // 
            this.lblDateFinPrev.AutoSize = true;
            this.lblDateFinPrev.Location = new System.Drawing.Point(3, 6);
            this.lblDateFinPrev.Name = "lblDateFinPrev";
            this.lblDateFinPrev.Size = new System.Drawing.Size(95, 13);
            this.lblDateFinPrev.TabIndex = 5;
            this.lblDateFinPrev.Text = "Date de fin prévue";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(3, 6);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(30, 13);
            this.lblMotif.TabIndex = 6;
            this.lblMotif.Text = "Motif";
            // 
            // lblAgence
            // 
            this.lblAgence.AutoSize = true;
            this.lblAgence.Location = new System.Drawing.Point(3, 7);
            this.lblAgence.Name = "lblAgence";
            this.lblAgence.Size = new System.Drawing.Size(77, 13);
            this.lblAgence.TabIndex = 7;
            this.lblAgence.Text = "Agence intérim";
            // 
            // lblEcole
            // 
            this.lblEcole.AutoSize = true;
            this.lblEcole.Location = new System.Drawing.Point(3, 6);
            this.lblEcole.Name = "lblEcole";
            this.lblEcole.Size = new System.Drawing.Size(34, 13);
            this.lblEcole.TabIndex = 8;
            this.lblEcole.Text = "Ecole";
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Location = new System.Drawing.Point(3, 6);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(42, 13);
            this.lblMission.TabIndex = 9;
            this.lblMission.Text = "Mission";
            // 
            // lblIndemnite
            // 
            this.lblIndemnite.AutoSize = true;
            this.lblIndemnite.Location = new System.Drawing.Point(3, 6);
            this.lblIndemnite.Name = "lblIndemnite";
            this.lblIndemnite.Size = new System.Drawing.Size(53, 13);
            this.lblIndemnite.TabIndex = 10;
            this.lblIndemnite.Text = "Indemnité";
            // 
            // flpContrat
            // 
            this.flpContrat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpContrat.Controls.Add(this.pnlNumContrat);
            this.flpContrat.Controls.Add(this.pnlQualif);
            this.flpContrat.Controls.Add(this.pnlSalaire);
            this.flpContrat.Controls.Add(this.pnlIndemnite);
            this.flpContrat.Controls.Add(this.pnlMotif);
            this.flpContrat.Controls.Add(this.pnlMission);
            this.flpContrat.Controls.Add(this.pnlDateDeb);
            this.flpContrat.Controls.Add(this.pnlDateFinPrev);
            this.flpContrat.Controls.Add(this.pnlDateFin);
            this.flpContrat.Controls.Add(this.pnlAgence);
            this.flpContrat.Controls.Add(this.pnlEcole);
            this.flpContrat.Controls.Add(this.btnAvenants);
            this.flpContrat.Location = new System.Drawing.Point(12, 30);
            this.flpContrat.Name = "flpContrat";
            this.flpContrat.Size = new System.Drawing.Size(355, 547);
            this.flpContrat.TabIndex = 11;
            // 
            // pnlNumContrat
            // 
            this.pnlNumContrat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNumContrat.Controls.Add(this.txtNumContrat);
            this.pnlNumContrat.Controls.Add(this.lblNumContrat);
            this.pnlNumContrat.Location = new System.Drawing.Point(3, 3);
            this.pnlNumContrat.Name = "pnlNumContrat";
            this.pnlNumContrat.Size = new System.Drawing.Size(340, 28);
            this.pnlNumContrat.TabIndex = 0;
            // 
            // txtNumContrat
            // 
            this.txtNumContrat.Location = new System.Drawing.Point(137, 3);
            this.txtNumContrat.Name = "txtNumContrat";
            this.txtNumContrat.ReadOnly = true;
            this.txtNumContrat.Size = new System.Drawing.Size(200, 20);
            this.txtNumContrat.TabIndex = 1;
            // 
            // pnlQualif
            // 
            this.pnlQualif.AutoSize = true;
            this.pnlQualif.Controls.Add(this.lblErreurQualif);
            this.pnlQualif.Controls.Add(this.txtQualif);
            this.pnlQualif.Controls.Add(this.lblQualif);
            this.pnlQualif.Location = new System.Drawing.Point(3, 37);
            this.pnlQualif.Name = "pnlQualif";
            this.pnlQualif.Size = new System.Drawing.Size(340, 39);
            this.pnlQualif.TabIndex = 1;
            // 
            // txtQualif
            // 
            this.txtQualif.Location = new System.Drawing.Point(137, 3);
            this.txtQualif.Name = "txtQualif";
            this.txtQualif.Size = new System.Drawing.Size(200, 20);
            this.txtQualif.TabIndex = 2;
            this.txtQualif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQualif_KeyPress);
            // 
            // pnlSalaire
            // 
            this.pnlSalaire.AutoSize = true;
            this.pnlSalaire.Controls.Add(this.lblErreurSalaire);
            this.pnlSalaire.Controls.Add(this.txtSalaire);
            this.pnlSalaire.Controls.Add(this.lblSalaire);
            this.pnlSalaire.Location = new System.Drawing.Point(3, 82);
            this.pnlSalaire.Name = "pnlSalaire";
            this.pnlSalaire.Size = new System.Drawing.Size(340, 39);
            this.pnlSalaire.TabIndex = 2;
            // 
            // txtSalaire
            // 
            this.txtSalaire.Location = new System.Drawing.Point(137, 3);
            this.txtSalaire.Name = "txtSalaire";
            this.txtSalaire.Size = new System.Drawing.Size(200, 20);
            this.txtSalaire.TabIndex = 5;
            this.txtSalaire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalaire_KeyPress);
            // 
            // pnlIndemnite
            // 
            this.pnlIndemnite.AutoSize = true;
            this.pnlIndemnite.Controls.Add(this.lblErreurIndemnite);
            this.pnlIndemnite.Controls.Add(this.txtIndemnite);
            this.pnlIndemnite.Controls.Add(this.lblIndemnite);
            this.pnlIndemnite.Location = new System.Drawing.Point(3, 127);
            this.pnlIndemnite.Name = "pnlIndemnite";
            this.pnlIndemnite.Size = new System.Drawing.Size(340, 55);
            this.pnlIndemnite.TabIndex = 3;
            // 
            // txtIndemnite
            // 
            this.txtIndemnite.Location = new System.Drawing.Point(137, 3);
            this.txtIndemnite.Name = "txtIndemnite";
            this.txtIndemnite.Size = new System.Drawing.Size(200, 20);
            this.txtIndemnite.TabIndex = 11;
            this.txtIndemnite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIndemnite_KeyPress);
            // 
            // pnlMotif
            // 
            this.pnlMotif.AutoSize = true;
            this.pnlMotif.Controls.Add(this.lblErreurMotif);
            this.pnlMotif.Controls.Add(this.txtMotif);
            this.pnlMotif.Controls.Add(this.lblMotif);
            this.pnlMotif.Location = new System.Drawing.Point(3, 188);
            this.pnlMotif.Name = "pnlMotif";
            this.pnlMotif.Size = new System.Drawing.Size(340, 39);
            this.pnlMotif.TabIndex = 4;
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(137, 3);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(200, 20);
            this.txtMotif.TabIndex = 7;
            this.txtMotif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotif_KeyPress);
            // 
            // pnlMission
            // 
            this.pnlMission.AutoSize = true;
            this.pnlMission.Controls.Add(this.lblErreurMission);
            this.pnlMission.Controls.Add(this.txtMission);
            this.pnlMission.Controls.Add(this.lblMission);
            this.pnlMission.Location = new System.Drawing.Point(3, 233);
            this.pnlMission.Name = "pnlMission";
            this.pnlMission.Size = new System.Drawing.Size(340, 39);
            this.pnlMission.TabIndex = 5;
            // 
            // txtMission
            // 
            this.txtMission.Location = new System.Drawing.Point(137, 3);
            this.txtMission.Name = "txtMission";
            this.txtMission.Size = new System.Drawing.Size(200, 20);
            this.txtMission.TabIndex = 10;
            this.txtMission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMission_KeyPress);
            // 
            // pnlDateDeb
            // 
            this.pnlDateDeb.AutoSize = true;
            this.pnlDateDeb.Controls.Add(this.lblErreurDateDebut);
            this.pnlDateDeb.Controls.Add(this.dtpDateDebut);
            this.pnlDateDeb.Controls.Add(this.lblDateDebut);
            this.pnlDateDeb.Location = new System.Drawing.Point(3, 278);
            this.pnlDateDeb.Name = "pnlDateDeb";
            this.pnlDateDeb.Size = new System.Drawing.Size(340, 39);
            this.pnlDateDeb.TabIndex = 6;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(137, 3);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDateDebut.TabIndex = 3;
            this.dtpDateDebut.Value = new System.DateTime(2017, 9, 6, 0, 0, 0, 0);
            this.dtpDateDebut.Enter += new System.EventHandler(this.dtpDateDebut_Enter);
            // 
            // pnlDateFinPrev
            // 
            this.pnlDateFinPrev.AutoSize = true;
            this.pnlDateFinPrev.Controls.Add(this.lblErreurFinPrevue);
            this.pnlDateFinPrev.Controls.Add(this.dtpDateFinPrev);
            this.pnlDateFinPrev.Controls.Add(this.lblDateFinPrev);
            this.pnlDateFinPrev.Location = new System.Drawing.Point(3, 323);
            this.pnlDateFinPrev.Name = "pnlDateFinPrev";
            this.pnlDateFinPrev.Size = new System.Drawing.Size(340, 57);
            this.pnlDateFinPrev.TabIndex = 7;
            // 
            // dtpDateFinPrev
            // 
            this.dtpDateFinPrev.Location = new System.Drawing.Point(137, 3);
            this.dtpDateFinPrev.Name = "dtpDateFinPrev";
            this.dtpDateFinPrev.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFinPrev.TabIndex = 6;
            this.dtpDateFinPrev.Value = new System.DateTime(2017, 9, 6, 0, 0, 0, 0);
            this.dtpDateFinPrev.Enter += new System.EventHandler(this.dtpDateFinPrev_Enter);
            // 
            // pnlDateFin
            // 
            this.pnlDateFin.AutoSize = true;
            this.pnlDateFin.Controls.Add(this.lblErreurDateFin);
            this.pnlDateFin.Controls.Add(this.chkFinNonConnue);
            this.pnlDateFin.Controls.Add(this.dtpDateFin);
            this.pnlDateFin.Controls.Add(this.lblDateFin);
            this.pnlDateFin.Location = new System.Drawing.Point(3, 386);
            this.pnlDateFin.Name = "pnlDateFin";
            this.pnlDateFin.Size = new System.Drawing.Size(340, 80);
            this.pnlDateFin.TabIndex = 8;
            // 
            // chkFinNonConnue
            // 
            this.chkFinNonConnue.AutoSize = true;
            this.chkFinNonConnue.Checked = true;
            this.chkFinNonConnue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFinNonConnue.Location = new System.Drawing.Point(137, 3);
            this.chkFinNonConnue.Name = "chkFinNonConnue";
            this.chkFinNonConnue.Size = new System.Drawing.Size(85, 17);
            this.chkFinNonConnue.TabIndex = 5;
            this.chkFinNonConnue.Text = "Non connue";
            this.chkFinNonConnue.UseVisualStyleBackColor = true;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(137, 26);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFin.TabIndex = 4;
            this.dtpDateFin.EnabledChanged += new System.EventHandler(this.dtpDateFin_EnabledChanged);
            this.dtpDateFin.Enter += new System.EventHandler(this.dtpDateFin_Enter);
            // 
            // pnlAgence
            // 
            this.pnlAgence.AutoSize = true;
            this.pnlAgence.Controls.Add(this.lblErreurAgence);
            this.pnlAgence.Controls.Add(this.txtAgence);
            this.pnlAgence.Controls.Add(this.lblAgence);
            this.pnlAgence.Location = new System.Drawing.Point(3, 472);
            this.pnlAgence.Name = "pnlAgence";
            this.pnlAgence.Size = new System.Drawing.Size(340, 40);
            this.pnlAgence.TabIndex = 9;
            // 
            // txtAgence
            // 
            this.txtAgence.Location = new System.Drawing.Point(137, 4);
            this.txtAgence.Name = "txtAgence";
            this.txtAgence.Size = new System.Drawing.Size(200, 20);
            this.txtAgence.TabIndex = 8;
            this.txtAgence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgence_KeyPress);
            // 
            // pnlEcole
            // 
            this.pnlEcole.AutoSize = true;
            this.pnlEcole.Controls.Add(this.lblErreurEcole);
            this.pnlEcole.Controls.Add(this.txtEcole);
            this.pnlEcole.Controls.Add(this.lblEcole);
            this.pnlEcole.Location = new System.Drawing.Point(3, 518);
            this.pnlEcole.Name = "pnlEcole";
            this.pnlEcole.Size = new System.Drawing.Size(340, 43);
            this.pnlEcole.TabIndex = 10;
            // 
            // txtEcole
            // 
            this.txtEcole.Location = new System.Drawing.Point(137, 3);
            this.txtEcole.Name = "txtEcole";
            this.txtEcole.Size = new System.Drawing.Size(200, 20);
            this.txtEcole.TabIndex = 9;
            this.txtEcole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEcole_KeyPress);
            // 
            // btnAvenants
            // 
            this.btnAvenants.Location = new System.Drawing.Point(3, 567);
            this.btnAvenants.Name = "btnAvenants";
            this.btnAvenants.Size = new System.Drawing.Size(75, 23);
            this.btnAvenants.TabIndex = 17;
            this.btnAvenants.Text = "Avenants";
            this.btnAvenants.UseVisualStyleBackColor = true;
            this.btnAvenants.Click += new System.EventHandler(this.btnAvenants_Click);
            // 
            // lblTypeContrat
            // 
            this.lblTypeContrat.AutoSize = true;
            this.lblTypeContrat.Location = new System.Drawing.Point(9, 9);
            this.lblTypeContrat.Name = "lblTypeContrat";
            this.lblTypeContrat.Size = new System.Drawing.Size(82, 13);
            this.lblTypeContrat.TabIndex = 12;
            this.lblTypeContrat.Text = "Type de contrat";
            // 
            // rbtCdd
            // 
            this.rbtCdd.AutoSize = true;
            this.rbtCdd.Checked = true;
            this.rbtCdd.Location = new System.Drawing.Point(111, 7);
            this.rbtCdd.Name = "rbtCdd";
            this.rbtCdd.Size = new System.Drawing.Size(48, 17);
            this.rbtCdd.TabIndex = 13;
            this.rbtCdd.TabStop = true;
            this.rbtCdd.Text = "CDD";
            this.rbtCdd.UseVisualStyleBackColor = true;
            this.rbtCdd.CheckedChanged += new System.EventHandler(this.rbtCdd_CheckedChanged);
            // 
            // rbtCdi
            // 
            this.rbtCdi.AutoSize = true;
            this.rbtCdi.Location = new System.Drawing.Point(165, 7);
            this.rbtCdi.Name = "rbtCdi";
            this.rbtCdi.Size = new System.Drawing.Size(43, 17);
            this.rbtCdi.TabIndex = 14;
            this.rbtCdi.Text = "CDI";
            this.rbtCdi.UseVisualStyleBackColor = true;
            this.rbtCdi.CheckedChanged += new System.EventHandler(this.rbtCdi_CheckedChanged);
            // 
            // rbtInterim
            // 
            this.rbtInterim.AutoSize = true;
            this.rbtInterim.Location = new System.Drawing.Point(214, 7);
            this.rbtInterim.Name = "rbtInterim";
            this.rbtInterim.Size = new System.Drawing.Size(56, 17);
            this.rbtInterim.TabIndex = 15;
            this.rbtInterim.Text = "Interim";
            this.rbtInterim.UseVisualStyleBackColor = true;
            this.rbtInterim.CheckedChanged += new System.EventHandler(this.rbtInterim_CheckedChanged);
            // 
            // rbtStage
            // 
            this.rbtStage.AutoSize = true;
            this.rbtStage.Location = new System.Drawing.Point(276, 7);
            this.rbtStage.Name = "rbtStage";
            this.rbtStage.Size = new System.Drawing.Size(53, 17);
            this.rbtStage.TabIndex = 16;
            this.rbtStage.Text = "Stage";
            this.rbtStage.UseVisualStyleBackColor = true;
            this.rbtStage.CheckedChanged += new System.EventHandler(this.rbtStage_CheckedChanged);
            // 
            // grdAvenant
            // 
            this.grdAvenant.AllowUserToAddRows = false;
            this.grdAvenant.AllowUserToDeleteRows = false;
            this.grdAvenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAvenant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumAvenant,
            this.dateAvenant});
            this.grdAvenant.Location = new System.Drawing.Point(409, 30);
            this.grdAvenant.Name = "grdAvenant";
            this.grdAvenant.ReadOnly = true;
            this.grdAvenant.Size = new System.Drawing.Size(394, 413);
            this.grdAvenant.TabIndex = 18;
            // 
            // NumAvenant
            // 
            this.NumAvenant.HeaderText = "Numéro de l\'avenant";
            this.NumAvenant.Name = "NumAvenant";
            this.NumAvenant.ReadOnly = true;
            this.NumAvenant.Width = 150;
            // 
            // dateAvenant
            // 
            this.dateAvenant.HeaderText = "Date d\'établissement de l\'avenant";
            this.dateAvenant.Name = "dateAvenant";
            this.dateAvenant.ReadOnly = true;
            this.dateAvenant.Width = 200;
            // 
            // btnAjoutAvenant
            // 
            this.btnAjoutAvenant.Location = new System.Drawing.Point(470, 449);
            this.btnAjoutAvenant.Name = "btnAjoutAvenant";
            this.btnAjoutAvenant.Size = new System.Drawing.Size(107, 23);
            this.btnAjoutAvenant.TabIndex = 19;
            this.btnAjoutAvenant.Text = "Ajouter un avenant";
            this.btnAjoutAvenant.UseVisualStyleBackColor = true;
            // 
            // btnDetailsAvenant
            // 
            this.btnDetailsAvenant.Location = new System.Drawing.Point(583, 449);
            this.btnDetailsAvenant.Name = "btnDetailsAvenant";
            this.btnDetailsAvenant.Size = new System.Drawing.Size(107, 23);
            this.btnDetailsAvenant.TabIndex = 20;
            this.btnDetailsAvenant.Text = "Voir détails";
            this.btnDetailsAvenant.UseVisualStyleBackColor = true;
            // 
            // btnMasquer
            // 
            this.btnMasquer.Location = new System.Drawing.Point(696, 449);
            this.btnMasquer.Name = "btnMasquer";
            this.btnMasquer.Size = new System.Drawing.Size(107, 23);
            this.btnMasquer.TabIndex = 21;
            this.btnMasquer.Text = "Masquer la liste";
            this.btnMasquer.UseVisualStyleBackColor = true;
            this.btnMasquer.Click += new System.EventHandler(this.btnMasquer_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(200, 3);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 22;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(281, 3);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 23;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // flpValidAnnul
            // 
            this.flpValidAnnul.Controls.Add(this.btnAnnuler);
            this.flpValidAnnul.Controls.Add(this.btnValider);
            this.flpValidAnnul.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpValidAnnul.Location = new System.Drawing.Point(12, 583);
            this.flpValidAnnul.Name = "flpValidAnnul";
            this.flpValidAnnul.Size = new System.Drawing.Size(359, 33);
            this.flpValidAnnul.TabIndex = 24;
            // 
            // lblErreurQualif
            // 
            this.lblErreurQualif.AutoSize = true;
            this.lblErreurQualif.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErreurQualif.Location = new System.Drawing.Point(134, 26);
            this.lblErreurQualif.Name = "lblErreurQualif";
            this.lblErreurQualif.Size = new System.Drawing.Size(149, 13);
            this.lblErreurQualif.TabIndex = 3;
            this.lblErreurQualif.Text = "Veuillez saisir une qualification";
            this.lblErreurQualif.Visible = false;
            // 
            // lblErreurSalaire
            // 
            this.lblErreurSalaire.AutoSize = true;
            this.lblErreurSalaire.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErreurSalaire.Location = new System.Drawing.Point(134, 26);
            this.lblErreurSalaire.Name = "lblErreurSalaire";
            this.lblErreurSalaire.Size = new System.Drawing.Size(117, 13);
            this.lblErreurSalaire.TabIndex = 6;
            this.lblErreurSalaire.Text = "Veuillez saisir un salaire";
            this.lblErreurSalaire.Visible = false;
            // 
            // lblErreurIndemnite
            // 
            this.lblErreurIndemnite.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErreurIndemnite.Location = new System.Drawing.Point(134, 26);
            this.lblErreurIndemnite.Name = "lblErreurIndemnite";
            this.lblErreurIndemnite.Size = new System.Drawing.Size(203, 29);
            this.lblErreurIndemnite.TabIndex = 12;
            this.lblErreurIndemnite.Text = "Veuillez saisir une indemnité";
            this.lblErreurIndemnite.Visible = false;
            // 
            // lblErreurMotif
            // 
            this.lblErreurMotif.AutoSize = true;
            this.lblErreurMotif.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErreurMotif.Location = new System.Drawing.Point(134, 26);
            this.lblErreurMotif.Name = "lblErreurMotif";
            this.lblErreurMotif.Size = new System.Drawing.Size(109, 13);
            this.lblErreurMotif.TabIndex = 8;
            this.lblErreurMotif.Text = "Veuillez saisir un motif";
            this.lblErreurMotif.Visible = false;
            // 
            // lblErreurMission
            // 
            this.lblErreurMission.AutoSize = true;
            this.lblErreurMission.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErreurMission.Location = new System.Drawing.Point(134, 26);
            this.lblErreurMission.Name = "lblErreurMission";
            this.lblErreurMission.Size = new System.Drawing.Size(127, 13);
            this.lblErreurMission.TabIndex = 11;
            this.lblErreurMission.Text = "Veuillez saisir une mission";
            this.lblErreurMission.Visible = false;
            // 
            // lblErreurDateDebut
            // 
            this.lblErreurDateDebut.AutoSize = true;
            this.lblErreurDateDebut.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErreurDateDebut.Location = new System.Drawing.Point(134, 26);
            this.lblErreurDateDebut.Name = "lblErreurDateDebut";
            this.lblErreurDateDebut.Size = new System.Drawing.Size(145, 13);
            this.lblErreurDateDebut.TabIndex = 4;
            this.lblErreurDateDebut.Text = "Veuillez saisir une date valide";
            this.lblErreurDateDebut.Visible = false;
            // 
            // lblErreurDateFin
            // 
            this.lblErreurDateFin.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErreurDateFin.Location = new System.Drawing.Point(134, 49);
            this.lblErreurDateFin.Name = "lblErreurDateFin";
            this.lblErreurDateFin.Size = new System.Drawing.Size(203, 31);
            this.lblErreurDateFin.TabIndex = 6;
            this.lblErreurDateFin.Text = "La date de fin ne peut être antérieure à la date de début";
            this.lblErreurDateFin.Visible = false;
            // 
            // lblErreurAgence
            // 
            this.lblErreurAgence.AutoSize = true;
            this.lblErreurAgence.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErreurAgence.Location = new System.Drawing.Point(134, 27);
            this.lblErreurAgence.Name = "lblErreurAgence";
            this.lblErreurAgence.Size = new System.Drawing.Size(161, 13);
            this.lblErreurAgence.TabIndex = 9;
            this.lblErreurAgence.Text = "Veuillez saisir le nom de l\'agence";
            this.lblErreurAgence.Visible = false;
            // 
            // lblErreurEcole
            // 
            this.lblErreurEcole.AutoSize = true;
            this.lblErreurEcole.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErreurEcole.Location = new System.Drawing.Point(137, 30);
            this.lblErreurEcole.Name = "lblErreurEcole";
            this.lblErreurEcole.Size = new System.Drawing.Size(151, 13);
            this.lblErreurEcole.TabIndex = 10;
            this.lblErreurEcole.Text = "Veuillez saisir le nom de l\'école";
            this.lblErreurEcole.Visible = false;
            // 
            // lblErreurFinPrevue
            // 
            this.lblErreurFinPrevue.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErreurFinPrevue.Location = new System.Drawing.Point(137, 30);
            this.lblErreurFinPrevue.Name = "lblErreurFinPrevue";
            this.lblErreurFinPrevue.Size = new System.Drawing.Size(200, 27);
            this.lblErreurFinPrevue.TabIndex = 7;
            this.lblErreurFinPrevue.Text = "La date de fin prévue ne peut être antérieur à la date de début";
            this.lblErreurFinPrevue.Visible = false;
            // 
            // frmContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(816, 624);
            this.Controls.Add(this.flpValidAnnul);
            this.Controls.Add(this.btnMasquer);
            this.Controls.Add(this.btnDetailsAvenant);
            this.Controls.Add(this.btnAjoutAvenant);
            this.Controls.Add(this.grdAvenant);
            this.Controls.Add(this.rbtStage);
            this.Controls.Add(this.rbtInterim);
            this.Controls.Add(this.rbtCdi);
            this.Controls.Add(this.rbtCdd);
            this.Controls.Add(this.lblTypeContrat);
            this.Controls.Add(this.flpContrat);
            this.Name = "frmContrat";
            this.Text = "frmContrat";
            this.flpContrat.ResumeLayout(false);
            this.flpContrat.PerformLayout();
            this.pnlNumContrat.ResumeLayout(false);
            this.pnlNumContrat.PerformLayout();
            this.pnlQualif.ResumeLayout(false);
            this.pnlQualif.PerformLayout();
            this.pnlSalaire.ResumeLayout(false);
            this.pnlSalaire.PerformLayout();
            this.pnlIndemnite.ResumeLayout(false);
            this.pnlIndemnite.PerformLayout();
            this.pnlMotif.ResumeLayout(false);
            this.pnlMotif.PerformLayout();
            this.pnlMission.ResumeLayout(false);
            this.pnlMission.PerformLayout();
            this.pnlDateDeb.ResumeLayout(false);
            this.pnlDateDeb.PerformLayout();
            this.pnlDateFinPrev.ResumeLayout(false);
            this.pnlDateFinPrev.PerformLayout();
            this.pnlDateFin.ResumeLayout(false);
            this.pnlDateFin.PerformLayout();
            this.pnlAgence.ResumeLayout(false);
            this.pnlAgence.PerformLayout();
            this.pnlEcole.ResumeLayout(false);
            this.pnlEcole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvenant)).EndInit();
            this.flpValidAnnul.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumContrat;
        private System.Windows.Forms.Label lblQualif;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblSalaire;
        private System.Windows.Forms.Label lblDateFinPrev;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblAgence;
        private System.Windows.Forms.Label lblEcole;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.Label lblIndemnite;
        private System.Windows.Forms.FlowLayoutPanel flpContrat;
        private System.Windows.Forms.Panel pnlNumContrat;
        private System.Windows.Forms.TextBox txtNumContrat;
        private System.Windows.Forms.Panel pnlQualif;
        private System.Windows.Forms.TextBox txtQualif;
        private System.Windows.Forms.Panel pnlSalaire;
        private System.Windows.Forms.TextBox txtSalaire;
        private System.Windows.Forms.Panel pnlIndemnite;
        private System.Windows.Forms.TextBox txtIndemnite;
        private System.Windows.Forms.Panel pnlMotif;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Panel pnlMission;
        private System.Windows.Forms.TextBox txtMission;
        private System.Windows.Forms.Panel pnlDateDeb;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Panel pnlDateFinPrev;
        private System.Windows.Forms.DateTimePicker dtpDateFinPrev;
        private System.Windows.Forms.Panel pnlDateFin;
        private System.Windows.Forms.Panel pnlAgence;
        private System.Windows.Forms.TextBox txtAgence;
        private System.Windows.Forms.Panel pnlEcole;
        private System.Windows.Forms.TextBox txtEcole;
        private System.Windows.Forms.Button btnAvenants;
        private System.Windows.Forms.Label lblTypeContrat;
        private System.Windows.Forms.RadioButton rbtCdd;
        private System.Windows.Forms.RadioButton rbtCdi;
        private System.Windows.Forms.RadioButton rbtInterim;
        private System.Windows.Forms.RadioButton rbtStage;
        private System.Windows.Forms.DataGridView grdAvenant;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumAvenant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAvenant;
        private System.Windows.Forms.Button btnAjoutAvenant;
        private System.Windows.Forms.Button btnDetailsAvenant;
        private System.Windows.Forms.Button btnMasquer;
        private System.Windows.Forms.FlowLayoutPanel flpValidAnnul;
        internal System.Windows.Forms.Button btnValider;
        internal System.Windows.Forms.Button btnAnnuler;
        internal System.Windows.Forms.CheckBox chkFinNonConnue;
        internal System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label lblErreurQualif;
        private System.Windows.Forms.Label lblErreurSalaire;
        private System.Windows.Forms.Label lblErreurIndemnite;
        private System.Windows.Forms.Label lblErreurMotif;
        private System.Windows.Forms.Label lblErreurMission;
        private System.Windows.Forms.Label lblErreurDateDebut;
        private System.Windows.Forms.Label lblErreurDateFin;
        private System.Windows.Forms.Label lblErreurAgence;
        private System.Windows.Forms.Label lblErreurEcole;
        private System.Windows.Forms.Label lblErreurFinPrevue;
    }
}