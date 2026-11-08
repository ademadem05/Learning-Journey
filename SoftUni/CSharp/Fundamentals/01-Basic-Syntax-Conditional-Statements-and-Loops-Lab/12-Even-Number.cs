using System.Numerics;

namespace _1._1_Student_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int n))
                {
                   if (n % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                } 
                   
                }
            }
        }
    }
}