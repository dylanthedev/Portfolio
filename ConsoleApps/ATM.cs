using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            //Allows the do while statement to run until the user hits exit
            bool repeat = true;

            //decimal value for keeping track of account balance
            decimal accountBalance = 0;

            do
            {
                //Prompt user to enter in their account number
                Console.WriteLine("Please enter your account number: ");
                int accountNumber = Convert.ToInt32(Console.ReadLine());

                //If account number is correct, have customer enter PIN
                if (accountNumber == 1234)
                {
                    Console.WriteLine("Please enter your PIN: ");
                    int pin = Convert.ToInt32(Console.ReadLine());

                    //if pin number is correct, open menu
                    if (pin == 1111)
                    {

                        do
                        {
                            Console.WriteLine("Please type an action:\n" +
                                "B) Balance\nD) Deposit\nW) Withdrawal\nE) Exit");

                            //Captures user input
                            ConsoleKey userAction = Console.ReadKey().Key;


                            Console.Clear();

                            //Makes sure user inputs correct action
                            switch (userAction)
                            {
                                case ConsoleKey.B:
                                    Console.WriteLine($"Your balance is: {accountBalance:c}");
                                    break;

                                case ConsoleKey.D:
                                    Console.Write("Enter the amount you want to deposit: $");
                                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                                    accountBalance += depositAmount;
                                    Console.WriteLine($"You have deposited {depositAmount:c} into account: {accountNumber}.\n" +
                                        $"Your balance is now: {accountBalance:c}");
                                    break;

                                case ConsoleKey.W:
                                    Console.Write("Enter the amount you want to withdrawal: $");
                                    decimal withdrawalAmt = Convert.ToDecimal(Console.ReadLine());

                                    //If account balance is greater than or equal to withdrawal amount,
                                    //perform withdraw and subtract from account balance.
                                    if (accountBalance >= withdrawalAmt)
                                    {
                                        accountBalance -= withdrawalAmt;
                                        Console.WriteLine($"You have withdrawn {withdrawalAmt:c} from the account: {accountNumber}\n" +
                                            $"Your leftover balance is: {accountBalance:c}.");
                                    }

                                    else
                                    {
                                        Console.WriteLine($"Insufficient funds.\nYour balance is: {accountBalance:c}.");
                                    }
                                    break;

                                case ConsoleKey.E:
                                    Console.WriteLine("Thank you for banking with Dylan's Bank.");
                                    repeat = false;
                                    break;

                                default:
                                    Console.WriteLine("Invalid option. Try again. ");
                                    break;
                            }//end switch

                        }
                        while (repeat); //end do while
                    }//end if

                    

                }//end if

                else
                {
                    Console.WriteLine($"Account number invalid.");

                    repeat = false;


                }//end else
            } while (repeat);
         
        }//end Main()
            


    }//end class
}//end namespace

