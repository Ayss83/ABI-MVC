namespace ABI_csharp_mvc
{
    partial class frmAvenant
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblNumAvenant = new System.Windows.Forms.Label();
            this.txtNumAvenant = new System.Windows.Forms.TextBox();
            this.lblDateAvenant = new System.Windows.Forms.Label();
            this.dtpDateEtablissement = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnValider = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(89, 3);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 0;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // lblNumAvenant
            // 
            this.lblNumAvenant.AutoSize = true;
            this.lblNumAvenant.Location = new System.Drawing.Point(12, 15);
            this.lblNumAvenant.Name = "lblNumAvenant";
            this.lblNumAvenant.Size = new System.Drawing.Size(94, 13);
            this.lblNumAvenant.TabIndex = 1;
            this.lblNumAvenant.Text = "Numéro d\'avenant";
            // 
            // txtNumAvenant
            // 
            this.txtNumAvenant.Location = new System.Drawing.Point(124, 12);
            this.txtNumAvenant.Name = "txtNumAvenant";
            this.txtNumAvenant.ReadOnly = true;
            this.txtNumAvenant.Size = new System.Drawing.Size(200, 20);
            this.txtNumAvenant.TabIndex = 2;
            // 
            // lblDateAvenant
            // 
            this.lblDateAvenant.AutoSize = true;
            this.lblDateAvenant.Location = new System.Drawing.Point(12, 42);
            this.lblDateAvenant.Name = "lblDateAvenant";
            this.lblDateAvenant.Size = new System.Drawing.Size(105, 13);
            this.lblDateAvenant.TabIndex = 3;
            this.lblDateAvenant.Text = "Date d\'établissement";
            // 
            // dtpDateEtablissement
            // 
            this.dtpDateEtablissement.Location = new System.Drawing.Point(124, 38);
            this.dtpDateEtablissement.Name = "dtpDateEtablissement";
            this.dtpDateEtablissement.Size = new System.Drawing.Size(200, 20);
            this.dtpDateEtablissement.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAnnuler);
            this.flowLayoutPanel1.Controls.Add(this.btnValider);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(159, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(167, 30);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(8, 3);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // frmAvenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 106);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dtpDateEtablissement);
            this.Controls.Add(this.lblDateAvenant);
            this.Controls.Add(this.txtNumAvenant);
            this.Controls.Add(this.lblNumAvenant);
            this.Name = "frmAvenant";
            this.Text = "Avenant";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumAvenant;
        private System.Windows.Forms.TextBox txtNumAvenant;
        private System.Windows.Forms.Label lblDateAvenant;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal System.Windows.Forms.Button btnAnnuler;
        internal System.Windows.Forms.Button btnValider;
        internal System.Windows.Forms.DateTimePicker dtpDateEtablissement;
    }
}