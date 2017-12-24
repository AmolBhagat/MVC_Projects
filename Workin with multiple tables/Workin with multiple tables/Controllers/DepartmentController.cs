using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Workin_with_multiple_tables.Models;

namespace Workin_with_multiple_tables.Controllers
{
    public class DepartmentController : Controller
    {
        DbModelEntities dbcontext = new DbModelEntities();
        public ActionResult Index()
        {
            List<tblDepartment> departments = dbcontext.tblDepartments.ToList();

            return View(departments);
        }
    }
}