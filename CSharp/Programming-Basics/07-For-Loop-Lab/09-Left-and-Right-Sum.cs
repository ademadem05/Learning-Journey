namespace _01._Numbers_from_1_to_100
{
    internal class Program
    {
        static void Main(string[] args)
        {

         int n = int.Parse(Console.ReadLine());

            int total1 = 0;
            int total2 = 0;

            for (int i = 1; i <= n; i++)
            {
                int userInput = int.Parse((Console.ReadLine()));
                total1 += userInput;
            }

            for (int i = 1; i <= n; i++)
            {
                int userInput = int.Parse((Console.ReadLine()));
                total2 += userInput;
            }

            if (total1 - total2 == 0)
            {
                Console.WriteLine($"Yes, sum = {total1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(total1 - total2)}");
            }

        }
    }
}
