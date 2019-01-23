using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VideoLib.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }

        public MyDbContext()
        {
        }
    }
}