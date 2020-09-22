using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{
    public class MyContext : DbContext
    {
        private string connectionString;

        public MyContext()
        {
            this.connectionString = Properties.Settings.Default.MyConnection;
        }


        public MyContext(string connectionString) : base(connectionString) { }
        public DbSet<Person> people { get; set; }
        public DbSet<User> users { get; set; }

    }
    
       
    
}