namespace _06._Number_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int UserNumber = int.Parse(Console.ReadLine());
            if (-100 <= UserNumber && UserNumber <= 100)
            {
                if (UserNumber != 0)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
