using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.Console
{
    internal class _09
    {
        static void Main()
        {
            double pricePerMeter = 7.61;
            double discountPercent = 0.18;

            double recMeter = double.Parse(System.Console.ReadLine());
            double totalPrice = recMeter * pricePerMeter;
            double discountAmount = totalPrice * discountPercent;
            double finalPrice = totalPrice - discountAmount;

            System.Console.WriteLine($"The final price is: {finalPrice} lv.");
            System.Console.WriteLine($"The discount is: {discountAmount} lv.");

        }
    }
}
