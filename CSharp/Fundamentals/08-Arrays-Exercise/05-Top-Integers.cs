using System.Linq;
namespace _5._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                bool isTopInteger = true;
                for (global::System.Int32 j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        isTopInteger = false;
                    }
                }
                if (isTopInteger) 
                {
                    Console.Write($"{arr[i]} ");
                }

            }
        }
    }
}
