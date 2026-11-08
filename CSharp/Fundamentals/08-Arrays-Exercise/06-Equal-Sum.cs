using System.Linq;
namespace _6._Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool found  = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int totalLeft = 0;
                int totalRight = 0;

                for (global::System.Int32 left = 0; left < i; left++)
                {
                    totalLeft += arr[left];
                }
                for (global::System.Int32 right = i + 1; right < arr.Length; right++)
                {
                    totalRight += arr[right];
                }

                if (totalLeft == totalRight)
                {
                    Console.WriteLine(i);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}
