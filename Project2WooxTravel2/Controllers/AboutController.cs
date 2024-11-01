using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Project2WooxTravel2.Context;
using Project2WooxTravel2.Entities;

namespace Project2WooxTravel2.Controllers
{
    public class AboutController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult Index(int id = 3)
        {
            var values = context.Destinations.Find(id);
            return View(values);
        }

        public ActionResult TourDetails(int id = 3)
        {
            var values = context.Destinations.Find(id);
            ViewBag.DestinationTitle = context.Destinations.Find(id).Title;
            ViewBag.DestinationCountry = context.Destinations.Find(id).Country;
            ViewBag.DestinationDescription = context.Destinations.Find(id).Description;
            ViewBag.DestinationImageUrl = context.Destinations.Find(id).ImageUrl;
            ViewBag.DestinationDayNight = context.Destinations.Find(id).DayNight;
            ViewBag.DestinationCapacity = context.Destinations.Find(id).Capacity;
            ViewBag.DestinationPrice = context.Destinations.Find(id).Price;
            return View(values);
        }

        public PartialViewResult TourPhotos()
        {
            var values = context.Destinations.ToList();
            return PartialView(values);
        }

        public PartialViewResult TourDeals()
        {
            var values = context.Destinations.ToList();
            return PartialView(values);
        }
    }
}