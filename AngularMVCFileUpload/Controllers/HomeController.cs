﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace AngularMVCFileUpload.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void upload(System.Web.HttpPostedFileBase aFile)
        {
            string file = aFile.FileName;
            string path = Server.MapPath("../Upload//");
            string fileName = Guid.NewGuid() + "." + file.Split('.')[1];
            aFile.SaveAs(path + fileName);
            HttpContext.Response.Write(fileName);
        }

    }
}
