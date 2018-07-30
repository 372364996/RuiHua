
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using RuiHuaComponents.Domains;

namespace RuiHuaComponents.Repositories.Ef
{
    public class RuiHuaDbConfiguration : DbConfiguration
    {
        public RuiHuaDbConfiguration()
        {
            this.SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy(3, TimeSpan.FromSeconds(10)));
        }
    }
    [DbConfigurationType(typeof(RuiHuaDbConfiguration))]
    public class RuiHuaDbContext : DbContext
    {
      
        private string guid = Guid.NewGuid().ToString();
        public string InstanceId
        {
            get
            {
                return guid;
            }
        }
        public RuiHuaDbContext()
            : base("RuiHuaDb")
        {
        }
        public RuiHuaDbContext(String connString)
            : base(connString)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserInfo>().ToTable("UserInfo");
            modelBuilder.Entity<Vacation>().ToTable("Vacation");
            

        }
        public class VacationDetailMapping : EntityTypeConfiguration<VacationDetail>
        {
            public VacationDetailMapping()
            {
                ToTable("VacationDetail");

                HasRequired(c => c.UserInfo)
                    .WithMany(c => c.VacationDetails)
                    .HasForeignKey(c => c.UserID)
                    .WillCascadeOnDelete(false);

                HasRequired(c => c.Vacation)
                    .WithMany(c => c.VacationDetails)
                    .HasForeignKey(c => c.VacationType)
                    .WillCascadeOnDelete(false);
            }
        }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<Vacation> Vacation { get; set; }
        public DbSet<VacationDetail> VacationDetail { get; set; }
    }

   

}