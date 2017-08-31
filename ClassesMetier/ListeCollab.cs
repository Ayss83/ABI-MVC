/***********************************************************************
 * Module:  ListeCollab.cs
 * Author:  Renaud
 * Purpose: Classe métier de l'objet liste de collaborateurs listeCollab
 ***********************************************************************/

using System;
using System.Collections.Generic;

public class ListeCollab
{
   public SortedDictionary<int,Collaborateur> collaborateurs;
   
   /// <summary>
   /// Méthode d'ajout d'un collaborateur dans le dictionnaire
   /// </summary>
   /// <param name="newCollaborateur">Instance d'un objet collaborateur</param>
   public void AjouterCollaborateur(Collaborateur newCollaborateur)
   {
      if (newCollaborateur == null)
         return;
      if (this.collaborateurs == null)
         this.collaborateurs = new SortedDictionary<int, Collaborateur>();
      if (!this.collaborateurs.ContainsKey(newCollaborateur.Matricule))
         this.collaborateurs.Add(newCollaborateur.Matricule,newCollaborateur);
   }

   /// <summary>
   /// Méthode retournant le contenu du la liste (Matricule + Nom) sous forme de string
   /// </summary>
   /// <returns>String contenant les paires matricule/nom de la listeCollab</returns>
   public override String ToString()
   {
        string retourListe="";
        foreach(KeyValuePair<int,Collaborateur> kvp in collaborateurs)
        {
            retourListe = retourListe + "Matricule : " + kvp.Key + ", Nom : " + kvp.Value.NomCollabo + "\n";
        }
      return retourListe;
   }
}