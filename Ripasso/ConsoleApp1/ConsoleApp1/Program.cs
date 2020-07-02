using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Felino felino = new Felino("Mammifero", "tigre", "pippo");
                Felino f = new Felino();
                Elefante e = new Elefante();

                e.Salta(30);

                Console.WriteLine(f.Mangia());
                Console.WriteLine(e.Mangia());
                Console.WriteLine(e.Salta(5));

                string conversione = Utility.ConvertiAnimale(felino);
                Console.WriteLine(conversione);

                Erbivoro er = new Erbivoro(); //istanzio la classe parziale e in fase di esecuzione vengono uniti i file
                er.Salta();
                er.Mangia();

                Console.ReadKey();
            }
            catch( FileNotFoundException fnfex)
            {

            }
            catch(NotImplementedException niex)
            {

            }
            catch ( Exception ex)
            {

                throw;
            }
            finally
            {
                //nel caso del db se conn aperta va chiusa 
            }
        }
    }
}
