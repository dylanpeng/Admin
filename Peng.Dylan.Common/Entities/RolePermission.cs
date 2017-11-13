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
    /// 角色权限表
    /// </summary>
    [Table("role_permission")]
    public class RolePermission
    {
        /// <summary>  
        /// ID  
        /// </summary>  
        [Column("ID")]
        [Key]
        public int ID { get; set; }

        /// <summary>  
        /// 权限ID  
        /// </summary>  
        [Column("ADMIN_ID")]
        public int PermissionId { get; set; }

        /// <summary>  
        /// 角色ID  
        /// </summary>  
        [Column("ROLE_ID")]
        public int RoleId { get; set; }
    }
}
