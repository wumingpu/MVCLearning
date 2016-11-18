using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace AngularFileUpload.Views.Home
{
    /// <summary>
    /// Summary description for UploadHandler
    /// </summary>
    public class UploadHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string fname = string.Empty;
            if (context.Request.Files.Count > 0)
            {
                
                HttpFileCollection files = context.Request.Files;
                //var userName = context.Request.Form["name"];
                for (int i = 0; i < files.Count; i++)
                {
                    HttpPostedFile file = files[i];

                    //string fname = context.Server.MapPath("Uploads\\" + userName.ToUpper() + "\\" + file.FileName);
                    string path = context.Server.MapPath("../Upload//");
                    fname = Guid.NewGuid() + "." + Path.GetExtension(file.FileName);/*file.FileName.Split('.')[1]*/
                    file.SaveAs(path + fname);
                }
            }
            context.Response.ContentType = "text/plain";
            //context.Response.Write("File/s uploaded successfully!");
            context.Response.Write(fname);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}