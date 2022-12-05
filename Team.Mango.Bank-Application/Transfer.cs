using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    internal class Transfer : Menu
    {
        public static void transfer(Users CurrentUser)
        {
            decimal fromAccount;
            decimal toAccount;


            Console.Clear();
            Console.WriteLine("Which account would you like to transfer money from?");
            Console.WriteLine("Press 1 for Account balance, Press 2 for Saving balance:");            
            string whatAccount = Console.ReadLine();
            if (whatAccount== "1")
            {
                fromAccount = CurrentUser._balance;
            }
            if (whatAccount == "2")
            {
                 fromAccount = CurrentUser._savings;
            }
            Console.WriteLine("Which account would you like to transfer to?");
            Console.WriteLine("Press 1 for Account balance, Press 2 for Saving balance:");
            string towhatAccount = Console.ReadLine();
            if (towhatAccount == "1")
            {
                 toAccount = CurrentUser._balance;
            }
            if (towhatAccount == "2")
            {
                 toAccount = CurrentUser._savings;
            }
            Console.WriteLine("What amount do you want to transfer?");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            decimal newValueonAccount1 = fromAccount - amount;
            decimal newValueonAccount2 = toAccount + amount;



            
        }


    }
}
