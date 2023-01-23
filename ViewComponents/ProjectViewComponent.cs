using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVC_Card.Models;

namespace MVC_Card.ViewComponents
{
    public class ProjectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Project> _projects = new List<Project>()
            {
                new Project(1, "مدیریت مدرسه", "project-1.jpg",
                    "پروژه مدیریت مدارس به صورت یکپارچه و افزودن تمامی سطوح و لایه های مدیریتی طبق نیاز",
                    "اموزش پرورش","#"),
                new Project(2, "سایت فروشگاه", "project-2.jpg",
                    "پروژه فروشگاه لوازم دیجیتال با قابلیت اتصال به درگاه بانک و ثبت نام کاربرو....",
                    "مجموعه افق کوروش","#"),
                new Project(3, "پروژه حسابداری شخصی", "project-3.jpg",
                    "پروژه ویندوزی مدیریت خرج و مخارج و محاسبه پس انداز و پیش بینی خرج آینده", "مهندس طاهری","#"),
                new Project(4, "سایت فروش و خدمات لوازم خانگی", "project-4.jpg",
                    "سایت خدمات و پشتیبانی و فروش لوازم خانگی ", "مهندس رستمی","#")
            };
            return View("_Projects", _projects);
        }
    }
}