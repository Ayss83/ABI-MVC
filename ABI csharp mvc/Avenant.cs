/***********************************************************************
 * Module:  Avenant.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Avenant
 ***********************************************************************/

using System;

public class Avenant
{
   public String ToString()
   {
      // TODO: implement
      return null;
   }
   
   public Avenant(int unNum, DateTime uneDate)
   {
      // TODO: implement
   }

   private int numAvenant;
   private DateTime dateAvenant;

   public int NumAvenant
   {
      get
      {
         return numAvenant;
      }
      set
      {
         if (this.numAvenant != value)
            this.numAvenant = value;
      }
   }
   
   public DateTime DateAvenant
   {
      get
      {
         return dateAvenant;
      }
      set
      {
         if (this.dateAvenant != value)
            this.dateAvenant = value;
      }
   }

}