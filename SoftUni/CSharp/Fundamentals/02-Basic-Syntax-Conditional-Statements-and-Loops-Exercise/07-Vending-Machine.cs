
namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var menu = new Dictionary<string, double>()
            {
                ["Nuts"] = 2.0,
                ["Water"] = 0.7,
                ["Crisps"] = 1.5,
                ["Soda"] = 0.8,
                ["Coke"] = 1.0
            };
            double total = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Start")
                {
                    break;
                }

                double coins = double.Parse(input); 
                if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    continue;
                }
                total += coins;

            }
            while (true)
            {
                string products = Console.ReadLine();
                if (products == "End") { break; }

                if (!menu.ContainsKey(products))
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                if (total < menu[products])
                {
                    Console.WriteLine("Sorry, not enough money");
                    continue;
                }
                else
                {
                    total -= menu[products];
                    Console.WriteLine($"Purchased {products.ToLower()}");
                }

            }
            Console.WriteLine($"Change: {total:F2}");
        }
    }
}
