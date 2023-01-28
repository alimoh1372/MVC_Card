using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace MVC_Card.Controllers
{
    public class TestController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View("Footer");
        //}

        //public PartialViewResult Index()
        //{
        //    return PartialView("Footer");
        //}


        //public ContentResult Index()
        //{
        //    return Content(@"<h1 style='color:blue;'>Ali mohammadzade is the student of asp.core ....</h1><script>alert('hellooooo');</script>", MediaTypeNames.Text.Html);
        //}

        //public EmptyResult Index()
        //{
        //    return new EmptyResult();
        //}


        //public FileResult Index()
        //{
        //  //  return File("~/text.txt", "text/html");

        //  byte[] fileBytes = System.IO.File.ReadAllBytes("wwwroot/text.txt");

        //  const string fileNameAfterDownload = "TextFileOfMe.txt";
        // string fileType = MediaTypeNames.Text.Plain;
        // return File(fileBytes, fileType, fileNameAfterDownload);

        //}


        //    public JsonResult Index()
        //    {
        //        var obj = new
        //        {
        //            id = 1,
        //            Name = "ali",
        //            lastName = "mohammadzade",
        //            age = 23
        //        };
        //        return Json(obj);
        //    }
        //}
        //public JavascriptResult Index()
        //{
        //    return new  JavascriptResult("alert('ali mohammadzadeh');");
        //}


        //redirect results

        //public IActionResult Index()
        //{
        //    //return Redirect("https://www.google.com");
        //    return RedirectToAction( "Contact", "Home");
        //}


        public StatusCodeResult Index()
        {
            //return new OkResult();
            //return new UnauthorizedResult();

            //return new BadRequestResult();
            return new StatusCodeResult(200);
        }

         
    }

    //public class JavascriptResult : ContentResult
    //{
    //    public JavascriptResult(string javascriptCode)
    //    {
    //        Content = javascriptCode;
    //        ContentType = "application/javascript";
    //    }
    //}
}
