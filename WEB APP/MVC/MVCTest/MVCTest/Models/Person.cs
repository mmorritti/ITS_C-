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
        [Required]//obbligatorio
        [MaxLength(50)] //data anotation per customizzare
        public string name { get; set; }
        [Required]
        [MaxLength(50)]
        public string surname { get; set; }
        [MaxLength(100)]
        public string mail { get; set; }




    }
}