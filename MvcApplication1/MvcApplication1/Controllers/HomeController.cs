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
            dynamic a = new ExpandoObject(); a.Name = "The Bridge"; a.Id = 1; list.Add(a);
            a = new ExpandoObject(); a.Name = "Unplugged"; a.Id = 2; list.Add(a);
            a = new ExpandoObject(); a.Name = "The Stranger"; a.Id = 3; list.Add(a);
            a = new ExpandoObject(); a.Name = "Piano Man"; a.Id = 4; list.Add(a);
            a = new ExpandoObject(); a.Name = "Ten"; a.Id = 5; list.Add(a);
            a = new ExpandoObject(); a.Name = "August and Everything After"; a.Id = 6; list.Add(a);
            a = new ExpandoObject(); a.Name = "West"; a.Id = 7; list.Add(a);

            return View(list.ToList() );
            //return File("index.html", "text/html");
        } 
               

        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return PartialView();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your quintessential contact page.";

            return View();
        }
    }
}
