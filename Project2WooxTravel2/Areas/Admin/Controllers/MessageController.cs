//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using Project2WooxTravel2.Context;
//using Project2WooxTravel2.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2WooxTravel2.Entities;
using Project2WooxTravel2.Context;

namespace Project2WooxTravel2.Areas.Admin.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        TravelContext context = new TravelContext();
        public ActionResult InBox()
        {
            var a = Session["x"];
            var email = context.Admins.Where(x => x.Username == a.ToString()).Select(y => y.Email).FirstOrDefault();
            var values = context.Messages.Where(x => x.ReceiverMail == email).ToList();

            ViewBag.PersonName = context.Admins.Where(x => x.Username == a.ToString()).Select(x => x.Name + " " + x.Surname).FirstOrDefault();

            return View(values);

        }

        public ActionResult SendBox()
        {
            var a = Session["x"];
            var email = context.Admins.Where(x => x.Username == a.ToString()).Select(y => y.Email).FirstOrDefault();
            var values = context.Messages.Where(x => x.SenderMail == email).ToList();
            return View(values);
        }

        public ActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendMessage(Message message)
        {
            var a = Session["x"];
            var email = context.Admins.Where(x => x.Username == a.ToString()).Select(y => y.Email).FirstOrDefault();
            message.SenderMail = email;
            message.SendDate = DateTime.Now;
            message.IsRead = false;
            message.AdminId = context.Admins.Where(x => x.Username == a.ToString()).Select(x => x.AdminId).FirstOrDefault();
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("Sendbox", "Message", new { area = "Admin" });
        }
    }
}