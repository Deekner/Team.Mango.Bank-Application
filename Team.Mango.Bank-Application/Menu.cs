using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    internal class Menu
    {
        public static void MenuOptions()
        {          
            do
            {

                Console.WriteLine("             MAIN MENU             ");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("|    [1.]  Accounts                  | ");
                Console.WriteLine("|    [2.]  Transfer                  | ");
                Console.WriteLine("|    [3.]  Withdraw                  | ");
                Console.WriteLine("|    [4.]  Logout                    | ");
                Console.WriteLine("|    [5.]  Exit application          | ");
                Console.WriteLine("--------------------------------------");


                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Bankaccount.bankaccount();
                            break;

                        case 2:
                            Transfer.transfer();
                            break;

                        case 3:
                            Withdraw.withdraw();
                            break;

                        case 4:
                            LogIn.Accounts();
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

                Console.Clear();
            } while (true);
        }

        //public string void Testpage()
        //{
        //    foreach (Users item in )
        //    {
        //        Console.WriteLine("id = {0}, name = {1}", item._id, item._username);
        //    }
        //}
    
      
    }
}
