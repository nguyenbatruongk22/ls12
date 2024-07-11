using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nbt_2210900140.Controllers
{
    public class nbtHomeController : Controller
    {
        public ActionResult nbtIndex()
        {
            return View();
        }

        public ActionResult nbtAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult nbtContact()
        {
            ViewBag.msv  = "2210900140";
            ViewBag.fullname = "nguyễn bá trường";

            return View();
        }
    }
}