namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            //град / продукт  coffee water   beer sweets  peanuts
            //        Sofia   0.50    0.80    1.20    1.45    1.60
            //        Plovdiv 0.40    0.70    1.15    1.30    1.50
            //        Varna   0.45    0.70    1.10    1.35    1.55

            var Catalog = new Dictionary<string, Dictionary<string, double>>()
            {

                ["Sofia"] = new Dictionary<string, double>()
                {
                    ["coffee"] = 0.50,
                    ["water"] = 0.80,
                    ["beer"] = 1.20,
                    ["sweets"] = 1.45,
                    ["peanuts"] = 1.60
                },

                ["Plovdiv"] = new Dictionary<string, double>()
                {
                    ["coffee"] = 0.40,
                    ["water"] = 0.70,
                    ["beer"] = 1.15,
                    ["sweets"] = 1.30,
                    ["peanuts"] = 1.50
                },

                ["Varna"] = new Dictionary<string, double>() 
                {
                    ["coffee"] = 0.45,
                    ["water"] = 0.70,
                    ["beer"] = 1.10,
                    ["sweets"] = 1.35,
                    ["peanuts"] = 1.55
                }
            };

            string Product = Console.ReadLine();
            string City = Console.ReadLine();   
            double Amount = double.Parse(Console.ReadLine());

            double totalPrice = Catalog[City][Product] * Amount;
            Console.WriteLine($"{totalPrice}");

        }
    }
}
