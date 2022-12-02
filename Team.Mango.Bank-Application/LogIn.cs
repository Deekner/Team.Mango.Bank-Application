using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{   // only add login function here
    public class Login
    {
        public bool LoginGranted = false;
        public int Attempt = 2;

        public void UserLogin(List<User> accounts)
        {
            Console.Clear();
            Console.WriteLine("Please enter Username and Password");
            while (LoginGranted == false)
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();

                foreach (var users in accounts)
                {
                    if (username == users.Username && password == users.Password)
                    {
                       
                            LoginGranted = true;
                            User Check = accounts.Find(s => s.Username == username);
                            Menu.MenuOptions(accounts, Check);
                            Console.ReadKey();
                       
                    }
                }
                if (Attempt == 0)
                {
                    LoginGranted = false;
                    Console.WriteLine("You have tried to meny times....");
                    Environment.Exit(1);
                }
                else
                {
                    LoginGranted = false;
                    Console.WriteLine("Wrong username or password! You have " + Attempt + " attempts left");
                    Attempt--;
                    LoginGranted = false;
                }
            }
        }


        //public void loginAdmin(List<User> accounts, User activeUser)
        //{
        //    do
        //    {
        //        Console.Clear();
        //        Console.WriteLine("1. Update Currency Rates (Current Rate: {0})", Math.Round(objRates._Rate, 2));
        //        Console.WriteLine("2. Create Account");
        //        Console.WriteLine("3. Show all Accounts");
        //        Console.WriteLine("4. Log out");
        //        int menu = int.Parse(Console.ReadLine());

        //        switch (menu)
        //        {
        //            case 1:
                        
        //                break;
        //            case 2:
        //                User.CreateUser(accounts, true, activeUser);
        //                break;
        //            case 3:
        //                activeUser.PrintAllUsers(accounts, activeUser, objRates);
        //                break;
        //            case 4:
        //                Login logout = new Login();
        //                logout.UserLogin(accounts, objRates);
        //                break;
        //            default:
        //                break;
        //        }
        //    } while (true);
        //}










    }
}
