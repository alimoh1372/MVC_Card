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


        public FileResult Index()
        {
          //  return File("~/text.txt", "text/html");

          byte[] fileBytes = System.IO.File.ReadAllBytes("wwwroot/text.txt");

          const string fileNameAfterDownload = "TextFileOfMe.txt";
         string fileType = MediaTypeNames.Text.Plain;
         return File(fileBytes, fileType, fileNameAfterDownload);

        }
    }
}
