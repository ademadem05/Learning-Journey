using System.Globalization;

namespace _8._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int[] nums = numbers.Split().Select(int.Parse).ToArray();

            while (nums.Length > 1)
            {
                
                int[] condensed = new int[nums.Length - 1];
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }
                //if (nums.Length > 1)
                //{
                //    break;
                //}
                nums = condensed;
                
            }
            Console.WriteLine(nums[0]); 
        }
    }
}
