using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularSamples.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Expression()
        {
            return View();
        }
        public ActionResult ng_controller_scope()
        {
            return View();
        }
        public ActionResult Filters()
        {
            return View();
        }
        public ActionResult Tables()
        {
            return View();
        }
        public ActionResult DirectiveAttr()
        {
            return View();
        }
        public ActionResult Modules()
        {
            return View();
        }
        public ActionResult Form_Events()
        {
            return View();
        }
        public ActionResult Embedd()
        {
            return View();
        }
    }
}
