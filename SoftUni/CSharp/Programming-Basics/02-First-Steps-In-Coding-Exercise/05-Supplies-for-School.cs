using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class _05
    {
        static void Main()
        {
            double penPrice = 5.80;
            double markersPrice = 7.20;
            double detergentPrice = 1.20;

            string? s_penCount = Console.ReadLine();
            string? s_markersCount = Console.ReadLine();
            string? s_detergentCount = Console.ReadLine();
            string? s_discountCount = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(s_penCount) && string.IsNullOrWhiteSpace(s_markersCount) && string.IsNullOrWhiteSpace(s_detergentCount) && string.IsNullOrWhiteSpace(s_discountCount))
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            else
            {
                int penCount = int.Parse(s_penCount);
                int markersCount = int.Parse(s_markersCount);
                int detergentCount = int.Parse(s_detergentCount);
                int discountCount = int.Parse(s_discountCount);

                double totalPrice = (penCount * penPrice) + (markersCount * markersPrice) + (detergentCount * detergentPrice);
                double finalPrice = totalPrice - (totalPrice * (discountCount / 100.0));

                Console.WriteLine(finalPrice);
            }                                   
        }
    }
}
