using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAPartialViews.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<Address> Addresses { get; set; }
    }
}