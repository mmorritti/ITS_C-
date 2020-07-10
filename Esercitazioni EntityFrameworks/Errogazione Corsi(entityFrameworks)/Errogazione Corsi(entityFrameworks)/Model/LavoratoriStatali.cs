using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errogazione_Corsi_entityFrameworks_.Model
{

    [Table("Lavoratori Statali")]
    public class LavoratoriStatali
    {
        public int ID { get; set; }

        [Required]
        public int Livello { get; set; }

        [Column("Posizione ricoperta")]
        [Required]
        [MaxLength(50)]
        public string posizioneRicoperta { get; set; }

    }
}
