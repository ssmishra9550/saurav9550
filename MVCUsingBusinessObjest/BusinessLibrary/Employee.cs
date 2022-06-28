using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary
{
    public interface IEmployee
    {
        
        string Gender { get; set; }
        string City { get; set; }

    }
    public class Employee : IEmployee
    {
        public int Id { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int DepartmentId { get; set; }
    }
}
