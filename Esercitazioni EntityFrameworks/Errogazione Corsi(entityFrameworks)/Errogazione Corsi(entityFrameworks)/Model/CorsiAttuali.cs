using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errogazione_Corsi_entityFrameworks_.Model
{

    [Table("Corsi Attuali")]
    public class CorsiAttuali
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Titolo { get; set; }

        [Column("Numero Partecipanti")]
        [Required]
        public int NumeroPartecipanti { get; set; }

        [Column("Data Lezione")]
        [Required]
        public DateTime DataLezione { get; set; }

        [Column("Luogo Lezione")]
        [Required]
        [MaxLength(50)]
        public string LuogoLezione { get; set; }

        [Column("Ore Lezione")]
        [Required]
        public int OreLezione { get; set; }

        public List<Partecipanti>partecipantis { get; set; }


    }
}
