using Peng.Dylan.Common.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Peng.Dylan.Common
{
    public interface IAdminDao
    {
        /// <summary>
        /// 根据账户名查询账户
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        AdminEntity GetAdminByName(string name);

        /// <summary>
        /// 添加账户
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        int AddAdmin(AdminEntity account);

        /// <summary>
        /// 更新账户
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        int UpdateAdmin(AdminEntity account);
    }
}