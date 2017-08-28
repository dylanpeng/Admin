using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peng.Dylan.Common
{
    public interface IUserDao
    {
        /// <summary>
        /// 获取用户ID
        /// </summary>
        /// <returns></returns>
        int GetUserId();
    }
}
