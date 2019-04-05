using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webshoppingonline.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult gioithieu()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult lienhevoi()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}