/***********************************************************************
 * Module:  ListeCollab.cs
 * Author:  Renaud
 * Purpose: Classe métier de l'objet liste de collaborateurs listeCollab
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Data;

namespace ClassesMetier
{

    public class MListeCollab
    {
        private SortedDictionary<int,MCollaborateur> collaborateurs;
        private DataTable datatableCollab;

        /// <summary>
        /// Constructeur de l'objet ListeCollab, Rempli le dictionnaire avec le contenu de la base de données (prévu)
        /// </summary>
        public MListeCollab()
        {
            //Ajout d'un collaborateur en dur pour tests,
            //A remplacer par une lecture base de donnees pour la release
            //MCollaborateur unCollab = new MCollaborateur("Bouchard", "Gérard", "chef de projet", "23 Avenue de Steve le berger allemand", "", "Divorcé", "Actif", 1);
            //this.AjouterCollaborateur(unCollab);
            //MCollaborateur unCollab2 = new MCollaborateur("Guiche", "Albert", "Technicien", "pas d'adresse connue", "", "Marié", "Actif", 2);
            //this.AjouterCollaborateur(unCollab2);
        }
   
       /// <summary>
       /// Méthode d'ajout d'un collaborateur dans le dictionnaire
       /// </summary>
       /// <param name="newCollaborateur">Instance d'un objet collaborateur</param>
       public void AjouterCollaborateur(MCollaborateur newCollaborateur)
       {
          if (newCollaborateur == null)
             return;
          if (this.collaborateurs == null)
             this.collaborateurs = new SortedDictionary<int, MCollaborateur>();
          if (!this.collaborateurs.ContainsKey(newCollaborateur.Matricule))
             this.collaborateurs.Add(newCollaborateur.Matricule,newCollaborateur);
       }

        public void ModifierCollaborateur(MCollaborateur leCollaborateur)
        {
            if (leCollaborateur == null)
                return;
            if (this.collaborateurs == null)
                this.collaborateurs = new SortedDictionary<int, MCollaborateur>();
            if (this.collaborateurs.ContainsKey(leCollaborateur.Matricule))
                this.collaborateurs[leCollaborateur.Matricule] = leCollaborateur;
        }

       /// <summary>
       /// Méthode retournant le contenu du la liste (Matricule + Nom) sous forme de string
       /// </summary>
       /// <returns>String contenant les paires matricule/nom de la listeCollab</returns>
       public override String ToString()
       {
            string retourListe="";
            foreach(KeyValuePair<int,MCollaborateur> kvp in collaborateurs)
            {
                retourListe = retourListe + "Matricule : " + kvp.Key + ", Nom : " + kvp.Value.NomCollabo + "\n";
            }
          return retourListe;
       }

        /// <summary>
        /// Méthode recréant la datatable et l'alimentant avec le contenu du dictionnaire
        /// </summary>
        /// <returns>La datatable listant les collaborateurs</returns>
        public DataTable ListerCollab()
        {
            datatableCollab = new DataTable();
            datatableCollab.Columns.Add(new DataColumn("Matricule", typeof(Int32)));
            datatableCollab.Columns.Add(new DataColumn("Nom", typeof(String)));
            datatableCollab.Columns.Add(new DataColumn("Prénom", typeof(String)));
            datatableCollab.Columns.Add(new DataColumn("Fonction", typeof(String)));
            datatableCollab.Columns.Add(new DataColumn("Statut", typeof(String)));

            if (collaborateurs!=null)
            {
                foreach (KeyValuePair<int, MCollaborateur> kvp in collaborateurs)
                {
                    DataRow dr = datatableCollab.NewRow();
                    dr[0] = kvp.Key;
                    dr[1] = kvp.Value.NomCollabo;
                    dr[2] = kvp.Value.PrenomCollabo;
                    dr[3] = kvp.Value.FonctionCollabo;
                    dr[4] = kvp.Value.Statut;

                    datatableCollab.Rows.Add(dr);
                }
            }
            return datatableCollab;
        }

        /// <summary>
        /// Méthode retournant une instance de collaborateur correspondant au matricule reçu en paramètre depuis le dictionnaire
        /// </summary>
        /// <param name="matricule">Matricule recherché</param>
        /// <returns></returns>
        public MCollaborateur RestituerCollaborateur(Int32 matricule)
        {
            return collaborateurs[matricule];
        }
    }
}