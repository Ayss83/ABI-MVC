namespace ABI_csharp_mvc
{
    partial class frmCollab
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblFonction = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblSituation = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.cbxFonction = new System.Windows.Forms.ComboBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.cbxSituation = new System.Windows.Forms.ComboBox();
            this.rbtActif = new System.Windows.Forms.RadioButton();
            this.rbtInactif = new System.Windows.Forms.RadioButton();
            this.btnChoixImage = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.ofdChoixImage = new System.Windows.Forms.OpenFileDialog();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnContratInit = new System.Windows.Forms.Button();
            this.lblListeContrats = new System.Windows.Forms.Label();
            this.grdContrats = new System.Windows.Forms.DataGridView();
            this.btnAjoutContrat = new System.Windows.Forms.Button();
            this.btnDetailsContrat = new System.Windows.Forms.Button();
            this.flpValidAnnul = new System.Windows.Forms.FlowLayoutPanel();
            this.flpImgBtnContrat = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMasquer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdContrats)).BeginInit();
            this.flpValidAnnul.SuspendLayout();
            this.flpImgBtnContrat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 41);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(12, 67);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblFonction
            // 
            this.lblFonction.AutoSize = true;
            this.lblFonction.Location = new System.Drawing.Point(12, 93);
            this.lblFonction.Name = "lblFonction";
            this.lblFonction.Size = new System.Drawing.Size(48, 13);
            this.lblFonction.TabIndex = 2;
            this.lblFonction.Text = "Fonction";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(12, 120);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 3;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblSituation
            // 
            this.lblSituation.AutoSize = true;
            this.lblSituation.Location = new System.Drawing.Point(12, 199);
            this.lblSituation.Name = "lblSituation";
            this.lblSituation.Size = new System.Drawing.Size(88, 13);
            this.lblSituation.TabIndex = 4;
            this.lblSituation.Text = "Situation familiale";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(12, 234);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(35, 13);
            this.lblStatut.TabIndex = 5;
            this.lblStatut.Text = "Statut";
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(12, 263);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(35, 13);
            this.lblPhoto.TabIndex = 6;
            this.lblPhoto.Text = "Photo";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricule.Location = new System.Drawing.Point(12, 15);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(50, 13);
            this.lblMatricule.TabIndex = 7;
            this.lblMatricule.Text = "Matricule";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Enabled = false;
            this.txtMatricule.Location = new System.Drawing.Point(151, 12);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.ReadOnly = true;
            this.txtMatricule.Size = new System.Drawing.Size(272, 20);
            this.txtMatricule.TabIndex = 8;
            this.txtMatricule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(151, 38);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(272, 20);
            this.txtNom.TabIndex = 9;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(151, 64);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(272, 20);
            this.txtPrenom.TabIndex = 10;
            // 
            // cbxFonction
            // 
            this.cbxFonction.FormattingEnabled = true;
            this.cbxFonction.Location = new System.Drawing.Point(151, 90);
            this.cbxFonction.Name = "cbxFonction";
            this.cbxFonction.Size = new System.Drawing.Size(272, 21);
            this.cbxFonction.TabIndex = 11;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(151, 117);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(272, 73);
            this.txtAdresse.TabIndex = 12;
            // 
            // cbxSituation
            // 
            this.cbxSituation.FormattingEnabled = true;
            this.cbxSituation.Location = new System.Drawing.Point(151, 196);
            this.cbxSituation.Name = "cbxSituation";
            this.cbxSituation.Size = new System.Drawing.Size(272, 21);
            this.cbxSituation.TabIndex = 13;
            // 
            // rbtActif
            // 
            this.rbtActif.AutoSize = true;
            this.rbtActif.Checked = true;
            this.rbtActif.Location = new System.Drawing.Point(151, 232);
            this.rbtActif.Name = "rbtActif";
            this.rbtActif.Size = new System.Drawing.Size(46, 17);
            this.rbtActif.TabIndex = 14;
            this.rbtActif.TabStop = true;
            this.rbtActif.Text = "Actif";
            this.rbtActif.UseVisualStyleBackColor = true;
            // 
            // rbtInactif
            // 
            this.rbtInactif.AutoSize = true;
            this.rbtInactif.Location = new System.Drawing.Point(275, 232);
            this.rbtInactif.Name = "rbtInactif";
            this.rbtInactif.Size = new System.Drawing.Size(54, 17);
            this.rbtInactif.TabIndex = 15;
            this.rbtInactif.Text = "Inactif";
            this.rbtInactif.UseVisualStyleBackColor = true;
            // 
            // btnChoixImage
            // 
            this.btnChoixImage.Location = new System.Drawing.Point(3, 3);
            this.btnChoixImage.Name = "btnChoixImage";
            this.btnChoixImage.Size = new System.Drawing.Size(116, 23);
            this.btnChoixImage.TabIndex = 16;
            this.btnChoixImage.Text = "Choisir une image";
            this.btnChoixImage.UseVisualStyleBackColor = true;
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(3, 32);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(141, 170);
            this.pbPhoto.TabIndex = 17;
            this.pbPhoto.TabStop = false;
            // 
            // ofdChoixImage
            // 
            this.ofdChoixImage.FileName = "Image";
            // 
            // btnValider
            // 
            this.btnValider.AutoSize = true;
            this.btnValider.Location = new System.Drawing.Point(263, 3);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 18;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(344, 3);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnContratInit
            // 
            this.btnContratInit.Location = new System.Drawing.Point(3, 208);
            this.btnContratInit.Name = "btnContratInit";
            this.btnContratInit.Size = new System.Drawing.Size(141, 23);
            this.btnContratInit.TabIndex = 20;
            this.btnContratInit.Text = "Création du contrat initial";
            this.btnContratInit.UseVisualStyleBackColor = true;
            // 
            // lblListeContrats
            // 
            this.lblListeContrats.AutoSize = true;
            this.lblListeContrats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeContrats.Location = new System.Drawing.Point(471, 15);
            this.lblListeContrats.Name = "lblListeContrats";
            this.lblListeContrats.Size = new System.Drawing.Size(135, 20);
            this.lblListeContrats.TabIndex = 21;
            this.lblListeContrats.Text = "Liste des contrats";
            // 
            // grdContrats
            // 
            this.grdContrats.AllowUserToAddRows = false;
            this.grdContrats.AllowUserToDeleteRows = false;
            this.grdContrats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContrats.Location = new System.Drawing.Point(474, 46);
            this.grdContrats.Name = "grdContrats";
            this.grdContrats.ReadOnly = true;
            this.grdContrats.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdContrats.Size = new System.Drawing.Size(394, 411);
            this.grdContrats.TabIndex = 22;
            // 
            // btnAjoutContrat
            // 
            this.btnAjoutContrat.Location = new System.Drawing.Point(499, 463);
            this.btnAjoutContrat.Name = "btnAjoutContrat";
            this.btnAjoutContrat.Size = new System.Drawing.Size(119, 23);
            this.btnAjoutContrat.TabIndex = 23;
            this.btnAjoutContrat.Text = "Ajouter un contrat";
            this.btnAjoutContrat.UseVisualStyleBackColor = true;
            // 
            // btnDetailsContrat
            // 
            this.btnDetailsContrat.Location = new System.Drawing.Point(624, 463);
            this.btnDetailsContrat.Name = "btnDetailsContrat";
            this.btnDetailsContrat.Size = new System.Drawing.Size(119, 23);
            this.btnDetailsContrat.TabIndex = 24;
            this.btnDetailsContrat.Text = "Voir détails contrat";
            this.btnDetailsContrat.UseVisualStyleBackColor = true;
            // 
            // flpValidAnnul
            // 
            this.flpValidAnnul.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpValidAnnul.Controls.Add(this.btnAnnuler);
            this.flpValidAnnul.Controls.Add(this.btnValider);
            this.flpValidAnnul.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpValidAnnul.Location = new System.Drawing.Point(12, 504);
            this.flpValidAnnul.Name = "flpValidAnnul";
            this.flpValidAnnul.Size = new System.Drawing.Size(422, 33);
            this.flpValidAnnul.TabIndex = 25;
            // 
            // flpImgBtnContrat
            // 
            this.flpImgBtnContrat.Controls.Add(this.btnChoixImage);
            this.flpImgBtnContrat.Controls.Add(this.pbPhoto);
            this.flpImgBtnContrat.Controls.Add(this.btnContratInit);
            this.flpImgBtnContrat.Location = new System.Drawing.Point(150, 255);
            this.flpImgBtnContrat.Name = "flpImgBtnContrat";
            this.flpImgBtnContrat.Size = new System.Drawing.Size(149, 243);
            this.flpImgBtnContrat.TabIndex = 26;
            // 
            // btnMasquer
            // 
            this.btnMasquer.Location = new System.Drawing.Point(749, 463);
            this.btnMasquer.Name = "btnMasquer";
            this.btnMasquer.Size = new System.Drawing.Size(119, 23);
            this.btnMasquer.TabIndex = 27;
            this.btnMasquer.Text = "Masquer la liste";
            this.btnMasquer.UseVisualStyleBackColor = true;
            this.btnMasquer.Click += new System.EventHandler(this.btnMasquer_Click);
            // 
            // frmCollab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(880, 549);
            this.Controls.Add(this.btnMasquer);
            this.Controls.Add(this.flpImgBtnContrat);
            this.Controls.Add(this.flpValidAnnul);
            this.Controls.Add(this.btnDetailsContrat);
            this.Controls.Add(this.btnAjoutContrat);
            this.Controls.Add(this.grdContrats);
            this.Controls.Add(this.lblListeContrats);
            this.Controls.Add(this.rbtInactif);
            this.Controls.Add(this.rbtActif);
            this.Controls.Add(this.cbxSituation);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.cbxFonction);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.lblStatut);
            this.Controls.Add(this.lblSituation);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblFonction);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCollab";
            this.Text = "Création collaborateur";
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdContrats)).EndInit();
            this.flpValidAnnul.ResumeLayout(false);
            this.flpValidAnnul.PerformLayout();
            this.flpImgBtnContrat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblFonction;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblSituation;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.ComboBox cbxFonction;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.ComboBox cbxSituation;
        private System.Windows.Forms.RadioButton rbtActif;
        private System.Windows.Forms.RadioButton rbtInactif;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.OpenFileDialog ofdChoixImage;
        private System.Windows.Forms.Label lblListeContrats;
        private System.Windows.Forms.FlowLayoutPanel flpValidAnnul;
        private System.Windows.Forms.FlowLayoutPanel flpImgBtnContrat;
        private System.Windows.Forms.Button btnMasquer;
        internal System.Windows.Forms.Button btnChoixImage;
        internal System.Windows.Forms.Button btnValider;
        internal System.Windows.Forms.Button btnAnnuler;
        internal System.Windows.Forms.Button btnContratInit;
        internal System.Windows.Forms.Button btnAjoutContrat;
        internal System.Windows.Forms.Button btnDetailsContrat;
        internal System.Windows.Forms.DataGridView grdContrats;
    }
}