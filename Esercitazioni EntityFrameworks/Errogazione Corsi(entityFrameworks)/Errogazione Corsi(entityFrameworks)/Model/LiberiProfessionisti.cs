using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errogazione_Corsi_entityFrameworks_.Model
{

    [Table("Liberi Professionisti")]
    public class LiberiProfessionisti
    {
        public int ID { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Titolo { get; set; }
        
    }
}
