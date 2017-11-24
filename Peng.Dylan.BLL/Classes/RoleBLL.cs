using Peng.Dylan.Common;
using Peng.Dylan.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peng.Dylan.BLL.Classes
{
    public class RoleBLL
    {
        /// <summary>
        /// 添加账户
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public static int AddRole(RoleEntity role)
        {
            try
            {
                var dao = UnityInstance.GetInstanceDAL<IRoleDao>();
                var result = dao.AddRole(role);
                return result;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        public static int AddPermission(PermissionEntity permission)
        {
            try
            {
                var dao = UnityInstance.GetInstanceDAL<IRoleDao>();
                var result = dao.AddPermission(permission);
                return result;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
