using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        public IEnumerable<Employee> employees
        {
            get
            {
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                List<Employee> employees = new List<Employee>();
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while(rdr.Read())
                    {
                        Employee employee = new Employee();
                        employee.Employeeid = Convert.ToInt32(rdr["Employeeid"]);
                        employee.Name = rdr["Name"].ToString();
                        employee.DepartmentId = Convert.ToInt32(rdr["DepartmentId"]);
                        employee.Address = rdr["Address"].ToString();

                        employees.Add(employee);
                    }
                }
                return employees;
            }
          

        }
    }
}
