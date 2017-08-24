/***********************************************************************
 * Module:  Contrat.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Contrat
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Data;

public abstract class Contrat
{
   /// <summary>
   /// Retourne les informations concernant la classe contrat
   /// </summary>
   /// <returns>String des informations du contrat</returns>
   public override String ToString()
   {
      if(DateFinContrat !=null)
        {
            return "Num�ro de contrat : " + NumContrat + "\n Qualification : " + Qualification + "\n Date d'�tablissement du contrat : " + DateDebutContrat + "\n Date de fin de contrat : " + DateFinContrat + "\n";
        }else
        {
            return "Num�ro de contrat : " + NumContrat + "\n Qualification : " + Qualification + "\n Date d'�tablissement du contrat : " + DateDebutContrat + "\n";

        }
    }
   
   /// <summary>
   /// M�thode permettant de d�finir une date de fin de contrat
   /// </summary>
   /// <param name="uneDateFin">La date de fin de contrat</param>
   public void Cloturer(DateTime uneDateFin)
   {
        if(uneDateFin>DateDebutContrat)
        {
        this.DateFinContrat = uneDateFin;
        }else
        {
            throw new Exception("La date de fin ne peut pas �tre plus ancienne que la date de d�but");
        }
   }
   
   /// <summary>
   /// Constructeur du contrat sans date de fin d�finie
   /// </summary>
   /// <param name="unNum">Num�ro de contrat</param>
   /// <param name="uneQualif">Qualification du collaborateur</param>
   /// <param name="uneDateDeb">Date de d�but du contrat</param>
   public Contrat(int unNum, String uneQualif, DateTime uneDateDeb)
   {
        NumContrat = unNum;
        Qualification = uneQualif;
        DateDebutContrat = uneDateDeb;
   }
   
   /// <summary>
   /// Constructeur du contrat avec date de fin d�finie
   /// </summary>
   /// <param name="unNum">Num�ro de contrat</param>
   /// <param name="uneQualif">Qualification du collaborateur</param>
   /// <param name="uneDateDeb">Date de d�but du contrat</param>
   /// <param name="uneDateFin">Date de fin du contrat</param>
   public Contrat(int unNum, String uneQualif, DateTime uneDateDeb, DateTime uneDateFin)
   {
        NumContrat = unNum;
        Qualification = uneQualif;
        DateDebutContrat = uneDateDeb;
        DateFinContrat = uneDateFin;
    }

   protected DateTime dateDebutContrat;
   protected String qualification;
   protected int numContrat;
   protected DateTime dateFinContrat;

   private SortedDictionary<int, Avenant> avenants;
   
   /// <summary>
   /// Ajout d'un avenant dans le dictionnaire
   /// </summary>
   /// <param name="newAvenant">R�f�rence d'un avenant</param>
   public void AddAvenant(Avenant newAvenant)
   {
      if (newAvenant == null)
         return;
      if (this.avenants == null)
         this.avenants = new SortedDictionary<int,Avenant>();
      if (!this.avenants.ContainsValue(newAvenant))
         this.avenants.Add(newAvenant.NumAvenant, newAvenant);
   }

   public DataTable ListerAvenants()
    {
        DataTable listeAvenants = new DataTable();
        listeAvenants.Columns.Add("Num�ro");
        listeAvenants.Columns.Add("Date");

        DataRow dr;
        foreach(KeyValuePair<int,Avenant> kvp in avenants)
        {
            dr
        }
    }

    public DateTime DateDebutContrat
   {
      get
      {
         return dateDebutContrat;
      }
      set
      {
         if (this.dateDebutContrat != value)
            this.dateDebutContrat = value;
      }
   }
   
   public String Qualification
   {
      get
      {
         return qualification;
      }
      set
      {
         if (this.qualification != value)
            this.qualification = value;
      }
   }
   
   public DateTime DateFinContrat
   {
      get
      {
         return dateFinContrat;
      }
      set
      {
         if (this.dateFinContrat != value)
            this.dateFinContrat = value;
      }
   }
   
   public int NumContrat
   {
      get
      {
         return numContrat;
      }
      set
      {
         if (this.numContrat != value)
            this.numContrat = value;
      }
   }

}