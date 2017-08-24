/***********************************************************************
 * Module:  Cdd.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Cdd
 ***********************************************************************/

using System;

public class Cdd : ContratTemporaire
{
   public override String ToString()
   {
      // TODO: implement
      return null;
   }
   
   public Cdd(Double unSalaire, DateTime uneDateDeb, String uneQualif, int unNum, String unMotif, DateTime uneDateFinPrev)
   {
      // TODO: implement
   }
   
   public Cdd(Double unSalaire, DateTime uneDateDeb, String uneQualif, int unNum, String unMotif, DateTime uneDateFinPrev, DateTime uneDateFin)
   {
      // TODO: implement
   }

   private double salaireBrut;

   public double SalaireBrut
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