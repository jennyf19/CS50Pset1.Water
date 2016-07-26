using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50Pset1.Water
{
    class Program
    {
        private static int numberOfBottles;

        static void Main(string[] args)
        {
            Console.WriteLine("How long is your shower in minutes?");
            string input = Console.ReadLine();
            int i;
            Bottles myBottles = new Bottles(input, out i);
            int showerLength;
            Int32.TryParse(input, out showerLength);

            Console.WriteLine("Minutes: {0} Bottles: {1}", showerLength, numberOfBottles);
            Console.ReadLine();


        }
    }
}
