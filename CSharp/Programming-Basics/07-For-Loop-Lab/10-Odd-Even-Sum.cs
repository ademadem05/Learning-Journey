namespace _01._Numbers_from_1_to_100
{
    internal class Program
    {
        static void Main(string[] args)
        {

         int n = int.Parse(Console.ReadLine());

            int oddNums = 0;
            int evenNums = 0;
            for (int i = 1; i <= n; i++)
            {
                int userInput = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenNums += userInput;
                }
                else
                {
                    oddNums += userInput;
                }
            }

            if (oddNums == evenNums)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddNums}");
            }
            else 
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddNums - evenNums)}");
            }

        }
    }
}
