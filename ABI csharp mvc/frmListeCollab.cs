using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABI_csharp_mvc
{
    public partial class frmListeCollab : Form
    {

        /// <summary>
        /// Constructeur d'origine pour tests, à supprimer en sortie de beta
        /// </summary>
        public frmListeCollab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructeur recevant la liste de collaborateurs en paramètre pour l'affichage
        /// </summary>
        /// <param name="uneListe">La liste de collaborateurs</param>
        public frmListeCollab(DataTable lesCollabs)
        {
            InitializeComponent();
            this.grdCollab.DataSource = lesCollabs;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
