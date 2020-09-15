using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeTier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Inserire una lettera:");
            //string lettera = Console.ReadLine();
            //ThreeTier_Business.Users u = new ThreeTier_Business.Users();
            //List<string> persons = u.GetUsefulUsers(lettera);

            Console.WriteLine("Inserire un cognome:");
            string cognome = Console.ReadLine();
            ThreeTier_Business.Users u = new ThreeTier_Business.Users();
            List<string> persons = u.GetSingleUser(cognome);

            //PRESENTAZIONE
            foreach (string p in persons)
                Console.WriteLine(p);

            Console.ReadLine();
        }
    }
}
