using ConsoleApp2.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            ConsoleApp2.Model.AppContext context = new ConsoleApp2.Model.AppContext();

            context.Customers.Add(new Model.Customer()
            {
                Name = "Papero",
                Surname = "Bello"
            });

            List<Customer> customers = context.Customers.ToList();

            //Customer customer;
            
            //customer = context.Customers.Where(c => c.Name == "Paolino")
            //    .FirstOrDefault(); //SELECT * FROM Customers WHERE Name = 'Paolino'

            //customer = context.Customers.Where(c => c.Name == "Paolino")
            //    .Include(c => c.Addresses)
            //    .FirstOrDefault(); //SELECT * FROM Customers INNER JOIN Addresses ON Customers.ID = Addresses.ID WHERE Name = 'Paolino'

            //customer.Surname = "Paperinoooooo";

            //if(customer != null)
            //{
            //    customer.Addresses = new List<Address>();
            //    customer.Addresses.Add(new Address()
            //    {
            //        Street = "Via Paperinia 123",
            //        City = "Paperopoli",
            //        Country = "Boh"
            //    });
            //}


            context.SaveChanges();

        }
    }
}
