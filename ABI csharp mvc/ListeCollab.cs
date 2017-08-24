/***********************************************************************
 * Module:  ListeCollab.cs
 * Author:  CDI14
 * Purpose: Definition of the Class ListeCollab
 ***********************************************************************/

using System;

public class ListeCollab
{
   public override String ToString()
   {
      // TODO: implement
      return null;
   }

   public System.Collections.ArrayList collaborateur;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetCollaborateur()
   {
      if (collaborateur == null)
         collaborateur = new System.Collections.ArrayList();
      return collaborateur;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetCollaborateur(System.Collections.ArrayList newCollaborateur)
   {
      RemoveAllCollaborateur();
      foreach (Collaborateur oCollaborateur in newCollaborateur)
         AddCollaborateur(oCollaborateur);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddCollaborateur(Collaborateur newCollaborateur)
   {
      if (newCollaborateur == null)
         return;
      if (this.collaborateur == null)
         this.collaborateur = new System.Collections.ArrayList();
      if (!this.collaborateur.Contains(newCollaborateur))
         this.collaborateur.Add(newCollaborateur);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveCollaborateur(Collaborateur oldCollaborateur)
   {
      if (oldCollaborateur == null)
         return;
      if (this.collaborateur != null)
         if (this.collaborateur.Contains(oldCollaborateur))
            this.collaborateur.Remove(oldCollaborateur);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllCollaborateur()
   {
      if (collaborateur != null)
         collaborateur.Clear();
   }

}