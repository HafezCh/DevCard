using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1,"آموزش Asp.net.core","blog-post-thumb-card-5.jpg","کاملترین پکیج آموزش asp.net"),
                new Article(2,"آموزش GitHub","blog-post-thumb-card-1.jpg","کاملترین پکیج آموزش Git"),
                new Article(3,"آموزش Onion Architecture","blog-post-thumb-card-3.jpg","کاملترین پکیج آموزش Onion Architecture"),
                new Article(4,"آموزش طراحی سایت","blog-post-thumb-card-4.jpg","کاملترین پکیج آموزش طراحی سایت")
            };
            return View("_LatestArticles",articles);
        }
    }
}
