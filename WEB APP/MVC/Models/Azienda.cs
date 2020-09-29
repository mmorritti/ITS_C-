using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ErogazioneCorsi.Models
{
    public class Azienda
    {
        
        public int id { get; set; }
        [Column("Ragione Sociale"),Required, MaxLength(100)]
        public string ragioneSociale { get; set; }
        [Column("Partita Iva"),Required, MaxLength(15)]
        public string pIva { get; set; }
        [Column("Email"),MaxLength(200)]
        public string email { get; set; }
    }
}