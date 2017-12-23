using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Generate_Hyperlinks.Models;

namespace Generate_Hyperlinks.Controllers
{
    public class EmployeeController : Controller
    {
        DbModelEntities dbcontext = new DbModelEntities();
        public ActionResult Index()
        {
            List<Employee> employeelist = dbcontext.Employees.ToList();
            return View(employeelist);
        }
        public ActionResult Details(int id)
        {
            Employee employees = dbcontext.Employees.Single(emp => emp.ID==id);
            return View(employees);
        }
    }
}