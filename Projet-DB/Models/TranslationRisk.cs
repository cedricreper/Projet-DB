//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projet_DB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TranslationRisk
    {
        public int idTranslation { get; set; }
        public string translation { get; set; }
        public string FK_Language { get; set; }
        public string FK_Risk { get; set; }
    
        public virtual Language Language { get; set; }
        public virtual Risk Risk { get; set; }
    }
}
