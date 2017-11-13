using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peng.Dylan.Common.Entities
{
    [Table("role")]
    public class RoleEntity
    {
        /// <summary>  
        /// 用户ID  
        /// </summary>  
        [Column("ID")]
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 角色名
        /// </summary>
        [Column("ROLE_NAME")]
        public string RoleName { get; set; }
    }
}
