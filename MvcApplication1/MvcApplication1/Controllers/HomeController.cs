using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public FileResult Index()
        {
            return File("index.html", "text/html"); 
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
