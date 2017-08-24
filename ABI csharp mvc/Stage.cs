/***********************************************************************
 * Module:  Stage.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Stage
 ***********************************************************************/

using System;

public class Stage : ContratTemporaire
{
   public override String ToString()
   {
      // TODO: implement
      return null;
   }
   
   public Stage(String uneEcole, String uneMission, Double uneIndemnite, String unMotif, DateTime uneDateFinPrev, int unNum, String uneQualif, DateTime uneDateDeb)
   {
      // TODO: implement
   }
   
   public Stage(String uneEcole, String uneMission, Double uneIndemnite, String unMotif, DateTime uneDateFinPrev, int unNum, String uneQualif, DateTime uneDateDeb, DateTime uneDateFin)
   {
      // TODO: implement
   }

   private String ecole;
   private String mission;
   private Double indemnite;

   public String Ecole
   {
      get
      {
         return ecole;
      }
      set
      {
         if (this.ecole != value)
            this.ecole = value;
      }
   }
   
   public String Mission
   {
      get
      {
         return mission;
      }
      set
      {
         if (this.mission != value)
            this.mission = value;
      }
   }
   
   public Double Indemnite
   {
      get
      {
         return indemnite;
      }
      set
      {
         if (this.indemnite != value)
            this.indemnite = value;
      }
   }

}