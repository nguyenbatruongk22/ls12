//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pvv_2210900085.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class nhaxuatban
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nhaxuatban()
        {
            this.sach = new HashSet<sach>();
        }
        [Display(Name ="ma danh muc")]
        public int manxb { get; set; }
        [Display(Name = "ten danh muc ")]

        public string tennhaxuatban { get; set; }
        [Display(Name = "so luong")]

        public Nullable<int> tongdausach { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sach> sach { get; set; }
    }
}
