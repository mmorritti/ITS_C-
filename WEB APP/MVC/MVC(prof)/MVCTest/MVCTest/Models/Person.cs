using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{
    [Table("People", Schema = "ANG")]
    public class Person
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        
        [MaxLength(100)]
        public string Email { get; set; }
    }
}