using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesMetier;

namespace ABIDAO
{
    public class CollaborateurDAOEFStatic
    {
        /// <summary>
        /// Méthode pour récupérer la liste de collaborateurs en DB et construire la ListeCollab des objets métiers
        /// </summary>
        /// <param name="laListe">Une instance de MListeCollab</param>
        public static void InstancieCollaborateurs(MListeCollab laListe)
        {
            if (DonneesDAO.DbContextAbiDao == null)
            {
                DonneesDAO.DbContextAbiDao = new AbiDaoContainer();
            }
            var query = from c in DonneesDAO.DbContextAbiDao.CollaborateurSet
                        select c;

            MCollaborateur leCollab;

            foreach(Collaborateur collab in query)
            {
                leCollab = new MCollaborateur(collab.NomCollabo,
                    collab.PrenomCollabo,
                    collab.FonctionCollabo,
                    collab.Adresse,
                    collab.Photo,
                    collab.SituationFamiliale,
                    collab.Statut,
                    collab.Matricule);

                //Ajoute le collaborateur s'il n'est pas présent dans la liste
                laListe.AjouterCollaborateur(leCollab);
                //Met à jour le collaborateur s'il est présent dans la liste
                laListe.ModifierCollaborateur(leCollab);
            }
        }

        /// <summary>
        /// Méthode qui récupère les contrats correspondants au collaborateur choisi en DB pour construire le dictionnaire
        /// </summary>
        /// <param name="leCollab">l'instance de MCollaborateur dont on recherche les contrats</param>
        public static void InstancieContrats(MCollaborateur leCollab)
        {
            if (DonneesDAO.DbContextAbiDao == null)
            {
                DonneesDAO.DbContextAbiDao = new AbiDaoContainer();
            }

            var query = from b in DonneesDAO.DbContextAbiDao.ContratSet
                        where b.Collaborateur.Matricule == leCollab.Matricule
                        select b;

            MContrat leContrat;

            foreach(Contrat contrat in query)
            {
                if(contrat is CDD)
                {
                    leContrat = new MCdd((contrat as CDD).SalaireBrut,
                        contrat.DateDebutContrat,
                        contrat.Qualification,
                        contrat.NumContrat,
                        (contrat as CDD).Motif,
                        (DateTime)(contrat as CDD).DateFinPrevue,
                        contrat.DateFinContrat);

                    leCollab.AddContrat(leContrat);
                }
                else if(contrat is CDI)
                {
                    leContrat = new MCdi((contrat as CDI).SalaireBrut,
                        contrat.NumContrat,
                        contrat.Qualification,
                        contrat.DateDebutContrat,
                        contrat.DateFinContrat);

                    leCollab.AddContrat(leContrat);
                }
                else if(contrat is Stage)
                {
                    leContrat = new MStage((contrat as Stage).Ecole, 
                        (contrat as Stage).Mission, 
                        (Decimal)(contrat as Stage).Indemnite, 
                        (contrat as Stage).Motif, 
                        (DateTime)(contrat as Stage).DateFinPrevue, 
                        contrat.NumContrat, 
                        contrat.Qualification, 
                        contrat.DateDebutContrat, 
                        contrat.DateFinContrat);

                    leCollab.AddContrat(leContrat);
                }
                else
                {
                    leContrat = new MInterim((contrat as Interim).AgenceInterim, 
                        (contrat as Interim).Motif, 
                        (DateTime)(contrat as Interim).DateFinPrevue, 
                        contrat.NumContrat, 
                        contrat.Qualification, 
                        contrat.DateDebutContrat, 
                        contrat.DateFinContrat);

                    leCollab.AddContrat(leContrat);
                }
            }
        }

        /// <summary>
        /// Méthode qui instancie un Collaborateur à partir d'un MCollaborateur et l'enregistre en DB
        /// </summary>
        /// <param name="unCollab">une instance de MCollaborateur</param>
        public static void InsereCollaborateur(MCollaborateur unCollab)
        {
            if (DonneesDAO.DbContextAbiDao == null)
            {
                DonneesDAO.DbContextAbiDao = new AbiDaoContainer();
            }

            Collaborateur CollabEF = new Collaborateur();
            CollabEF.NomCollabo = unCollab.NomCollabo;
            CollabEF.PrenomCollabo = unCollab.PrenomCollabo;
            CollabEF.FonctionCollabo = unCollab.FonctionCollabo;
            CollabEF.Adresse = unCollab.Adresse;
            CollabEF.SituationFamiliale = unCollab.SituationFamiliale;
            CollabEF.Statut = unCollab.Statut;
            CollabEF.Photo = unCollab.Photo;

            DonneesDAO.DbContextAbiDao.CollaborateurSet.Add(CollabEF);
            DonneesDAO.DbContextAbiDao.SaveChanges();
     

        }

        /// <summary>
        /// Méthode qui recherche la correspondance en DB d'une instance de MCollaborateur et met à jour les attributs avant d'enregistrer
        /// </summary>
        /// <param name="unCollab"></param>
        public static void ModifieCollaborateur(MCollaborateur unCollab)
        {
            if (DonneesDAO.DbContextAbiDao == null)
            {
                DonneesDAO.DbContextAbiDao = new AbiDaoContainer();
            }
            Collaborateur CollabEF = new Collaborateur();
            CollabEF = DonneesDAO.DbContextAbiDao.CollaborateurSet.Find(unCollab.Matricule);
            CollabEF.NomCollabo = unCollab.NomCollabo;
            CollabEF.PrenomCollabo = unCollab.PrenomCollabo;
            CollabEF.FonctionCollabo = unCollab.FonctionCollabo;
            CollabEF.Adresse = unCollab.Adresse;
            CollabEF.SituationFamiliale = unCollab.SituationFamiliale;
            CollabEF.Statut = unCollab.Statut;
            CollabEF.Photo = unCollab.Photo;

            DonneesDAO.DbContextAbiDao.SaveChanges();
        }

        /// <summary>
        /// Méthode retournant depuis la DB une instance de MCollaborateur correspondant au numéro de matricule fourni
        /// </summary>
        /// <param name="matricule">numéro de matricule recherché</param>
        /// <returns></returns>
        public static MCollaborateur RetourneCollaborateur(Int32 matricule)
        {
            if (DonneesDAO.DbContextAbiDao == null)
            {
                DonneesDAO.DbContextAbiDao = new AbiDaoContainer();
            }
            //Instancie un Collaborateur et recherche en DB le matricule reçu en paramètre
            Collaborateur CollabEF = new Collaborateur();
            CollabEF = DonneesDAO.DbContextAbiDao.CollaborateurSet.Find(matricule);

            //Instancie un MCollaborateur en lui passant les valeurs des attributs de CollabEF
            MCollaborateur leCollab = new MCollaborateur(CollabEF.NomCollabo,
                CollabEF.PrenomCollabo,
                CollabEF.FonctionCollabo,
                CollabEF.Adresse,
                CollabEF.Photo,
                CollabEF.SituationFamiliale,
                CollabEF.Statut,
                CollabEF.Matricule);

            return leCollab;
        }
    }
}
