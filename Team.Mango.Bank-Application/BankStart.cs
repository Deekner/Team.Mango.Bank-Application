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


            //Create Admin
            List<BankAccount> AM = new List<BankAccount>();
            BankAccount AdminBAccount = new BankAccount("No money", 0000);
            User Admin = new User("admin", "admin", "Tony", "Stark", "2129704133", AM, true);
            Admin.BankAccountList.Add(AdminBAccount);
            Users.Add(Admin);



            //User 1

            //Making a list of Tim Bankaccount "BA1"
            List<BankAccount> TA1 = new List<BankAccount>();
            //Create default bankaccount
            BankAccount TAccount1 = new BankAccount("Private account", 25000);
            BankAccount TAccount2 = new BankAccount("Private account", 500);
            BankAccount TAccount3 = new BankAccount("Private account", 4989056456897);

            //Create User
            User User1 = new User("Tim", "1111", "Tim", "Nilsson", "0709496224", TA1, false);

            //Add BAccount1 to BankAccountList
            User1.BankAccountList.Add(TAccount1);
            User1.BankAccountList.Add(TAccount2);
            User1.BankAccountList.Add(TAccount3);
            //Add User1 to Users List
            Users.Add(User1);



            //User 2
            List<BankAccount> EA2 = new List<BankAccount>();
            BankAccount EAccount1= new BankAccount("Private account", 2000);
            BankAccount EAccount2 = new BankAccount("Private account", 2500);
            BankAccount EAccount3 = new BankAccount("Private account", 497);
            User User2= new User("Elin", "2222", "Elin", "Linderholm", "0708687334", EA2, false);
            User2.BankAccountList.Add(EAccount1);
            User2.BankAccountList.Add(EAccount2);
            User2.BankAccountList.Add(EAccount3);
            Users.Add(User2);


            //User 3
            List<BankAccount> DA3 = new List<BankAccount>();
            BankAccount DAccount1 = new BankAccount("Private account", 200);
            BankAccount DAccount2 = new BankAccount("Private account", 20230000);
            User User3 = new User("Dennis", "3333", "Dennis", "Ekner", "070427245", DA3, false);
            User3.BankAccountList.Add(DAccount1);
            User3.BankAccountList.Add(DAccount2);
            Users.Add(User3);



            //User 4
            List<BankAccount> AA4 = new List<BankAccount>();
            BankAccount AAccount1 = new BankAccount("Private account", 250);
            BankAccount AAccount2 = new BankAccount("Private account", 2600);
            User User4 = new User("Anton", "4444", "Anton", "Johansson", "0708687334", AA4, false);
            User4.BankAccountList.Add(AAccount1);
            User4.BankAccountList.Add(AAccount2);
            Users.Add(User4);


          


            //Create object of Login
            Login login = new Login();
            //Send Users list data to UserLogin() 
            login.UserLogin(Users);


            





        }
    }
}



