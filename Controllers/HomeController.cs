using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Index";

            return View();
        }

        public ActionResult YouTube()
        {
            List<string> videos = new List<string>();
            new YouTube().Run(videos).Wait();
            ViewBag.Title = "YouTube";

            return View();
        }
    }
}
