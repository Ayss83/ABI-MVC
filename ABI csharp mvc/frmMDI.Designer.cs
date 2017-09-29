namespace ABI_csharp_mvc
{
    partial class frmMDI
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuMDI = new System.Windows.Forms.MenuStrip();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiListeCollab = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMDI
            // 
            this.menuMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outilsToolStripMenuItem});
            this.menuMDI.Location = new System.Drawing.Point(0, 0);
            this.menuMDI.Name = "menuMDI";
            this.menuMDI.Size = new System.Drawing.Size(1044, 24);
            this.menuMDI.TabIndex = 1;
            this.menuMDI.Text = "menuStrip1";
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiListeCollab});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.outilsToolStripMenuItem.Text = "&Collaborateur";
            // 
            // tsiListeCollab
            // 
            this.tsiListeCollab.Name = "tsiListeCollab";
            this.tsiListeCollab.Size = new System.Drawing.Size(197, 22);
            this.tsiListeCollab.Text = "Liste des collaborateurs";
            this.tsiListeCollab.Click += new System.EventHandler(this.tsiListeCollab_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 626);
            this.Controls.Add(this.menuMDI);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMDI;
            this.Name = "frmMDI";
            this.Text = "Active Bretagne Informatique";
            this.menuMDI.ResumeLayout(false);
            this.menuMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMDI;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiListeCollab;
    }
}

