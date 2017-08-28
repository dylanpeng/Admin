﻿using Peng.Dylan.BLL.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Peng.Dylan.Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var userId = UserBLL.GetUserId();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page."; 

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}