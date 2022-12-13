using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{   // Login fuction and admin menu
    public class Login
    {
        public bool LoginGranted = false;
        public int Attempt = 2;

        //UserLogin method gets data from BankStart List<User> Users
        public void UserLogin(List<User> Users)
        {
            string UP = "Please enter Username and Password";
            string U = "Username: ";
            string P = "Password: ";
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - UP.Length) / 2, Console.CursorTop);
            Console.WriteLine(UP);
            while (LoginGranted == false)
            {
                Console.SetCursorPosition((Console.WindowWidth - U.Length) / 2, Console.CursorTop); 
                Console.Write(U);
                string username = Console.ReadLine();
                Console.SetCursorPosition((Console.WindowWidth - P.Length) / 2, Console.CursorTop);
                Console.Write(P);
                string password = Console.ReadLine();
                

                //Check if username and password is matching with List<User> named Users
                foreach (var user in Users)
                {

                    if (username == user.Username && password == user.Password)
                    {
                        // Checking if the user that logged in have acces to admin abillity
                        if (user.AdminCheck == true)
                        {
                            //Admin
                            LoginGranted = true;
                            User CurrentUser = Users.Find(f => f.Username == username);
                            //Sending Users if Admin need to create a new user
                            AdminMenu adminM = new AdminMenu();
                             adminM.adminMenu(Users, CurrentUser);




                        }
                        else if (user.AdminCheck != true)
                        {
                            //Standard user
                            LoginGranted = true;
                            //Checking if Username exist
                            User CurrentUser = Users.Find(f => f.Username == username);
                            Menu.MenuOptions(Users, CurrentUser);

                        }


                    }
                }
                if (Attempt == 0)
                {
                    string failing = "You have tried to meny times....";
                    LoginGranted = false;
                    Console.SetCursorPosition((Console.WindowWidth - failing.Length) / 2, Console.CursorTop);
                    Console.WriteLine("You have tried to meny times....");
                    
                    Environment.Exit(1);
                }
                else
                {
                    Console.Clear();
                    string tries = "Invilid Username or Password! you have " + Attempt + " attempts left";
                    LoginGranted = false;
                    Console.SetCursorPosition((Console.WindowWidth - tries.Length) / 2, Console.CursorTop);
                    Console.WriteLine("Invilid Username or Password! you have " + Attempt + " attempts left");
                    Attempt--;
                    LoginGranted = false;
                }
            }
        }





    }



}




