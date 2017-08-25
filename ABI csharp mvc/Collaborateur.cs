/***********************************************************************
 * Module:  Collaborateur.cs
 * Author:  Renaud
 * Purpose: Classe métier de l'objet collaborateur
 ***********************************************************************/

using System;
using System.Collections.Generic;

public class Collaborateur
{
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
   
   public Double GetSalaireEffectif()
   {
      //Et là, c'est la merde
   }

    /// <summary>
    /// constructeur pour instancier un nouveau collabo (matricule affecté par SGBD)
    /// </summary>
    /// <param name="unNom">Nom du collaborateur</param>
    /// <param name="unPrenom">Prénom du collaborateur</param>
    /// <param name="uneAdresse">Adresse du collaborateur</param>
    /// <param name="uneFonction">Fonction du collaborateur</param>
    public Collaborateur(String unNom, String unPrenom, String uneAdresse, String uneFonction)
   {
        this.NomCollabo = unNom;
        this.PrenomCollabo = unPrenom;
        this.Adresse = uneAdresse;
        this.FonctionCollabo = uneFonction;
   }

    /// <summary>
    /// constructeur pour instancier un nouveau collabo (matricule affecté par SGBD)
    /// </summary>
    /// <param name="unNom">Nom du collaborateur</param>
    /// <param name="unPrenom">Prénom du collaborateur</param>
    /// <param name="uneFonction">Fonction du collaborateur</param>
    public Collaborateur(String unNom, String unPrenom, String uneFonction)
   {
        this.NomCollabo = unNom;
        this.PrenomCollabo = unPrenom;
        this.FonctionCollabo = uneFonction;
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
   public Collaborateur(String unNom, String unPrenom, String uneFonction, String uneAdresse, String unePhoto, String uneSituation, String unStatut)
   {
        this.NomCollabo = unNom;
        this.PrenomCollabo = unPrenom;
        this.Adresse = uneAdresse;
        this.FonctionCollabo = uneFonction;
        this.Photo = unePhoto;
        this.SituationFamiliale = uneSituation;
        this.Statut = unStatut;
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
    public Collaborateur(String unNom, String unPrenom, String uneFonction, String uneAdresse, String unePhoto, String uneSituation, String unStatut, int unMatricule)
   {
        // voir pour n'accepter que depuis la couche DAO
        this.NomCollabo = unNom;
        this.PrenomCollabo = unPrenom;
        this.Adresse = uneAdresse;
        this.FonctionCollabo = uneFonction;
        this.Photo = unePhoto;
        this.SituationFamiliale = uneSituation;
        this.Statut = unStatut;
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
   
   private SortedDictionary<int,Contrat> contrats;
   
   /// <summary>
   /// Ajouter un contrat a la liste de contrats du collaborateur
   /// </summary>
   /// <param name="newContrat">une instance de contrat</param>
   public void AddContrat(Contrat newContrat)
   {
      if (newContrat == null)
         return;
      if (this.contrats == null)
         this.contrats = new SortedDictionary<int, Contrat>();
      if (!this.contrats.ContainsValue(newContrat))
         this.contrats.Add(newContrat.NumContrat,newContrat);
   }

   private List<AugmentationSalaire> listAugmentationSalaire;

    /// <summary>
    ///  Ajouter une augmentation de salaire à la liste
    /// </summary>
    /// <param name="newAugmentationSalaire">Une augmentation de salaire</param>
    public void AjouterAugmentation(AugmentationSalaire newAugmentationSalaire)
   {
      if (newAugmentationSalaire == null)
         return;
      if (this.listAugmentationSalaire == null)
         this.listAugmentationSalaire = new List<AugmentationSalaire>();
      if (!this.listAugmentationSalaire.Contains(newAugmentationSalaire))
         this.listAugmentationSalaire.Add(newAugmentationSalaire);
   }

   public String NomCollabo
   {
      get
      {
         return nomCollabo;
      }
      set
      {
         if (this.nomCollabo != value)
            this.nomCollabo = value;
      }
   }
   
   public String FonctionCollabo
   {
      get
      {
         return fonctionCollabo;
      }
      set
      {
         if (this.fonctionCollabo != value)
            this.fonctionCollabo = value;
      }
   }
   
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
            this.prenomCollabo = value;
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
            this.photo = value;
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
            this.adresse = value;
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
            this.situationFamiliale = value;
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
            this.statut = value;
      }
   }

}