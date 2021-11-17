using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigureMVCWebApplication.Controllers
{   
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult About()
        {
            return View();
        }
        public ViewResult Contact()
        {
            return View("ContactPage");
        }


        public ActionResult Privacy()
        {
            return RedirectToAction("Index");
        }
        public string Message()
        {
            return "This is Message action method from Home controller";
        }
    }
}
