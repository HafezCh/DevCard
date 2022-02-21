using System.Collections.Generic;
using System.Linq;
using DevCard_MVC.Models;

namespace DevCard_MVC
{
    public class ProjectStore
    {
        public static List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project(1,"ربات تلگرام","ربات تلگرام خانه چرم","project-1.jpg","فروشگاه خانه چرم","https://t.me/KhaneCharm_Bot"),
                new Project(2,"حسابداری شخصی","نرم افزار حسابداری شخصی","project-2.jpg","سپیدار","#"),
                new Project(3,"ماشین حساب","نرم افزار ماشین حساب","project-3.jpg","فروشگاه خانه چرم","#"),
                new Project(4,"مخاطبین","نرم افزار مخاطبین","project-4.jpg","حافظ چراغی","#"),
            };
        }

        public static Project GetProjectBy(long id)
        {
            return GetProjects().FirstOrDefault(x => x.Id == id);
        }
    }
}
