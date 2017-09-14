/***********************************************************************
 * Module:  ContratTemporaire.cs
 * Author:  Renaud
 * Purpose: Classe m�tier ContratTemporaire h�ritant de Contrat
 ***********************************************************************/

using System;

namespace ClassesMetier
{

    public abstract class MContratTemporaire : MContrat
    {
       /// <summary>
       /// Constructeur de Contrat temporaire avec date de fin d�finie
       /// </summary>
       /// <param name="unMotif">Motif du contrat temporaire</param>
       /// <param name="uneDateFinPrev">Date de fin pr�vue</param>
       /// <param name="unNum">Num�ro du contrat</param>
       /// <param name="uneQualif">Qualification</param>
       /// <param name="uneDateDeb">Date de d�but du cotnrat</param>
       /// <param name="uneDateFin">Date de fin du contrat</param>
       public MContratTemporaire(String unMotif, DateTime uneDateFinPrev, int unNum, String uneQualif, DateTime uneDateDeb, DateTime? uneDateFin) :base(unNum,uneQualif,uneDateDeb,uneDateFin)
        {
            initContratTemp(unMotif, uneDateFinPrev);
        }


        /// <summary>
        /// Constructeur de Contrat temporaire sans date de fin d�finie
        /// </summary>
        /// <param name="unMotif">Motif du contrat temporaire</param>
        /// <param name="uneDateFinPrev">Date de fin pr�vue</param>
        /// <param name="unNum">Num�ro du contrat</param>
        /// <param name="uneQualif">Qualification</param>
        /// <param name="uneDateDeb">Date de d�but du contrat</param>
        public MContratTemporaire(String unMotif, DateTime uneDateFinPrev, int unNum, String uneQualif, DateTime uneDateDeb) :base(unNum,uneQualif,uneDateDeb)
        {
            initContratTemp(unMotif, uneDateFinPrev);
        }

       protected String motif;
       protected DateTime dateFinPrevue;

       public String Motif
       {
          get
          {
             return motif;
          }
          set
          {
             if (this.motif != value)
                this.motif = value;
          }
       }
   
       public DateTime DateFinPrevue
       {
          get
          {
             return dateFinPrevue;
          }
          set
          {
             if (this.dateFinPrevue != value)
                this.dateFinPrevue = value;
          }
       }

        /// <summary>
        /// M�thode de retour du contenu d'un objet ContratTemporaire sous forme de string
        /// </summary>
        /// <returns>String pr�sentant contenu de l'objet</returns>
        public override String ToString()
       {
            return base.ToString() + "Motif : " + Motif +
                "\nDate de fin pr�vue : " + DateFinPrevue + "\n";
       }

        /// <summary>
        /// M�thode d'initialisation des attributs sp�cifiques � un ContratTemporaire
        /// </summary>
        /// <param name="unMotif">Motif du contrat</param>
        /// <param name="uneDateFinPrev">Date de fin pr�vue</param>
        private void initContratTemp(string unMotif, DateTime uneDateFinPrev)
        {
            this.Motif = unMotif;
            this.DateFinPrevue = uneDateFinPrev;
        }
    }
}