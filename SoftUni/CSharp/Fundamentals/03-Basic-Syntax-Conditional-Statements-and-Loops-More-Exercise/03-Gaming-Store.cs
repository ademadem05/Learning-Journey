namespace _3._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gameCatalog = new Dictionary<string, double>()
            {
                ["OutFall 4"] = 39.99,
                ["CS: OG"] = 15.99,
                ["Zplinter Zell"] = 19.99,
                ["Honored 2"] = 59.99,
                ["RoverWatch"] = 29.99,
                ["RoverWatch Origins Edition"] = 39.99
            };
            double budget = double.Parse(Console.ReadLine());
            double totalSpend = 0;
            double remaining = 0;
            while (true)
            {
                string games = Console.ReadLine();
                if (games == "Game Time")
                {
                    break;
                }
                else if (!gameCatalog.ContainsKey(games))
                {
                    Console.WriteLine("Not Found");
                    continue;
                }
                if (gameCatalog.TryGetValue(games, out double gamePrice))
                {
                    if (gamePrice > budget)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                }
                Console.WriteLine($"Bought {games}");
                budget -= gameCatalog[games];
                totalSpend += gameCatalog[games];

            }
            if (budget > 0) 
            {
                Console.WriteLine($"Total spent: ${totalSpend:F2}. Remaining: ${budget:F2}");
            }
            else
            {
              Console.WriteLine("Out of money!");  
            }

        }
    }
}
