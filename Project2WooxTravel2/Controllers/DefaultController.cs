using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;
using Project2WooxTravel2.Context;
using Project2WooxTravel2.Entities;
using PagedList;
using PagedList.Mvc;

namespace Project2WooxTravel2.Controllers
{
    public class DefaultController : Controller
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

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialBanner()
        {
            var values = context.Destinations.Take(4).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialPopUpReservation()
        {
            List<SelectListItem> list = (from x in context.Destinations.ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.City + " (" + x.DayNight.ToString() + " gün)",
                                             Value = x.DestinationId.ToString()
                                         }).ToList();

            ViewBag.ReservationDropDL = list;

            return PartialView();
        }

        [HttpPost]
        public ActionResult PopUpReservationSave(Reservation reservation)
        {
            reservation.ReservationDate = DateTime.Now;
            context.Reservations.Add(reservation);
            context.SaveChanges();
            return RedirectToAction("Index", "Default");
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ContactUs(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
            return RedirectToAction("Index", "Default");
        }

        public PartialViewResult PartialCountry(int p = 1)
        {
            var values = context.Destinations.ToList().ToPagedList(p, 3);
            return PartialView(values);
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
    }
}