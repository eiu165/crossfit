using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class CheckListController : Controller
    {
        //
        // GET: /CheckList/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form2()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult ListLink()
        {      
            ViewData["PercentDone"] = "35%";    
            return PartialView("_CheckList");
        }

    }
}
