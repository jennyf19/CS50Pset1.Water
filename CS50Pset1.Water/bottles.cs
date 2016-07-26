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

        public Bottles(string minutes, out int showerLength)
        {
            showerLength = Int32.Parse(minutes);
        }

        #region Methods

        public int Shower(int showerLength)
        {
            if (showerLength <= 0)
            {
                Console.WriteLine("Please enter a value greater than 0");
            }
           else  numberOfBottles = (showerLength*12);
            return numberOfBottles;
            
        }

        #endregion

    }
}
