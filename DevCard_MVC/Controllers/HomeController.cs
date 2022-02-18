using System;
using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>
        {
            new Service(1,"نقره ای"),
            new Service(2,"طلایی"),
            new Service(3,"پلاتین"),
            new Service(4,"الماس"),
        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new ContactForm()
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(ContactForm model)
        {
            model.Services = new SelectList(_services, "Id", "Name");
            //if (ModelState.IsValid == false)
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست ، لطفا دوباره تلاش کنید";
                return View(model);
            }
            
            ModelState.Clear();

            model = new ContactForm
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            ViewBag.success = "پیغام شما با موفقیت ارسال شد ، باتشکر از شما";
            return View(model);
            //return RedirectToAction("Index");
        }

        //[HttpPost]
        //public JsonResult Contact(ContactForm form)
        //{
        //    Console.WriteLine(form.ToString());
        //    return Json(Ok());
        //}

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
