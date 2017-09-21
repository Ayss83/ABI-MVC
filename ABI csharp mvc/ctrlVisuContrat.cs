using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesMetier;
using ABIDAO;

namespace ABI_csharp_mvc
{
    class ctrlVisuContrat
    {
        private frmContrat leForm;
        private MContrat leContrat;

        public ctrlVisuContrat(MContrat unContrat, bool modif)
        {
            leContrat = unContrat;
            leForm = new frmContrat(unContrat);
            leForm.Text = "Contrat N°" + unContrat.NumContrat;
            leForm.ModeVisu();
            leForm.btnAnnuler.Visible = false;
            leForm.btnValider.Click += this.btnValider_Click;
            leForm.btnAjoutAvenant.Click += this.btnAjoutAvenant_Click;
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

        public void btnAjoutAvenant_Click(object sender, EventArgs e)
        {
            ctrlNouvAvenant nouvelAvenant = new ctrlNouvAvenant(this.leContrat);
            if (nouvelAvenant.Resultat == true)
                AvenantDAOEFStatic.InstancieAvenants(this.leContrat);
                this.leForm.grdAvenant.DataSource = leContrat.ListerAvenants();
        }
    }
}
