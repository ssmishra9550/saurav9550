using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo1.Models
{
    [Table("tblDepartment")]
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public List<Employee> employees { get; set; }
    }
}