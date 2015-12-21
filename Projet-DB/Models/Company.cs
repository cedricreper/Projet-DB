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
    
    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            this.SubmittedJobs = new HashSet<SubmittedJob>();
        }
    
        public int idCompany { get; set; }
        public string denomination { get; set; }
        public int adressNum { get; set; }
        public string adressStreet { get; set; }
        public int adressPostCode { get; set; }
        public string adressLocality { get; set; }
        public string telNum { get; set; }
        public int nbSubmittedWorkerDeb { get; set; }
        public int nbNonSubmittedWorkerDeb { get; set; }
        public string FK_Sector { get; set; }
    
        public virtual Sector Sector { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubmittedJob> SubmittedJobs { get; set; }
    }
}
