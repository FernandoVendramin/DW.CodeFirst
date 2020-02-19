using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.CodeFirst.Data.Models.Configurations
{
    public class DimTimeConfiguration : EntityTypeConfiguration<DimTime>
    {
        public DimTimeConfiguration()
        {
            HasKey(x => x.DimTimeKey);
            Property(x => x.DimTimeKey).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
