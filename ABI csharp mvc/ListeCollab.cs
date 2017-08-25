/***********************************************************************
 * Module:  ListeCollab.cs
 * Author:  CDI14
 * Purpose: Definition of the Class ListeCollab
 ***********************************************************************/

using System;
using System.Collections.Generic;

public class ListeCollab
{
   /// <summary>
   /// 
   /// </summary>
   /// <returns></returns>
   public override String ToString()
   {
        string retourListe="";
        foreach(KeyValuePair<int,Collaborateur> kvp in collaborateurs)
        {
            retourListe = retourListe + "Matricule : " + kvp.Key + ", Nom : " + kvp.Value.NomCollabo + "\n";
        }
      return retourListe;
   }

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

}