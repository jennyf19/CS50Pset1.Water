using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50Pset1.Water
{
    class Bottles
    {

        public int numberOfBottles;
        public int showerLength;
        private int input;

        public Bottles(int input, out int numberOfBottles)
        {
            if (input <= 0)
            {
                Console.WriteLine("Please enter a value greater than 0");
            }

            this.input = input;
            numberOfBottles = input * 12;
        }

        public Bottles(string minutes, out int showerLength)
        {
            showerLength = Int32.Parse(minutes);
        }

        #region Methods

        /* public int Shower(int input)
         {
             if (input <= 0)
             {
                 Console.WriteLine("Please enter a value greater than 0");
             }
            else  numberOfBottles = input*12;
             return numberOfBottles;

         }*/

        #endregion

    }
}
