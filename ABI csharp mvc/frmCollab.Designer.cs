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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.rbtActif = new System.Windows.Forms.RadioButton();
            this.rbtInactif = new System.Windows.Forms.RadioButton();
            this.btnChoixImage = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.ofdChoixImage = new System.Windows.Forms.OpenFileDialog();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnContratInit = new System.Windows.Forms.Button();
            this.lblListeContrats = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumContrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDebContrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjoutContrat = new System.Windows.Forms.Button();
            this.btnDetailsContrat = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(272, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(272, 20);
            this.textBox3.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(151, 117);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(272, 73);
            this.textBox4.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(151, 196);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(272, 21);
            this.comboBox2.TabIndex = 13;
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
            this.btnChoixImage.Location = new System.Drawing.Point(151, 258);
            this.btnChoixImage.Name = "btnChoixImage";
            this.btnChoixImage.Size = new System.Drawing.Size(116, 23);
            this.btnChoixImage.TabIndex = 16;
            this.btnChoixImage.Text = "Choisir une image";
            this.btnChoixImage.UseVisualStyleBackColor = true;
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(151, 287);
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
            this.btnValider.Location = new System.Drawing.Point(697, 3);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 18;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(778, 3);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnContratInit
            // 
            this.btnContratInit.Location = new System.Drawing.Point(151, 463);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumContrat,
            this.DateDebContrat,
            this.Qualification});
            this.dataGridView1.Location = new System.Drawing.Point(474, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(394, 411);
            this.dataGridView1.TabIndex = 22;
            // 
            // NumContrat
            // 
            this.NumContrat.HeaderText = "Numéro de contrat";
            this.NumContrat.Name = "NumContrat";
            this.NumContrat.ReadOnly = true;
            // 
            // DateDebContrat
            // 
            this.DateDebContrat.HeaderText = "Date de début de contrat";
            this.DateDebContrat.Name = "DateDebContrat";
            this.DateDebContrat.ReadOnly = true;
            // 
            // Qualification
            // 
            this.Qualification.HeaderText = "Qualification";
            this.Qualification.Name = "Qualification";
            this.Qualification.ReadOnly = true;
            this.Qualification.Width = 150;
            // 
            // btnAjoutContrat
            // 
            this.btnAjoutContrat.Location = new System.Drawing.Point(624, 463);
            this.btnAjoutContrat.Name = "btnAjoutContrat";
            this.btnAjoutContrat.Size = new System.Drawing.Size(119, 23);
            this.btnAjoutContrat.TabIndex = 23;
            this.btnAjoutContrat.Text = "Ajouter un contrat";
            this.btnAjoutContrat.UseVisualStyleBackColor = true;
            // 
            // btnDetailsContrat
            // 
            this.btnDetailsContrat.Location = new System.Drawing.Point(749, 463);
            this.btnDetailsContrat.Name = "btnDetailsContrat";
            this.btnDetailsContrat.Size = new System.Drawing.Size(119, 23);
            this.btnDetailsContrat.TabIndex = 24;
            this.btnDetailsContrat.Text = "Voir détails contrat";
            this.btnDetailsContrat.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnAnnuler);
            this.flowLayoutPanel1.Controls.Add(this.btnValider);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 504);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(856, 33);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // frmCollab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(880, 549);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnDetailsContrat);
            this.Controls.Add(this.btnAjoutContrat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblListeContrats);
            this.Controls.Add(this.btnContratInit);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.btnChoixImage);
            this.Controls.Add(this.rbtInactif);
            this.Controls.Add(this.rbtActif);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton rbtActif;
        private System.Windows.Forms.RadioButton rbtInactif;
        private System.Windows.Forms.Button btnChoixImage;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.OpenFileDialog ofdChoixImage;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnContratInit;
        private System.Windows.Forms.Label lblListeContrats;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumContrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDebContrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualification;
        private System.Windows.Forms.Button btnAjoutContrat;
        private System.Windows.Forms.Button btnDetailsContrat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}