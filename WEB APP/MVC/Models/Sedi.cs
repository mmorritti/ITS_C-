using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ErogazioneCorsi.Models
{
    public class Sedi
    {
        public int id { get; set; }
        [Column("Nome Sede"),Required, MaxLength(200)]
        public string nomeSede { get; set; }
        [Column("Indirizzo"),Required, MaxLength(100)]
        public string indirizzo { get; set; }
        [Column("CAP"), Required]
        public int cap { get; set; }
        [Column("Città"), Required, MaxLength(100)]
        public string citta { get; set; }
        public List<Azienda>aziendas { get; set; }
    }
}