using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop2
    {
        static void Main(string[] args)
        {
            //array of fruits
            string[] fruits = {"Banana", "Apple", "Orange",
                "Strawberry", "Kiwi", "Cherry"};
            //empty string that will add "." each iteration
            string period = "";

            
            for (int i = 0; i < fruits.Length; i++)
            {
                //outputs each fruit that is stored in the array
                Console.WriteLine(fruits[i]);

                //adds a "." after each iteration in the loop
                period += ".";
                Console.WriteLine(period);
            }
        }//end Main()
    }//end class
}//end namespace
