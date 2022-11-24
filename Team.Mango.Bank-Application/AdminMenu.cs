using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    internal class AdminMenu
    {
        public static void AdminOptions()
        {
            int result;
            string Acc_num;
            string choice;

            CreateUser CU = new CreateUser();



            for (; ; )
            {

                Console.WriteLine("            ADMIN MAIN MENU            ");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("|    [1.]  Create New Account        | ");
                Console.WriteLine("|    [2.]  Check accounts            | ");
                Console.WriteLine("|    [3.]  Diposit                   | ");
                Console.WriteLine("|    [4.]  Withdraw                  | ");
                Console.WriteLine("|    [5.]  Transfer                  | ");
                Console.WriteLine("|    [6.]  Logout                    | ");
                Console.WriteLine("|    [7.]  Exit application          | ");
                Console.WriteLine("--------------------------------------");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":

                        result = CU.Create_User();
                        if (result == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Account number \"{0}\" Created Successfuly", CU.Acc_ID);
                        }
                        else
                        {
                            Console.WriteLine("Account could not be created! Try again.");
                        }

                        break;

                    case "2":
                        Console.Clear();
                        Console.Write("Enter the Account Number:\t");
                        Acc_num = Console.ReadLine();
                        CU.Admin_Availability(Acc_num);
                        break;

                    case "3":
                        Console.Clear();
                        Console.Write("Enter the Account Number:\t");
                        Acc_num = Console.ReadLine();
                        CU.Deposite(Acc_num);
                        break;

                    case "4":
                        Console.Clear();
                        Console.Write("Enter The Customer Account Number:  ");
                        Acc_num = Console.ReadLine();
                        CU.Withdraw(Acc_num);
                        break;

                    case "5":

                        System.Environment.Exit(0);
                        break;

                    default:

                        Console.WriteLine("invalid choice!");
                        break;
                }

                
            } 
        }
    }
}
