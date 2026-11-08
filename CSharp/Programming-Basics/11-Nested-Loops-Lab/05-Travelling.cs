namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End") { break; }
                double minBudget = double.Parse(Console.ReadLine());

                double budget = 0;
                while (true)
                { 
                    string input = Console.ReadLine();

                    double savings = double.Parse(input);
                    budget += savings;
                                       
                    if (budget >= minBudget)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }

                }
            }
        }
    }
}
