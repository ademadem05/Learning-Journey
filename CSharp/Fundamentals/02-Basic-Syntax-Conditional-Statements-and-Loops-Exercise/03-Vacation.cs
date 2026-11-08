using System.Globalization;

namespace _3._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string typeOfPeople  = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double total = 0;

            if (typeOfPeople == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    total += numOfPeople * 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    total += numOfPeople * 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    total += numOfPeople * 10.46;
                }
                if (numOfPeople >= 30)
                {
                    total *= 0.85;
                }
            }
            else if (typeOfPeople == "Business")
            {
                if (numOfPeople >= 100)
                {
                    numOfPeople -= 10;
                }
                if (dayOfWeek == "Friday")
                {
                    total += numOfPeople * 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    total += numOfPeople * 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    total += numOfPeople * 16;
                }
            }
            else if (typeOfPeople == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    total += numOfPeople * 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    total += numOfPeople * 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    total += numOfPeople * 22.50;
                }
                if (10 <= numOfPeople && numOfPeople <=20)
                {
                    total *= 0.95;
                }
            }

            Console.WriteLine($"Total price: {total:F2}");
        }
    }
}
