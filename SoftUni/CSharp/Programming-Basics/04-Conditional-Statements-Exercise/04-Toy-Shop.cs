using System.Numerics;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main()
        {
            //Цени на играчките:
            //•	Пъзел - 2.60 лв.
            //•	Говореща кукла -3 лв.
            //•	Плюшено мече -4.10 лв.
            //•	Миньон - 8.20 лв.
            //•	Камионче - 2 лв.

            //1.Цена на екскурзията -реално число в интервала[1.00 … 10000.00]
            //2.Брой пъзели - цяло число в интервала[0… 1000]
            //3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
            //4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
            //5.Брой миньони - цяло число в интервала[0 … 1000]
            //6.Брой камиончета - цяло число в интервала[0 … 1000]

            double Puzzle = 2.60;
            double talkingDoll = 3;
            double fluffyBear = 4.10;
            double Minion = 8.20;
            double Truck = 2;

            double priceOfHoliday = double.Parse(Console.ReadLine());   
            int countOFpuzzle = int.Parse(Console.ReadLine());
            int countOFtalkingDolls = int.Parse(Console.ReadLine());
            int countOFfluffyBears = int.Parse(Console.ReadLine());    
            int countOFminions =  int.Parse(Console.ReadLine());    
            int countOFtracks = int.Parse(Console.ReadLine());

            int totalOrder = countOFpuzzle + countOFtracks + countOFminions + countOFtalkingDolls + countOFfluffyBears;

            double totalPrice = (countOFpuzzle * Puzzle) + 
                                (countOFtalkingDolls * talkingDoll) + 
                                (countOFfluffyBears * fluffyBear) + 
                                (countOFminions * Minion) + 
                                (countOFtracks * Truck);
            totalPrice -= totalPrice * 0.1;
            if (totalOrder >= 50)
            {
                totalPrice -= totalPrice * 0.25;
            }

            if (totalPrice >= priceOfHoliday )
            {
                Console.WriteLine($"Yes! {(totalPrice - priceOfHoliday).ToString("F2")} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(priceOfHoliday - totalPrice).ToString("F2")} lv needed.");
            }


        }
    }
}
