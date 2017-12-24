using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Workin_with_multiple_tables.Models;

namespace Workin_with_multiple_tables.Controllers
{
    public class EmployeeController : Controller
    {
        DbModelEntities dbcontext = new DbModelEntities();
        public ActionResult Index(int departmentid)
        {
            List<tblEmployee> employees = dbcontext.tblEmployees.Where(x=>x.DepartmentId==departmentid).ToList();

            return View(employees);
        }
        public ActionResult Details(int id)
        {
            tblEmployee employee = dbcontext.tblEmployees.Single(x => x.Employeeid == id);
            return View(employee);
        }
    }
}