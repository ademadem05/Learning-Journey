namespace _05.NumberBetWeen
{
    internal class Program
    {
        static void Main()
        {
            int UserNum = int.Parse(Console.ReadLine());

            if (UserNum < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (100 <= UserNum && UserNum <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
