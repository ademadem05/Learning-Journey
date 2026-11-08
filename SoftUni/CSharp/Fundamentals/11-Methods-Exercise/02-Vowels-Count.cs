using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            Console.WriteLine(VowelsCount(text));

        }
        static int VowelsCount(string text) 
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(text[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
