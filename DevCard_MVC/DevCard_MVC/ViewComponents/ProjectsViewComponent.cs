using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string name)
        {
            var projects = new List<Project>()
            {
                new Project(1,"پرواز","project-1.jpg","بهترین نرخ پرواز در بین اپلیکشن ها","aliBaba"),
                new Project(2,"کتابخانه","project-2.jpg","برترین منبع کتاب در خاورمیانه","ممد"),
                new Project(3,"موزه","project-3.jpg","بهترین نرخ پرواز در بین اپلیکشن ها","موره بین الممل"),
                new Project(4,"آسمان خراش","project-4.jpg","بهترین نرخ پرواز در بین اپلیکشن ها","حسین"),
                new Project(5,"مدرن نوبس","project-5.jpg","بهترین نرخ پرواز در بین اپلیکشن ها","یاسر"),
            };
            return View("_Projects",projects);
        }
    }
}
