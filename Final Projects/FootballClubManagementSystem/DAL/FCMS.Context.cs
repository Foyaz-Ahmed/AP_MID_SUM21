//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FCMSEntities : DbContext
    {
        public FCMSEntities()
            : base("name=FCMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClubAdmin> ClubAdmins { get; set; }
        public virtual DbSet<Coach> Coaches { get; set; }
        public virtual DbSet<Fitness> Fitnesses { get; set; }
        public virtual DbSet<Fixture> Fixtures { get; set; }
        public virtual DbSet<Formation> Formations { get; set; }
        public virtual DbSet<Performance> Performances { get; set; }
        public virtual DbSet<Physio> Physios { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<LogIn> LogIns { get; set; }
    }
}
