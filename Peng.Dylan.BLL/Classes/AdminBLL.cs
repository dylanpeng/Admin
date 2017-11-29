using Peng.Dylan.Common;
using Peng.Dylan.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peng.Dylan.BLL.Classes
{
    public class AdminBLL
    {
        public static AdminEntity GetAccountByName(string name)
        {
            try
            {
                var dao = UnityInstance.GetInstanceDAL<IAdminDao>();
                var result = dao.GetAdminByName(name);
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 添加账户
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static int AddAccount(AdminEntity account)
        {
            try
            {
                var dao = UnityInstance.GetInstanceDAL<IAdminDao>();
                var result = dao.AddAdmin(account);
                return result;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static List<UserData> GetUserDataList(int pageIndex, int pageSize)
        {
            try
            {
                var dao = UnityInstance.GetInstanceDAL<IAdminDao>();
                var adminiList = dao.GetAdminEntityList(pageIndex, pageSize);
                var result = new List<UserData>();
                if (adminiList != null && adminiList.Count > 0)
                {
                    foreach (var admin in adminiList)
                    {
                        var user = new UserData();
                        user.UserId = admin.ID;
                        user.UserName = admin.Name;
                        result.Add(user);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
