using DW.CodeFirst.Data.Models;
using DW.CodeFirst.Data.Models.Configurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.CodeFirst.Data
{
    public partial class Context : DbContext
    {
        public Context()
            : base("DW.CodeFirst")
        {
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<DimDate> DimDate { get; set; }
        public DbSet<DimTime> DimTime { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new DimTimeConfiguration());
            modelBuilder.Configurations.Add(new DimDateConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
