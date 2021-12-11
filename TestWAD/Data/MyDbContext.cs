using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestWAD.Models;

namespace TestWAD.Data
{
    public class MyDbContext : DbContext 
    {
        public MyDbContext() : base("name=MyConnectionString")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}