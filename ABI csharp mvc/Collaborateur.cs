/***********************************************************************
 * Module:  Collaborateur.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Collaborateur
 ***********************************************************************/

using System;

public class Collaborateur
{
   public override String ToString()
   {
      // TODO: implement
      return null;
   }
   
   public Double GetSalaireEffectif()
   {
      // TODO: implement
      return null;
   }
   
   public Collaborateur(String unNom, String unPrenom, String uneAdresse, String uneFonction)
   {
      // TODO: implement
   }
   
   public Collaborateur(String unNom, String unPrenom, String uneFonction)
   {
      // TODO: implement
   }
   
   public Collaborateur(String unNom, String unPrenom, String uneFonction, String uneAdresse, String unePhoto, String uneSituation, String unStatut)
   {
      // TODO: implement
   }
   
   public Collaborateur(String unNom, String unPrenom, String uneFonction, String uneAdresse, String unePhoto, String uneSituation, String unStatut, int unMatricule)
   {
      // TODO: implement
   }

   private String nomCollabo;
   private String fonctionCollabo;
   private static int matricule;
   private String prenomCollabo;
   private String photo;
   private String adresse;
   private String situationFamiliale;
   private String statut;
   
   private System.Collections.ArrayList contrat;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetContrat()
   {
      if (contrat == null)
         contrat = new System.Collections.ArrayList();
      return contrat;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetContrat(System.Collections.ArrayList newContrat)
   {
      RemoveAllContrat();
      foreach (Contrat oContrat in newContrat)
         AddContrat(oContrat);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddContrat(Contrat newContrat)
   {
      if (newContrat == null)
         return;
      if (this.contrat == null)
         this.contrat = new System.Collections.ArrayList();
      if (!this.contrat.Contains(newContrat))
         this.contrat.Add(newContrat);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveContrat(Contrat oldContrat)
   {
      if (oldContrat == null)
         return;
      if (this.contrat != null)
         if (this.contrat.Contains(oldContrat))
            this.contrat.Remove(oldContrat);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllContrat()
   {
      if (contrat != null)
         contrat.Clear();
   }
   private System.Collections.ArrayList listAugmentationSalaire;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetListAugmentationSalaire()
   {
      if (listAugmentationSalaire == null)
         listAugmentationSalaire = new System.Collections.ArrayList();
      return listAugmentationSalaire;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetListAugmentationSalaire(System.Collections.ArrayList newListAugmentationSalaire)
   {
      RemoveAllListAugmentationSalaire();
      foreach (ListAugmentationSalaire oListAugmentationSalaire in newListAugmentationSalaire)
         AddListAugmentationSalaire(oListAugmentationSalaire);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddListAugmentationSalaire(ListAugmentationSalaire newListAugmentationSalaire)
   {
      if (newListAugmentationSalaire == null)
         return;
      if (this.listAugmentationSalaire == null)
         this.listAugmentationSalaire = new System.Collections.ArrayList();
      if (!this.listAugmentationSalaire.Contains(newListAugmentationSalaire))
         this.listAugmentationSalaire.Add(newListAugmentationSalaire);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveListAugmentationSalaire(ListAugmentationSalaire oldListAugmentationSalaire)
   {
      if (oldListAugmentationSalaire == null)
         return;
      if (this.listAugmentationSalaire != null)
         if (this.listAugmentationSalaire.Contains(oldListAugmentationSalaire))
            this.listAugmentationSalaire.Remove(oldListAugmentationSalaire);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllListAugmentationSalaire()
   {
      if (listAugmentationSalaire != null)
         listAugmentationSalaire.Clear();
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