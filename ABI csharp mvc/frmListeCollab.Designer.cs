namespace ABI_csharp_mvc
{
    partial class frmListeCollab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdCollab = new System.Windows.Forms.DataGridView();
            this.Matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fonction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnVisualiser = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCollab)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCollab
            // 
            this.grdCollab.AllowUserToAddRows = false;
            this.grdCollab.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCollab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdCollab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCollab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricule,
            this.Nom,
            this.Prenom,
            this.Fonction,
            this.Statut});
            this.grdCollab.Location = new System.Drawing.Point(12, 12);
            this.grdCollab.Name = "grdCollab";
            this.grdCollab.ReadOnly = true;
            this.grdCollab.RowHeadersWidth = 50;
            this.grdCollab.Size = new System.Drawing.Size(707, 488);
            this.grdCollab.TabIndex = 0;
            // 
            // Matricule
            // 
            this.Matricule.HeaderText = "Matricule";
            this.Matricule.Name = "Matricule";
            this.Matricule.ReadOnly = true;
            this.Matricule.Width = 110;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 145;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            this.Prenom.Width = 145;
            // 
            // Fonction
            // 
            this.Fonction.HeaderText = "Fonction";
            this.Fonction.Name = "Fonction";
            this.Fonction.ReadOnly = true;
            this.Fonction.Width = 145;
            // 
            // Statut
            // 
            this.Statut.HeaderText = "Statut";
            this.Statut.Name = "Statut";
            this.Statut.ReadOnly = true;
            this.Statut.Width = 110;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(401, 506);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnVisualiser
            // 
            this.btnVisualiser.Location = new System.Drawing.Point(482, 506);
            this.btnVisualiser.Name = "btnVisualiser";
            this.btnVisualiser.Size = new System.Drawing.Size(75, 23);
            this.btnVisualiser.TabIndex = 2;
            this.btnVisualiser.Text = "Voir détails";
            this.btnVisualiser.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(563, 506);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(644, 506);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 4;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // frmListeCollab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 541);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnVisualiser);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.grdCollab);
            this.Name = "frmListeCollab";
            this.Text = "Liste Collaborateurs";
            ((System.ComponentModel.ISupportInitialize)(this.grdCollab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCollab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fonction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statut;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnVisualiser;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnFermer;
    }
}