/***********************************************************************
 * Module:  Cdd.cs
 * Author:  Renaud
 * Purpose: Classe m�tier CDD h�ritant de contrat->contratTemporaire
 ***********************************************************************/

using System;

namespace ClassesMetier
{

    public class MCdd : MContratTemporaire
    {
   
       /// <summary>
       /// Constructeur d'un objet CDD sans date de fin d�finie
       /// </summary>
       /// <param name="unSalaire">Salaire brut</param>
       /// <param name="uneDateDeb">Date de d�but du contrat</param>
       /// <param name="uneQualif">Qualification</param>
       /// <param name="unNum">Num�ro du contrat</param>
       /// <param name="unMotif">Motif d'�tablissement du contrat</param>
       /// <param name="uneDateFinPrev">Date de fin pr�vue</param>
       public MCdd(Decimal unSalaire, DateTime uneDateDeb, String uneQualif, int unNum, String unMotif, DateTime uneDateFinPrev) :base(unMotif,uneDateFinPrev,unNum,uneQualif,uneDateDeb)
        {
            initSalaire(unSalaire);
        }

        /// <summary>
        /// Constructeur d'un objet CDD sans date de fin d�finie
        /// </summary>
        /// <param name="unSalaire">Salaire brut</param>
        /// <param name="uneDateDeb">Date de d�but du contrat</param>
        /// <param name="uneQualif">Qualification</param>
        /// <param name="unNum">Num�ro du contrat</param>
        /// <param name="unMotif">Motif d'�tablissement du contrat</param>
        /// <param name="uneDateFinPrev">Date de fin pr�vue</param>
        /// <param name="uneDateFin">Date de fin du contrat</param>
        public MCdd(Decimal unSalaire, DateTime uneDateDeb, String uneQualif, int unNum, String unMotif, DateTime uneDateFinPrev, DateTime uneDateFin) :base(unMotif,uneDateFinPrev,unNum,uneQualif,uneDateDeb,uneDateFin)
       {
            initSalaire(unSalaire);
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

       /// <summary>
       /// M�thode retournant les information de l'objet CDD sous forme de string
       /// </summary>
       /// <returns>String pr�sentant le contenu de l'objet</returns>
       public override String ToString()
       {
            if (DateFinContrat != null)
            {
                return "Num�ro de contrat : " + NumContrat + "\n Qualification : " + Qualification + "\n Motif : " + Motif + "\n Salaire brut : " + SalaireBrut + "\n Date d'�tablissement du contrat : " + DateDebutContrat + "\n Date de fin pr�vue : " + DateFinPrevue + "\n Date de fin de contrat : " + DateFinContrat + "\n";
            }
            else
            {
                return "Num�ro de contrat : " + NumContrat + "\n Qualification : " + Qualification + "\n Motif : " + Motif + "\n Salaire brut : " + SalaireBrut + "\n Date d'�tablissement du contrat : " + DateDebutContrat + "\n Date de fin pr�vue : " + DateFinPrevue + "\n";

            }
        }

        /// <summary>
        /// M�thode d'initialisation du salaire dans les constructeurs
        /// </summary>
        /// <param name="unSalaire">Salaire brut</param>
        private void initSalaire(decimal unSalaire)
        {
            this.SalaireBrut = unSalaire;
        }
    }
}