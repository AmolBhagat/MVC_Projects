using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_partialview1.Models
{
    public class CategoryProductViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> products { get; set; }
    }
    public class SupplierProductViewModel
    {
        public IEnumerable<Supplier> Suppliers { get; set; }
        public IEnumerable<Product> products { get; set; }
    }
}