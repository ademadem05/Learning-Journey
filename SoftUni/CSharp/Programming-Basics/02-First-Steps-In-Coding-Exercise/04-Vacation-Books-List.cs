using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class _04
    {
        static void Main()
        {
          
            string? s_numPages = Console.ReadLine();

            string? s_pagesPerHour = Console.ReadLine();

            string? s_daysToRead = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(s_daysToRead) && string.IsNullOrWhiteSpace(s_pagesPerHour) && string.IsNullOrWhiteSpace(s_numPages))
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            else
            {
                int numPages = int.Parse(s_numPages);
                int pagesPerHour = int.Parse(s_pagesPerHour);
                int daysToRead = int.Parse(s_daysToRead);
                int totalHours = numPages / pagesPerHour;
                int hoursPerDay = totalHours / daysToRead;
                Console.WriteLine(hoursPerDay);

            }
        }
    }
}