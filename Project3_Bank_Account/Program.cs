using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_Bank_Account
{
    class Program
    {
        //fields
        protected static double depositAmount;
        protected static double withdrawAmount;
        private static int userInput;
        private static string userTrans;

        public static double DepositAmount { get; set; }
        public static double WithdrawAmount { get; set; }

        static void Main(string[] args)
        {
            //string atm;
            do
            {
                //objects
                Client client = new Client("Khadijah Wilson", "1756 Treetop Drive Savannah, Georgia", "674392108");

                Savings savings = new Savings("345678129", 2595.01d, "Savings", 0.00d, 0.00d);
                //Savings savings = new Savings();
                //savings.AcctType = "Savings";
                //savings.AcctNumber = "345678129";
                //savings.AcctBalance = 2595.01d;

                //Checking checking = new Checking("765923610", 473.25d, "Checking", 0.00d, 0.00d);
                Checking checking = new Checking();
                checking.AcctType = "Checking";
                checking.AcctNumber = "765923610";
                checking.AcctBalance = 473.25d;
                //checking.DepositAmount = depositAmount;
                //checking.WithdrawAmount = withdrawAmount;


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

                //bank navigation
                if (userInput == 1)
                {
                    Console.WriteLine(client.ClientInfo());
                    Console.WriteLine();
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
                        Console.WriteLine();
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine(savings.DisplayBalance());
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please try again.");
                        userInput = int.Parse(Console.ReadLine());
                    }
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("Please select an account.");
                    Console.WriteLine("1. Checking");
                    Console.WriteLine("2. Savings");

                    if (userInput == 1)
                    {
                        Console.WriteLine("Please enter deposit amount.");
                        DepositAmount = Convert.ToDouble(Console.ReadLine());
                        checking.Deposit();
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("Please enter deposit amount.");
                        DepositAmount = Convert.ToDouble(Console.ReadLine());
                        savings.Deposit();
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please try again.");
                        userInput = int.Parse(Console.ReadLine());
                    }
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("Please select an account to withdraw from.");
                    Console.WriteLine("1. Checking");
                    Console.WriteLine("2. Savings");
                    userInput = int.Parse(Console.ReadLine());

                    if (userInput == 1)
                    {
                        Console.WriteLine("Please enter withdrawal amount.");
                        WithdrawAmount = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(checking.Withdraw());
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("Please enter withdrawal amount.");
                        WithdrawAmount = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(savings.Withdraw());
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please try again.");
                        userInput = int.Parse(Console.ReadLine());
                    }
                }
                else if (userInput == 5)
                {
                    Console.WriteLine("Thank you for your business. Have a nice day.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please try again.");
                    userInput = int.Parse(Console.ReadLine());
                }





                //User input to contine/end transaction
                Console.WriteLine("Would you like to make another transaction? Enter yes to continue.");
                userTrans = Console.ReadLine().ToUpper();
                if (userTrans == "YES")
                {
                    continue;
                }
               
            }
            while (userInput < 5);



            //atm = Console.ReadLine().ToUpper();
            //if (atm == "EXIT")
            //{
            //    Console.WriteLine("Thank you for your business. Have a nice day.");
            //}

            //Console.WriteLine("Would you like to make another transaction?");
            //if (userInput == 5)
            //{
            //    Console.WriteLine("Thank you for your business. Have a nice day.");
            //}

            //(atm == "EXIT");

        }

    }
}
