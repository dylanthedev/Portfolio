using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {
            /* Declare and initialize an array of any six fruit names (as text).
             * Set up a FOR loop and iterate through them (displaying each value
             * in the console.)
             */
            string[] fruits = {"Banana", "Apple", "Orange",
                "Strawberry", "Kiwi", "Cherry"};

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }//end for
        }//end Main()
    }//end class
}//end namespace
