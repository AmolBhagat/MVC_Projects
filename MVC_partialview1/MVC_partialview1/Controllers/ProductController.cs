using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_partialview1.Models;
namespace MVC_partialview1.Controllers
{
    public class ProductController : Controller
    {

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Category(int? cid)
        {
            NORTHWINDEntities context = new NORTHWINDEntities();
            var categoryname = from c in context.Categories select c;

            var products = from p in context.Products where p.CategoryID == cid select p;
            CategoryProductViewModel categoryProd = new Models.CategoryProductViewModel() { Categories = categoryname, products = products };

            return View(categoryProd);
        }
       
        public ActionResult Suppliers(int? sid)
        {
            NORTHWINDEntities context = new NORTHWINDEntities();
            var supplier = from s in context.Suppliers select s;

            var products = from p in context.Products where p.SupplierID == sid select p;
            SupplierProductViewModel supplierProd = new Models.SupplierProductViewModel() { Suppliers = supplier, products = products };

            return View(supplierProd);
        }


    }
}