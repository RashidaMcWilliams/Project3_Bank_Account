using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_Bank_Account
{
    class Program
    {
        private static string depositAmount;
        private static int userInput;

        static void Main(string[] args)
        {
            string atm;
            do
            {
                Client user2 = new Client("Khadijah Wilson", "1756 Treetop Drive Savannah, Georgia", "674392108");

                Savings user3 = new Savings();
                user3.AcctType = "Savings";
                user3.AcctNumber = "345678129";
                user3.AcctBalance = 2595.00;

                Checking user1 = new Checking();
                user1.AcctType = "Checking";
                user1.AcctNumber = "765923610";
                user1.AcctBalance = 473.25;


                //intial bank display
                Console.WriteLine("Welcome to Worthington Bank");
                Console.WriteLine("Please make enter a number to begin.");
                Console.WriteLine();
                Console.WriteLine("1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");
                userInput = int.Parse(Console.ReadLine());

                if (userInput == 1)
                {
                    Console.WriteLine(user2.Name);
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("Please select an account to display.");
                    Console.WriteLine("1. Checking");
                    Console.WriteLine("2. Savings");
                    userInput = int.Parse(Console.ReadLine());

                    if (userInput == 1)
                    {
                        Console.WriteLine(user1.AcctBalance);
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine(user3.AcctBalance);
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please try again.");
                    }
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("Please select an account to deposit into.");
                    Console.WriteLine("1. Checking");
                    Console.WriteLine("2. Savings");

                    if (userInput == 1)
                    {
                        Console.WriteLine("Please enter deposit amount.");
                        depositAmount = Console.ReadLine();
                        user1.Deposit();
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("Please enter deposit amount.");
                        depositAmount = Console.ReadLine();
                        user3.Deposit();
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please try again.");
                    } 
                }
                else if (userInput == 4)
                {

                }
                else if (userInput ==5)
                {
                    Console.WriteLine("Thank you for your business. Have a nice day.");
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please try again.");
                    userInput = int.Parse(Console.ReadLine());
                }

                



                //User input to contine/end transaction
                Console.WriteLine("Would you like to make another transcation?");
                atm = Console.ReadLine().ToUpper();
                if (atm == "EXIT")
                {
                    Console.WriteLine("Thank you for your business. Have a nice day.");
                }
            }
            while (atm == "EXIT");

        }
            
    }
}
