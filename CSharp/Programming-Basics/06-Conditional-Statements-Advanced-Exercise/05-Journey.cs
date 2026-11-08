namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());   
            string seasone = Console.ReadLine();


            if (100 >= budget)
            {
                if (seasone == "summer")
                {
                    Console.WriteLine($"Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {(budget * 0.3):F2}");
                }
                else if (seasone == "winter")
                {
                    Console.WriteLine($"Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {(budget * 0.7):F2}");
                }
            }
            else if (1000 >= budget) 
            {
                if (seasone == "summer")
                {
                    Console.WriteLine($"Somewhere in Balkans");
                    Console.WriteLine($"Camp - {(budget * 0.4):F2}");
                }
                else if (seasone == "winter")
                {
                    Console.WriteLine($"Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {(budget * 0.8):F2}");
                }
            }
            else
            {
                if (seasone == "summer")
                {
                    Console.WriteLine($"Somewhere in Europe");
                    Console.WriteLine($"Hotel - {(budget * 0.9):F2}");
                }
                else if (seasone == "winter")
                {
                    Console.WriteLine($"Somewhere in Europe");
                    Console.WriteLine($"Hotel - {(budget * 0.9):F2}");
                }
            }

        }
    }
}
