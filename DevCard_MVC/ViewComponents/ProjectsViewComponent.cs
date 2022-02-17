using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
	public class ProjectsViewComponent : ViewComponent
	{
        public IViewComponentResult Invoke()
        {
            var project = new List<Project>
            {
                new Project(1,"ربات تلگرام","ربات تلگرام خانه چرم","project-1.jpg","فروشگاه خانه چرم"),
                new Project(2,"حسابداری شخصی","نرم افزار حسابداری شخصی","project-2.jpg","سپیدار"),
                new Project(3,"ماشین حساب","نرم افزار ماشین حساب","project-3.jpg","فروشگاه خانه چرم"),
                new Project(4,"مخاطبین","نرم افزار مخاطبین","project-4.jpg","حافظ چراغی"),
            };

            return View("_Projects",project);
        }
	}
}
