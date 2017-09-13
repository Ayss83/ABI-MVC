using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesMetier;

namespace ABI_csharp_mvc
{
    class ctrlModifCollab
    {
        private frmCollab leForm;

        public ctrlModifCollab(Collaborateur unCollab)
        {
            leForm = new frmCollab(unCollab);
            leForm.Text = unCollab.PrenomCollabo + " " + unCollab.NomCollabo;
            leForm.MdiParent = frmMDI.getInstance();
            leForm.Show();
        }
    }
}
