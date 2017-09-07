using Peng.Dylan.Admin.AuthenticationClasses;
using Peng.Dylan.BLL.Classes;
using Peng.Dylan.Common;
using Peng.Dylan.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Peng.Dylan.Admin.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        // GET: Login
        public ActionResult Index(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Index(string name, string password, bool rememberMe, string returnUrl)
        {
            if (string.IsNullOrEmpty(name))
            {
                ViewBag.ErrorMsg = "用户名不能为空！";
                return View();
            }
            var account = AccountBLL.GetAccountByName(name);
            if (account == null)
            {
                ViewBag.ErrorMsg = "用户不存在！";
                return View();
            }
            if(account.Password != password)
            {
                ViewBag.ErrorMsg = "密码不正确！";
                return View();
            }
            var accountView = new UserData()
            {
                UserName = account.Name,
                UserId = account.ID,
                Roles = new List<int>() { 1, 2, 3 }
            };
            HttpFormsAuthentication.SetAuthenticationCoolie(accountView, rememberMe ? 7 : 0);
            if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/") && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: /Account/LogOff
        [HttpPost]
        public ActionResult LogOff()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(UserAccount model)
        {
            //验证
            if (ModelState.IsValid)
            {
                var user = new Account { Name = model.Email, Password = model.Password, AddDate = DateTime.Now };
                var result = AccountBLL.AddAccount(user);
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

                    return RedirectToAction("Index", "Home");
                }
            }

            // 如果我们进行到这一步时某个地方出错，则重新显示表单
            return View(model);
        }
    }
}