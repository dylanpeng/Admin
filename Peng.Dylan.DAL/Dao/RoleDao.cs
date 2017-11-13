using Peng.Dylan.Common;
using Peng.Dylan.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peng.Dylan.DAL
{
    public class RoleDao : IRoleDao
    {
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int AddRole(RoleEntity role)
        {   
            try
            {
                if (role == null)
                    return -1;
                using (var context = new DContext())
                {
                    context.Roles.Add(role);
                    context.SaveChanges();
                    return role.ID;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int AddPermission(PermissionEntity permission)
        {
            try
            {
                if (permission == null)
                    return -1;
                using (var context = new DContext())
                {
                    context.Permissions.Add(permission);
                    context.SaveChanges();
                    return permission.ID;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
