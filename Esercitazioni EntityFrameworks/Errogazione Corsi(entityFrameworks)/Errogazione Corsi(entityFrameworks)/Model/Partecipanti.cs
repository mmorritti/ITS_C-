using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errogazione_Corsi_entityFrameworks_.Model
{
    public class Partecipanti
    {

        public int ID { get; set; }

        [Column("Codice Fiscale")]
        [MaxLength(20)]
        [Required]
        public string codiceFiscale { get; set; }

        [Required]
        public string Cognome { get; set; }
        public int Eta{ get; set;}

        [MaxLength(20)]
        public string Sesso { get; set; }

        [Column("Luogo di nascita")]
        [MaxLength(30)]
        [Required]
        public string luogoNascita { get; set; }

        public List<LiberiProfessionisti> liberiProfessionistis { get; set; }
        public List<LavoratoriStatali> lavoratoriStatalis { get; set; }





    }
}
