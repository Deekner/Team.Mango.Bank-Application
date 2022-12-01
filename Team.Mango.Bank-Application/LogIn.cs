using System;
using System.Collections.Generic;

namespace Team.Mango.Bank_Application
{
    class LogIn
    {
        public static void Accounts()
        {

            Users Admin = new Users("Admin", "0000");
            Users tim = new Users("Tim", "1111");
            Users elin = new Users("Elin", "2222");
            Users dennis = new Users("Dennis", "3333");
            Users anton = new Users("Anton", "4444");


            List<Users> accountList = new List<Users>();
            accountList.Add(Admin);
            accountList.Add(tim);
            accountList.Add(elin);
            accountList.Add(dennis);
            accountList.Add(anton);


            int tries = 0;
            bool Granted = true;
            Users CurrentUser;
            

            do
            {
                if (tries == 3)
                {
                    Environment.Exit(0);
                }


                Console.Write("Please enter your username: ");
                string username = Console.ReadLine();
                Console.Write("Please enter your password: ");
                string PasswordInput = Console.ReadLine();


                CurrentUser = accountList.Find(a => a._username == username); //Finds a matching username in accountList and pulls all information from that specific username
                if (CurrentUser != null || CurrentUser == Admin)
                {
                    if (CurrentUser.getpw() == PasswordInput) //If the password matches the username input, it returns the values from listed password
                    {
                        Console.Clear();
                        if (CurrentUser == Admin)
                        {
                            //Admin goes to AdminOptions if logged in and all regular users goes to normal menu
                            AdminMenu.AdminOptions(CurrentUser);
                        }
                        else
                        {
                            Menu.MenuOptions(username);
                        }
                        Console.Clear();
                        Granted = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Username or Password is incorrect");
                        tries++;
                        Console.WriteLine("{0} out of 3",tries);
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Username or Password is incorrect");
                    tries++;
                    Console.WriteLine("{0} out of 3", tries);
                }


            } while (Granted);

            //if (CurrentUser == Admin)
            //{
            //    //Admin goes to AdminOptions if logged in and all regular users goes to normal menu
            //    AdminMenu.AdminOptions(CurrentUser);
            //}
            //else
            //{
            //    Menu.MenuOptions(userName);
            //}
            //Console.Clear();





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
