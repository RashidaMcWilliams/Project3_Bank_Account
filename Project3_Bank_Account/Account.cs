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
        protected double newBalance;

        public string AcctNumber { get; set; }
        public double AcctBalance { get; set; }
        public string AcctType { get; set; }
        public double DepositAmount
        {
            get { return this.DepositAmount; }
            set { this.DepositAmount = value; }
        }
        public double WithdrawAmount
        {
            get { return this.WithdrawAmount; }
            set { this.WithdrawAmount = value; }
        }
        public double NewBalance { get; set; }

        public Account()
        {

        }

        public Account(string acctNumber, double acctBalance, string acctType, double newBalance)
        {
            this.AcctNumber = acctNumber;
            this.AcctBalance = acctBalance;
            this.AcctType = acctType;
            this.NewBalance = newBalance;
        }

        public virtual double DisplayBalance()
        {
            return AcctBalance; 
        }

        public virtual void Deposit(double DepositAmount)
        {
            NewBalance = (AcctBalance + DepositAmount); 
        }

        public abstract void Withdraw(double withdraw);


    }
}
