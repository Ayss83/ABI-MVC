/***********************************************************************
 * Module:  Cdd.cs
 * Author:  Renaud
 * Purpose: Classe métier CDD héritant de contrat->contratTemporaire
 ***********************************************************************/

using System;

public class Cdd : ContratTemporaire
{
   /// <summary>
   /// Méthode retournant les information de l'objet CDD sous forme de string
   /// </summary>
   /// <returns>String présentant le contenu de l'objet</returns>
   public override String ToString()
   {
        if (DateFinContrat != null)
        {
            return "Numéro de contrat : " + NumContrat + "\n Qualification : " + Qualification + "\n Motif : " + Motif + "\n Salaire brut : " + SalaireBrut + "\n Date d'établissement du contrat : " + DateDebutContrat + "\n Date de fin prévue : " + DateFinPrevue + "\n Date de fin de contrat : " + DateFinContrat + "\n";
        }
        else
        {
            return "Numéro de contrat : " + NumContrat + "\n Qualification : " + Qualification + "\n Motif : " + Motif + "\n Salaire brut : " + SalaireBrut + "\n Date d'établissement du contrat : " + DateDebutContrat + "\n Date de fin prévue : " + DateFinPrevue + "\n";

        }
    }
   
   /// <summary>
   /// Constructeur d'un objet CDD sans date de fin définie
   /// </summary>
   /// <param name="unSalaire">Salaire brut</param>
   /// <param name="uneDateDeb">Date de début du contrat</param>
   /// <param name="uneQualif">Qualification</param>
   /// <param name="unNum">Numéro du contrat</param>
   /// <param name="unMotif">Motif d'établissement du contrat</param>
   /// <param name="uneDateFinPrev">Date de fin prévue</param>
   public Cdd(Decimal unSalaire, DateTime uneDateDeb, String uneQualif, int unNum, String unMotif, DateTime uneDateFinPrev) :base(unMotif,uneDateFinPrev,unNum,uneQualif,uneDateDeb)
   {
        this.SalaireBrut = unSalaire;
    }
   
   /// <summary>
   /// Constructeur d'un objet CDD sans date de fin définie
   /// </summary>
   /// <param name="unSalaire">Salaire brut</param>
   /// <param name="uneDateDeb">Date de début du contrat</param>
   /// <param name="uneQualif">Qualification</param>
   /// <param name="unNum">Numéro du contrat</param>
   /// <param name="unMotif">Motif d'établissement du contrat</param>
   /// <param name="uneDateFinPrev">Date de fin prévue</param>
   /// <param name="uneDateFin">Date de fin du contrat</param>
   public Cdd(Decimal unSalaire, DateTime uneDateDeb, String uneQualif, int unNum, String unMotif, DateTime uneDateFinPrev, DateTime uneDateFin) :base(unMotif,uneDateFinPrev,unNum,uneQualif,uneDateDeb,uneDateFin)
   {
        this.SalaireBrut = unSalaire;
   }

   private decimal salaireBrut;

   public decimal SalaireBrut
   {
      get
      {
         return salaireBrut;
      }
      set
      {
         if (this.salaireBrut != value)
            this.salaireBrut = value;
      }
   }

}