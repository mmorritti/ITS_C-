using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Web;

namespace ErogazioneCorsi.Models
{

    
    public class Partecipanti
    {
        public int id { get; set; }
        [Column("Nome"),Required,MaxLength(50)]
        public string nome { get; set; }
        [Column("Cognome"),Required, MaxLength(50)]
        public string cognome { get; set; }
        [Column("Indirizzo"),Required, MaxLength(100)]
        public string indirizzo { get; set; }
        [Column("CAP"),Required]
        public string cap { get; set; }
        [Column("Città"),Required, MaxLength(100)]
        public string citta { get; set; }
        [Column("Numero Telefono"),Required, MaxLength(15)]
        public string numeroTelefono { get; set; }
    }
}