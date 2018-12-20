using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class InterestCalc
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the beginning balance: ");
            decimal balance = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the interest rate percentage: ");
            decimal interest = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the number of years: ");
            int years = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The amount you will have in {years} is ");
        }//end Main()
    }//end class
}//end namespace
