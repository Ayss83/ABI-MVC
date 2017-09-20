using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesMetier;

namespace ABI_csharp_mvc
{
    class ctrlVisuContrat
    {
        private frmContrat leForm;

        public ctrlVisuContrat(MContrat unContrat, bool modif)
        {
            leForm = new frmContrat(unContrat);
            leForm.Text = "Contrat N°" + unContrat.NumContrat;
            leForm.ModeVisu();
            leForm.btnAnnuler.Visible = false;
            leForm.btnValider.Click += this.btnValider_Click;
            if(modif == true)
            {
                leForm.ShowDialog();
            }
            else
            {
                leForm.MdiParent = frmMDI.getInstance();
                leForm.Show();
            }
        }

        public void btnValider_Click(object sender, EventArgs e)
        {
            leForm.Close();
        }
    }
}
