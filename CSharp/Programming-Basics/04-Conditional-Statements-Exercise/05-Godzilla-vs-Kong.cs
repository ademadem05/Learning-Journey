namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main()
        {
            //•	Декорът за филма е на стойност 10 % от бюджета.
            //•	При повече от 150 статиста,  има отстъпка за облеклото на стойност 10 %.
            //Вход
            //От конзолата се четат 3 реда:
            //            Ред 1.Бюджет за филма – реално число в интервала[1.00 … 1000000.00]
            //Ред 2.Брой на статистите – цяло число в интервала[1 … 500]
            //Ред 3.Цена за облекло на един статист – реално число в интервала[1.00 … 1000.00]


            double MovieBudget = double.Parse(Console.ReadLine());
            int countStats = int.Parse(Console.ReadLine());
            double pricePerDress = double.Parse(Console.ReadLine());

            double PriceForDecor = MovieBudget * 0.1;

            double PriceForStat = pricePerDress * countStats;

            if (countStats >= 150) 
            {
                PriceForStat -= PriceForStat * 0.1;
            }

            double totalPrice = PriceForDecor + PriceForStat;


            if (totalPrice > MovieBudget) 
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(totalPrice - MovieBudget).ToString("F2")} leva more.");
            }
            else 
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(MovieBudget - totalPrice).ToString("F2")} leva left.");
            }


        }
    }
}
