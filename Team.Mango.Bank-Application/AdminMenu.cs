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
                string Mmenu = "             MAIN MENU             ";
                string Mlines = "--------------------------------------";
                string MUsers = "|    [1.]  Show All Users            | ";
                string MCreateAccount = "|    [2.]  Create Account            | ";
                string MLogout = "|    [3.]  Logout                    | ";
                string Mexit = "|    [4.]  Exit application          | ";

                Console.SetCursorPosition((Console.WindowWidth - Mmenu.Length) / 2, Console.CursorTop);
                Console.WriteLine(Mmenu);
                Console.SetCursorPosition((Console.WindowWidth - Mlines.Length) / 2, Console.CursorTop);
                Console.WriteLine(Mlines);
                Console.SetCursorPosition((Console.WindowWidth - MUsers.Length) / 2, Console.CursorTop);
                Console.WriteLine(MUsers);
                Console.SetCursorPosition((Console.WindowWidth - MCreateAccount.Length) / 2, Console.CursorTop);
                Console.WriteLine(MCreateAccount);               
                Console.SetCursorPosition((Console.WindowWidth - MLogout.Length) / 2, Console.CursorTop);
                Console.WriteLine(MLogout);
                Console.SetCursorPosition((Console.WindowWidth - Mexit.Length) / 2, Console.CursorTop);
                Console.WriteLine(Mexit);
                Console.SetCursorPosition((Console.WindowWidth - Mlines.Length) / 2, Console.CursorTop);
                Console.WriteLine(Mlines);







                //Console.Clear();
                //Console.WriteLine("             MAIN MENU             ");
                //Console.WriteLine("--------------------------------------");
                //Console.WriteLine("|    [1.]  Show All Users            | ");
                //Console.WriteLine("|    [2.]  Create Account            | ");
                //Console.WriteLine("|    [3.]  Logout                    | ");
                //Console.WriteLine("|    [4.]  Exit application          | ");
                //Console.WriteLine("--------------------------------------");


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
                    string invalid = "Invalid Input!";
                    Console.SetCursorPosition((Console.WindowWidth - invalid.Length) / 2, Console.CursorTop);
                    Console.WriteLine(invalid);
                  
                    Console.ReadLine();
                }
            } while (true);
        }


    }
}
