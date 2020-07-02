using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Animal : IAnimal, IDisposable
    {
        public string Classificazione { get; set; }
        public string Razza { get; set; }

        public void Salta()
        {

        }

        public abstract string Mangia();

        public string Salta(int meters)
        {
            return "L'animale salta " + meters + " Metri.";
        }

        public void Dispose()
        {
            
        }
    }
}
