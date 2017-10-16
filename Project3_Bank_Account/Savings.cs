using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_Bank_Account
{
    class Savings : Account
    {
        private string minimumBalance;

        public Savings()
        {

        }

        public Savings(string acctNumber, double acctBalance, string acctType, double depositAmount, double withdrawAmount, double newBalance)
        {
            this.AcctNumber = acctNumber;
            this.AcctBalance = acctBalance;
            this.AcctType = acctType;
            this.DepositAmount = depositAmount;
            this.WithdrawAmount = withdrawAmount;
            this.NewBalance = newBalance;
        }

        public override double DisplayBalance()
        {
            Console.WriteLine("Savings balance: ");
            return AcctBalance;
        }

        public override void Withdraw(double withdrawAmount)
        {
            while (WithdrawAmount > AcctBalance)
            {
                Console.WriteLine("You can't withdraw more than $" + minimumBalance + ". Please input a new amount.");
                WithdrawAmount = double.Parse(Console.ReadLine());
            }
            AcctBalance -= WithdrawAmount;
        }

        public override void Deposit(double depositAmount)
        {
            AcctBalance += DepositAmount;
        }

        //{
        //    if (AcctBalance > WithdrawAmount)
        //    {
        //        return NewBalance = (AcctBalance - WithdrawAmount);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Insufficient funds for a withdrawal.");
        //        return AcctBalance;
        //    }

        //}

    }
}
