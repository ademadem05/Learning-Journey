using System.Numerics;

namespace _1._1_Student_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            
            if(j > 10) { Console.WriteLine($"{n} X {j} = {n * j}"); }
            for (int i = j; i <= 10; i++)
            {
                
                int total = n * i;
                Console.WriteLine($"{n} X {i} = {total}");
            }
        }
    }
}
