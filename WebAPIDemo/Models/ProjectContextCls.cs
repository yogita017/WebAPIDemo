using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    public class ProjectContextCls : DbContext

    {
        public ProjectContextCls() : base("name=ProjectContext")

        {

        }
        public DbSet<Product> Products { set; get; }

        public DbSet<Order> Orders { get; set; }


    }
}
