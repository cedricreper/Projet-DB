﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MeditEntities : DbContext
    {
        public MeditEntities()
            : base("name=MeditEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Exposition> Expositions { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Link> Links { get; set; }
        public virtual DbSet<Profession> Professions { get; set; }
        public virtual DbSet<Risk> Risks { get; set; }
        public virtual DbSet<Sector> Sectors { get; set; }
        public virtual DbSet<Submission> Submissions { get; set; }
        public virtual DbSet<SubmittedJob> SubmittedJobs { get; set; }
        public virtual DbSet<TranslationExam> TranslationExams { get; set; }
        public virtual DbSet<TranslationProfession> TranslationProfessions { get; set; }
        public virtual DbSet<TranslationRisk> TranslationRisks { get; set; }
        public virtual DbSet<TypeExam> TypeExams { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
    }
}
