using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesMetier;

namespace ABIDAO
{
    class ContratDAOEFStatic
    {
        public static void InsereContrat(MContrat unContrat, Collaborateur unCollabEF)
        {
            if (DonneesDAO.DbContextAbiDao == null)
            {
                DonneesDAO.DbContextAbiDao = new AbiDaoContainer();
            }
            if(unContrat is MCdi)
            {
                CDI unCdi = new CDI();
                unCdi.Qualification = unContrat.Qualification;
                unCdi.DateDebutContrat = unContrat.DateDebutContrat;
                unCdi.SalaireBrut = (unContrat as MCdi).SalaireBrut;
                unCdi.DateFinContrat = unContrat.DateFinContrat;
                unCdi.Collaborateur = unCollabEF;
            }
        }
    }
}
