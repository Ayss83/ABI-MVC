using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIDAO
{
    public abstract partial class Contrat
    {
        public void setDateFin(DateTime date)
        {
            this.DateFinContrat = date;
        }

        public DateTime? getDateFin()
        {
            return this.DateFinContrat;
        }
    }
}
