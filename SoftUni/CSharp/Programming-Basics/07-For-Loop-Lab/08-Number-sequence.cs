namespace _01._Numbers_from_1_to_100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int MaxNumber = -999999;
            int MinNumber = 9999999;

            for (int i = 1; i <= n; i++)
            {
                int userInput = int.Parse((Console.ReadLine()));
                if (userInput > MaxNumber)
                {
                    MaxNumber = userInput;
                }
                if (userInput < MinNumber) 
                {
                    MinNumber = userInput;
                }
            }
            Console.WriteLine($"Max number: {MaxNumber}");
            Console.WriteLine($"Min number: {MinNumber}");
        }
    }
}
