/***********************************************************************
 * Module:  Interim.cs
 * Author:  Renaud
 * Purpose: Classe de l'objet Interim h�ritant de Contrat -> ContratTemporaire
 ***********************************************************************/

using System;

public class Interim : ContratTemporaire
{
   /// <summary>
   /// M�thode d'affichage des informations de l'objet Interim sous forme de string
   /// </summary>
   /// <returns>String pr�sentant les informations d'un objet Interim</returns>
   public override String ToString()
   {
        return base.ToString() + "Agence int�rim : " + AgenceInterim;
      
   }
   
   /// <summary>
   /// Constructeur d'un objet Interim sans date de fin d�finie
   /// </summary>
   /// <param name="uneAgence">Nom de l'agence int�rim</param>
   /// <param name="unMotif">Motif du contrat</param>
   /// <param name="uneDateFinPrev">Date de fin pr�vue</param>
   /// <param name="unNum">Num�ro du contrat</param>
   /// <param name="uneQualif">Qualification</param>
   /// <param name="uneDateDeb">Date de d�but du contrat</param>
   public Interim(String uneAgence, String unMotif, DateTime uneDateFinPrev, int unNum, String uneQualif, DateTime uneDateDeb) :base(unMotif,uneDateFinPrev,unNum,uneQualif,uneDateDeb)
   {
        this.AgenceInterim = uneAgence;
   }

    /// <summary>
    /// Constructeur d'un objet Interim avec date de fin d�finie
    /// </summary>
    /// <param name="uneAgence">Nom de l'agence int�rim</param>
    /// <param name="unMotif">Motif du contrat</param>
    /// <param name="uneDateFinPrev">Date de fin pr�vue</param>
    /// <param name="unNum">Num�ro du contrat</param>
    /// <param name="uneQualif">Qualification</param>
    /// <param name="uneDateDeb">Date de d�but du contrat</param>
    /// <param name="uneDateFin">Date de fin du contrat</param>
    public Interim(String uneAgence, String unMotif, DateTime uneDateFinPrev, int unNum, String uneQualif, DateTime uneDateDeb, DateTime uneDateFin) : base(unMotif, uneDateFinPrev, unNum, uneQualif, uneDateDeb, uneDateFin)
    {
        this.AgenceInterim = uneAgence;
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

}