/***********************************************************************
 * Module:  ListAugmentationSalaire.cs
 * Author:  Renaud
 * Purpose: Classe m�tier d'un objet AugmentationSalaire
 ***********************************************************************/

using System;

public class AugmentationSalaire
{
   /// <summary>
   /// M�thode retournant les informations d'un objet AugmentationSalaire sous forme de string
   /// </summary>
   /// <returns>String pr�sentant les informations d'un objet AugmentationSalaire</returns>
   public override String ToString()
   {
        return "Date : " + Date + "\nMontant : " + Augmentation;
   }

   private DateTime date;
   private decimal augmentation;

    /// <summary>
    /// Constructeur d'un objet AugmentationSalaire
    /// </summary>
    /// <param name="uneDate">Date de l'augmentation</param>
    /// <param name="uneAugmentation">Montant de l'augmentation</param>
    public AugmentationSalaire(DateTime uneDate,decimal uneAugmentation)
    {
        this.Date = uneDate;
        this.Augmentation = uneAugmentation;
    }

    public DateTime Date
    {
        get
        {
            return date;
        }

        set
        {
            date = value;
        }
    }

    public decimal Augmentation
    {
        get
        {
            return augmentation;
        }

        set
        {
            augmentation = value;
        }
    }
}