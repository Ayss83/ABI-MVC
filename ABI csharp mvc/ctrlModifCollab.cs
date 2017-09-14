using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesMetier;
using ABIDAO;

namespace ABI_csharp_mvc
{
    class ctrlModifCollab
    {
        private frmCollab leForm;

        public ctrlModifCollab(MCollaborateur unCollab)
        {
            leForm = new frmCollab(unCollab);
            leForm.Text = unCollab.PrenomCollabo + " " + unCollab.NomCollabo;
            leForm.btnValider.Visible = true;
            leForm.btnAnnuler.Text = "Annuler";
            leForm.btnValider.Click += this.btnOK_Click;
            leForm.btnAnnuler.Click += this.btnAnnuler_Click;
            if (leForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (leForm.VerifChamps())
                {
                    if (leForm.Instancie())
                    {

                        CollaborateurDAOEFStatic.ModifieCollaborateur(leForm.getCollab());
                        
                    }
                }
            }
        }

        public void btnOK_Click(object sender, EventArgs e)
        {
            this.leForm.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.leForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
