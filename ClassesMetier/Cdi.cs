/***********************************************************************
 * Module:  Cdi.cs
 * Author:  Renaud
 * Purpose: Classe m�tier de l'objet CDI h�ritant de Contrat
 ***********************************************************************/

using System;

namespace ClassesMetier
{

    public class MCdi : MContrat
    {
        /// <summary>
        /// Constructeur d'un objet CDI avec date de fin d�finie
        /// </summary>
        /// <param name="unSalaire">Salaire brut</param>
        /// <param name="unNum">Num�ro du contrat</param>
        /// <param name="uneQualif">Qualification</param>
        /// <param name="uneDateDeb">Date de d�but du contrat</param>
        /// <param name="uneDateFin">Date de fin du contrat</param>
        public MCdi(Decimal unSalaire, int unNum, String uneQualif, DateTime uneDateDeb, DateTime? uneDateFin) :base(unNum,uneQualif,uneDateDeb,uneDateFin)
        {
            initSalaire(unSalaire);
        }


        /// <summary>
        /// Constructeur d'un objet CDI sans date de fin d�finie
        /// </summary>
        /// <param name="unSalaire">Salaire brut</param>
        /// <param name="unNum">Num�ro du contrat</param>
        /// <param name="uneQualif">Qualification</param>
        /// <param name="uneDateDeb">Date de d�but du contrat</param>
        public MCdi(Decimal unSalaire, int unNum, String uneQualif, DateTime uneDateDeb) :base(unNum,uneQualif,uneDateDeb)
       {
            initSalaire(unSalaire);
        }


       private Decimal salaireBrut;

       public Decimal SalaireBrut
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
        /// M�thode retournant le contenu d'un objet CDI sous forme de string
        /// </summary>
        /// <returns>String pr�sentant le contenu de l'objet CDI</returns>
        public override String ToString()
       {
            if (DateFinContrat != null)
            {
                return "Num�ro de contrat : " + NumContrat + "\n Qualification : " + Qualification + "\n Salaire brut : " + SalaireBrut + "\n Date d'�tablissement du contrat : " + DateDebutContrat + "\n Date de fin de contrat : " + DateFinContrat + "\n";
            }
            else
            {
                return "Num�ro de contrat : " + NumContrat + "\n Qualification : " + Qualification + "\n Salaire brut : " + SalaireBrut + "\n Date d'�tablissement du contrat : " + DateDebutContrat + "\n";

            }
        }

        /// <summary>
        /// M�thode d'initialisation du montant du salaire
        /// </summary>
        /// <param name="unSalaire">Salaire brut</param>
        private void initSalaire(decimal unSalaire)
        {
            this.SalaireBrut = unSalaire;
        }
    }
}