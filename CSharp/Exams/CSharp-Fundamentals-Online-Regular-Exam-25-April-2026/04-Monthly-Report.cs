using System;
using System.Collections.Generic;
using System.Linq;

namespace MonthlyReportProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> vendorBalances = new Dictionary<string, double>();
            Dictionary<string, double> clientSales = new Dictionary<string, double>();
            double totalEarnings = 0;

            string commandInput;
            while ((commandInput = Console.ReadLine()) != "End")
            {
                string[] details = commandInput.Split(' ');
                string operation = details[0];
                string entityName = details[1];
                double cashAmount = double.Parse(details[2]);

                if (operation == "Deliver")
                {
                    if (!vendorBalances.ContainsKey(entityName))
                    {
                        vendorBalances[entityName] = 0;
                    }
                    vendorBalances[entityName] += cashAmount;
                }
                else if (operation == "Return")
                {
                    if (vendorBalances.ContainsKey(entityName) && vendorBalances[entityName] >= cashAmount)
                    {
                        vendorBalances[entityName] -= cashAmount;

                        if (vendorBalances[entityName] == 0)
                        {
                            vendorBalances.Remove(entityName);
                        }
                    }
                }
                else if (operation == "Sell")
                {
                    if (!clientSales.ContainsKey(entityName))
                    {
                        clientSales[entityName] = 0;
                    }
                    clientSales[entityName] += cashAmount;
                    totalEarnings += cashAmount;
                }
            }

            foreach (var clientRecord in clientSales)
            {
                Console.WriteLine($"{clientRecord.Key}: {clientRecord.Value:f2}");
            }

            Console.WriteLine("-----------");

            foreach (var vendorRecord in vendorBalances)
            {
                Console.WriteLine($"{vendorRecord.Key}: {vendorRecord.Value:f2}");
            }

            Console.WriteLine("-----------");

            Console.WriteLine($"Total Income: {totalEarnings:f2}");
        }
    }
}