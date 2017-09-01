/***********************************************************************
 * Module:  ListeCollab.cs
 * Author:  Renaud
 * Purpose: Classe métier de l'objet liste de collaborateurs listeCollab
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Data;

public class ListeCollab
{
    private SortedDictionary<int,Collaborateur> collaborateurs;
    private DataTable datatableCollab;
   
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

    /// <summary>
    /// Méthode recréant la datatable et l'alimentant avec le contenu du dictionnaire
    /// </summary>
    /// <returns>La datatable listant les collaborateurs</returns>
    public DataTable ListerCollab()
    {
        datatableCollab = new DataTable();
        datatableCollab.Columns.Add(new DataColumn("Matricule", typeof(Int32)));
        datatableCollab.Columns.Add(new DataColumn("Nom", typeof(String)));
        datatableCollab.Columns.Add(new DataColumn("Prénom", typeof(String)));
        datatableCollab.Columns.Add(new DataColumn("Fonction", typeof(String)));
        datatableCollab.Columns.Add(new DataColumn("Statut", typeof(String)));

        foreach(KeyValuePair<int,Collaborateur> kvp in collaborateurs)
        {
            DataRow dr = datatableCollab.NewRow();
            dr[0] = kvp.Key;
            dr[1] = kvp.Value.NomCollabo;
            dr[2] = kvp.Value.PrenomCollabo;
            dr[3] = kvp.Value.FonctionCollabo;
            dr[4] = kvp.Value.Statut;

            datatableCollab.Rows.Add(dr);
        }
        return datatableCollab;
    }
}