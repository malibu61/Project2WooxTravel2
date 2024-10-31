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

        [HttpGet]
        public ActionResult Index()
        {
            var a = Session["x"];
            var values = context.Admins.Where(x => x.Username == a.ToString()).FirstOrDefault();
            return View(values);
        }

        [HttpPost]
        public ActionResult Index(Entities.Admin admin)
        {
            var values = context.Admins.Where(x => x.AdminId == admin.AdminId).FirstOrDefault();
            values.Username = admin.Username;
            values.Name = admin.Name;
            values.Surname = admin.Surname;
            values.Email = admin.Email;
            values.Password = admin.Password;
            values.ImageUrl = admin.ImageUrl;
            context.SaveChanges();
            return View(values);
        }
    }
}