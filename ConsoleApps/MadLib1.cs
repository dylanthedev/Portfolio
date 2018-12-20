using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib1
    {
        static void Main(string[] args)
        {
            /* Create a "mad lib" that asks the user for various
             * pieces of information. Store the information as
             * strings. Once the information has been collected,
             * output a story using the stored information.
             */
            Console.WriteLine("Let's make a mad lib!");

            Console.Write("Add a noun: ");
            string noun = Console.ReadLine();

            Console.Write("Add a verb: ");
            string verb = Console.ReadLine();

            Console.Write("Add an adjective: ");
            string adj = Console.ReadLine();

            Console.Write("Add another noun: ");
            string noun2 = Console.ReadLine();

            Console.Write("Add a verb that ends with -ing: ");
            string verbIng = Console.ReadLine();

            Console.Write("Add another adjective: ");
            string adj2 = Console.ReadLine();

            Console.Write("Add an adverb: ");
            string adverb = Console.ReadLine();

            Console.Write("Add an exclamation: ");
            string exclamation = Console.ReadLine();

            Console.Write("Add a city: ");
            string city = Console.ReadLine();

            Console.Write("Add a time: ");
            string time = Console.ReadLine();

            Console.WriteLine($"One day there was a {noun} that didn't want to {verb} anymore." +
                $" And so, like any good {adj} {noun2}, the {noun} decided to go {verbIng}." +
                $" But sometimes the universe is a {adj2} mistress, and destiny {adverb}" +
                $" called.\nAfter that, the {noun} exclaimed '{exclamation}', and they" +
                $" heard it all the way in {city}!\nAnd the {noun} vowed not to return" +
                $" until {time}.");
            Console.ReadKey();



        }//end Main()
    }//end class
}//end namespace
