using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Billing.Site.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("View", "Billing");
        }
    }
}
