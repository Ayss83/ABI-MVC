﻿using System;
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

        public ctrlVisuContrat(MContrat unContrat)
        {
            leForm = new frmContrat(unContrat);
            leForm.MdiParent = frmMDI.getInstance();
            leForm.Text = "Contrat N°" + unContrat.NumContrat;
            leForm.Show();
        }

    }
}