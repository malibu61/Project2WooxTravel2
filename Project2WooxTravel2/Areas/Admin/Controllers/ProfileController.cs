using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2WooxTravel2.Context;
using Project2WooxTravel2.Entities;

namespace Project2WooxTravel2.Areas.Admin.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            var a = Session["x"];
            var values = context.Admins.Where(x => x.Username == a.ToString()).FirstOrDefault();
            return View(values);
        }
    }
}