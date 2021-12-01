using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarParts.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The firm Tarataika EOOD was created on 28th april 2015 by Nikolai Kolev. Here you can find car parts  second hand for all car brands and all different modifications. We ship worldwide.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact phone: +359888888888.";

            return View();
        }
    }
}