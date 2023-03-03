using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Card.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Customer { get; set; }
        public string Link { get; set; }
        public Project(int id, string name, string image, string description, string customer,string link)
        {
            Id = id;
            Name = name;
            Image = image;
            Description = description;
            Customer = customer;
            Link = link;
        }

        public static List<Project> GetProjects()
        {
            
            List < Project > _projects = new List<Project>()
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
            return _projects;
        }

        public static Project GetProjectBy(int id)
        {
            Project _project = GetProjects().FirstOrDefault(p=>p.Id==id);

            return _project;
        }
    }


 
  
}
