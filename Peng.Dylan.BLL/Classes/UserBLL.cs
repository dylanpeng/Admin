using Peng.Dylan.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Peng.Dylan.BLL.Classes
{
    public class UserBLL
    {
        public static int GetUserId()
        {
            int result = 0;
            try
            {
                var dao = UnityInstance.GetInstanceDAL<IUserDao>();
                result = dao.GetUserId();
            }
            catch (Exception ex)
            {
                return -1;
            }
            return result;
        }
    }
}