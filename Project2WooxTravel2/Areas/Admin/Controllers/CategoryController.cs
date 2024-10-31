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
    public class CategoryController : Controller
    {
        TravelContext context = new TravelContext();

        public ActionResult CategoryList()
        {
            var values = context.Categories.Where(x => x.CategoryStatus == true).ToList();
            return View(values);
        }

        public ActionResult CategoryUpdate(int id)
        {
            var values = context.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public ActionResult CategoryUpdate(Category category)
        {
            var values = context.Categories.Where(x => x.CategoryId == category.CategoryId).FirstOrDefault();
            values.CategoryName = category.CategoryName;
            values.CategoryStatus = category.CategoryStatus;
            context.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        public ActionResult CategoryDelete(int id)
        {
            var values = context.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
            values.CategoryStatus = false;
            context.SaveChanges();
            return RedirectToAction("CategoryList");
        }
    }
}