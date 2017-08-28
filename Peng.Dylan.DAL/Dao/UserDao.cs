using Peng.Dylan.Common;
using Peng.Dylan.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peng.Dylan.DAL
{
    public class UserDao : IUserDao
    {
        public int GetUserId()
        {
            return 1;
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int AddUser(AccountUser user)
        {
            try
            {
                if (user == null)
                    return -1;
                using (var context = new DContext())
                {
                    context.AccountUsers.Add(user);
                    context.SaveChanges();
                    return user.AccountUserId;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
            return user.AccountUserId;
        }
    }


}
