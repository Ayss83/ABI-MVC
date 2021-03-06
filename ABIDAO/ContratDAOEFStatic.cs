﻿using System;
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
                if (ContratDAOEFStatic.getContratActif(unCollabEF) != null)
                {
                    ContratDAOEFStatic.getContratActif(unCollabEF).Cloture = true;
                    ContratDAOEFStatic.getContratActif(unCollabEF).setDateFin(DateTime.Now);
                }

                CDI unCdi = new CDI();
                unCdi.Qualification = unContrat.Qualification;
                unCdi.DateDebutContrat = unContrat.DateDebutContrat;
                unCdi.SalaireBrut = (unContrat as MCdi).SalaireBrut;
                unCdi.DateFinContrat = unContrat.DateFinContrat;
                unCdi.Collaborateur = unCollabEF;

                //DonneesDAO.DbContextAbiDao.ContratSet.Add(unCdi);
                //DonneesDAO.DbContextAbiDao.SaveChanges();
                //unCollabEF.ContratActif = unCdi.NumContrat;

                DonneesDAO.DbContextAbiDao.SaveChanges();
                unCollabEF.Contrat.Add(unCdi);
                //Enregistrement du contrat en DB pour procéder à l'attribution du numéro par la DB
                DonneesDAO.DbContextAbiDao.SaveChanges();

            }
            else if(unContrat is MCdd)
            {
                if (ContratDAOEFStatic.getContratActif(unCollabEF) != null)
                {
                    ContratDAOEFStatic.getContratActif(unCollabEF).Cloture = true;
                    ContratDAOEFStatic.getContratActif(unCollabEF).setDateFin(DateTime.Now);
                }

                CDD unCdd = new CDD();
                unCdd.Qualification = unContrat.Qualification;
                unCdd.DateDebutContrat = unContrat.DateDebutContrat;
                unCdd.SalaireBrut = (unContrat as MCdd).SalaireBrut;
                unCdd.DateFinPrevue = (unContrat as MCdd).DateFinPrevue;
                unCdd.DateFinContrat = unContrat.DateFinContrat;
                unCdd.Motif = (unContrat as MCdd).Motif;
                unCdd.Collaborateur = unCollabEF;

                unCollabEF.Contrat.Add(unCdd);
                //Enregistrement du contrat en DB pour procéder à l'attribution du numéro par la DB
                DonneesDAO.DbContextAbiDao.SaveChanges();
            }
            else if(unContrat is MStage)
            {
                if (ContratDAOEFStatic.getContratActif(unCollabEF) != null)
                {
                    ContratDAOEFStatic.getContratActif(unCollabEF).Cloture = true;
                    ContratDAOEFStatic.getContratActif(unCollabEF).setDateFin(DateTime.Now);
                }

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

                unCollabEF.Contrat.Add(unStage);
                //Enregistrement du contrat en DB pour procéder à l'attribution du numéro par la DB
                DonneesDAO.DbContextAbiDao.SaveChanges();
            }
            else
            {
                if (ContratDAOEFStatic.getContratActif(unCollabEF) != null)
                {
                    ContratDAOEFStatic.getContratActif(unCollabEF).Cloture = true;
                    ContratDAOEFStatic.getContratActif(unCollabEF).setDateFin(DateTime.Now);
                }

                Interim unInterim = new Interim();
                unInterim.Qualification = unContrat.Qualification;
                unInterim.DateDebutContrat = unContrat.DateDebutContrat;
                unInterim.DateFinPrevue = (unContrat as MInterim).DateFinPrevue;
                unInterim.DateFinContrat = unContrat.DateFinContrat;
                unInterim.Motif = (unContrat as MInterim).Motif;
                unInterim.AgenceInterim = (unContrat as MInterim).AgenceInterim;
                unInterim.Collaborateur = unCollabEF;

                unCollabEF.Contrat.Add(unInterim);
                //Enregistrement du contrat en DB pour procéder à l'attribution du numéro par la DB
                DonneesDAO.DbContextAbiDao.SaveChanges();
            }
        }

        /// <summary>
        /// Méthode retournant l'instance Contrat correspondant au contratActif du collaborateur
        /// </summary>
        /// <param name="unCollab">collaborateur dont on recherche le contrat</param>
        /// <returns>Le contrat actif du collaborateur</returns>
        public static Contrat getContratActif(Collaborateur unCollab)
        {
            if (DonneesDAO.DbContextAbiDao == null)
            {
                DonneesDAO.DbContextAbiDao = new AbiDaoContainer();
            }

            if((from a in DonneesDAO.DbContextAbiDao.ContratSet
                where a.Cloture == false && a.Collaborateur.Matricule == unCollab.Matricule
                select a).Count() > 0)
            {
                Contrat ContratActif = (from a in DonneesDAO.DbContextAbiDao.ContratSet
                            where a.Cloture == false && a.Collaborateur.Matricule == unCollab.Matricule
                            select a).First();

                return ContratActif;
            }
            else
            {
                return null;
            }           
        }
    }
}
