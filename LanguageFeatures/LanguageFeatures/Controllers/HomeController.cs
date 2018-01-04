using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanguageFeatures.Models;
using System.Text;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }
        public ViewResult Autoproperty()
        {
            // create a new Product object
            Product myProduct = new Product();
            // set the property value
            myProduct.Name = "Amol";
            // get the property
            string productName = myProduct.Name;
            // generate the view
            return View("Result", (object)String.Format("Product name : {0}", productName));

        }
        public ViewResult FindProducts()
        {
            Product[] products = {
                                    new Product {Name = "Amol", Category = "Watersports", Price = 275M},
                                    new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
                                    new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
                                    new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
                                  };
            var foundProducts = products.OrderByDescending(e => e.Price)
                                .Take(3)
                                .Select(e => new
                                {
                                    e.Name,
                                    e.Price
                                });
            products[2] = new Product { Name = "Stadium", Price = 79600M };
            StringBuilder result = new StringBuilder();
            foreach (var p in foundProducts)
            {
                result.AppendFormat("Price: {0} ", p.Price);
            }
            return View("Result", (object)result.ToString());
        }
        public ViewResult SumProducts()
        {
            Product[] products = {
                                    new Product {Name = "Amol", Category = "Watersports", Price = 275M},
                                    new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
                                    new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
                                    new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
                                };
            var results = products.Sum(e => e.Price);
            products[2] = new Product { Name = "Stadium", Price = 79500M };
            return View("Result",
            (object)String.Format("Sum: {0:c}", results));
        }
    }
}