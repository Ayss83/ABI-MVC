/***********************************************************************
 * Module:  Interim.cs
 * Author:  Renaud
 * Purpose: Classe de l'objet Interim héritant de Contrat -> ContratTemporaire
 ***********************************************************************/

using System;

namespace ClassesMetier
{

    public class MInterim : MContratTemporaire
    {
   
       /// <summary>
       /// Constructeur d'un objet Interim sans date de fin définie
       /// </summary>
       /// <param name="uneAgence">Nom de l'agence intérim</param>
       /// <param name="unMotif">Motif du contrat</param>
       /// <param name="uneDateFinPrev">Date de fin prévue</param>
       /// <param name="unNum">Numéro du contrat</param>
       /// <param name="uneQualif">Qualification</param>
       /// <param name="uneDateDeb">Date de début du contrat</param>
       public MInterim(String uneAgence, String unMotif, DateTime uneDateFinPrev, int unNum, String uneQualif, DateTime uneDateDeb) :base(unMotif,uneDateFinPrev,unNum,uneQualif,uneDateDeb)
        {
            initInterim(uneAgence);
        }

        /// <summary>
        /// Constructeur d'un objet Interim avec date de fin définie
        /// </summary>
        /// <param name="uneAgence">Nom de l'agence intérim</param>
        /// <param name="unMotif">Motif du contrat</param>
        /// <param name="uneDateFinPrev">Date de fin prévue</param>
        /// <param name="unNum">Numéro du contrat</param>
        /// <param name="uneQualif">Qualification</param>
        /// <param name="uneDateDeb">Date de début du contrat</param>
        /// <param name="uneDateFin">Date de fin du contrat</param>
        public MInterim(String uneAgence, String unMotif, DateTime uneDateFinPrev, int unNum, String uneQualif, DateTime uneDateDeb, DateTime? uneDateFin) : base(unMotif, uneDateFinPrev, unNum, uneQualif, uneDateDeb, uneDateFin)
        {
            initInterim(uneAgence);
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

       /// <summary>
       /// Méthode d'affichage des informations de l'objet Interim sous forme de string
       /// </summary>
       /// <returns>String présentant les informations d'un objet Interim</returns>
       public override String ToString()
       {
            return base.ToString() + "Agence intérim : " + AgenceInterim;
       }

        /// <summary>
        /// Méthode d'initialisation de l'attribut AgenceInterim pour les constructeurs
        /// </summary>
        /// <param name="uneAgence">Agence d'intérim</param>
        private void initInterim(string uneAgence)
        {
            this.AgenceInterim = uneAgence;
        }
    }
}