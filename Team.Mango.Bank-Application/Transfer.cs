using System;
using System.Collections.Generic;

namespace Team.Mango.Bank_Application
{
    internal class Transfer
    {
        public int accFrom = 0;
        public int accTo = 0;
        public double transferAmmount = 0;




        // In transfer
        public void transferMenu(List<BankAccount> CurrentUserAccounts, User CurrentUser, List<User> Users)
        {
            bool Tmenu = true;

            do
            {
                Console.Clear();
                Console.WriteLine("             TRANSFER MENU             ");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("|    [1.]  Internal Transfers        | ");
                Console.WriteLine("|    [2.]  Transfer to other user    | ");
                Console.WriteLine("|    [3.]  Go back                   | ");
                Console.WriteLine("--------------------------------------");


                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            internalTransfer(CurrentUserAccounts, CurrentUser);
                            break;

                        case 2:

                            break;

                        case 3:
                            Tmenu = false;
                            break;

                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input!");
                    Console.ReadLine();
                }


            } while (Tmenu);


        }
        public void internalTransfer(List<BankAccount> CurrentUserAccounts, User CurrentUser)
        {
            //iTloop = "internal transfer loop"
            bool iTloop1 = true;
            bool iTloop2 = true;
            bool iTCal = true;
            int maxAccNum = CurrentUserAccounts.Count;

            while (iTloop1)
            {
                // Account From
                Console.Clear();
                Console.WriteLine("Select the account that you want to transfer from.");
                int AccNum = 1;
                foreach (BankAccount item in CurrentUser.BankAccountList)
                {
                    Console.WriteLine(AccNum + $": Account name: {item.AccountName} Balance: {item.Balance} ");
                    AccNum++;
                }


                // Choose account that you want to transferform
                accFrom = int.Parse(Console.ReadLine());
                if (accFrom <= maxAccNum && accFrom > 0)
                {
                    iTloop1 = false;
                }
                else
                {
                    Console.WriteLine("Please enter an existing account \nPress enter to continue.");
                    Console.ReadKey();
                }


            }

            //Account To
            while (iTloop2)
            {
                Console.Clear();
                Console.WriteLine("Select the account that you want to tranfer to.");
                int AccNum = 1;
                foreach (BankAccount item in CurrentUser.BankAccountList)
                {
                    Console.WriteLine(AccNum + $": Account name: {item.AccountName} Balance: {item.Balance} ");
                    AccNum++;
                }

                try
                {
                    accTo = int.Parse(Console.ReadLine());
                    if (accTo <= maxAccNum && accTo != accFrom && accTo > 0)
                    {
                        iTloop2 = false;

                    }

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Please input the account number with a number/numbers");
                }



                //Selecting ammount

                Console.Clear();
                Console.WriteLine("Select the ammount.");
                try
                {
                    transferAmmount = double.Parse(Console.ReadLine());
                    if (transferAmmount > 0)
                    {
                        iTloop2 = false;
                    }
                    else
                    {
                        Console.WriteLine("You can not transfer less then 0 \nPress enter to try again");
                        Console.ReadKey();
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Just numbers !!!!!");
                }

            }

            // Transfering process
            // Minus 1 is because account start from 0 
            accFrom = accFrom - 1;
            accTo = accTo - 1;
            bool TSuccess = false;
            //CurrentUserAccounts[] is a way to access index of CurrentUsers Bankaccount 
            if (CurrentUserAccounts[accFrom].Balance >= transferAmmount)
            {
                CurrentUserAccounts[accFrom].Balance -= transferAmmount;
                CurrentUserAccounts[accTo].Balance += transferAmmount;
                TSuccess = true;
             
            }

            if(TSuccess == true)
            {
                Console.WriteLine("You transfered {0} from account {1} to accout {2}",transferAmmount, accFrom + 1, accTo + 1);
                Console.WriteLine("Account number {0} balance is now {1}\nAccount number {2} balance is now {3}", accFrom + 1, CurrentUserAccounts[accFrom].Balance, accTo + 1,CurrentUserAccounts[accTo].Balance);
                Console.ReadKey();

            }
        }
    }
}
