//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UmbracoHelios
{
    using System;
    using System.Collections.Generic;
    
    public partial class cmsTag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cmsTag()
        {
            this.cmsTagRelationships = new HashSet<cmsTagRelationship>();
            this.cmsTags1 = new HashSet<cmsTag>();
        }
    
        public int id { get; set; }
        public string tag { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string group { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cmsTagRelationship> cmsTagRelationships { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cmsTag> cmsTags1 { get; set; }
        public virtual cmsTag cmsTag1 { get; set; }
    }
}
