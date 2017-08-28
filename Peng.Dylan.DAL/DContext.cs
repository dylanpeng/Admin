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
        public DbSet<AccountUser> AccountUsers { get; set; }

        #endregion
    }
}
