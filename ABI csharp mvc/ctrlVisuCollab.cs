using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABI_csharp_mvc
{
    class ctrlVisuCollab
    {
        private frmCollab leForm;

        public ctrlVisuCollab(Collaborateur unCollab)
        {
            leForm = new frmCollab(unCollab);
            leForm.Text = unCollab.PrenomCollabo + " " + unCollab.NomCollabo;
            leForm.MdiParent = frmMDI.getInstance();
            leForm.grdContrats.DataSource = unCollab.ListerContrats();
            leForm.Show();
        }
    }
}
