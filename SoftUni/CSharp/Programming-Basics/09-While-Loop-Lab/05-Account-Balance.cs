namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double total = 0;
            while (true) 
            {
                string Input = Console.ReadLine();

                if (Input == "NoMoreMoney")
                {
                    break;
                }
                double Money = double.Parse(Input);
                if (Money <  0) 
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                total += Money;
                Console.WriteLine($"Increase: {Money:F2}");

            }
            Console.WriteLine($"Total: {total:F2}");
        }
    }
}
