/***********************************************************************
 * Module:  Cdi.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Cdi
 ***********************************************************************/

using System;

public class Cdi : Contrat
{
   public Cdi(Double unSalaire, int unNum, String uneQualif, DateTime uneDateDeb, DateTime uneDateFin)
   {
      // TODO: implement
   }
   
   public Cdi(Double unSalaire, int unNum, String uneQualif, DateTime uneDateDeb)
   {
      // TODO: implement
   }
   
   public override String ToString()
   {
      // TODO: implement
      return null;
   }

   private Double salaireBrut;

   public Double SalaireBrut
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