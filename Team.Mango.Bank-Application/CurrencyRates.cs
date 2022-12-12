using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    public class CurrencyRates
    {
        public string _currencyType;
        public double _currencyRate;

        public CurrencyRates(string currentcyType, double currentcyRate)
        {
            this._currencyType = currentcyType;
            this._currencyRate = currentcyRate;

        }


        public static void UpdateCurrentcyRate(CurrencyRates CurrRate)
        {
            double minValue = 9.5;
            Random R = new Random();
            double newRate = R.NextDouble();
            CurrRate._currencyRate = newRate + minValue;
            Console.WriteLine("New USD rate is {0}",CurrRate._currencyRate);
            Console.WriteLine("Press enter to go back");

            Console.ReadKey();

        }


    }
}
