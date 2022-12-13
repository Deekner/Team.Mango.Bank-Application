using System;
using System.Collections.Generic;

namespace Team.Mango.Bank_Application
{   //Here we construct bankaccounts
    public class BankAccount
    {
        public string _AccountName;
        public double _Balance;
        public string _CurrencyType;

        public BankAccount(string accountname, double balance, string type)
        {
            _AccountName = accountname;
            _Balance = balance;
            _CurrencyType = type;
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

        public string CurrencyType
        {
            get { return _CurrencyType; }
            set { _CurrencyType = value; }
        }

        public static void ShowAccounts(User CurrentUser)
        {
            Console.WriteLine("Private accounts");
            Console.WriteLine();
            // Account start with nr 1
            int A = 1;
            //Set CurrentUsers BankAccountList as UserAcc and loop through all accounts
            List<BankAccount> printSEK = CurrentUser.BankAccountList.FindAll(c => c.CurrencyType == "SEK");
            foreach (var item in printSEK)
            {
                double balanceSEK = item.Balance;
                Console.WriteLine(A + ". {0}: {1:f2} SEK", item.AccountName, balanceSEK);
                Console.WriteLine();
                A++;
            }

            List<BankAccount> printUSD = CurrentUser.BankAccountList.FindAll(c => c.CurrencyType == "USD");
            foreach (var item in printUSD)
            {
                double balanceUSD = item.Balance;
                Console.WriteLine(A + ". {0}: {1:f2} USD", item.AccountName, balanceUSD);
                Console.WriteLine();
                A++;
            }








        }
        public static void OpenBankAccount(User CurrentUser)
        {

            Console.Clear();
            Console.WriteLine("-------- Open Bank account --------\n");

            Console.Write("Account name: ");
            string accountName = Console.ReadLine();
            Console.Write("Deposit Amount: ");
            double amount = double.Parse(Console.ReadLine());

            List<BankAccount> NewBankAcc = CurrentUser.BankAccountList;
            BankAccount BankAccInfo = new BankAccount(accountName, amount,"SEK");
            NewBankAcc.Add(BankAccInfo);

        }
    }
}
