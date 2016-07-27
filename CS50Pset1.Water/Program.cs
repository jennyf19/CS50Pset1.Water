using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50Pset1.Water
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("How long is your shower in minutes?");
            int input = Int32.Parse(Console.ReadLine());
            int numberOfBottles;
            Bottles myBottles = new Bottles(input, out numberOfBottles);
            //int showerLength;
            //Int32.TryParse(input, out showerLength);


            Console.WriteLine("Minutes: {0} Bottles: {1}", input, numberOfBottles);
            Console.ReadLine();


        }
    }
}
