using System;

namespace TelecomandoMorritti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci canale attuale: ");
            int canale = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserisci volume attuale: ");
            int volume = Convert.ToInt32(Console.ReadLine());

            Telecomando t = new Telecomando(volume, canale);

            
            Console.WriteLine(t.Canale);



            Console.ReadKey();
        }
    }
}
