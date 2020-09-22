using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAPartialViews.Models;

namespace WAPartialViews.ViewModels
{
    public class UserAddressesVewModel
    {
        public int UserID { get; set; }
        public List<Address> UserAddresses { get; set; }
    }
}