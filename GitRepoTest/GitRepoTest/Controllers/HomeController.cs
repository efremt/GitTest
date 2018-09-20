using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitRepoTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // commewnt added from github
            // Second change from github
            // Thired chang from local VS
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
