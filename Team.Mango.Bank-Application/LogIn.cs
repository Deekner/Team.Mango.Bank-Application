﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    class LogIn
    {
        public static void Accounts()
        {
            Users Admin = new Users(0, "Admin", "0000");
            Users tim = new Users(1, "Tim", "1111");
            Users elin = new Users(2, "Elin", "2222");
            Users dennis = new Users(3, "Dennis", "3333");
            Users anton = new Users(4, "Anton", "4444");
            

            List<Users> accountList = new List<Users>();
            accountList.Add(Admin);
            accountList.Add(tim);
            accountList.Add(elin);
            accountList.Add(dennis);
            accountList.Add(anton);

            Console.WriteLine("Please enter your username: ");
            string username = "";
            Users CurrentUser;

            while (true)
            {
                try
                {
                    username = Console.ReadLine();
                    CurrentUser = accountList.Find(a => a._username == username);
                    if (CurrentUser != null || CurrentUser == Admin)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("User Is not listed in the database");
                    }

                }
                catch 
                { 
                    Console.WriteLine("User Is not listed in the database");         
                }
            }

            while (true)
            {
                try
                {
                    string PasswordInput = "";

                    Console.WriteLine("Please enter your password: ");
                    PasswordInput = Console.ReadLine();
                    if (CurrentUser.getpw() == PasswordInput)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Password is incorrect");
                    }
                }
                catch 
                { 
                    Console.WriteLine("Password is incorrect"); 
                }

            }
            if (CurrentUser == Admin)
            {
                AdminMenu.AdminOptions();
            }
            else
            {
                Menu.MenuOptions();
            }
            Console.Clear();




            //UserAccount checkuserAccount = 

            //    int Attempt = 1;
            //    do
            //    {
            //        Console.WriteLine("Please enter your username");
            //        string UserNameInput = Console.ReadLine();
            //        Console.WriteLine("Please enter your password");
            //        string PasswordInput = Console.ReadLine();

            //        for (int i = 0; i < accountList.Count; i++)
            //        {
            //            //Test admin account
            //            if (UserNameInput == "Admin" && PasswordInput == "0000")
            //            {
            //                AdminMenu.AdminOptions();
            //            }
            //            //if (accountList.Exists(x => string.Equals(x._username, UserNameInput)) && accountList.Exists(p => string.Equals(p._password, PasswordInput)))
            //            //{
            //            //    Console.WriteLine("Hej");
            //            //    Attempt = 4;
            //            //    Menu.MenuOptions();
            //            //    break;
            //            //}

            //        }
            //        Attempt++;
            //    } while (Attempt < 4);

            //    //UserAccount findUserName = accountList.Find(f => f._username == UserNameInput);
            //    //UserAccount findPassword = accountList.Find(p => p._password == PasswordInput);



            //    foreach (Users item in accountList)
            //    {

            //    }
        }

        /*public static int SignIn()
        {
            Console.WriteLine("Enter your username");
            foreach (UserAccount item in accountList)


            return 0;

        }
        */
    }
}
