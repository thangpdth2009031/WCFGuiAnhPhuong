using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WCFServer.Entity;

namespace WCFServer.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext():base("name=MyConnectionString")
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}