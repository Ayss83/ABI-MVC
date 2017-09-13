﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesMetier;

namespace ABIDAO
{
    public class CollaborateurDAOEFStatic
    {
        public static void InstancieCollaborateurs(ListeCollab laListe)
        {
            if (DonneesDAO.DbContextAbiDao == null)
            {
                DonneesDAO.DbContextAbiDao = new AbiDaoContainer();
            }
            var query = from c in DonneesDAO.DbContextAbiDao.CollaborateurSet
                        select c;

            ClassesMetier.Collaborateur leCollab;

            foreach(Collaborateur collab in query)
            {
                leCollab = new ClassesMetier.Collaborateur(collab.NomCollabo,
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
    }
}
