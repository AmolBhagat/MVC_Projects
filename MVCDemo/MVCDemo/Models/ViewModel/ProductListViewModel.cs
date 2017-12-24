using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models.ViewModel
{
    public class ProductListViewModel
    {
        public IQueryable<Product> productlist { get; set; }
        public string categoryname { get; set; }
    }
}