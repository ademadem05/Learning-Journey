using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.Console
{
    internal class _08
    {
        static void Main()
        {
            double dogFoodPricePerkg = 2.50;
            double catFoodPricePerkg = 4.00;

            int numOfdogFood = int.Parse(System.Console.ReadLine());
            int numOfcatsFood = int.Parse(System.Console.ReadLine());
            double totalPrice = (numOfdogFood * dogFoodPricePerkg) + (numOfcatsFood * catFoodPricePerkg);

            System.Console.WriteLine($"{totalPrice} lv.");
        }
    }
}