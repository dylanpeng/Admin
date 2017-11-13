using Peng.Dylan.Common.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peng.Dylan.DAL
{
    public class RoleConfiguration : EntityTypeConfiguration<RoleEntity>
    {
        public RoleConfiguration()
        {
            ToTable("role")
            .HasKey(q => q.ID);
        }
    }
}
