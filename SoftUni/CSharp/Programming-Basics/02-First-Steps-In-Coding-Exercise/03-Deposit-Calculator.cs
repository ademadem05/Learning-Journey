using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class _03
    {
        static void Main()
        {
            Console.WriteLine("Enter a Deposit");
            string? s_deposit =  Console.ReadLine();

            Console.WriteLine("Enter a Date");
            string? s_dateDeposit = Console.ReadLine();

            Console.WriteLine("Enter a Percent");
            string? s_annualPercent = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(s_annualPercent) && string.IsNullOrWhiteSpace(s_dateDeposit) && string.IsNullOrWhiteSpace(s_deposit))
            {
                Console.WriteLine("Invalid Input");
                return;
                
            }else
            {
                double deposit = double.Parse(s_deposit);
                int dateDeposit = int.Parse(s_dateDeposit);
                double annualPercent = double.Parse(s_annualPercent);

                double finalAmount = deposit + dateDeposit * ((deposit * annualPercent / 100) / 12);
                Console.WriteLine(finalAmount);
            }
        }
    }
}