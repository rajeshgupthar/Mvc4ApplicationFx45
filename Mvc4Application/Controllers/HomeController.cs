using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4Application.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            Trace.TraceInformation("Sample info trace");
            Trace.TraceWarning("Sample warning trace");
            Trace.TraceError("Sample error trace");

            return View();
        }

        static byte[] _bigArray;
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page that allocates a big array!";

            _bigArray = new byte[250 * 1000 * 1000];

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
