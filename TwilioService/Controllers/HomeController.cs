using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwilioService.Models;

namespace TwilioService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new Message();
            return View(model);
        }
    }
}
