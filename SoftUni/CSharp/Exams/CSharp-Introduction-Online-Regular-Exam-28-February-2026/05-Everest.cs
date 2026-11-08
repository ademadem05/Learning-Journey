namespace _05._Everest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goal = 8848;

            int total = 5364;
            int days = 1;
            while (total < goal)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                if (input == "Yes")
                {
                    days++;
                }

                if (days > 5)
                {
                    break;
                }
                else if (input == "No") { }
             
                int meters = int.Parse(Console.ReadLine());
                total += meters; 
            }
            if (total >= goal)
            {
                Console.WriteLine($"Goal reached for {days} days!");
            }
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{total}");
            }
        }
    }
}
