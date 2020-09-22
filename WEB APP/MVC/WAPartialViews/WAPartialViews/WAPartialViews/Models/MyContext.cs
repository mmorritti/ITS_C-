using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WAPartialViews.Models
{
    public class MyContext : DbContext
    {
        public MyContext()
        {
            new MyContext(Properties.Settings.Default.MyConnection);
        }

        public MyContext(string connectionString) : base(connectionString) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}