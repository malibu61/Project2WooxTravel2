using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel2.Areas.Admin.Controllers
{
    public class ErrorPagesController : Controller
    {
        // GET: Admin/ErrorPages
        public ActionResult Page404()
        {
            return View();
        }

        public ActionResult Page401()
        {
            return View();
        }
    }
}