using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVC_Card.Models;

namespace MVC_Card.ViewComponents
{
    public class ProjectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var _projects = Project.GetProjects();
            return View("_Projects", _projects);
        }
    }
}