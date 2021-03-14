using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace DevCard_MVC.Controllers
{
    public class TestController : Controller
    {

        //public PartialViewResult index()
        //{
        //    return PartialView("Header");
        //}

        //public ContentResult index()
        //{
        //    return Content("<h1> hello </h1><script>confirm('are u ok?')</script>");
        //}
        //public JsonResult Index()
        //{
        //    return Json(new {id=12,Name="yaser"});
        //}

        public FileResult Index2()
        {
            return File("Controllers/test.txt", "text/html");
            //var FileByte = System.IO.File.ReadAllBytes("Controllers/test.txt");
            //return File(FileByte, MediaTypeNames.Text.Plain, "textfile.txt");
        }

        public JavaScriptResult Index()
        {
            return new JavaScriptResult("alert('hello mr shakoori')");
        }
    }

    public class JavaScriptResult : ContentResult
    {
        public JavaScriptResult(string data)
        {
            Content = data;
            ContentType = "application/javascript";
        }
    }
}
