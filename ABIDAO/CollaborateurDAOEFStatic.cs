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

                laListe.AjouterCollaborateur(leCollab);
            }
        }

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

        public static void ModifieCollaborateur(MCollaborateur unCollab)
        {
            if (DonneesDAO.DbContextAbiDao == null)
            {
                DonneesDAO.DbContextAbiDao = new AbiDaoContainer();
            }
            Collaborateur CollabEF = new Collaborateur();
            CollabEF = DonneesDAO.DbContextAbiDao.CollaborateurSet.Find(1);
            CollabEF.NomCollabo = unCollab.NomCollabo;
            CollabEF.PrenomCollabo = unCollab.PrenomCollabo;
            CollabEF.FonctionCollabo = unCollab.FonctionCollabo;
            CollabEF.Adresse = unCollab.Adresse;
            CollabEF.SituationFamiliale = unCollab.SituationFamiliale;
            CollabEF.Statut = unCollab.Statut;
            CollabEF.Photo = unCollab.Photo;

            DonneesDAO.DbContextAbiDao.SaveChanges();
        }
    }
}
