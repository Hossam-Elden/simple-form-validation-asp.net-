using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int Hour = DateTime.Now.Hour;
            ViewBag.Greeting = Hour < 12 ? "Good Morning" :  "Good A fater noon";
            return  View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm( GuestResponse   guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("thanks", guestResponse);
            }
            else
            {
                //there is error 
                return View();
            }
        }
    }
}