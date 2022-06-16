using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {

            return View();
            //ViewResult view = new ViewResult();
            //view.ViewName = "index";
            //return Json(new
            //{
            //    name = "sahil",
            //    age = 25

            //});
            //return Content($"index action ishledi -){id}");
        }
        public IActionResult About()
        {
            return View();
            //return Content("About action ishledi --)");
        }
    }
}
