/***********************************************************************
 * Module:  Stage.cs
 * Author:  Renaud
 * Purpose: Classe métier de l'objet Stage
 ***********************************************************************/

using System;

namespace ClassesMetier
{

    public class MStage : MContratTemporaire
    {
   
       /// <summary>
       /// Constructeur d'initialisation d'un objet Stage sans date de fin définie
       /// </summary>
       /// <param name="uneEcole">Ecole du stagiaire</param>
       /// <param name="uneMission">Mission de stage</param>
       /// <param name="uneIndemnite">Indemnité de stage</param>
       /// <param name="unMotif">Motif du stage</param>
       /// <param name="uneDateFinPrev">Date de fin prévue</param>
       /// <param name="unNum">Numéro du contrat de stage</param>
       /// <param name="uneQualif">Qualification</param>
       /// <param name="uneDateDeb">Date de début du stage</param>
       public MStage(String uneEcole, String uneMission, Decimal uneIndemnite, String unMotif, DateTime uneDateFinPrev, int unNum, String uneQualif, DateTime uneDateDeb) :base(unMotif,uneDateFinPrev,unNum,uneQualif,uneDateDeb)
        {
            initStage(uneEcole, uneMission, uneIndemnite);
        }

        /// <summary>
        /// Constructeur d'initialisation d'un objet Stage avec date de fin définie
        /// </summary>
        /// <param name="uneEcole">Ecole du stagiaire</param>
        /// <param name="uneMission">Mission de stage</param>
        /// <param name="uneIndemnite">Indemnité de stage</param>
        /// <param name="unMotif">Motif du stage</param>
        /// <param name="uneDateFinPrev">Date de fin prévue</param>
        /// <param name="unNum">Numéro du contrat de stage</param>
        /// <param name="uneQualif">Qualification</param>
        /// <param name="uneDateDeb">Date de début du stage</param>
        /// <param name="uneDateFin">Date de fin du stage</param>
        public MStage(String uneEcole, String uneMission, Decimal uneIndemnite, String unMotif, DateTime uneDateFinPrev, int unNum, String uneQualif, DateTime uneDateDeb, DateTime? uneDateFin) : base(unMotif,uneDateFinPrev,unNum,uneQualif,uneDateDeb,uneDateFin)
        {
            initStage(uneEcole, uneMission, uneIndemnite);
        }

        private String ecole;
       private String mission;
       private Decimal indemnite;

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
   
       public Decimal Indemnite
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

       /// <summary>
       /// Méthode de retour des informations d'un objet Stage sous forme de string
       /// </summary>
       /// <returns>String contenant les informations</returns>
       public override String ToString()
       {
                return base.ToString() +
                    "Ecole : " + this.Ecole +
                    "\nMission : " + this.Mission +
                    "\nIndemnité : " + this.Indemnite + "\n";
        }

        /// <summary>
        /// Méthode d'initialisation des attributs spécifiques aux stages appelée par les constructeurs
        /// </summary>
        /// <param name="uneEcole">Ecole du stagiaire</param>
        /// <param name="uneMission">Mission du stagiaire</param>
        /// <param name="uneIndemnite">Indemnité de stage</param>
        private void initStage(string uneEcole, string uneMission, decimal uneIndemnite)
        {
            this.Ecole = uneEcole;
            this.Mission = uneMission;
            this.Indemnite = uneIndemnite;
        }
    }
}