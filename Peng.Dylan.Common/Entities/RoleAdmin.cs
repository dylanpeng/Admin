using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peng.Dylan.Common.Entities
{
    /// <summary>
    /// 用户角色表
    /// </summary>
    [Table("role_admin")]
    public class RoleAdmin
    {
        /// <summary>  
        /// ID  
        /// </summary>  
        [Column("ID")]
        [Key]
        public int ID { get; set; }

        /// <summary>  
        /// 用户ID  
        /// </summary>  
        [Column("ADMIN_ID")]
        public int AdminId { get; set; }

        /// <summary>  
        /// 角色ID  
        /// </summary>  
        [Column("ROLE_ID")]
        public int RoleId { get; set; }
    }
}
