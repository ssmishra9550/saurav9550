using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary
{
    public class EmployeeBusinessLayer
    {
        public IEnumerable<Employee1> Employees
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;
                List<Employee1> employees = new List<Employee1>();
                using (SqlConnection con= new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("getAllEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Employee1 employee = new Employee1();
                        employee.Id = Convert.ToInt32(rdr["Id"]);
                        employee.EmployeeName = rdr["EmployeeName"].ToString();
                        employee.Gender = rdr["Gender"].ToString();
                        employee.City = rdr["City"].ToString();

                        employees.Add(employee);
                    }
                }
                return employees;
            }
            
        }
    }
} 
