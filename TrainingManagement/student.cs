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
    
    public partial class student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public student()
        {
            this.studyings = new HashSet<studying>();
        }
    
        public int id { get; set; }
        public string ID_Student { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public string birth_place { get; set; }
        public string household { get; set; }
        public string is_in_dormitory { get; set; }
        public string is_deleted { get; set; }
        public string avatar { get; set; }
        public Nullable<int> department_id { get; set; }
        public Nullable<int> users_id { get; set; }
    
        public virtual department department { get; set; }
        public virtual user user { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<studying> studyings { get; set; }
    }
}
