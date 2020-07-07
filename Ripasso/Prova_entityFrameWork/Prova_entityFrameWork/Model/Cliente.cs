using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_entityFrameWork.Model
{
    public class Cliente
    {
        int Id { get; set; }
        string nome { get; set; }
        string cognome { get; set; }
        List<Indirizzo>indirizzi { get; set; }

    }
}
