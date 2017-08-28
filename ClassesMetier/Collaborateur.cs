/***********************************************************************
 * Module:  Collaborateur.cs
 * Author:  Renaud
 * Purpose: Classe m�tier de l'objet collaborateur
 ***********************************************************************/

using System;
using System.Collections.Generic;

public class Collaborateur
{
   /// <summary>
   /// M�thode retournant les informations d'un objet collaborateur sous forme de string
   /// </summary>
   /// <returns>String pr�sentant le contenu</returns>
   public override String ToString()
   {
        return "Matricule : " + Matricule +
            "\nNom : " + NomCollabo +
            "\nPr�nom : " + PrenomCollabo +
            "\nAdresse : " + Adresse +
            "\nFonction : " + FonctionCollabo +
            "\nSituation familiale : " + SituationFamiliale +
            "\nStatut : " + Statut +
            "\nChemin vers la photo : " + Photo + "\n";
   }

    /// <summary>
    /// M�thode retournant le salaire effectif (ou indemnit� effective) en fonction du type de contrat ou 0 si int�rimaire
    /// </summary>
    /// <returns>Valeur totale du salaire (indemnit�) effectif</returns>
    public Decimal GetSalaireEffectif()
    {
        if(ContratActif is Cdd || ContratActif is Cdi)
        {
            return (ContratActif as Cdd).SalaireBrut + TotalAugment();
        }else if(ContratActif is Stage)
        {
            return (ContratActif as Stage).Indemnite + TotalAugment();
        }else
        {
            return 0;
        }
    }

    /// <summary>
    /// constructeur pour instancier un nouveau collabo (matricule affect� par SGBD)
    /// </summary>
    /// <param name="unNom">Nom du collaborateur</param>
    /// <param name="unPrenom">Pr�nom du collaborateur</param>
    /// <param name="uneAdresse">Adresse du collaborateur</param>
    /// <param name="uneFonction">Fonction du collaborateur</param>
    public Collaborateur(String unNom, String unPrenom, String uneAdresse, String uneFonction)
   {
        initContrat();
        initNomPrenomFonction(unNom, unPrenom, uneFonction);
        this.Adresse = uneAdresse;
   }

    /// <summary>
    /// constructeur pour instancier un nouveau collabo (matricule affect� par SGBD)
    /// </summary>
    /// <param name="unNom">Nom du collaborateur</param>
    /// <param name="unPrenom">Pr�nom du collaborateur</param>
    /// <param name="uneFonction">Fonction du collaborateur</param>
    public Collaborateur(String unNom, String unPrenom, String uneFonction)
    {
        initContrat();
        initNomPrenomFonction(unNom, unPrenom, uneFonction);
    }

    /// <summary>
    /// constructeur principal pour instancier un nouveau collabo (matricule affect� par SGBD)
    /// </summary>
    /// <param name="unNom">Nom du collaborateur</param>
    /// <param name="unPrenom">Pr�nom du collaborateur</param>
    /// <param name="uneFonction">Fonction du collaborateur</param>
    /// <param name="uneAdresse">Adresse du collaborateur</param>
    /// <param name="unePhoto">Chemin d'acc�s � la photo</param>
    /// <param name="uneSituation">Situation familiale du collaborateur</param>
    /// <param name="unStatut">Statut du collaborateur</param>
    public Collaborateur(String unNom, String unPrenom, String uneFonction, String uneAdresse, String unePhoto, String uneSituation, String unStatut)
    {
        initContrat();
        initNomPrenomFonction(unNom, unPrenom, uneFonction);
        initAdressePhotoSituationStatut(uneAdresse, unePhoto, uneSituation, unStatut);
    }

