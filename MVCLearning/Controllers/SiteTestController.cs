﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLearning.Controllers
{
    public class SiteTestController : Controller
    {
        // GET: SiteTest
        public ActionResult Index()
        {
            return View();
        }
    }
}