using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Team.Mango.Bank_Application
{
    internal class SavingAccount
    {

        public static void ShowAccount(string username)
        {


            //Savings accounts
            int counting = 0;
            

            List<decimal> Tim = new List<decimal>();
            Tim.Add(9000);
            Tim.Add(20080);
            Tim.Add(700);
            Console.WriteLine("Sparkonto");
            

            List<decimal> Elin = new List<decimal>();
            Elin.Add(200);
            Elin.Add(80);

            List<decimal> Dennis = new List<decimal>();
            Dennis.Add(90002234);
            Dennis.Add(20034);

            Console.WriteLine("You sign in as {0}", username);

            switch(username)
            {
                case "Tim":
                    Console.Clear();
                    foreach (decimal value in Tim)
                    {
                        Console.WriteLine("Account:{0}",counting);
                        Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture));
                        counting++;
                    }
                    break;

                case "Elin":
                    Console.Clear();
                    foreach (decimal value in Elin)
                    {
                        Console.WriteLine("Account:{0} have {1}", counting, value);
                        Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture));
                        counting++;
                    }
                    break;

                case "Dennis":
                    Console.Clear();
                    foreach (decimal value in Dennis)
                    {
                        Console.WriteLine("Account:{0} have {1}", counting, value);
                        Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture));
                        counting++;
                    }
                    break;

            }

            Console.WriteLine("Return to menu press Enter");
            string enter = Console.ReadLine();
            if (enter == "")
            {
                Menu.MenuOptions(username);
            }




        }

    }
}
