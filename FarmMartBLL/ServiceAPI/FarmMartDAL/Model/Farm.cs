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
    
    public partial class Farm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Farm()
        {
            this.FarmCrop = new HashSet<FarmCrop>();
        }
    
        public int Id { get; set; }
        public Nullable<int> PersonId { get; set; }
        public string FarmName { get; set; }
        public string EmailAddress { get; set; }
        public string PhotoPath { get; set; }
        public bool IsActive { get; set; }
        public bool IsVerified { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> AddressId { get; set; }
    
        public virtual FarmAddress FarmAddress { get; set; }
        public virtual Person Person { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FarmCrop> FarmCrop { get; set; }
    }
}
