﻿using System;
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

        public Checking(string acctNumber, double acctBalance, string acctType, double depositAmount, double withdrawAmount)
        {
            this.acctNumber = acctNumber;
            this.acctBalance = acctBalance;
            this.acctType = acctType;
            this.depositAmount = depositAmount;
            this.withdrawAmount = withdrawAmount;
        }

        public override string DisplayBalance()
        {
            return acctType + "\n " + acctNumber + "\n" + base.DisplayBalance();
        }






    }
}