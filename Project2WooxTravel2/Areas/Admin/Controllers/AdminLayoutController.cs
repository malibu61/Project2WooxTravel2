using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Project2WooxTravel2.Context;
using Project2WooxTravel2.Entities;

namespace Project2WooxTravel2.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        TravelContext context = new TravelContext();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult PartialMessagesTag()
        {
            var values = context.Messages.OrderByDescending(x => x.MessageId).Take(5).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialNotificationsTag()
        {
            var values = context.Destinations.OrderByDescending(x => x.DestinationId).Take(4).ToList();
            return PartialView(values);
        }


        public ActionResult Payment()
        {
            return View();
        }


        public ActionResult LogOut()
        {
            //FormsAuthentication.SignOut();
            //Session.Abandon();
            //return RedirectToAction("Index","Login");

            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login", "Controllers");
        }

    }
}