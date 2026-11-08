using System.Diagnostics;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //· Бюджет на групата – цяло число в интервала[1…8000]

            //· Сезон – текст: "Spring", "Summer", "Autumn", "Winter"

            //· Брой рибари – цяло число в интервала[4…18]

            int budget = int.Parse(Console.ReadLine());
            string seassone = Console.ReadLine();
            int Fishers = int.Parse(Console.ReadLine());

            double rentPrice = 0;

            if (seassone == "Spring")
            {
                rentPrice += 3000;
            }
            else if(seassone == "Summer" ||  seassone == "Autumn") 
            {
                rentPrice += 4200;
            }
            else if (seassone == "Winter") 
            {
                rentPrice = 2600;
            }

          
            //Statement for fishers
            if (Fishers <= 6) 
            {
                rentPrice -= rentPrice * 0.1;
            }
            else if (7 <= Fishers && Fishers <= 11) 
            {
                rentPrice -= rentPrice * 0.15;
            }
            else if (Fishers >= 12)
            {
                rentPrice -= rentPrice * 0.25;
            }

            if (Fishers % 2 == 0 && seassone != "Autumn")
            {
                rentPrice -=  rentPrice * 0.05;
            }


            if (budget >= rentPrice)
            {
                Console.WriteLine($"Yes! You have {(budget - rentPrice):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(rentPrice - budget):F2} leva.");
            }


        }
    }
}