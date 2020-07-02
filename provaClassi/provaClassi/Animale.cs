using System;
using System.Collections.Generic;
using System.Text;

namespace provaClassi
{
    class Animale
    {
        
        public Animale()
        {
            this.Salta = string.Empty;
            this.Razza = string.Empty;
        }

        public Animale(string salta, string razza)
        {
            this.Salta = salta;
            this.Razza = razza;
        }

        public string Salta { get; set; }
        public string Razza { get; set; }

        public void Mangia ()
        {

        }


    }
}
