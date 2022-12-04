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
            //Create default bankaccount
            BankAccount BAccount1 = new BankAccount("Private account", 25000);
            BankAccount SAccount1 = new BankAccount("Savings", 500);

            //Create User
            User User1 = new User("Tim", "1111", "Tim", "Nilsson", "0709496224", BA1, false);

            //Add BAccount1 to BankAccountList
            User1.BankAccountList.Add(BAccount1);
            User1.BankAccountList.Add(SAccount1);
            //Add User1 to Users List
            Users.Add(User1);



            //User 2
            List<BankAccount> BA2 = new List<BankAccount>();
            BankAccount BAccount2= new BankAccount("Privat Konto", 2000);
            User User2= new User("Elin", "2222", "Elin", "Linderholm", "0708687334", BA2, false);
            User2.BankAccountList.Add(BAccount2);           
            Users.Add(User2);


            //User 3
            List<BankAccount> BA3 = new List<BankAccount>();
            BankAccount BAccount3 = new BankAccount("Privat Konto", 2000000);
            User User3 = new User("Dennis", "3333", "Dennis", "Ekner", "070427245", BA3, false);
            User3.BankAccountList.Add(BAccount3);
            Users.Add(User3);



            //User 4
            List<BankAccount> BA4 = new List<BankAccount>();
            BankAccount BAccount4 = new BankAccount("Privat Konto", 200);
            User User4 = new User("Anton", "4444", "Anton", "Johansson", "0708687334", BA4, false);
            User4.BankAccountList.Add(BAccount4);
            Users.Add(User4);


            //Admin
            List<BankAccount> AM= new List<BankAccount>();
            BankAccount AdminBAccount = new BankAccount("No money", 0000);
            User Admin = new User("admin", "admin", "Tony", "Stark", "2129704133", AM, true);
            Admin.BankAccountList.Add(AdminBAccount);
            Users.Add(Admin);


            //Create object of Login
            Login login = new Login();
            //Send Users list data to UserLogin() 
            login.UserLogin(Users);


            





        }
    }
}



