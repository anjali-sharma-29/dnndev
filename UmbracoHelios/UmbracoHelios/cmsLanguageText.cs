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
    
    public partial class cmsLanguageText
    {
        public int pk { get; set; }
        public int languageId { get; set; }
        public System.Guid UniqueId { get; set; }
        public string value { get; set; }
    
        public virtual umbracoLanguage umbracoLanguage { get; set; }
    }
}
