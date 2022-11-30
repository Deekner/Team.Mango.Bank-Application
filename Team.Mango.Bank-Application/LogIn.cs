using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    class LogIn
    {
        public static void Accounts()
        {

            Users Admin = new Users(0, "Admin", "0000", 0, 99999);
            Users tim = new Users(1, "Tim", "1111", 34932, 1200623);
            Users elin = new Users(2, "Elin", "2222", 69809, 20000);
            Users dennis = new Users(3, "Dennis", "3333", 2036, 2342324);
            Users anton = new Users(4, "Anton", "4444", 34689, 23434);


            List<Users> accountList = new List<Users>();
            accountList.Add(Admin);
            accountList.Add(tim);
            accountList.Add(elin);
            accountList.Add(dennis);
            accountList.Add(anton);

            Console.Write("Please enter your username: ");

            Users CurrentUser;

            while (true) //Potentially swap this while loop to a do-while?
            {
                try
                {
                    string username = Console.ReadLine();
                    CurrentUser = accountList.Find(a => a._username == username); //Finds a matching username in accountList and pulls all information from that specific username
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
                    Console.Write("Please enter your password: ");
                    string PasswordInput = Console.ReadLine();
                    Console.Clear();
                    if (CurrentUser.getpw() == PasswordInput) //If the password matches the username input, it returns the values from listed password
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

            //Admin goes to AdminOptions if logged in and all regular users goes to normal menu
            if (CurrentUser == Admin)§
            {
                AdminMenu.AdminOptions(CurrentUser);
            }
            else
            {
                Menu.MenuOptions(CurrentUser);
            }
            Console.Clear();
        }
    }
}



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


        /*public static int SignIn()
        {
            Console.WriteLine("Enter your username");
            foreach (UserAccount item in accountList)


            return 0;

        }
        */
