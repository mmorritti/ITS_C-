using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ErogazioneCorsi.Models
{
    public class Docenti
    {
        public int id { get; set; }
        [Required, MaxLength(50)]
        public string nome { get; set; }
        [Required, MaxLength(50)]
        public string cognome { get; set; }
        [Required, MaxLength(150)]
        public string indirizzo { get; set; }
        [Required, MaxLength(10)]
        public string cap { get; set; }
        [Required, MaxLength(50)]
        public string citta { get; set; }
        [Required, MaxLength(15)]
        public string numeroTelefono { get; set; }
        public List<Corsi> corsis { get; set; }

    }
}