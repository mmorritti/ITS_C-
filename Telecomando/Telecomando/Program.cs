using System;

namespace Telecomando
{
    class Program
    {
        static void Main(string[] args)
        {
            Telecomando t = new Telecomando();

            t.CanaleAv = 1;
            t.VolumeSu = 0;

            Console.WriteLine(t.MandaAvanti());
            Console.WriteLine(t.Alza());

            Console.ReadKey();
        }
    }
}
