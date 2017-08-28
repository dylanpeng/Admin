using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peng.Dylan.Common.Entities
{
    [Table("user")]
    public class AccountUser
    {
        /// <summary>  
        /// 用户ID  
        /// </summary>  
        [Column("ID")]
        [Key]
        public int AccountUserId { get; set; }

        /// <summary>  
        /// 用户名  
        /// </summary>  
        public string Name { get; set; }

        /// <summary>  
        /// 年龄  
        /// </summary>  
        public int Age { get; set; }

        /// <summary>  
        /// 性别  
        /// </summary>  
        public bool Sex { get; set; }
    }
}
