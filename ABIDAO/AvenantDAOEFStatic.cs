using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesMetier;

namespace ABIDAO
{
    public class AvenantDAOEFStatic
    {
        /// <summary>
        /// Méthode d'insertion d'avenant en DB en le liant à un contrat existant
        /// </summary>
        /// <param name="unAvenant">L'avenant à ajouter</param>
        /// <param name="unContrat">Le contrat complété par l'avenant</param>
        public static void InsereAvenant(MAvenant unAvenant, MContrat unContrat)
        {
            if (DonneesDAO.DbContextAbiDao == null)
            {
                DonneesDAO.DbContextAbiDao = new AbiDaoContainer();
            }

            Avenant lAvenant = new Avenant();
            lAvenant.DateAvenant = unAvenant.DateAvenant;
            lAvenant.Contrat = DonneesDAO.DbContextAbiDao.ContratSet.Find(unContrat.NumContrat);

            DonneesDAO.DbContextAbiDao.AvenantSet.Add(lAvenant);
            DonneesDAO.DbContextAbiDao.SaveChanges();
        }
    }
}
