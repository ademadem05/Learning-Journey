using System.Numerics;

namespace _1._1_Student_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= 10; i++)
            {
                int total = n * i;
                Console.WriteLine($"{n} X {i} = {total}");
            }
        }
    }
}
