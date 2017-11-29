using Peng.Dylan.Common;
using Peng.Dylan.Common.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Peng.Dylan.DAL
{
    public class AdminDao : IAdminDao
    {
        /// <summary>
        /// 根据账户名查询账户
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public AdminEntity GetAdminByName(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                    return null;
                using (var context = new DContext())
                {
                    var result = context.Admins.Where(q => q.Name == name).FirstOrDefault();
                    return result;
                }
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
        public int AddAdmin(AdminEntity account)
        {
            try
            {
                if (account == null)
                    return -1;
                using (var context = new DContext())
                {
                    context.Admins.Add(account);
                    context.SaveChanges();
                    return account.ID;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        /// <summary>
        /// 更新账户
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public int UpdateAdmin(AdminEntity account)
        {
            try
            {
                if (account == null)
                    return -1;
                using (var context = new DContext())
                {
                    var dbAccount = context.Admins.Where(q => q.ID == account.ID).FirstOrDefault();
                    if (dbAccount == null)
                        return -1;
                    dbAccount.Name = account.Name;
                    dbAccount.Password = account.Password;
                    dbAccount.UpdaedDate = DateTime.Now;
                    context.SaveChanges();
                    return account.ID;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }   
        }

        /// <summary>
        /// 获取管理员列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<AdminEntity> GetAdminEntityList(int pageIndex, int pageSize)
        {
            try
            {
                if (pageIndex <=  0)
                    pageIndex = 1;
                if (pageSize <= 0)
                    pageSize = 10;
                using (var context = new DContext())
                {
                    var dbAccount = context.Admins.Where(q => q.IsDeleted == false).OrderByDescending(q => q.AddDate).Skip((pageIndex - 1) * pageSize).ToList(); ;
                    return dbAccount;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}