using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDemo1.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }

        public System.Data.Entity.DbSet<BusinessLibrary.Employee1> Employees { get; set; }
    }
}