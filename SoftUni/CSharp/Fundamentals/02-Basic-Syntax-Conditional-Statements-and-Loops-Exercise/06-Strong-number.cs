
using System.Numerics;

namespace _6._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int num = int.Parse(number);
            int total = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int factNum = (int)number[i] - '0';

                int currentFact = 1;
                for (global::System.Int32 j = 1; j <= factNum; j++)
                {
                    currentFact *= j;
                }
                total += currentFact;
            }

            if (total == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
