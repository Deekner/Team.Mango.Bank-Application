using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Team.Mango.Bank_Application
{
    public class BankStart
    {       // In here we will start the bankprogram
        public void RunBank()
        {
            //Making a list of Users from User
            List<User> Users = new List<User>();

            //User 1
            //Making a list of Tim Bankaccount "BA1"
            List<BankAccount> BA1 = new List<BankAccount>();
            //Create start bankaccount
            BankAccount BAccount1 = new BankAccount("Privat Konto", 25000);
            User User1 = new User("TN", "1111","Tim","Nilsson", 0709496224, BA1);
            //Add BAccount1 to BankAccountList
            User1.BankAccountList.Add(BAccount1);
            //Add User1 to Users List
            Users.Add(User1);



            //User 2
            List<BankAccount> BA2 = new List<BankAccount>();
            BankAccount BAccount2= new BankAccount("Privat Konto", 2000);
            User User2= new User("EL", "2222", "Elin", "Linderholm", 0708687334, BA2);
            User2.BankAccountList.Add(BAccount2);           
            Users.Add(User2);


            ////User 3
            List<BankAccount> BA3 = new List<BankAccount>();
            BankAccount BAccount3 = new BankAccount("Privat Konto", 2000000);
            User User3 = new User("DE", "3333", "Dennis", "Ekner", 070427245, BA3);
            User3.BankAccountList.Add(BAccount3);
            Users.Add(User3);



            ////User 4
            List<BankAccount> BA4 = new List<BankAccount>();
            BankAccount BAccount4 = new BankAccount("Privat Konto", 200);
            User User4 = new User("AJ", "4444", "Anton", "Johansson", 0708687334, BA4);
            User4.BankAccountList.Add(BAccount4);
            Users.Add(User4);


            //Create object of Login
            Login login = new Login();
            //Send Users list data to UserLogin 
            login.UserLogin(Users);




            //List<User> accountList = new List<User>();
            //accountList.Add(Admin);
            //accountList.Add(User);
            //accountList.Add(elin);
            //accountList.Add(dennis);
            //accountList.Add(anton);


            //int tries = 0;
            //bool Granted = true;
            //User CurrentUser;


            //do
            //{
            //    if (tries == 3)
            //    {
            //        Environment.Exit(0);
            //    }


            //    Console.Write("Please enter your username: ");
            //    string username = Console.ReadLine();
            //    Console.Write("Please enter your password: ");
            //    string PasswordInput = Console.ReadLine();


            //    CurrentUser = accountList.Find(a => a._username == username); //Finds a matching username in accountList and pulls all information from that specific username
            //    if (CurrentUser != null || CurrentUser == Admin)
            //    {
            //        if (CurrentUser.getpw() == PasswordInput) //If the password matches the username input, it returns the values from listed password
            //        {
            //            Console.Clear();
            //            if (CurrentUser == Admin)
            //            {
            //                //Admin goes to AdminOptions if logged in and all regular users goes to normal menu
            //                AdminMenu.AdminOptions(CurrentUser);
            //            }
            //            else
            //            {
            //                Menu.MenuOptions(username);
            //            }
            //            Console.Clear();
            //            Granted = false;
            //        }
            //        else
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Username or Password is incorrect");
            //            tries++;
            //            Console.WriteLine("{0} out of 3",tries);
            //        }
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Username or Password is incorrect");
            //        tries++;
            //        Console.WriteLine("{0} out of 3", tries);
            //    }


            //} while (Granted);

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
