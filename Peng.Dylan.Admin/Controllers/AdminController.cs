using Peng.Dylan.Admin.AuthenticationClasses;
using Peng.Dylan.BLL.Classes;
using Peng.Dylan.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Peng.Dylan.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(UserAccount model)
        {
            //验证
            if (ModelState.IsValid)
            {
                var user = new Common.Entities.AdminEntity { Name = model.Email, Password = model.Password, AddDate = DateTime.Now };
                var result = AdminBLL.AddAccount(user);
                if (result > 0)
                {
                    var accountView = new UserData()
                    {
                        UserName = model.Email,
                        UserId = result,
                        Roles = new List<int>() { 1, 2, 3 }
                    };
                    HttpFormsAuthentication.SetAuthenticationCoolie(accountView, 7);
                    // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
                    // 发送包含此链接的电子邮件
                    // string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                    // var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                    // await UserManager.SendEmailAsync(user.Id, "确认你的帐户", "请通过单击 <a href=\"" + callbackUrl + "\">這裏</a>来确认你的帐户");

                    return RedirectToAction("Index", "Admin");
                }
            }

            // 如果我们进行到这一步时某个地方出错，则重新显示表单
            return View(model);
        }
    }
}