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
    
    public partial class Link
    {
        public int idLink { get; set; }
        public string FK_Risk { get; set; }
        public string FK_TypeExam { get; set; }
    
        public virtual Risk Risk { get; set; }
        public virtual TypeExam TypeExam { get; set; }
    }
}
