namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var catalog = new Dictionary<string, double>() 
            {
                ["Premiere"] = 12.00,
                ["Normal"] = 7.50,
                ["Discount"] = 5.00
            };

            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

             double total = rows * cols * catalog[type];
             Console.WriteLine($"{total:F2} leva");
        }
    }
}
