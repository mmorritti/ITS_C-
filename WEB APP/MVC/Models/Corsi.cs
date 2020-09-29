using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ErogazioneCorsi.Models
{
    public class Corsi
    {
        public int id { get; set; }
        [Column("Nome Corso"),Required,MaxLength(100)]
        public string nome { get; set; }
        [Column("Data Inizio")]
        public DateTime dataInizio { get; set; }
        [Column("Data Fine")]
        public DateTime dataFine { get; set; }
        public List<Sedi>sedis { get; set; }
        public List<Partecipanti>partecipantis { get; set; }
        public List<Docenti>docentis { get; set; }
    }
}