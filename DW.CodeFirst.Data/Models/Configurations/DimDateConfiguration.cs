using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.CodeFirst.Data.Models.Configurations
{
    public class DimDateConfiguration : EntityTypeConfiguration<DimDate>
    {
        public DimDateConfiguration()
        {
            HasKey(x => x.DimDateKey);
            Property(x => x.DimDateKey).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
