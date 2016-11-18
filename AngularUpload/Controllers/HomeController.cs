using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularUpload.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Upload(System.Web.HttpPostedFileBase aFile)
        {
            string file = aFile.FileName;
            string path = Server.MapPath("../UploadFiles//");
            string fileName = Guid.NewGuid() + "." + file.Split('.')[1];
            aFile.SaveAs(path + fileName);
            Response.Write(fileName);
        }
    }
}