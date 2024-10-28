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
            var a = Session["x"];
            var UserEmail = context.Admins.Where(x => x.Username == a.ToString()).Select(x => x.Email).FirstOrDefault();
            var values = context.Messages.Where(x => x.ReceiverMail == UserEmail.ToString()).OrderByDescending(x => x.MessageId).Take(5).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAllAreReadTag()
        {
            var a = Session["x"];

            var UserEmail = context.Admins.Where(x => x.Username == a.ToString()).Select(x => x.Email).FirstOrDefault();
            var values = context.Messages.Where(x => x.ReceiverMail == UserEmail.ToString()).ToList();


            foreach (var i in values)
            {
                i.IsRead = true;
            }

            context.SaveChanges();

            return PartialView();
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

        public PartialViewResult PartialUserInformationBox()
        {
            var a = Session["x"];
            var values = context.Admins.Where(x => x.Username == a.ToString()).FirstOrDefault();

            ViewBag.UserImageUrl = context.Admins.Where(x => x.Username == a.ToString()).Select(x => x.ImageUrl).FirstOrDefault();
            ViewBag.UserName = context.Admins.Where(x => x.Username == a.ToString()).Select(x => x.Name + " " + x.Surname).FirstOrDefault();
            ViewBag.UserEmail = context.Admins.Where(x => x.Username == a.ToString()).Select(x => x.Email).FirstOrDefault();

            return PartialView(values);
        }

    }
}