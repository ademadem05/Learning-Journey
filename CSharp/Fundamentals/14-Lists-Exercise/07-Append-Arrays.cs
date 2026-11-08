using System.Text.RegularExpressions;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Arr = Console.ReadLine().Split('|').ToList();
            
            List<string> resultList = new List<string>();

            for (int i = Arr.Count - 1; i >= 0; i--)
            {
               
                string[] numbers = Arr[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

               
                resultList.AddRange(numbers);
            }


            Console.WriteLine(string.Join(" ",resultList));
        }
    }
}
