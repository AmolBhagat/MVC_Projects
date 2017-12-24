using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
using MVCDemo.Models.ViewModel;
namespace MVCDemo.Controllers
{
    public class ProductController : Controller
    {
        
        public ActionResult Index()
        {
            NORTHWINDEntities context = new Models.NORTHWINDEntities();
            var categories = from c in context.Categories select c;

            return View(categories);
        }
        public ActionResult ProductList(int cid=1)
        {
            NORTHWINDEntities context = new Models.NORTHWINDEntities();
            var products = from p in context.Products where p.CategoryID == cid select p;
            string categoryname = (from c in context.Categories where c.CategoryID == cid select c.CategoryName).FirstOrDefault();
            ViewBag.categoryname = categoryname;

            ProductListViewModel prod = new ProductListViewModel();
            prod.productlist = products;
            prod.categoryname = categoryname;
            return View("productviewmodel",prod);
        }
        
        public ActionResult AddProduct(int cid=1)
        {
            NORTHWINDEntities context = new Models.NORTHWINDEntities();
            string categoryname = (from c in context.Categories where c.CategoryID == cid select c.CategoryName).FirstOrDefault();
            ViewBag.categoryname = categoryname;
            return View(new Product());
        }

        [HttpPost]
        public ActionResult AddProduct(Product newproduct,int cid = 1)
        {
            NORTHWINDEntities context = new Models.NORTHWINDEntities();
            newproduct.CategoryID = cid;
            context.Products.Add(newproduct);
            context.SaveChanges();
            return RedirectToAction("productlist", new { cid = cid });
            return View(newproduct);
        }

    }
}