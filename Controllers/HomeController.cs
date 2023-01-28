using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Card.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC_Card.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>
        {
            new Service(1, "نقره ای"),
            new Service(2, "طلایی"),
            new Service(3, "پلاتینیوم"),
            new Service(4, "الماس")
        };
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            Contact contact = new Contact();
            contact.Services = new SelectList(_services, "Id", "Name");
            return View(contact);
        }
        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}
        //[HttpPost]
        //public JsonResult Contact(Contact form)
        //{
        //    Models.Contact contact = form;
        //    contact.Name = contact.Name + "Ezafe shode";
        //    return Json(contact);
        //}



        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(_services, "Id", "Name");
            //if (ModelState.IsValid == false)
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نمیباشد لطفا دوباره تلاش نمائید. با تشکر";
                return View(model);
            }
            ModelState.Clear();
            model = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };

            ViewBag.success = "پیغام شما با موفقیت ارسال گردید.در صورت نیاز با شما تماس گرفته خواهد شد";
            return View(model);

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
