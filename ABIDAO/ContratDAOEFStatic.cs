using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesMetier;

namespace ABIDAO
{
    public class ContratDAOEFStatic
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

                unCollabEF.ContratActif = unCdi.NumContrat;
                DonneesDAO.DbContextAbiDao.ContratSet.Add(unCdi);
                DonneesDAO.DbContextAbiDao.SaveChanges();
            }
            else if(unContrat is MCdd)
            {
                CDD unCdd = new CDD();
                unCdd.Qualification = unContrat.Qualification;
                unCdd.DateDebutContrat = unContrat.DateDebutContrat;
                unCdd.SalaireBrut = (unContrat as MCdd).SalaireBrut;
                unCdd.DateFinPrevue = (unContrat as MCdd).DateFinPrevue;
                unCdd.DateFinContrat = unContrat.DateFinContrat;
                unCdd.Motif = (unContrat as MCdd).Motif;
                unCdd.Collaborateur = unCollabEF;

                unCollabEF.ContratActif = unCdd.NumContrat;
                DonneesDAO.DbContextAbiDao.ContratSet.Add(unCdd);
                DonneesDAO.DbContextAbiDao.SaveChanges();
            }
            else if(unContrat is MStage)
            {
                Stage unStage = new Stage();
                unStage.Qualification = unContrat.Qualification;
                unStage.DateDebutContrat = unContrat.DateDebutContrat;
                unStage.Indemnite = (unContrat as MStage).Indemnite;
                unStage.DateFinPrevue = (unContrat as MStage).DateFinPrevue;
                unStage.DateFinContrat = unContrat.DateFinContrat;
                unStage.Motif = (unContrat as MStage).Motif;
                unStage.Mission = (unContrat as MStage).Mission;
                unStage.Ecole = (unContrat as MStage).Ecole;
                unStage.Collaborateur = unCollabEF;

                unCollabEF.ContratActif = unStage.NumContrat;
                DonneesDAO.DbContextAbiDao.ContratSet.Add(unStage);
                DonneesDAO.DbContextAbiDao.SaveChanges();
            }
            else
            {
                Interim unInterim = new Interim();
                unInterim.Qualification = unContrat.Qualification;
                unInterim.DateDebutContrat = unContrat.DateDebutContrat;
                unInterim.DateFinPrevue = (unContrat as MInterim).DateFinPrevue;
                unInterim.DateFinContrat = unContrat.DateFinContrat;
                unInterim.Motif = (unContrat as MInterim).Motif;
                unInterim.AgenceInterim = (unContrat as MInterim).AgenceInterim;
                unInterim.Collaborateur = unCollabEF;

                unCollabEF.ContratActif = unInterim.NumContrat;
                DonneesDAO.DbContextAbiDao.ContratSet.Add(unInterim);
                DonneesDAO.DbContextAbiDao.SaveChanges();
            }
        }
    }
}
