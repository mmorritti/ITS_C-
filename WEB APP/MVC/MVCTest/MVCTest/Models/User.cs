using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{
    public class User
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string username { get; set; }
        [MaxLength(50)]
        public string password { get; set; }
    }
}