using System.Linq;
namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            string[] message = new string[arr1.Length];
            for (int i = 0; i < arr2.Length; i++)
            {
                string element = arr2[i];
                for (global::System.Int32 j = 0; j < arr1.Length; j++)
                {
                    if (element == arr1[j])
                    {
                        Console.Write($"{arr1[j]} ");
                    }
                }
            }
          
            
        }
    }
}
