using Peng.Dylan.Common;
using Peng.Dylan.Common.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Peng.Dylan.DAL
{
    public class AccountDao : IAccountDao
    {
        /// <summary>
        /// 根据账户名查询账户
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Account GetAccountByName(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                    return null;
                using (var context = new DContext())
                {
                    var result = context.Accounts.Where(q => q.Name == name).FirstOrDefault();
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
        public int AddAccount(Account account)
        {
            try
            {
                if (account == null)
                    return -1;
                using (var context = new DContext())
                {
                    context.Accounts.Add(account);
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
        public int UpdateAccount(Account account)
        {
            try
            {
                if (account == null)
                    return -1;
                using (var context = new DContext())
                {
                    var dbAccount = context.Accounts.Where(q => q.ID == account.ID).FirstOrDefault();
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
    }
}