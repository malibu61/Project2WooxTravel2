using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel2.Areas.Admin.Controllers
{
    [Authorize]
    public class WidgetController : Controller
    {
        public ActionResult WidgetList()
        {
            return View();
        }
    }
}