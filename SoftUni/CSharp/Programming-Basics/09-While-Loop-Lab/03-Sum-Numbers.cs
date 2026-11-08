namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is our target sum
            int target = int.Parse(Console.ReadLine());
            int total = 0;

            while (true)
            {
                // We need to read a NEW number in every iteration
                int currentNumber = int.Parse(Console.ReadLine());
                total += currentNumber;

                // If the total has met or exceeded the target, we stop
                if (total >= target)
                {
                    break;
                }
            }

            Console.WriteLine(total);
        }
    }
}