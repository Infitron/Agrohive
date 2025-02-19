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
    
    public partial class FarmCrop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FarmCrop()
        {
            this.Planting = new HashSet<Planting>();
            this.Pricing = new HashSet<Pricing>();
        }
    
        public int Id { get; set; }
        public Nullable<int> FarmId { get; set; }
        public Nullable<int> CropId { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public bool IsSelected { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Crop Crop { get; set; }
        public virtual Farm Farm { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Planting> Planting { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pricing> Pricing { get; set; }
    }
}
