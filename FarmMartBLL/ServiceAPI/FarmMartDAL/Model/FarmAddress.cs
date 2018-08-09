//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FarmMartDAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class FarmAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FarmAddress()
        {
            this.Farm = new HashSet<Farm>();
        }
    
        public int Id { get; set; }
        public string Address { get; set; }
        public Nullable<int> StateId { get; set; }
        public Nullable<int> LocalGovermentId { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Farm> Farm { get; set; }
        public virtual LocalGovernment LocalGovernment { get; set; }
        public virtual State State { get; set; }
    }
}
