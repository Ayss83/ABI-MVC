//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABIDAO
{
    using System;
    using System.Collections.Generic;
    
    public abstract partial class Contrat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contrat()
        {
            this.Cloture = false;
            this.Avenant = new HashSet<Avenant>();
        }
    
        internal int NumContrat { get; set; }
        internal string Qualification { get; set; }
        internal System.DateTime DateDebutContrat { get; set; }
        internal Nullable<System.DateTime> DateFinContrat { get; set; }
        public bool Cloture { get; set; }
    
        public virtual Collaborateur Collaborateur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avenant> Avenant { get; set; }
    }
}
