using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{   //Here we construct bankaccounts
    public class BankAccount
    {
        public string _AccountName;
        public double _Balance;

        public BankAccount(string accountname, double balance)
        {
            _AccountName = accountname;
            _Balance = balance;
        }
    }   
}
