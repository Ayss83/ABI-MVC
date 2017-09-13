/***********************************************************************
 * Module:  Avenant.cs
 * Author:  Renaud
 * Purpose: Classe métier de l'objet Avenant
 ***********************************************************************/

using System;

namespace ClassesMetier
{

    public class Avenant
    {
       /// <summary>
       /// Constructeur pour un objet avenant
       /// </summary>
       /// <param name="unNum">Numéro de l'avenant</param>
       /// <param name="uneDate">Date d'établissement de l'avenant</param>
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

       /// <summary>
       /// Méthode retournant le contenu d'un objet avenant sous forme de string
       /// </summary>
       /// <returns>String présentant le contenu d'un objet avenant</returns>
       public override String ToString()
       {
            return "Numéro : " + NumAvenant +
                "\nDate d'établissement : " + DateAvenant;
       }
    }
}