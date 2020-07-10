using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errogazione_Corsi_entityFrameworks_.Model
{
    [Table("Corsi Passati")]
    public class CorsiPassati
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Titolo { get; set; }

        [Column("Numero Studenti")]
        [Required]
        public int NumeroPartecipanti { get; set; }
        public int Giudizio { get; set; }

        [Column("Data inizio")]
        [Required]
        public DateTime DataInizio { get; set; }

        [Column("Data fine")]
        [Required]
        public DateTime DataFine { get; set; }

        public List<Partecipanti> partecipantis { get; set; }



    }
}
