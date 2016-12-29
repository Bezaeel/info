using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace info.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Let's get in touch";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string u_emaill, string messagee)
        {
            ViewBag.Message = "Thanks, we got your message";

            return View();
        }
    }
}