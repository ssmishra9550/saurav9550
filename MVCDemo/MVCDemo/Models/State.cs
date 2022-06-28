using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [Table("Tbl_State1")] 
    public class State
    {
        [Key]
        public int State_id { get; set; }
        public string State_name { get; set; }
        public string StateCode { get; set; }


    }
}