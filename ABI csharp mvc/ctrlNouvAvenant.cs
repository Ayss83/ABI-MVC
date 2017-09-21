using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesMetier;
using ABIDAO;
using System.Windows.Forms;

namespace ABI_csharp_mvc
{
    public class ctrlNouvAvenant
    {
        frmAvenant leForm;
        MAvenant lAvenant;

        public ctrlNouvAvenant(MContrat leContrat)
        {
            leForm = new frmAvenant();
            leForm.btnAnnuler.Click += this.btnAnnuler_Click;
            leForm.btnValider.Click += this.btnValider_Click;
            if (leForm.ShowDialog() == DialogResult.OK)
            {
                lAvenant = new MAvenant(leForm.dtpDateEtablissement.Value.Date);
                AvenantDAOEFStatic.InsereAvenant(lAvenant, leContrat);
            }
        }

        public void btnAnnuler_Click(object sender, EventArgs e)
        {
            leForm.DialogResult = DialogResult.Cancel;
        }

        public void btnValider_Click(object sender, EventArgs e)
        {
            leForm.DialogResult = DialogResult.OK;
        }
    }
}
