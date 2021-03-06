﻿using Peng.Dylan.BLL.Classes;
using Peng.Dylan.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Peng.Dylan.Admin.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(RoleEntity role)
        {
            //var role = new RoleEntity() { RoleName = roleName };
            //验证
            if (ModelState.IsValid)
            {
                var result = RoleBLL.AddRole(role);
                if (result > 0)
                {
                    return RedirectToAction("Index", "Role");
                }
                ViewBag.ErrorMsg = "添加失败，请确认ID是否重复";
            }
            // 如果我们进行到这一步时某个地方出错，则重新显示表单
            return View(role);
        }

        public ActionResult PermissionList()
        {
            return View();
        }

        public ActionResult AddPermission()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPermission(PermissionEntity permission)
        {
            //var role = new RoleEntity() { RoleName = roleName };
            //验证
            if (ModelState.IsValid)
            {
                var result = RoleBLL.AddPermission(permission);
                if (result > 0)
                {
                    return RedirectToAction("PermissionList", "Role");
                }
                ViewBag.ErrorMsg = "添加失败，请确认ID是否重复";
            }
            // 如果我们进行到这一步时某个地方出错，则重新显示表单
            return View(permission);
        }
    }
}