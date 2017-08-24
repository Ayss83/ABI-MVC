/***********************************************************************
 * Module:  Interim.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Interim
 ***********************************************************************/

using System;

public class Interim : ContratTemporaire
{
   public override String ToString()
   {
      // TODO: implement
      return null;
   }
   
   public Interim(String uneAgence, String unMotif, DateTime uneDateFinPrev, int unNum, String uneQualif, DateTime uneDateDeb)
   {
      // TODO: implement
   }
   
   public Interim(String uneAgence, String unMotif, DateTime uneDateFinPrev, int unNum, String uneQualif, DateTime uneDateDeb, DateTime uneDateFin)
   {
      // TODO: implement
   }

   private String agenceInterim;

   public String AgenceInterim
   {
      get
      {
         return agenceInterim;
      }
      set
      {
         if (this.agenceInterim != value)
            this.agenceInterim = value;
      }
   }

}