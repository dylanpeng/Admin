using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace Peng.Dylan.Common.Entities
{
    [Table("admin")]
    public class AdminEntity
    {
        /// <summary>  
        /// 用户ID  
        /// </summary>  
        [Column("ID")]
        [Key]
        public int ID { get; set; }

        /// <summary>  
        /// 账号  
        /// </summary>  
        [Column("NAME")]
        public string Name { get; set; }

        /// <summary>  
        /// 密码  
        /// </summary>  
        [Column("PASSWORD")]
        public string Password { get; set; }

        /// <summary>  
        /// 添加时间  
        /// </summary>  
        [Column("ADD_DATE")]
        public DateTime? AddDate { get; set; }

        /// <summary>  
        /// 更新时间  
        /// </summary>  
        [Column("UPDATED_DATE")]
        public DateTime? UpdaedDate { get; set; }

        /// <summary>  
        /// 删除时间  
        /// </summary>  
        [Column("DELETED_DATE")]
        public DateTime? DeletedDate { get; set; }

        /// <summary>  
        /// 是否删除  
        /// </summary>  
        [Column("IS_DELETED")]
        public bool IsDeleted { get; set; }
    }
}