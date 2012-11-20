using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Massive;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var list = new List<ExpandoObject>();
            for (int i = 0; i < 10; i++)
            {
                dynamic a = new ExpandoObject();
                a.Name = "Album"+i;
                a.Id = i;
                list.Add(a);
            }     
            return View(list.ToList() );
            //return File("index.html", "text/html");
        } 
               

        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your quintessential contact page.";

            return View();
        }
    }
}
