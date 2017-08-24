/***********************************************************************
 * Module:  ContratTemporaire.cs
 * Author:  CDI14
 * Purpose: Definition of the Class ContratTemporaire
 ***********************************************************************/

using System;

public abstract class ContratTemporaire : Contrat
{
   public ContratTemporaire(String unMotif, DateTime uneDateFinPrev, int unNum, String uneQualif, DateTime uneDateDeb, DateTime uneDateFin)
   {
      // TODO: implement
   }
   
   public ContratTemporaire(String unMotif, DateTime uneDateFinPrev, int unNum, String uneQualif, DateTime uneDateDeb)
   {
      // TODO: implement
   }
   
   public override String ToString()
   {
      // TODO: implement
      return null;
   }

   protected String motif;
   protected DateTime dateFinPrevue;

   public String Motif
   {
      get
      {
         return motif;
      }
      set
      {
         if (this.motif != value)
            this.motif = value;
      }
   }
   
   public DateTime DateFinPrevue
   {
      get
      {
         return dateFinPrevue;
      }
      set
      {
         if (this.dateFinPrevue != value)
            this.dateFinPrevue = value;
      }
   }

}