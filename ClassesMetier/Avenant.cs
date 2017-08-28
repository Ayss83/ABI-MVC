/***********************************************************************
 * Module:  Avenant.cs
 * Author:  Renaud
 * Purpose: Classe m�tier de l'objet Avenant
 ***********************************************************************/

using System;

public class Avenant
{
   /// <summary>
   /// M�thode retournant le contenu d'un objet avenant sous forme de string
   /// </summary>
   /// <returns>String pr�sentant le contenu d'un objet avenant</returns>
   public override String ToString()
   {
        return "Num�ro : " + NumAvenant +
            "\nDate d'�tablissement : " + DateAvenant;
   }
   
   /// <summary>
   /// Constructeur pour un objet avenant
   /// </summary>
   /// <param name="unNum">Num�ro de l'avenant</param>
   /// <param name="uneDate">Date d'�tablissement de l'avenant</param>
   public Avenant(int unNum, DateTime uneDate)
   {
        this.NumAvenant = unNum;
        this.DateAvenant = uneDate;
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