using Peng.Dylan.Common.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peng.Dylan.DAL
{
    public class DContext : DbContext
    {
        /// <summary>  
        /// 添加构造函数,name为config文件中数据库连接字符串的name  
        /// </summary>  
        public DContext() : base("name=MyContext")
        {

        }

        #region 数据集  
        public DbSet<AdminEntity> Admins { get; set; }
        public DbSet<AccountUser> AccountUsers { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<PermissionEntity> Permissions { get; set; }
        public DbSet<RoleAdmin> RoleAdmins { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        #endregion

        #region Fluent API配置
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new RoleConfiguration());
        }
        #endregion
    }
}
