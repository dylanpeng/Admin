using Peng.Dylan.Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peng.Dylan.DAL
{
    public class PermissionConfiguration : EntityTypeConfiguration<PermissionEntity>
    {
        public PermissionConfiguration()
        {
            ToTable("permission")
            .HasKey(q => q.ID)
            //id不自增
            .Property(q => q.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
