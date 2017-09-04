using Peng.Dylan.Common.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Peng.Dylan.Common
{
    public interface IAccountDao
    {
        /// <summary>
        /// 根据账户名查询账户
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Account GetAccountByName(string name);

        /// <summary>
        /// 添加账户
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        int AddAccount(Account account);

        /// <summary>
        /// 更新账户
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        int UpdateAccount(Account account);
    }
}