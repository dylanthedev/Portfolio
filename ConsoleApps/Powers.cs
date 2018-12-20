using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Powers
    {
        static void Main(string[] args)
        {
            long num = 2;
            for (int power = 1; power <= 50; power++)
            {

                num *= 2;
                Console.WriteLine(num);

            }
        }//end Main()
    }//end class
}//end namespace
