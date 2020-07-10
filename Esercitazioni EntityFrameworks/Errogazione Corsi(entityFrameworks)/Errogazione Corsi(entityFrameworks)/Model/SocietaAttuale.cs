using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errogazione_Corsi_entityFrameworks_.Model
{
    [Table("Società Attuale")]
    public class SocietaAttuale
    {
        public int ID { get; set; }

        [Column("Data inizio")]
        [Required]
        public DateTime DataInizio { get; set; }

        [Column("Data Fine")]
        public DateTime DataFine { get; set; }

        [Required]
        [MaxLength(50)]
        public string Indirizzo { get; set; }

        [Column("Numero di telefono")]
        [MaxLength(50)]
        public string NumeroTelefono { get; set; }

        public List<LavoratoriStatali>lavoratoriStatalis { get; set; }

    }
}
