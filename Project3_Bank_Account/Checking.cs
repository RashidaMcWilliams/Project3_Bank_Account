using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_Bank_Account
{
    class Checking : Account
    {
        public Checking()
        {

        }

        public Checking(string acctNumber, double acctBalance, string acctType, double depositAmount, double withdrawAmount, double newBalance)
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
            Console.WriteLine("Checking balance: ");
            return AcctBalance;
        }

        public override double Withdraw()
        {
            return NewBalance = (AcctBalance - WithdrawAmount);
        }






    }
}
