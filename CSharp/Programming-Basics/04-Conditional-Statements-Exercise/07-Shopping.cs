namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Видеокарта – 250 лв./ бр.
            // •	Процесор – 35 % от цената на закупените видеокарти/ бр.
            // •	Рам памет – 10 % от цената на закупените видеокарти/ бр.

            //Входът се състои от четири реда:
            //1.Бюджетът на Петър -реално число в интервала[0.0…100000.0]
            //2.Броят видеокарти - цяло число в интервала[0…100]
            //3.Броят процесори - цяло число в интервала[0…100]
            //4.Броят рам памет -цяло число в интервала[0…100]

            int VideoCardPrice = 250;
          

            double BudgetOFPeter = double.Parse(Console.ReadLine());
            int VideoCardCount = int.Parse(Console.ReadLine()); 
            int ProccesorCount = int.Parse(Console.ReadLine()); 
            int RamCount = int.Parse(Console.ReadLine());

            double ProccesorPrice = (VideoCardPrice * VideoCardCount) * 0.35;
            double RamPrice = (VideoCardPrice * VideoCardCount) * 0.1;


            double TotalPrice = VideoCardCount * VideoCardPrice + ProccesorCount * ProccesorPrice + RamCount * RamPrice;
            if (VideoCardCount > ProccesorCount)
            {
                TotalPrice -= TotalPrice * 0.15;
            }


            if (BudgetOFPeter >= TotalPrice)
            {
                Console.WriteLine($"You have {(BudgetOFPeter - TotalPrice):F2} leva left!");
            }
            else 
            {
                Console.WriteLine($"Not enough money! You need {(TotalPrice - BudgetOFPeter):F2} leva more!");
            }
        }
    }
}
