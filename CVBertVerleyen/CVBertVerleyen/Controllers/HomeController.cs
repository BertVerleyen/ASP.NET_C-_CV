using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVBertVerleyen.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home pagina CV online";
           

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About me";

            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Title = "Projects";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contact";

            return View();
        }
    }
}
