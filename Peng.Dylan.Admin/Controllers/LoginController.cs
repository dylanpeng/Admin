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
    }
}