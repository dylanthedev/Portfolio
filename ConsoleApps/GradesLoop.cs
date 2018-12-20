using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class GradesLoop
    {
        static void Main(string[] args)
        {

            /*
             * Ask the user for scores and display those scores.
             * The program should stop asking for scores and display
             * all the scores when the user enters a negative number.
             */
            Console.WriteLine("Please enter as many scores as you have. " +
                "Enter any negative value to stop.");


            
            bool repeat = true;
            

            //empty string for displaying scores at the end
            string scores = "";
            int score = 0;

            while (repeat)
            {
                
                if (score >= 0)
                {
                    Console.WriteLine("Enter a score: ");
                    score = Convert.ToInt32(Console.ReadLine());
                    if (score >= 0)
                    {
                        scores += Convert.ToString(score) + "\n";
                    }//end if

                }//end if

                else
                {
                    repeat = false;
                    Console.WriteLine("Your scores are: ");
                    Console.WriteLine(scores);

                }//end else
            }
            



        }//end Main()
    }//end class
}//end namespace
