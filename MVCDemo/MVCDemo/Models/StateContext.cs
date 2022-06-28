using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class StateContext : DbContext
    {
        public DbSet<State> states { get; set; }
    }
}