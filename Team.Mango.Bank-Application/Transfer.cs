using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    internal class Transfer : SavingAccount
    {
        public static void transfer(string username)
        {
            Console.Clear();

            //int counting = 0;
            //Console.Clear();
            //Console.WriteLine("Tranfer money on {0} account", username);
            //Console.WriteLine("In progress");

            //List<decimal> Tim = new List<decimal>();
            //Tim.Add(9000);
            //Tim.Add(20080);
            //Tim.Add(700);
            //Console.WriteLine("Sparkonto");


            //List<decimal> Elin = new List<decimal>();
            //Elin.Add(200);
            //Elin.Add(80);

            //List<decimal> Dennis = new List<decimal>();
            //Dennis.Add(90002234);
            //Dennis.Add(20034);

            //switch (username)
            //{
            //    case "Tim":
            //        Console.Clear();
            //        foreach (decimal value in Tim)
            //        {
            //            Console.WriteLine("Account:{0} have {1}", counting, value);
            //            counting++;
            //        }
            //        break;

            //    case "Elin":
            //        Console.Clear();
            //        foreach (decimal value in Elin)
            //        {
            //            Console.WriteLine("Account:{0} have {1}", counting, value);
            //            counting++;
            //        }
            //        break;

            //    case "Dennis":
            //        Console.Clear();
            //        foreach (decimal value in Dennis)
            //        {
            //            Console.WriteLine("Account:{0} have {1}", counting, value);
            //            counting++;
            //        }
            //        break;

            //}

            //Console.WriteLine("Select the account that you want to transfer from");
            //int acc1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please insert ammount");
            //decimal ammount = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Select the account that you want to transfer to");
            //int acc2 = int.Parse(Console.ReadLine());


            //switch (username)
            //{
            //    case "Tim":
                    

            //        Console.WriteLine("You have transfered {0} from account {1} to account {2}", ammount, acc1, acc2);
            //        Console.WriteLine("The ammount of account {0} is {1}", acc2, ammount + Tim[acc2]);
            //        break;

            //    case "Elin":
                   

            //        Console.WriteLine("You have transfered {0} from account {1} to account {2}", ammount, acc1, acc2);
            //        Console.WriteLine("The ammount of account {0} is {1}", acc2, ammount + Dennis[acc2]);
            //        break;

            //    case "Dennis":

            //        Console.WriteLine("You have transfered {0} from account {1} to account {2}", ammount, acc1, acc2);
            //        Console.WriteLine("The ammount of account {0} is {1}", acc2, ammount + Elin[acc2]);
            //        break;

            //}
            

            Console.WriteLine("Return to menu press Enter");
            string enter = Console.ReadLine();
            if (enter == "")
            {
                Menu.MenuOptions(username);
            }

        }


    }
}
