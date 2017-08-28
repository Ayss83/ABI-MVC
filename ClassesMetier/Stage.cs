/***********************************************************************
 * Module:  Stage.cs
 * Author:  Renaud
 * Purpose: Classe m�tier de l'objet Stage
 ***********************************************************************/

using System;

public class Stage : ContratTemporaire
{
   public override String ToString()
   {
            return base.ToString() +
                "Ecole : " + this.Ecole +
                "\nMission : " + this.Mission +
                "\nIndemnit� : " + this.Indemnite + "\n";
    }
   
   /// <summary>
   /// Constructeur d'initialisation d'un objet Stage sans date de fin d�finie
   /// </summary>
   /// <param name="uneEcole">Ecole du stagiaire</param>
   /// <param name="uneMission">Mission de stage</param>
   /// <param name="uneIndemnite">Indemnit� de stage</param>
   /// <param name="unMotif">Motif du stage</param>
   /// <param name="uneDateFinPrev">Date de fin pr�vue</param>
   /// <param name="unNum">Num�ro du contrat de stage</param>
   /// <param name="uneQualif">Qualification</param>
   /// <param name="uneDateDeb">Date de d�but du stage</param>
   public Stage(String uneEcole, String uneMission, Decimal uneIndemnite, String unMotif, DateTime uneDateFinPrev, int unNum, String uneQualif, DateTime uneDateDeb) :base(unMotif,uneDateFinPrev,unNum,uneQualif,uneDateDeb)
   {
        this.Ecole = uneEcole;
        this.Mission = uneMission;
        this.Indemnite = uneIndemnite;
   }
   
   /// <summary>
   /// Constructeur d'initialisation d'un objet Stage avec date de fin d�finie
   /// </summary>
   /// <param name="uneEcole">Ecole du stagiaire</param>
   /// <param name="uneMission">Mission de stage</param>
   /// <param name="uneIndemnite">Indemnit� de stage</param>
   /// <param name="unMotif">Motif du stage</param>
   /// <param name="uneDateFinPrev">Date de fin pr�vue</param>
   /// <param name="unNum">Num�ro du contrat de stage</param>
   /// <param name="uneQualif">Qualification</param>
   /// <param name="uneDateDeb">Date de d�but du stage</param>
   /// <param name="uneDateFin">Date de fin du stage</param>
   public Stage(String uneEcole, String uneMission, Decimal uneIndemnite, String unMotif, DateTime uneDateFinPrev, int unNum, String uneQualif, DateTime uneDateDeb, DateTime uneDateFin) : base(unMotif,uneDateFinPrev,unNum,uneQualif,uneDateDeb,uneDateFin)
   {
        this.Ecole = uneEcole;
        this.Mission = uneMission;
        this.Indemnite = uneIndemnite;
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

}