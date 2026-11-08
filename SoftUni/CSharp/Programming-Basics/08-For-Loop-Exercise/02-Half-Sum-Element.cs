namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int MaxValue = int.MinValue;
            int total = 0;
            for (int i = 1; i <= n; i++) 
            {
                int userInput = int.Parse(Console.ReadLine());
                total += userInput;

                if (userInput > MaxValue) 
                {
                    MaxValue = userInput;
                }
            }

            if (total - MaxValue == MaxValue)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {MaxValue}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(MaxValue - (total - MaxValue))}");
            }
        }
    }
}
