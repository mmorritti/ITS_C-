using System;
using System.Collections.Generic;
using System.Text;

namespace TelecomandoMorritti
{
    class Telecomando
    {
        private int volume = 0;
        private int canale = 1;

        public int Volume { get; set; }
        public int Canale { get; set; }

        public Telecomando()
        {

        }

        public Telecomando(int volume,int canale)
        {
            volume = Volume;
            canale = Canale;
        }

        public int CanaleAvanti()
        {
            return canale++;
        }

        public int CanaleIndietro()
        {
            return canale--;
        }

        public int ModVolP()
        {
            return volume++;
        }

        public int ModVolM()
        {
            return volume--;
        }


    }
}