    /// <summary>
    /// constructeur pour collaborateurs existant issu de la BDD (fourni par DAO)
    /// </summary>
    /// <param name="unNom">Nom du collaborateur</param>
    /// <param name="unPrenom">Pr�nom du collaborateur</param>
    /// <param name="uneFonction">Fonction du collaborateur</param>
    /// <param name="uneAdresse">Adresse du collaborateur</param>
    /// <param name="unePhoto">Chemin vers la photo</param>
    /// <param name="uneSituation">Situation familiale du collaborateur</param>
    /// <param name="unStatut">Statut du collaborateur</param>
    /// <param name="unMatricule">Matricule du collaborateur</param>
    public Collaborateur(String unNom, String unPrenom, String uneFonction, String uneAdresse, String unePhoto, String uneSituation, String unStatut, int unMatricule)
   {
        // voir pour n'accepter que depuis la couche DAO
        initContrat();
        initNomPrenomFonction(unNom, unPrenom, uneFonction);
        initAdressePhotoSituationStatut(uneAdresse, unePhoto, uneSituation, unStatut);
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
   private Contrat contratActif;
   private List<AugmentationSalaire> listAugmentationSalaire;
   
   private SortedDictionary<int,Contrat> contrats;
   
   /// <summary>
   /// Ajouter un contrat a la liste de contrats du collaborateur et le d�finit comme contrat actif
   /// </summary>
   /// <param name="newContrat">une instance de contrat</param>
   public void AddContrat(Contrat newContrat)
   {
      if (newContrat == null)
         return;

      if (this.contrats == null)
         this.contrats = new SortedDictionary<int, Contrat>();

      if (!this.contrats.ContainsValue(newContrat)) {
            this.contrats.Add(newContrat.NumContrat,newContrat);
            this.ContratActif = newContrat;
        }

   }



    /// <summary>
    /// nom du collaborateur (converti en MAJ) - Obligatoire
    /// </summary>
    /// <exception cref="Exception">Valeur null refus�e</exception>
    public String NomCollabo
   {
      get
      {
         return nomCollabo;
      }
      set
      {
            if (this.nomCollabo != value)
            this.nomCollabo = value.Trim().ToUpper();
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

    public Contrat ContratActif
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
    ///  Ajouter une augmentation de salaire � la liste
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

    /// <summary>
    /// M�thode retournant le total de toutes les augmentations du collaborateur
    /// </summary>
    /// <returns>Total de toutes les augmentations</returns>
    public decimal TotalAugment()
    {
        decimal total = 0;
        foreach(AugmentationSalaire augment in listAugmentationSalaire)
        {
            total = total + augment.Augmentation;
        }
        return total;
    }

    /// <summary>
    /// M�thode d'initialisation de la liste de contrats et du contrat actif appel�e par les constructeurs
    /// </summary>
    private void initContrat()
    {
        this.contrats = new SortedDictionary<int, Contrat>();
        this.ContratActif = null;
    }

    /// <summary>
    /// M�thode d'initialisation des attributs nom, prenom et fonction appel�e par les constructeurs
    /// </summary>
    /// <param name="unNom">Nom du collaborateur</param>
    /// <param name="unPrenom">Pr�nom du collaborateur</param>
    /// <param name="uneFonction">Fonction du collaborateur</param>
    private void initNomPrenomFonction(string unNom, string unPrenom, string uneFonction)
    {
        this.NomCollabo = unNom;
        this.PrenomCollabo = unPrenom;
        this.FonctionCollabo = uneFonction;
    }

    /// <summary>
    /// M�thode d'initialisation de l'adresse, de la photo, de la situation et du statut appel� par le constructeur principal et le constructeur depuis la BDD
    /// </summary>
    /// <param name="uneAdresse">Adresse du collaborateur</param>
    /// <param name="unePhoto">Chemin vers la photo du collaborateur</param>
    /// <param name="uneSituation">Situation familiale du collaborateur</param>
    /// <param name="unStatut">Statut du collaborateur</param>
    private void initAdressePhotoSituationStatut(string uneAdresse, string unePhoto, string uneSituation, string unStatut)
    {
        this.Adresse = uneAdresse;
        this.Photo = unePhoto;
        this.SituationFamiliale = uneSituation;
        this.Statut = unStatut;
    }
}