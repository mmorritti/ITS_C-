using System;
using System.Collections.Generic;
using System.Text;

namespace Telecomando
{
    class Telecomando
    {
        private int volumeSu;
        private int volumeGiu;
        private int canaleAv;
        private int canaleIn;

        public int VolumeSu { get; set; }
        public int VolumeGiu { get; set; }
        public int CanaleAv{ get; set; }
        public int CanaleIn { get; set; }

        public Telecomando()
        {

        }
        public Telecomando(int volumeSu, int volumeGiu, int canaleAv, int canaleIn)
        {
            volumeSu = VolumeSu;
            volumeGiu = VolumeGiu;
            canaleAv = CanaleAv;
            canaleIn = CanaleIn;
        }

        public int MandaAvanti()
        {
            return canaleAv++;
        }

        public int MandaIndietro()
        {
            return canaleIn--;
        }

        public int Alza()
        {
            return volumeSu++;
        }
        public int Abbassa()
        {
            return volumeGiu--;
        }


    }
}
