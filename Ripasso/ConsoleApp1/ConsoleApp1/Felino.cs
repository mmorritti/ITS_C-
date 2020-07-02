using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Felino : Animal
    {
        public string Nome { get; set; }

        public Felino()
        {
            base.Classificazione = string.Empty;
            base.Razza = string.Empty;

        }

        //overload
        public Felino(string classificazione, string razza, string nome )
        {
            base.Classificazione = classificazione;
            base.Razza = razza;
            this.Nome = nome;
        }

        //override
        public override string Mangia()
        {
            return "Il felino mangia";
        }
    }
}
