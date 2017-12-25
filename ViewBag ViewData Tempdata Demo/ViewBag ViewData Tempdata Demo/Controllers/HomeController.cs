using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBag_ViewData_Tempdata_Demo.Models;

namespace ViewBag_ViewData_Tempdata_Demo.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            List<Employee> employeelist = new List<Employee>();
            Employee employee = new Employee();
            employeelist.Add(new Employee { EmployeeId = 1, Name = "Amol", Department = "IT" });
            employeelist.Add(new Employee { EmployeeId = 2, Name = "John", Department = "Sales" });
            employeelist.Add(new Employee { EmployeeId = 3, Name = "Sara", Department = "QA" });
            employeelist.Add(new Employee { EmployeeId = 4, Name = "Andrew", Department = "Inventory" });

            //ViewBag.EmployeeList = employeelist;

            ViewData["EmployeeList"] = employeelist;

            ViewBag.EmployeeNameVB = "Amol";

            ViewData["EmployeeNameVD"] = "John";

            TempData["EmployeeNameTD"] = "Sara";

            TempData.Keep();
            return View();
        }
        public ActionResult SecondPage()
        {
            TempData.Keep();
            return View();
        }
    }
}