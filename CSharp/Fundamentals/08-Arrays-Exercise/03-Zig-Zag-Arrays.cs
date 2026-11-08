using System.Linq;
namespace _3._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            for (int i = 0; i < n; i ++)
            {
                string[] input = Console.ReadLine().Split();
                if (i % 2 == 0)
                {
                  arr1[i] = int.Parse(input[0]);
                  arr2[i] = int.Parse(input[1]);  
                }
                else
                {
                    arr1[i] = int.Parse(input[1]);
                    arr2[i] = int.Parse(input[0]);
                }

            }
            foreach (var item in arr1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            foreach (var item2 in arr2)
            {
                Console.Write($"{item2} ");
            }
        }
    }
}
