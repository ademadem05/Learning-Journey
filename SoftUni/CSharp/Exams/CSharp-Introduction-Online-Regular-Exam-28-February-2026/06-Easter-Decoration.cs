using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Catalog = new Dictionary<string, double>()
            {
                ["basket"] = 1.50,
                ["wreath"] = 3.80,
                ["chocolate bunny"] = 7.00
            };

            int clients = int.Parse(Console.ReadLine());
            double totalMoneyAllClients = 0;

            for (int i = 1; i <= clients; i++)
            {
                int perCustomer = 0;
                double totalSumPerCustomer = 0;

                while (true)
                {
                    string product = Console.ReadLine();

                    if (product == "Finish")
                    {
                        break;
                    }

                    if (Catalog.ContainsKey(product))
                    {
                        totalSumPerCustomer += Catalog[product];
                        perCustomer++;
                    }
                }

                if (perCustomer % 2 == 0)
                {
                    totalSumPerCustomer *= 0.80;
                }

                Console.WriteLine($"You purchased {perCustomer} items for {totalSumPerCustomer:F2} leva.");
                totalMoneyAllClients += totalSumPerCustomer;
            }

            double average = totalMoneyAllClients / clients;
            Console.WriteLine($"Average bill per client is: {average:F2} leva.");
        }
    }
}