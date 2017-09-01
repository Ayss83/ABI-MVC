using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABI_csharp_mvc
{
    class ctrlNouvContrat
    {
        private frmContrat leForm;

        public ctrlNouvContrat()
        {
            leForm = new frmContrat();
            leForm.ShowDialog();
        }
    }
}
