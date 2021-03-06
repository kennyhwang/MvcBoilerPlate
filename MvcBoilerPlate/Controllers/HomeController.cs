﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBoilerPlate.auth;

namespace MvcBoilerPlate.Controllers
{
    [CustomerAuthorizeAttribute]
    public class HomeController : BaseController
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Home/Restricted
        //[RoleTypeAction("Admin,Test1")]
        public ActionResult Restricted(string role)
        {
            return View();
        }

    }
}
