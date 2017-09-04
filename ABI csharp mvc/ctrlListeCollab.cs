using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ABI_csharp_mvc
{
    class ctrlListeCollab
    {
        private frmListeCollab leForm;
        private DataTable laTable;

        public ctrlListeCollab()
        {
            leForm = new frmListeCollab();
            leForm.MdiParent = frmMDI.getInstance();
            leForm.Show();
        }

        private void init()
        {

        }
    }
}
