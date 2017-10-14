using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_Bank_Account
{
    class Program
    {
        private static double depositAmount;
        private static int userInput;
        private static double withdrawAmount;

        static void Main(string[] args)
        {
            string atm;
            do
            {
                //objects
                Client client = new Client("Khadijah Wilson", "1756 Treetop Drive Savannah, Georgia", "674392108");

                Savings savings = new Savings();
                savings.AcctType = "Savings";
                savings.AcctNumber = "345678129";
                savings.AcctBalance = 2595.00d;

                Checking checking = new Checking();
                checking.AcctType = "Checking";
                checking.AcctNumber = "765923610";
                checking.AcctBalance = 473.25d;


                //intial bank display
                Console.WriteLine("Welcome to Worthington Bank");
                Console.WriteLine("Please enter a number to begin.");
                Console.WriteLine();
                Console.WriteLine("1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");
                userInput = int.Parse(Console.ReadLine());

                if (userInput == 1)
                {
                    Console.WriteLine(client.ClientInfo());
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("Please select an account to display.");
                    Console.WriteLine("1. Checking");
                    Console.WriteLine("2. Savings");
                    userInput = int.Parse(Console.ReadLine());

                    if (userInput == 1)
                    {
                        Console.WriteLine(checking.DisplayBalance());
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine(savings.DisplayBalance());
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
                        depositAmount = Convert.ToDouble(Console.ReadLine());
                        checking.Deposit();
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("Please enter deposit amount.");
                        depositAmount = Convert.ToDouble(Console.ReadLine());
                        savings.Deposit();
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please try again.");
                    } 
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("Please select an account to withdraw from.");
                    Console.WriteLine("1. Checking");
                    Console.WriteLine("2. Savings");

                    if (userInput == 1)
                    {
                        Console.WriteLine("Please enter withdrawal amount.");
                        withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        checking.Withdraw();
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("Please enter deposit amount.");
                        depositAmount = Convert.ToDouble(Console.ReadLine());
                        savings.Withdraw();
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please try again.");
                    }
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
                Console.WriteLine("Would you like to make another transaction?");
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
