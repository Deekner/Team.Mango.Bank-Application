using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    internal class SavingAccount 
    {

        public static void ShowAccount()
        {
           

            List<List<int>> SavingAccounts = new List<List<int>>();

            SavingAccounts.Add(new List<int> { 200, 500, 600 });
            SavingAccounts.Add(new List<int> { 900, 500 });
            SavingAccounts.Add(new List<int> { 7000, 4000, 800, 9200 });


            foreach(var list in SavingAccounts)
            {
                Console.WriteLine("-------------");
                foreach(var item in list)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("Press enter to go back to Menu");
            Console.ReadLine();
            Console.Clear();
            Menu.MenuOptions();

        }

        
    }
}
