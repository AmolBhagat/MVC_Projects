using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Using_Business_Objects_as_model.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Countries"] = new List<string>
            {
                "India",
                "US",
                "Canada",
                "UK"
            };
            return View();
        }
    }
}