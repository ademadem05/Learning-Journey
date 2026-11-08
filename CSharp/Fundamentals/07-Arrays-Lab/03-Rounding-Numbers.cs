namespace _3._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            string[] values = userInput.Split();
            double[] arr = new double[values.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(values[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int roundedValues = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{arr[i]} => {roundedValues}");
            }
        }
    }
}
