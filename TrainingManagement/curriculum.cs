//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrainingManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class curriculum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public curriculum()
        {
            this.module = new HashSet<module>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string training_system { get; set; }
        public string training_type { get; set; }
        public string school_year { get; set; }
        public Nullable<int> major_id { get; set; }
    
        public virtual major major { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<module> module { get; set; }
    }
}
