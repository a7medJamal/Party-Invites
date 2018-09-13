using Party_Invites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Party_Invites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int Hours = DateTime.Now.Hour;
            ViewBag.Greeting=Hours<12?"Good Morning":"Good Afternoon";
            return View();
        }

        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RsvpForm(GestResponse gestResponse)
        {
            return View("Thanks",gestResponse);
        }

    }
}