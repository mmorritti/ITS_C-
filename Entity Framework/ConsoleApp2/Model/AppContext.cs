using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Model
{
    public class AppContext : DbContext
    {
        public AppContext() : base(@"Server=localhost\SQLEXPRESS;Database=MyCustomerDB;User ID=sa;Password=Its2020!")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }
}
