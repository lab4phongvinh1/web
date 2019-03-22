using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webshoppingonline.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

<<<<<<< HEAD
        public ActionResult LienHeVoiChungToi()
=======
        public ActionResult LienHe()
>>>>>>> 83625f66521ea7b3163dd2bf51073cb334d159de
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}