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
        /// <summary>
        /// Méthode d'ajout d'un contrat à un collaborateur en DB
        /// </summary>
        /// <param name="unContrat">Le contrat à ajouter</param>
        /// <param name="unCollabEF">le Collaborateur auquel appartient le contrat</param>
        public static void InsereContrat(MContrat unContrat, MCollaborateur unCollab)
        {
            if (DonneesDAO.DbContextAbiDao == null)
            {
                DonneesDAO.DbContextAbiDao = new AbiDaoContainer();
            }

            //Instanciation d'un Collaborateur et recherche en DB de la correspondance avec le matricule du MCollaborateur reçu en paramètre
            Collaborateur unCollabEF;
            unCollabEF = DonneesDAO.DbContextAbiDao.CollaborateurSet.Find(unCollab.Matricule);

            //Instancie un Contrat pour l'ajouter à la DB correspondant au type réel du Mcontrat fourni
            if(unContrat is MCdi)
            {
                CDI unCdi = new CDI();
                unCdi.Qualification = unContrat.Qualification;
                unCdi.DateDebutContrat = unContrat.DateDebutContrat;
                unCdi.SalaireBrut = (unContrat as MCdi).SalaireBrut;
                unCdi.DateFinContrat = unContrat.DateFinContrat;
                unCdi.Collaborateur = unCollabEF;

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

                DonneesDAO.DbContextAbiDao.ContratSet.Add(unInterim);
                DonneesDAO.DbContextAbiDao.SaveChanges();
            }
        }

        /// <summary>
        /// Méthode retournant un MContrat correspondant au numéro de contrat recherché dans la DB
        /// </summary>
        /// <param name="leNumContrat">Numéro de contrat recherché</param>
        /// <returns>Instance de MContrat correspondant au numéro</returns>
        public static MContrat RetourneContrat(Int32 leNumContrat)
        {
            if (DonneesDAO.DbContextAbiDao == null)
            {
                DonneesDAO.DbContextAbiDao = new AbiDaoContainer();
            }

            //Instanciation d'un contrat et recherche de la correspondance du numéro en DB
            Contrat contratEF;
            contratEF = DonneesDAO.DbContextAbiDao.ContratSet.Find(leNumContrat);

            MContrat leContrat;
            //Instanciation de leContrat selon son type réel et retourne leContrat après instanciation
            if(contratEF is CDI)
            {
                leContrat = new MCdi((contratEF as CDI).SalaireBrut, 
                    contratEF.NumContrat, 
                    contratEF.Qualification, 
                    contratEF.DateDebutContrat, 
                    contratEF.DateFinContrat);

                return leContrat;
            }
            else if(contratEF is CDD)
            {
                leContrat = new MCdd((contratEF as CDD).SalaireBrut, 
                    contratEF.DateDebutContrat, 
                    contratEF.Qualification, 
                    contratEF.NumContrat, 
                    (contratEF as CDD).Motif, 
                    (DateTime)(contratEF as CDD).DateFinPrevue, 
                    contratEF.DateFinContrat);

                return leContrat;
            }
            else if(contratEF is Stage)
            {
                leContrat = new MStage((contratEF as Stage).Ecole, 
                    (contratEF as Stage).Mission, 
                    (Decimal)(contratEF as Stage).Indemnite, 
                    (contratEF as Stage).Motif, 
                    (DateTime)(contratEF as Stage).DateFinPrevue, 
                    contratEF.NumContrat, 
                    contratEF.Qualification, 
                    contratEF.DateDebutContrat, 
                    contratEF.DateFinContrat);

                return leContrat;
            }
            else
            {
                leContrat = new MInterim((contratEF as Interim).AgenceInterim, 
                    (contratEF as Interim).Motif, 
                    (DateTime)(contratEF as Interim).DateFinPrevue, 
                    contratEF.NumContrat, 
                    contratEF.Qualification, 
                    contratEF.DateDebutContrat, 
                    contratEF.DateFinContrat);

                return leContrat;
            }
        }
    }
}
