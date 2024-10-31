using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2WooxTravel2.Context;
using Project2WooxTravel2.Entities;

namespace Project2WooxTravel2.Areas.Admin.Controllers
{
    public class StatisticController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult Index()
        {
            List<int> capacity = context.Destinations.Select(x => x.Capacity).ToList();
            ViewBag.Capacity = capacity;
            List<string> capacityName = context.Destinations.Select(x => x.Country).ToList();
            ViewBag.CapacityName = capacityName;

            List<decimal> price = context.Destinations.Select(x => x.Price).ToList();
            ViewBag.Price = price;
            List<string> priceName = context.Destinations.Select(x => x.Country).ToList();
            ViewBag.PriceName = priceName;

            List<int> daynight = context.Destinations.Select(x => x.DayNight).ToList();
            ViewBag.DayNight = daynight;
            List<string> daynightName = context.Destinations.Select(x => x.City).ToList();
            ViewBag.DayNightName = daynightName;




            var values = context.Destinations.ToList();
            return View(values);
        }
    }
}