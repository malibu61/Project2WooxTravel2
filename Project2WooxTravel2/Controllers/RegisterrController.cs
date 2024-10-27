using Project2WooxTravel2.Context;
using Project2WooxTravel2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel2.Controllers
{
    public class RegisterrController : Controller
    {
        TravelContext context = new TravelContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            context.Admins.Add(admin);
            context.SaveChanges();
            return RedirectToAction("Index","Login");
        }
    }
}