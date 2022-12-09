using System;
using System.Collections.Generic;

namespace Team.Mango.Bank_Application
{   //Here we construct bankaccounts
    public class BankAccount : AdminMenu
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
                double balance = item.Balance;
                Console.WriteLine(A + ". {0}: {1:f2} SEK", item.AccountName, balance);
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
            Console.WriteLine("Select currency:");
            Console.WriteLine("| [1] Kronor, SEK   [2] Euro, EUR    [3] Dollar, USD   |");
            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {

                case 1:
                    BankAccount BankAccInfo = new BankAccount(accountName, amount);
                    NewBankAcc.Add(BankAccInfo);
                    break;
                case 2:
                    double amount2 = amount * 11.6531;  //Euro 221207 
                    BankAccount BankAccInfoEUR = new BankAccount(accountName, amount2);
                    NewBankAcc.Add(BankAccInfoEUR);
                    break;
                case 3:
                    double amount3 = amount * 11.2343;  //Dollar 221207 
                    BankAccount BankAccInfoUSD = new BankAccount(accountName, amount3);
                    NewBankAcc.Add(BankAccInfoUSD);
                    break;
                default:
                    Console.WriteLine("Please select currency");
                    break;
            }
        }
    }
}
