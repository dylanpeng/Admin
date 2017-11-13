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
    /// 权限实体
    /// </summary>
    [Table("permission")]
    public class PermissionEntity
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
        [Column("PERMISSION_NAME")]
        public string PermissionName { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [Column("INDEX")]
        public int Index { get; set; }

        /// <summary>
        /// 层级
        /// </summary>
        [Column("LEVEL")]
        public int Level { get; set; }

        /// <summary>
        /// 当前层级
        /// </summary>
        [Column("PARENT_LEVEL")]
        public int ParentLevel { get; set; }
    }
}
