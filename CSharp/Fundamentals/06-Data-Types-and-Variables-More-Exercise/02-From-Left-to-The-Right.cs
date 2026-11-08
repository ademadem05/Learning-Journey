
namespace _2._From_Left_to_the_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                int total = 0;

                string[] input = Console.ReadLine().Split(' ');

                long number1 = long.Parse(input[0]);
                long number2 = long.Parse(input[1]);

                long selectedNum = number1 > number2 ? number1 : number2;

                long tempNum = Math.Abs(selectedNum);

                string numberstr = tempNum.ToString();
                for (global::System.Int32 j = 0; j < numberstr.Length; j++)
                {
                    total += (int)numberstr[j] - '0';
                }
                Console.WriteLine(total);

            }
        }
    }
}
