namespace _5._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            string[] arr = userInput.Split();
            int[] numbers = new int[arr.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(arr[i]);
            }
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    total += numbers[i];
                }
            }
            Console.WriteLine(total);
        }
    }
}
