using System;

namespace _7._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers1 = Console.ReadLine();
            string numbers2 = Console.ReadLine();

            int[] arr1 = numbers1.Split().Select(int.Parse).ToArray();
            int[] arr2 = numbers2.Split().Select(int.Parse).ToArray();

            bool flag = false;
            int counter = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                
                if (arr1[i] != arr2[i])
                {
                    flag = true;
                    break;
                }
                counter++;
            }
            if (flag) 
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {counter} index");
            }
            else
            {
                Console.WriteLine($"Arrays are identical. Sum: {arr1.Sum()}");
            }
        }
    }
}
