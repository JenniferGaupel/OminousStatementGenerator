using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OSGenerator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OSGenerate()
        {
            ViewBag.Message = "Your ominous statement here";

            return View();
        }
    }
}