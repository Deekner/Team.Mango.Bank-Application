using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    public class AdminMenu
    {
        //ADMIN Menu
        public void adminMenu(List<User> Users, User CurrentUser)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("             MAIN MENU             ");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("|    [1.]  Show All Users            | ");
                Console.WriteLine("|    [2.]  Create Account            | ");
                Console.WriteLine("|    [3.]  Logout                    | ");
                Console.WriteLine("|    [4.]  Exit application          | ");
                Console.WriteLine("--------------------------------------");


                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            CurrentUser.ShowAllUsers(Users, CurrentUser);
                            break;

                        case 2:
                            // Sending list of Users and CurrentUser and if Admin is true
                            User.CreateUser(Users, CurrentUser, true);
                            break;

                        case 3:
                            Login logout = new Login();
                            logout.UserLogin(Users);
                            break;


                        case 4:
                            Environment.Exit(0);
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
            } while (true);
        }


    }
}
