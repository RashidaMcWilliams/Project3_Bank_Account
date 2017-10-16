using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_Bank_Account
{
    abstract class Account
    {
        protected string acctNumber;
        protected double acctBalance;
        protected string acctType;
        protected double depositAmount;
        protected double withdrawAmount;

        public string AcctNumber { get; set; }
        public double AcctBalance { get; set; }
        public string AcctType { get; set; }
        protected double DepositAmount { get; set; }
        protected double WithdrawAmount { get; set; }

        public Account()
        {

        }

        public Account(string acctNumber, double acctBalance, string acctType)
        {
            this.AcctNumber = acctNumber;
            this.AcctBalance = acctBalance;
            this.AcctType = acctType;
        }

        public virtual double DisplayBalance()
        {
            return AcctBalance; 
        }

        public virtual double Deposit()
        {
            return AcctBalance + DepositAmount;
        }

        public abstract double Withdraw();



    }
}
