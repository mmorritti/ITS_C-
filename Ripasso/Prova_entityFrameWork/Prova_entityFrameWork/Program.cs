using Prova_entityFrameWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_entityFrameWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digita nome: ");
            string name = Console.ReadLine();
            Console.Write("Digita cognome: ");
            string surname = Console.ReadLine();

            ApContext context = new ApContext();

            context.Clienti.Add(new Model.Cliente()
            {
                Nome = name,
                Cognome = surname

            });

            List<Cliente> clienti = context.Clienti.ToList();






            context.SaveChanges();

            Console.WriteLine("Fine..");
            Console.ReadKey();

        }
    }
}
