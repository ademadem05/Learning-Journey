using System.Text.Json.Nodes;

namespace _8._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());

            long fact1 = GetFactorial(num1);
            long fact2 = GetFactorial(num2);

            double result = (double)fact1 / fact2;
            Console.WriteLine($"{result:F2}");
            
           
        }
        static long GetFactorial(long num) 
        {
            long result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
        
    }
}
