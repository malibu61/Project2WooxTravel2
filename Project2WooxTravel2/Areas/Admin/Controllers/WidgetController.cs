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
    public class WidgetController : Controller
    {
        TravelContext context = new TravelContext();

        public ActionResult WidgetList()
        {
            var a = Session["x"];
            var email = context.Admins.Where(x => x.Username == a.ToString()).Select(x => x.Email).FirstOrDefault();

            ViewBag.CountOfTours = context.Destinations.Count();
            ViewBag.MostExpensiveTour = context.Destinations.Max(x => x.Price);
            ViewBag.CheapestTour = context.Destinations.Min(x => x.Price);
            ViewBag.MostCapacityTour = context.Destinations.Max(x => x.Capacity);
            ViewBag.LongestTour = context.Destinations.Max(x => x.DayNight);
            ViewBag.AveragePrice = Decimal.Parse((context.Destinations.Average(x => x.Price).ToString("000,000")));
            ViewBag.CountOfCategories = context.Categories.Count();
            ViewBag.ShortestTour = context.Destinations.Min(x => x.DayNight);
            ViewBag.SentMail = context.Messages.Count(x => x.SenderMail == email.ToString());
            ViewBag.ReceivedMail = context.Messages.Count(x => x.ReceiverMail == email.ToString());
            ViewBag.CountOfAdmins = context.Admins.Count();
            ViewBag.CountOfReservations = context.Reservations.Count();

            return View();
        }
    }
}