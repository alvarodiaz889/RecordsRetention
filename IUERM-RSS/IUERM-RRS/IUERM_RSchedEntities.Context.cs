﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IUERM_RRS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IUERM_RSchedEntities : DbContext
    {
        public IUERM_RSchedEntities()
            : base("name=IUERM_RSchedEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AreaScope> AreaScopes { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<DispositionOption> DispositionOptions { get; set; }
        public virtual DbSet<EventCode> EventCodes { get; set; }
        public virtual DbSet<GoverningPolicy> GoverningPolicies { get; set; }
        public virtual DbSet<GoverningRegulation> GoverningRegulations { get; set; }
        public virtual DbSet<GoverningStatute> GoverningStatutes { get; set; }
        public virtual DbSet<OfficeOfRecord> OfficeOfRecords { get; set; }
        public virtual DbSet<OfficialRecordMedium> OfficialRecordMediums { get; set; }
        public virtual DbSet<Retainer> Retainers { get; set; }
        public virtual DbSet<Retention> Retentions { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
