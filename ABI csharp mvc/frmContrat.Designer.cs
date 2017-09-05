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
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.pnlAgence = new System.Windows.Forms.Panel();
            this.txtAgence = new System.Windows.Forms.TextBox();
            this.pnlEcole = new System.Windows.Forms.Panel();
            this.txtEcole = new System.Windows.Forms.TextBox();
            this.btnAvenants = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.chkFinNonConnue = new System.Windows.Forms.CheckBox();
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
            this.flpContrat.Size = new System.Drawing.Size(355, 417);
            this.flpContrat.TabIndex = 11;
            // 
            // pnlNumContrat
            // 
            this.pnlNumContrat.Controls.Add(this.txtNumContrat);
            this.pnlNumContrat.Controls.Add(this.lblNumContrat);
            this.pnlNumContrat.Location = new System.Drawing.Point(3, 3);
            this.pnlNumContrat.Name = "pnlNumContrat";
            this.pnlNumContrat.Size = new System.Drawing.Size(345, 26);
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
            this.pnlQualif.Controls.Add(this.txtQualif);
            this.pnlQualif.Controls.Add(this.lblQualif);
            this.pnlQualif.Location = new System.Drawing.Point(3, 35);
            this.pnlQualif.Name = "pnlQualif";
            this.pnlQualif.Size = new System.Drawing.Size(344, 27);
            this.pnlQualif.TabIndex = 1;
            // 
            // txtQualif
            // 
            this.txtQualif.Location = new System.Drawing.Point(137, 3);
            this.txtQualif.Name = "txtQualif";
            this.txtQualif.Size = new System.Drawing.Size(200, 20);
            this.txtQualif.TabIndex = 2;
            // 
            // pnlSalaire
            // 
            this.pnlSalaire.Controls.Add(this.txtSalaire);
            this.pnlSalaire.Controls.Add(this.lblSalaire);
            this.pnlSalaire.Location = new System.Drawing.Point(3, 68);
            this.pnlSalaire.Name = "pnlSalaire";
            this.pnlSalaire.Size = new System.Drawing.Size(344, 27);
            this.pnlSalaire.TabIndex = 2;
            // 
            // txtSalaire
            // 
            this.txtSalaire.Location = new System.Drawing.Point(137, 3);
            this.txtSalaire.Name = "txtSalaire";
            this.txtSalaire.Size = new System.Drawing.Size(200, 20);
            this.txtSalaire.TabIndex = 5;
            // 
            // pnlIndemnite
            // 
            this.pnlIndemnite.Controls.Add(this.txtIndemnite);
            this.pnlIndemnite.Controls.Add(this.lblIndemnite);
            this.pnlIndemnite.Location = new System.Drawing.Point(3, 101);
            this.pnlIndemnite.Name = "pnlIndemnite";
            this.pnlIndemnite.Size = new System.Drawing.Size(344, 27);
            this.pnlIndemnite.TabIndex = 3;
            // 
            // txtIndemnite
            // 
            this.txtIndemnite.Location = new System.Drawing.Point(137, 3);
            this.txtIndemnite.Name = "txtIndemnite";
            this.txtIndemnite.Size = new System.Drawing.Size(200, 20);
            this.txtIndemnite.TabIndex = 11;
            // 
            // pnlMotif
            // 
            this.pnlMotif.Controls.Add(this.txtMotif);
            this.pnlMotif.Controls.Add(this.lblMotif);
            this.pnlMotif.Location = new System.Drawing.Point(3, 134);
            this.pnlMotif.Name = "pnlMotif";
            this.pnlMotif.Size = new System.Drawing.Size(344, 27);
            this.pnlMotif.TabIndex = 4;
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(137, 3);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(200, 20);
            this.txtMotif.TabIndex = 7;
            // 
            // pnlMission
            // 
            this.pnlMission.Controls.Add(this.txtMission);
            this.pnlMission.Controls.Add(this.lblMission);
            this.pnlMission.Location = new System.Drawing.Point(3, 167);
            this.pnlMission.Name = "pnlMission";
            this.pnlMission.Size = new System.Drawing.Size(345, 27);
            this.pnlMission.TabIndex = 5;
            // 
            // txtMission
            // 
            this.txtMission.Location = new System.Drawing.Point(137, 3);
            this.txtMission.Name = "txtMission";
            this.txtMission.Size = new System.Drawing.Size(200, 20);
            this.txtMission.TabIndex = 10;
            // 
            // pnlDateDeb
            // 
            this.pnlDateDeb.Controls.Add(this.dtpDateDebut);
            this.pnlDateDeb.Controls.Add(this.lblDateDebut);
            this.pnlDateDeb.Location = new System.Drawing.Point(3, 200);
            this.pnlDateDeb.Name = "pnlDateDeb";
            this.pnlDateDeb.Size = new System.Drawing.Size(345, 27);
            this.pnlDateDeb.TabIndex = 6;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(137, 3);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDateDebut.TabIndex = 3;
            // 
            // pnlDateFinPrev
            // 
            this.pnlDateFinPrev.Controls.Add(this.dtpDateFinPrev);
            this.pnlDateFinPrev.Controls.Add(this.lblDateFinPrev);
            this.pnlDateFinPrev.Location = new System.Drawing.Point(3, 233);
            this.pnlDateFinPrev.Name = "pnlDateFinPrev";
            this.pnlDateFinPrev.Size = new System.Drawing.Size(345, 26);
            this.pnlDateFinPrev.TabIndex = 7;
            // 
            // dtpDateFinPrev
            // 
            this.dtpDateFinPrev.Location = new System.Drawing.Point(137, 3);
            this.dtpDateFinPrev.Name = "dtpDateFinPrev";
            this.dtpDateFinPrev.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFinPrev.TabIndex = 6;
            this.dtpDateFinPrev.Value = new System.DateTime(2017, 9, 5, 0, 0, 0, 0);
            // 
            // pnlDateFin
            // 
            this.pnlDateFin.Controls.Add(this.chkFinNonConnue);
            this.pnlDateFin.Controls.Add(this.dtpDateFin);
            this.pnlDateFin.Controls.Add(this.lblDateFin);
            this.pnlDateFin.Location = new System.Drawing.Point(3, 265);
            this.pnlDateFin.Name = "pnlDateFin";
            this.pnlDateFin.Size = new System.Drawing.Size(345, 54);
            this.pnlDateFin.TabIndex = 8;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(137, 26);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFin.TabIndex = 4;
            // 
            // pnlAgence
            // 
            this.pnlAgence.Controls.Add(this.txtAgence);
            this.pnlAgence.Controls.Add(this.lblAgence);
            this.pnlAgence.Location = new System.Drawing.Point(3, 325);
            this.pnlAgence.Name = "pnlAgence";
            this.pnlAgence.Size = new System.Drawing.Size(345, 26);
            this.pnlAgence.TabIndex = 9;
            // 
            // txtAgence
            // 
            this.txtAgence.Location = new System.Drawing.Point(137, 4);
            this.txtAgence.Name = "txtAgence";
            this.txtAgence.Size = new System.Drawing.Size(200, 20);
            this.txtAgence.TabIndex = 8;
            // 
            // pnlEcole
            // 
            this.pnlEcole.Controls.Add(this.txtEcole);
            this.pnlEcole.Controls.Add(this.lblEcole);
            this.pnlEcole.Location = new System.Drawing.Point(3, 357);
            this.pnlEcole.Name = "pnlEcole";
            this.pnlEcole.Size = new System.Drawing.Size(345, 26);
            this.pnlEcole.TabIndex = 10;
            // 
            // txtEcole
            // 
            this.txtEcole.Location = new System.Drawing.Point(137, 3);
            this.txtEcole.Name = "txtEcole";
            this.txtEcole.Size = new System.Drawing.Size(200, 20);
            this.txtEcole.TabIndex = 9;
            // 
            // btnAvenants
            // 
            this.btnAvenants.Location = new System.Drawing.Point(3, 389);
            this.btnAvenants.Name = "btnAvenants";
            this.btnAvenants.Size = new System.Drawing.Size(75, 23);
            this.btnAvenants.TabIndex = 17;
            this.btnAvenants.Text = "Avenants";
            this.btnAvenants.UseVisualStyleBackColor = true;
            this.btnAvenants.Click += new System.EventHandler(this.btnAvenants_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Type de contrat";
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
            this.grdAvenant.Size = new System.Drawing.Size(394, 367);
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
            this.btnAjoutAvenant.Location = new System.Drawing.Point(470, 403);
            this.btnAjoutAvenant.Name = "btnAjoutAvenant";
            this.btnAjoutAvenant.Size = new System.Drawing.Size(107, 23);
            this.btnAjoutAvenant.TabIndex = 19;
            this.btnAjoutAvenant.Text = "Ajouter un avenant";
            this.btnAjoutAvenant.UseVisualStyleBackColor = true;
            // 
            // btnDetailsAvenant
            // 
            this.btnDetailsAvenant.Location = new System.Drawing.Point(583, 403);
            this.btnDetailsAvenant.Name = "btnDetailsAvenant";
            this.btnDetailsAvenant.Size = new System.Drawing.Size(107, 23);
            this.btnDetailsAvenant.TabIndex = 20;
            this.btnDetailsAvenant.Text = "Voir détails";
            this.btnDetailsAvenant.UseVisualStyleBackColor = true;
            // 
            // btnMasquer
            // 
            this.btnMasquer.Location = new System.Drawing.Point(696, 403);
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
            this.flpValidAnnul.Location = new System.Drawing.Point(12, 453);
            this.flpValidAnnul.Name = "flpValidAnnul";
            this.flpValidAnnul.Size = new System.Drawing.Size(359, 33);
            this.flpValidAnnul.TabIndex = 24;
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
            // frmContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.flpValidAnnul);
            this.Controls.Add(this.btnMasquer);
            this.Controls.Add(this.btnDetailsAvenant);
            this.Controls.Add(this.btnAjoutAvenant);
            this.Controls.Add(this.grdAvenant);
            this.Controls.Add(this.rbtStage);
            this.Controls.Add(this.rbtInterim);
            this.Controls.Add(this.rbtCdi);
            this.Controls.Add(this.rbtCdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpContrat);
            this.Name = "frmContrat";
            this.Text = "frmContrat";
            this.flpContrat.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
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
    }
}