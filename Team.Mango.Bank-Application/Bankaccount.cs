using System;
using System.Collections.Generic;

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

        public string AccountName
        {
            get { return _AccountName; }
            set { _AccountName = value; }
        }
        public double Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }

        public static void ShowAccounts(User CurrentUser)
        {
            Console.WriteLine("Private accounts");
            Console.WriteLine();
            // Account start with nr 1
            int A = 1;
            //Set CurrentUsers BankAccountList as UserAcc and loop through all accounts
            List<BankAccount> UserAcc = CurrentUser.BankAccountList;
            foreach (var item in UserAcc)
            {
                double balance = i.Balance;
                Console.WriteLine(A + ". {0}: {1:f2} SEK", item.AccountName, balance);
                Console.WriteLine();
                A++;
            }
        }
    }
}
