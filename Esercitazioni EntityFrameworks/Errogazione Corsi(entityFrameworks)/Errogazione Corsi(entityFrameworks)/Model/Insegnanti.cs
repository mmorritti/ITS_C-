using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errogazione_Corsi_entityFrameworks_.Model
{
    public class Insegnanti
    {
        public int ID { get; set; }

        [MaxLength(20)]
        [Required]
        public string Cognome { get; set; }

        [Column("Età")]
        [Required]
        public int Eta { get; set; }

        [Column("Luogo di nascita")]
        [MaxLength(50)]
        [Required]
        public string LuogoNascita { get; set; }

        public List<CorsiAttuali>corsiAttualis { get; set; }
        public List<CorsiPassati>corsiPassatis { get; set; }






    }
}
