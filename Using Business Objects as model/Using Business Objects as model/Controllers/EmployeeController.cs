using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace Using_Business_Objects_as_model.Controllers
{
    public class EmployeeController : Controller
    {
        
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee> employees = employeeBusinessLayer.employees.ToList();
            return View(employees);
        }
        
        //[HttpPost]
        //public ActionResult Create()
        //{
        //    return View();
        //}

    }
}