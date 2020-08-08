using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemoproj.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            System.Diagnostics.Trace.TraceInformation("This is Home method hit....");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            System.Diagnostics.Trace.TraceInformation("This is About method hit....");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            System.Diagnostics.Trace.TraceInformation("This is contact method hit....");
            return View();
        }
    }
}