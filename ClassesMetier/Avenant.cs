/***********************************************************************
 * Module:  Avenant.cs
 * Author:  Renaud
 * Purpose: Classe m�tier de l'objet Avenant
 ***********************************************************************/

using System;

namespace ClassesMetier
{

    public class MAvenant
    {
       /// <summary>
       /// Constructeur pour un objet avenant
       /// </summary>
       /// <param name="unNum">Num�ro de l'avenant</param>
       /// <param name="uneDate">Date d'�tablissement de l'avenant</param>
       public MAvenant(int unNum, DateTime uneDate)
       {
            this.NumAvenant = unNum;
            this.DateAvenant = uneDate;
       }

        /// <summary>
        /// Constructeur pour un avenant avec seulement date en param�tre, le num�ro est attribu� par la DB
        /// </summary>
        /// <param name="uneDate">Date d'�tablissement de l'avenant</param>
        public MAvenant(DateTime uneDate)
        {
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
       /// M�thode retournant le contenu d'un objet avenant sous forme de string
       /// </summary>
       /// <returns>String pr�sentant le contenu d'un objet avenant</returns>
       public override String ToString()
       {
            return "Num�ro : " + NumAvenant +
                "\nDate d'�tablissement : " + DateAvenant;
       }
    }
}