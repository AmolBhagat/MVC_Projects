using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialView_Action_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            NorthwindEntities entities = new NorthwindEntities();
            return View(from customer in entities.Customers.Take(5)
                        select customer);
        }

        [ChildActionOnly]
        public ActionResult Details(string customerId)
        {
            NorthwindEntities entities = new NorthwindEntities();
            return PartialView("Details", entities.Customers.Find(customerId));
        }
    }
}