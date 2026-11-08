namespace _2._Divison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int maxDivisor = 0;
            if (number % 10 == 0) maxDivisor = 10;
            else if (number % 7 == 0) maxDivisor = 7;
            else if (number % 6 == 0) maxDivisor = 6;
            else if (number % 3 == 0) maxDivisor = 3;
            else if (number % 2 == 0) maxDivisor = 2;

            if (maxDivisor != 0)
            {
                Console.WriteLine($"The number is divisible by {maxDivisor}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }

        }
    }
}
