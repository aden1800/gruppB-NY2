﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gruppBNY.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gruppBEntities : DbContext
    {
        public gruppBEntities()
            : base("name=gruppBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<category> category { get; set; }
        public virtual DbSet<competence> competence { get; set; }
        public virtual DbSet<core_abilities> core_abilities { get; set; }
        public virtual DbSet<customer> customer { get; set; }
        public virtual DbSet<education> education { get; set; }
        public virtual DbSet<Freelancer> Freelancer { get; set; }
        public virtual DbSet<languages> languages { get; set; }
        public virtual DbSet<work_history> work_history { get; set; }

        public System.Data.Entity.DbSet<gruppBNY.ViewModels.freelancer_competence> freelancer_competence { get; set; }
    }
}
