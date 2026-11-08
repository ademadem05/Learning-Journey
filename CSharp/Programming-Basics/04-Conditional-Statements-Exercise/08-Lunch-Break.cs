namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //От конзолата се четат 3 реда:
            //    1.Име на сериал – текст
            //    2.Продължителност на епизод  – цяло число в диапазона[10… 90]
            //    3.Продължителност на почивката  – цяло число в диапазона[10… 120]


            string SerialName = Console.ReadLine();
            int Episode = int.Parse(Console.ReadLine());    
            int BreakTime = int.Parse(Console.ReadLine());

            double launch = BreakTime * 1.0 / 8;
            double RestTime = BreakTime * 1.0 / 4;

            double TimeLeft = BreakTime - launch - RestTime;

            if (TimeLeft >= Episode)
            {
                Console.WriteLine($"You have enough time to watch {SerialName} and left with {Math.Ceiling(TimeLeft - Episode)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {SerialName}, you need {Math.Ceiling(Episode - TimeLeft)} more minutes.");
            }

        }
    }
}
