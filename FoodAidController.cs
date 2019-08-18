using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class FoodAidController : Controller
    {
        // GET: FoodAid
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Donate()
        {
            return View();
        }
        public ActionResult Listings()
        {
            return View();
        }
    }
}