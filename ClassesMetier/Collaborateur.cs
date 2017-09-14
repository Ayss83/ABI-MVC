/***********************************************************************
 * Module:  Collaborateur.cs
 * Author:  Renaud
 * Purpose: Classe métier de l'objet collaborateur
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Data;

namespace ClassesMetier
{

    public class MCollaborateur
    {
        /// <summary>
        /// constructeur pour instancier un nouveau collabo (matricule affecté par SGBD)
        /// </summary>
        /// <param name="unNom">Nom du collaborateur</param>
        /// <param name="unPrenom">Prénom du collaborateur</param>
        /// <param name="uneAdresse">Adresse du collaborateur</param>
        /// <param name="uneFonction">Fonction du collaborateur</param>
        public MCollaborateur(String unNom, String unPrenom, String uneAdresse, String uneFonction, String unStatut)
       {
            initContrat();
            initNomPrenomFonctionStatut(unNom, unPrenom, uneFonction, unStatut);
            this.Adresse = uneAdresse;
       }

        /// <summary>
        /// constructeur pour instancier un nouveau collabo (matricule affecté par SGBD)
        /// </summary>
        /// <param name="unNom">Nom du collaborateur</param>
        /// <param name="unPrenom">Prénom du collaborateur</param>
        /// <param name="uneFonction">Fonction du collaborateur</param>
        public MCollaborateur(String unNom, String unPrenom, String uneFonction, String unStatut)
        {
            initContrat();
            initNomPrenomFonctionStatut(unNom, unPrenom, uneFonction, unStatut);
        }

        /// <summary>
        /// constructeur principal pour instancier un nouveau collabo (matricule affecté par SGBD)
        /// </summary>
        /// <param name="unNom">Nom du collaborateur</param>
        /// <param name="unPrenom">Prénom du collaborateur</param>
        /// <param name="uneFonction">Fonction du collaborateur</param>
        /// <param name="uneAdresse">Adresse du collaborateur</param>
        /// <param name="unePhoto">Chemin d'accès à la photo</param>
        /// <param name="uneSituation">Situation familiale du collaborateur</param>
        /// <param name="unStatut">Statut du collaborateur</param>
        public MCollaborateur(String unNom, String unPrenom, String uneFonction, String uneAdresse, String unePhoto, String uneSituation, String unStatut)
        {
            initContrat();
            initNomPrenomFonctionStatut(unNom, unPrenom, uneFonction, unStatut);
            initAdressePhotoSituation(uneAdresse, unePhoto, uneSituation);
        }

        /// <summary>
        /// constructeur pour collaborateurs existant issu de la BDD (fourni par DAO)
        /// </summary>
        /// <param name="unNom">Nom du collaborateur</param>
        /// <param name="unPrenom">Prénom du collaborateur</param>
        /// <param name="uneFonction">Fonction du collaborateur</param>
        /// <param name="uneAdresse">Adresse du collaborateur</param>
        /// <param name="unePhoto">Chemin vers la photo</param>
        /// <param name="uneSituation">Situation familiale du collaborateur</param>
        /// <param name="unStatut">Statut du collaborateur</param>
        /// <param name="unMatricule">Matricule du collaborateur</param>
        public MCollaborateur(String unNom, String unPrenom, String uneFonction, String uneAdresse, String unePhoto, String uneSituation, String unStatut, int unMatricule)
       {
            // voir pour n'accepter que depuis la couche DAO
            initContrat();
            initNomPrenomFonctionStatut(unNom, unPrenom, uneFonction,unStatut);
            initAdressePhotoSituation(uneAdresse, unePhoto, uneSituation);
            this.Matricule = unMatricule;
        }

       private String nomCollabo;
       private String fonctionCollabo;
       private int matricule;
       private String prenomCollabo;
       private String photo;
       private String adresse;
       private String situationFamiliale;
       private String statut;
       private MContrat contratActif;
       private List<MAugmentationSalaire> listAugmentationSalaire;
   
       private SortedDictionary<int,MContrat> contrats;

        /// <summary>
        /// nom du collaborateur (converti en MAJ) - Obligatoire
        /// </summary>
        /// <exception cref="Exception">Valeur null refusée</exception>
        public String NomCollabo
       {
          get
          {
             return nomCollabo;
          }
          set
            {
                if (this.nomCollabo != value)
                {
                    this.nomCollabo = value.Trim().ToUpper();
                }
            }
        }
   
       /// <summary>
       /// Fonction du collaborateur (obligatoire)
       /// </summary>
       public String FonctionCollabo
       {
          get
          {
             return fonctionCollabo;
          }
          set
          {
             if (this.fonctionCollabo != value)
                this.fonctionCollabo = value.Trim();
          }
       }
   
       /// <summary>
       /// Matricule du collaborateur (attribué par l'auto-incrémentation en SGBD)
       /// </summary>
       public int Matricule
       {
          get
          {
             return matricule;
          }
          set
          {
             if (this.matricule != value)
                this.matricule = value;
          }
       }
   
       public String PrenomCollabo
       {
          get
          {
             return prenomCollabo;
          }
          set
          {
             if (this.prenomCollabo != value)
                this.prenomCollabo = value.Trim();
          }
       }
   
       public String Photo
       {
          get
          {
             return photo;
          }
          set
          {
             if (this.photo != value)
                this.photo = value.Trim();
          }
       }
   
       public String Adresse
       {
          get
          {
             return adresse;
          }
          set
          {
             if (this.adresse != value)
                this.adresse = value.Trim();
          }
       }
   
       public String SituationFamiliale
       {
          get
          {
             return situationFamiliale;
          }
          set
          {
             if (this.situationFamiliale != value)
                this.situationFamiliale = value.Trim();
          }
       }
   
       public String Statut
       {
          get
          {
             return statut;
          }
          set
          {
             if (this.statut != value)
                this.statut = value.Trim();
          }
       }

        public MContrat ContratActif
        {
            get
            {
                return contratActif;
            }

            set
            {
                contratActif = value;
            }
        }

       /// <summary>
       /// Méthode retournant les informations d'un objet collaborateur sous forme de string
       /// </summary>
       /// <returns>String présentant le contenu</returns>
       public override String ToString()
       {
            return "Matricule : " + Matricule +
                "\nNom : " + NomCollabo +
                "\nPrénom : " + PrenomCollabo +
                "\nAdresse : " + Adresse +
                "\nFonction : " + FonctionCollabo +
                "\nSituation familiale : " + SituationFamiliale +
                "\nStatut : " + Statut +
                "\nChemin vers la photo : " + Photo + "\n";
       }

        /// <summary>
        /// Méthode retournant le salaire effectif (ou indemnité effective) en fonction du type de contrat ou 0 si intérimaire
        /// </summary>
        /// <returns>Valeur totale du salaire (indemnité) effectif</returns>
        public Decimal GetSalaireEffectif()
        {
            if(ContratActif is MCdd || ContratActif is MCdi)
            {
                return (ContratActif as MCdd).SalaireBrut + TotalAugment();
            }else if(ContratActif is MStage)
            {
                return (ContratActif as MStage).Indemnite + TotalAugment();
            }else
            {
                return 0;
            }
        }

       /// <summary>
       /// Ajouter un contrat a la liste de contrats du collaborateur et le définit comme contrat actif
       /// </summary>
       /// <param name="newContrat">une instance de contrat</param>
       public void AddContrat(MContrat newContrat)
       {
          if (newContrat == null)
             return;

          if (this.contrats == null)
             this.contrats = new SortedDictionary<int, MContrat>();

          if (!this.contrats.ContainsValue(newContrat)) {
                this.contrats.Add(newContrat.NumContrat,newContrat);
                this.ContratActif = newContrat;
            }

       }

        public DataTable ListerContrats()
        {
            DataTable datatableContrats;
            datatableContrats = new DataTable();
            datatableContrats.Columns.Add("Numéro de contrat", typeof(Int32));
            datatableContrats.Columns.Add("Date d'établissement", typeof(String));
            datatableContrats.Columns.Add("Qualification", typeof(String));

            foreach(KeyValuePair<int,MContrat> kvp in contrats)
            {
                DataRow dr;
                dr = datatableContrats.NewRow();
                dr[0] = kvp.Key;
                dr[1] = kvp.Value.DateDebutContrat.ToShortDateString();
                dr[2] = kvp.Value.Qualification;

                datatableContrats.Rows.Add(dr);
            }
            return datatableContrats;
        }

        public MContrat RetourneContrat(int numero)
        {
            return this.contrats[numero];
        }

        /// <summary>
        ///  Ajouter une augmentation de salaire à la liste
        /// </summary>
        /// <param name="newAugmentationSalaire">Une augmentation de salaire</param>
        public void AjouterAugmentation(MAugmentationSalaire newAugmentationSalaire)
       {
          if (newAugmentationSalaire == null)
             return;
          if (this.listAugmentationSalaire == null)
             this.listAugmentationSalaire = new List<MAugmentationSalaire>();
          if (!this.listAugmentationSalaire.Contains(newAugmentationSalaire))
             this.listAugmentationSalaire.Add(newAugmentationSalaire);
       }

        /// <summary>
        /// Méthode retournant le total de toutes les augmentations du collaborateur
        /// </summary>
        /// <returns>Total de toutes les augmentations</returns>
        public decimal TotalAugment()
        {
            decimal total = 0;
            foreach(MAugmentationSalaire augment in listAugmentationSalaire)
            {
                total = total + augment.Augmentation;
            }
            return total;
        }

        /// <summary>
        /// Méthode d'initialisation de la liste de contrats et du contrat actif appelée par les constructeurs
        /// </summary>
        private void initContrat()
        {
            this.contrats = new SortedDictionary<int, MContrat>();
            this.ContratActif = null;
        }

        /// <summary>
        /// Méthode d'initialisation des attributs nom, prenom et fonction appelée par les constructeurs
        /// </summary>
        /// <param name="unNom">Nom du collaborateur</param>
        /// <param name="unPrenom">Prénom du collaborateur</param>
        /// <param name="uneFonction">Fonction du collaborateur</param>
        private void initNomPrenomFonctionStatut(string unNom, string unPrenom, string uneFonction, string unStatut)
        {
            this.NomCollabo = unNom;
            this.PrenomCollabo = unPrenom;
            this.FonctionCollabo = uneFonction;
            this.Statut = unStatut;
        }

        /// <summary>
        /// Méthode d'initialisation de l'adresse, de la photo et de la situation appelées par le constructeur principal et le constructeur depuis la BDD
        /// </summary>
        /// <param name="uneAdresse">Adresse du collaborateur</param>
        /// <param name="unePhoto">Chemin vers la photo du collaborateur</param>
        /// <param name="uneSituation">Situation familiale du collaborateur</param>
        /// <param name="unStatut">Statut du collaborateur</param>
        private void initAdressePhotoSituation(string uneAdresse, string unePhoto, string uneSituation)
        {
            this.Adresse = uneAdresse;
            this.Photo = unePhoto;
            this.SituationFamiliale = uneSituation;
        }
    }
}