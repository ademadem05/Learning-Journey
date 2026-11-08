namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int num = int.Parse(Console.ReadLine());

            int total = 0;
            for (int i = 1; i <= num; i++)
            {
                char chars = Console.ReadLine()[0];
                total += (int)chars;
            }
            Console.WriteLine($"The sum equals: {total}");
        }
    }
}
