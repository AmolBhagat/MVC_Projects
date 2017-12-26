using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data_transfer_objects_as_model.Models;

namespace Data_transfer_objects_as_model.Controllers
{
    public class EmployeeController : Controller
    {
        DbModelEntities dbcontext = new DbModelEntities();
        public ActionResult Index()
        {
            ViewBag.DepartmentList = dbcontext.Departments.ToList();

            return View(dbcontext.Employees);
        }
        public ActionResult EmployeesByDepartment()
        {
            var employees = dbcontext.Employees.Include("Department")
                            .GroupBy(x => x.Department.DepartmentName)
                            .Select(y => new DepartmentsTotal
                            {
                                Name = y.Key,
                                Total = y.Count()
                            }).ToList().OrderByDescending(y=>y.Total);
            return View(employees);
        }
    }
}