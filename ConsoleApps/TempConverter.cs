using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            double cTemp = 0;
            double fTemp = 0;
            do
            {
                Console.WriteLine("Temperature Converter\nF) Fahrenheit to Celsius\n" +
                    "C) Celsius to Fahrenheit\nE) Exit");

                ConsoleKey userAction = Console.ReadKey().Key;

                Console.Clear();

                switch (userAction)
                {
                    case ConsoleKey.C:
                        Console.WriteLine("Enter a temperature (in Celsius): ");
                        cTemp = Convert.ToDouble(Console.ReadLine());

                        fTemp = cTemp * (9.0 / 5.0) + 32;
                        Console.WriteLine(fTemp + "\u00B0F");
                        break;

                    case ConsoleKey.F:
                        Console.WriteLine("Enter a temperature (in Fahrenheit): ");
                        fTemp = Convert.ToDouble(Console.ReadLine());

                        cTemp = (fTemp - 32) / (9.0 / 5.0);
                        Console.WriteLine(cTemp + "\u00B0C");
                        break;

                    case ConsoleKey.E:
                        Console.WriteLine("Thank you for using Dylan's Temperature" +
                            " Converter!");
                        repeat = false;
                        break;

                    default:
                        break;
                }
            } while (repeat);

            


        }//end Main()

    }//end class
}//end namespace
