using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    public static class Utility
    {
        public static string ConvertiAnimale(Animal a)
        {
            return a.Classificazione + " " + a.Razza;
        }

        
    }
}
