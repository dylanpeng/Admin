using Peng.Dylan.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peng.Dylan.Common
{
    public interface IRoleDao
    {
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        int AddRole(RoleEntity role);

        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        int AddPermission(PermissionEntity permission);
    }
}
