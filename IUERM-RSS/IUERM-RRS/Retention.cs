//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IUERM_RRS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Retention
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Retention()
        {
            this.Schedules = new HashSet<Schedule>();
        }
    
        public int RET_Id { get; set; }
        public string RET_BasedOnCode { get; set; }
        public string RET_BaseOnDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
