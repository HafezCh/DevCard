using System;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new ContactForm();
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(ContactForm model)
        {
            //if (ModelState.IsValid == false)
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست ، لطفا دوباره تلاش کنید";
                return View(model);
            }

            ViewBag.success = "پیغام شما با موفقیت ارسال شد ، باتشکر از شما";
            return View();
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
