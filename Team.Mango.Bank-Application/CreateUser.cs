using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    class Errors : Exception
    {
        public Errors(string ErrorMsg)
            : base(ErrorMsg)
        {

        }

    }

    internal class CreateUser
    {
        public int[] index;
        public string Acc_ID = "", _name = "";
        public double Balance = 0;
        int Age;

        public CreateUser() { }
        public CreateUser(string Acc_id, string C_name, double Balance)
        {
            this.Acc_ID = Acc_id;
            this._name = C_name;
            this.Balance = Balance;
        }

        public int Create_User()
        {
           
            try
            {
                Console.Clear();
                Console.Write("Enter The Account Number:\t");
                Acc_ID = Console.ReadLine();
                if (Acc_ID == null)
                    throw new Errors("You must enter the Account number!");

                Console.Write("Enter The Customer Name:\t");
                _name = Console.ReadLine();
                if (_name == null)
                    throw new Errors("You must enter the Account number!");

                Console.Write("Deposite amount:\t\t");
                Balance = double.Parse(Console.ReadLine());
                if (Balance <= 0)
                    throw new Errors("You must enter the Account number!");
            }
            catch (Errors e)
            {
                Console.Write(e.Message);
            }

            return 1;

        }

        public void Admin_Availability(string Acc_num)
        {
            if (Acc_ID.Equals(Acc_num))
            {
                Console.WriteLine("-----------------------------****************-----------------------------");
                Console.WriteLine("Account Number:\t" + Acc_ID);
                Console.WriteLine("Name:\t\t" + _name);
                Console.WriteLine("Balance: \t$" + Balance);
                Console.WriteLine("-----------------------------****************-----------------------------");
            }
            else
            {
                Console.WriteLine("Account does not exist!");
            }
        }
        public void Deposite(string Acc_num)
        {
            try
            {


                if (Acc_ID.Equals(Acc_num))
                {
                    Console.Write("Enter the amount:\t\t");
                    int Amount = int.Parse(Console.ReadLine());
                    if (Amount <= 0)
                        throw new Errors("Amount must be larger than $0");
                    else
                        this.Balance = Balance + Amount;

                    Console.WriteLine("-----------------------------****************-----------------------------");
                    Console.WriteLine("Balance is:  $" + Balance);
                    Console.WriteLine("-----------------------------****************-----------------------------");
                }
                else
                {
                    Console.WriteLine("Account does not exist!");
                }
            }
            catch (Errors e)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void Withdraw(string Acc_num)
        {
            if (Acc_ID.Equals(Acc_num))
            {
                Console.Write("Enter the amount:\t\t");
                int Amount = int.Parse(Console.ReadLine());
                if (Balance == 0)
                {
                    Console.WriteLine("Insufficient balance");

                }
                else if (Amount > Balance)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    Balance = Balance - Amount;
                    Console.WriteLine("Balance: $" + Balance);
                }
            }
            else
            {
                Console.WriteLine("Account does not exist!");
            }
        }
        public void Balenquiry()
        {
            Console.WriteLine("Your baance is: " + Balance);
        }


    }
}
