using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("What is the amount you wish converted?");
            string totalAsString = Console.ReadLine();
            double totalAsDouble = Convert.ToDouble(totalAsString);
            Console.WriteLine(totalAsString + " cents is equal to...");

            int goldValue = 10;
            int silverValue = 5;

            double goldCoins = Math.Floor(totalAsDouble / goldValue);
            double remainder = totalAsDouble % goldValue;

            double silverCoins = Math.Floor(remainder / silverValue);

            remainder = remainder % silverValue;

            Console.WriteLine("Gold coins: " + goldCoins);
            Console.WriteLine("Silver coins: " + silverCoins);
            Console.WriteLine("Bronze coins: " + remainder);
        }
    }
}
