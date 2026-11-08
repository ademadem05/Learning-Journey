
namespace _02._Deer_of_Santa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());  
            int foodLeftPerKilos = int.Parse(Console.ReadLine()); 
            
            double foodForFirstElen = double.Parse(Console.ReadLine());
            double foodForSecondELen = double.Parse(Console.ReadLine());
            double foorForThirdELen  = double.Parse(Console.ReadLine());

            double neededFoodforFirstElen = countDays * foodForFirstElen;
            double neededFoodforSecondElen = countDays * foodForSecondELen;
            double neededFoodforThirdElen = countDays * foorForThirdELen;

            double total = neededFoodforFirstElen + neededFoodforSecondElen + neededFoodforThirdElen;

            if (foodLeftPerKilos > total)
            {
                Console.WriteLine($"{Math.Floor(foodLeftPerKilos - total)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(total - foodLeftPerKilos)} more kilos of food are needed.");
            }

        }
    }
}
