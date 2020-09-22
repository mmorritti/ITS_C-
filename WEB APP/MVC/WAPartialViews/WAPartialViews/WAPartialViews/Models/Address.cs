using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAPartialViews.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }

        public User User { get; set; }
    }
}