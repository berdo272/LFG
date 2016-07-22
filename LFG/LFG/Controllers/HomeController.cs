using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RiotApi;
using System.Collections.ObjectModel;

namespace LFG.Controllers
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
            ReadOnlyCollection<TimeZoneInfo> tz;
            tz = TimeZoneInfo.GetSystemTimeZones();
            return View();



        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}