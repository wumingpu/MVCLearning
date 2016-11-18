using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularFileUpload.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void upload(HttpPostedFile context)/*System.Web.HttpPostedFileBase aFile*/
        {
            //string file = context.Request.Files;
            //string path = Server.MapPath("../Upload//");
            //string fileName = Guid.NewGuid() + "." + file.Split('.')[1];
            //aFile.SaveAs(path + fileName);
            //HttpContext.Response.Write(fileName);

            //if (context.Request.Files.Count > 0)
            //{
            //    HttpFileCollection files = context.Request.Files;
            //    //var userName = context.Request.Form["name"];
            //    for (int i = 0; i < files.Count; i++)
            //    {
            //        HttpPostedFile file = files[i];

            //        //string fname = context.Server.MapPath("Uploads\\" + userName.ToUpper() + "\\" + file.FileName);
            //        string path = Server.MapPath("../Upload//");
            //        string fname = Guid.NewGuid() + "." + file.FileName.Split('.')[1];
            //        file.SaveAs(path + fname);
            //    }
            //}
        }
    }
}