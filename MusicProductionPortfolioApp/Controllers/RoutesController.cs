using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicProductionPortfolioApp.Controllers
{
    public class RoutesController : Controller
    {
        // GET: Routes
        public ActionResult Latest()
        {
            return View();
        }

        public ActionResult Music()
        {
            return View();
        }

        [Authorize]
        public ActionResult Shop()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}