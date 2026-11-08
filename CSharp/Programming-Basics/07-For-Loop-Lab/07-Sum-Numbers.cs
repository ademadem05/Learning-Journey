namespace _01._Numbers_from_1_to_100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int total = 0;
            for (int i = 1; i <= n; i++)
            {
                int userInput = int .Parse(Console.ReadLine());
                total += userInput;
            }
            Console.WriteLine(total);
        }
    }
}
