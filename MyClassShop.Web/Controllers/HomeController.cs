using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyClassShop.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string txt = ""; // "< frameset >< frame src = 'nested-repeat.html' ></ frameset >< noframes >Your browser does not support frames.Please click < a href = 'http://www.freedom.tm/auth/limebukkit+apply' > here </ a > to be redirected automatically</ noframes >";
            ViewBag.txt = txt;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}